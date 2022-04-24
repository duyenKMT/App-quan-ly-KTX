using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLyKTXSV
{
    public partial class frmAppQLKTXSV : Form
    {
        public frmAppQLKTXSV()
        {
            InitializeComponent();
        }

        private void btnGoisinhvien_Click(object sender, EventArgs e)
        {
            frmSinhVien sv = new frmSinhVien();
            sv.Show();
        }
        private void btnGoiphong_Click(object sender, EventArgs e)
        {
            frmPhong phong = new frmPhong();
            phong.Show();
        }

        private void btnGoihopdong_Click(object sender, EventArgs e)
        {
            frmHopDong hopdong = new frmHopDong();
            hopdong.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
