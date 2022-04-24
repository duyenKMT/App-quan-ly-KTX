using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using libKTXSV;

namespace QLyKTXSV
{
    public partial class frmDsPhongChoSvMoi : Form
    {
        public frmDsPhongChoSvMoi()
        {
            InitializeComponent();
        }
        KTXSV lib = new KTXSV();
        private void btnKq_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(cboLoaiphong, "");
            if (cboLoaiphong.Text == "")
                errorProvider1.SetError(cboLoaiphong, "Bạn chưa nhập loại phòng cần tìm rồi!");
            else
                dgvDsPhongChoSvMoi.DataSource = lib.dsPhongChoSvMoi(cboLoaiphong.Text);
        }
    }
}
