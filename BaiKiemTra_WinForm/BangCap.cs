using BaiKiemTra_WinForm.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            foreach(var item in BANGCAPs)
            {
                int index = dgvDanhSach.Rows.Add();
                dgvDanhSach.Rows[index].Cells[0].Value = item.MaBangCap;
                dgvDanhSach.Rows[index].Cells[1].Value = item.TenBangCap;
            }    
        }

        //đổ dữ liệu từ datagridview vào groupbox
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
            txtMaBC.Text = Convert.ToString(row.Cells["dgvMaBC"].Value);
            txtTenBC.Text = Convert.ToString(row.Cells["dgvTenBC"].Value);
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

    }
}
