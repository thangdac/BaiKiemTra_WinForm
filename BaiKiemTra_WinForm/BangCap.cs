using BaiKiemTra_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra_WinForm
{
    public partial class BangCap : Form
    {
        //khai báo DBContext
        static ThuVienDBContext Context = new ThuVienDBContext();
        List<BANGCAP> BangCapList = Context.BANGCAPs.ToList();
        List<NHANVIEN> NhanVienList = Context.NHANVIENs.ToList();
        //tải dữ liệu xuống datagirview 
        private void BidingBangCapDataGridView(List<BANGCAP> BANGCAPs)
        {
            dgvDanhSach.Rows.Clear();
            foreach (var item in BANGCAPs)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.MaBangCap;
                dgvDanhSach.Rows[index].Cells[1].Value = item.TenBangCap;
                dgvDanhSach.Rows[index].Cells[2].Value = item.NHANVIENs.Count;
            }
            DemBangCap();
        }

        //reset
        private void reset()
        {
            lblMaBangCap.Text = "";
            txtTenBC.Clear();
            List<BANGCAP> BangCapReset = Context.BANGCAPs.ToList();
            BidingBangCapDataGridView (BangCapReset);
        }
        int rowIndex = -1;
        //đổ dữ liệu từ datagridview vào groupbox
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowIndex = e.RowIndex;
            if (rowIndex >= 0 && rowIndex < dgvDanhSach.Rows.Count)
            {
                lblMaBangCap.Text = dgvDanhSach.Rows[rowIndex].Cells[0].Value.ToString();
                txtTenBC.Text = dgvDanhSach.Rows[rowIndex].Cells[1].Value.ToString();
            }
        }

        //hàm xem nhập đủ thông tin chưa 
        public bool CheckNull()
        {
            if ( txtTenBC.Text == "")
                return true;
            return false;
        }


        //thêm bằng cấp
        private void AddBangCap(BANGCAP b)
        {
            Context.BANGCAPs.Add(b);
            Context.SaveChanges();
            MessageBox.Show("thêm thành công " + b.TenBangCap, "thông báo", MessageBoxButtons.OK);
        }

        public void DemBangCap()
        {
                var dem = Context.BANGCAPs;
                lblTongSobangCap.Text = dem.Count().ToString();
        }


        public BangCap()
        {
            InitializeComponent();
            BidingBangCapDataGridView(BangCapList);
            reset();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra đã nhập đủ thông tin
                if (CheckNull()) 
                {
                    MessageBox.Show("chưa đủ thông tin", "thông báo", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    BANGCAP b = new BANGCAP()
                    {
                       TenBangCap = txtTenBC.Text
                    };
                    AddBangCap(b);
                    reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && rowIndex < dgvDanhSach.Rows.Count)
            {
                int selectedMaDocGia = int.Parse(lblMaBangCap.Text);
                var selectedMember = Context.BANGCAPs.FirstOrDefault(dg => dg.MaBangCap == selectedMaDocGia);
                if (selectedMember != null)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn bằng cấp ?", "Xác nhận xoá", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Context.BANGCAPs.Remove(selectedMember);
                        Context.SaveChanges();
                        MessageBox.Show("Xoá bằng cấp thành công!");
                        rowIndex = 0;
                        reset();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bằng cấp để xóa.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (rowIndex >= 0 && rowIndex < dgvDanhSach.Rows.Count)
            {
                int MaBC = int.Parse(lblMaBangCap.Text);
                var selectedMember = Context.BANGCAPs.FirstOrDefault(bc => bc.MaBangCap == MaBC);
                if (selectedMember != null && !CheckNull())
                {
                    selectedMember.TenBangCap = txtTenBC.Text;
                    try
                    {
                        Context.SaveChanges();
                        MessageBox.Show("Cập nhật bằng cấp thành công!");
                        rowIndex = 0;
                        reset();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi cập nhật bằng cấp: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("hãy nhập đầy đủ thông tin");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bằng cấp để cập nhật thông tin.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.ToLower();
            List<BANGCAP> timKiemList = new List<BANGCAP>();
            if (!string.IsNullOrEmpty(keyword))
            {
                timKiemList = Context.BANGCAPs.
                    Where(bc=>bc.MaBangCap.ToString().Contains(keyword) ||
                              bc.TenBangCap.ToLower().Contains(keyword))
                    .ToList();
            }
            else
            {
                timKiemList = Context.BANGCAPs.ToList();
            }
            BidingBangCapDataGridView(timKiemList);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbLoc.Checked)
            {
                var BangCapKhongCoNV = BangCapList.Where(bc => !bc.NHANVIENs.Any()).ToList();
                BidingBangCapDataGridView(BangCapKhongCoNV); 
            }
            else
            {
                BidingBangCapDataGridView(BangCapList); 
            }
        }
    }
}
