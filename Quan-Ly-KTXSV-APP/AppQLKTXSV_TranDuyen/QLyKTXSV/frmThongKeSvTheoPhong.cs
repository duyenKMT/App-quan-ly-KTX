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
    public partial class frmThongKeSvTheoPhong : Form
    {
        public frmThongKeSvTheoPhong()
        {
            InitializeComponent();
        }
        KTXSV lib = new KTXSV();
       
        private void frmThongKeSvTheoPhong_Load(object sender, EventArgs e)
        {
            
            dgvThongkesv.DataSource = lib.LoadSV();
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtKhunha, "");
            if (txtKhunha.Text == "")
                errorProvider1.SetError(txtKhunha, "Bạn chưa nhập khu nhà rồi kìa!");
            errorProvider1.SetError(txtSophong, "");
            if (txtSophong.Text == "")
                errorProvider1.SetError(txtSophong, "Bạn chưa nhập số phòng rồi kìa!");
            else
            {
                dgvThongkesv.DataSource = lib.dssvTheoPhong(txtSophong.Text, txtKhunha.Text);
            }
        }
    }
}
