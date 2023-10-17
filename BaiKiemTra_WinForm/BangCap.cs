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
        List<BANGCAP> BANGCAPs = Context.BANGCAPs.ToList();

        //tải dữ liệu xuống datagirview 
        private void BidingBangCapDataGridView(List<BANGCAP> BANGCAPs)
        {
            dgvDanhSach.Rows.Clear();
            foreach (var item in BANGCAPs)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.MaBangCap;
                dgvDanhSach.Rows[index].Cells[1].Value = item.TenBangCap;
            }
        }

        //reset
        private void reset()
        {
            lblMaBangCap.Text = ""; 
            txtTenBC.Clear();
        }

        //đổ dữ liệu từ datagridview vào groupbox
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
            lblMaBangCap.Text = Convert.ToString(row.Cells["dgvMaBC"].Value);
            txtTenBC.Text = Convert.ToString(row.Cells["dgvTenBC"].Value);
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



        public BangCap()
        {
            InitializeComponent();
            BidingBangCapDataGridView(BANGCAPs);
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
                    BANGCAPs = Context.BANGCAPs.ToList();
                    BidingBangCapDataGridView(BANGCAPs);
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
            try
            {
                //text
                var deleteBangCap = Context.BANGCAPs.FirstOrDefault(b => b.TenBangCap.Equals(txtTenBC.Text));
                if (deleteBangCap != null)
                {
                    Context.BANGCAPs.Remove(deleteBangCap);
                    Context.SaveChanges();
                    BANGCAPs = Context.BANGCAPs.ToList();
                    BidingBangCapDataGridView(BANGCAPs); 
                    MessageBox.Show("xóa thành công", "thông báo");
                    reset(); 
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu cần xóa", "thông báo");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
        }

    }
}
