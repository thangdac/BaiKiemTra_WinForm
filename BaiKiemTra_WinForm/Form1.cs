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
    public partial class Form1 : Form
    {
        public BangCap BangCap;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBangcap_Click(object sender, EventArgs e)
        {
            BangCap bangcap = new BangCap();
            bangcap.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }
    }
}
