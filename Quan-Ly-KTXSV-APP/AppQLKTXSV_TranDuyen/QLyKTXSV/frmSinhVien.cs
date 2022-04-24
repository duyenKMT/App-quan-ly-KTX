using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using libKTXSV;
using Microsoft.Reporting.WinForms;



namespace QLyKTXSV
{
    public partial class frmSinhVien : Form
    {
        
        public frmSinhVien()
        {
            InitializeComponent();
        }
        KTXSV lib = new KTXSV();
        //Hiển thị danh sách sinh viên lên DataGridview
        private void SinhVien_Load(object sender, EventArgs e)
        {
            dgvSv.DataSource = lib.LoadSV();
           
        }
        /// <summary>
        /// Hiển thị chi tiết sinh viên đang chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvSv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSv.CurrentRow.Index;
            txtMssv.Text = dgvSv.Rows[i].Cells[0].Value.ToString();
            txtHodem.Text = dgvSv.Rows[i].Cells[1].Value.ToString();
            txtTen.Text = dgvSv.Rows[i].Cells[2].Value.ToString();
            dtpkNgaysinh.Text = dgvSv.Rows[i].Cells[3].Value.ToString();
            cobGioitinh.Text = dgvSv.Rows[i].Cells[4].Value.ToString();
            txtCmnd.Text = dgvSv.Rows[i].Cells[5].Value.ToString();
            txtSdt.Text = dgvSv.Rows[i].Cells[6].Value.ToString();
            txtKhoa.Text = dgvSv.Rows[i].Cells[7].Value.ToString();
            txtLop.Text = dgvSv.Rows[i].Cells[8].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMssv, "");
            if (txtMssv.Text == "")
                errorProvider1.SetError(txtMssv, "Bạn chưa nhập mã sinh viên kìa");
            else
            {
                lib.ThemSV(txtMssv.Text, txtHodem.Text, txtTen.Text, dtpkNgaysinh.Text, cobGioitinh.Text, txtCmnd.Text, txtSdt.Text, txtKhoa.Text, txtLop.Text);
                MessageBox.Show("Thêm thành công");
                dgvSv.DataSource = lib.LoadSV();

            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            errorProvider1.SetError(txtMssv, "");
            if (txtMssv.Text == "")
                errorProvider1.SetError(txtMssv, "Bạn chưa nhập mã sinh viên kìa");
            else
            {
                lib.XoaSV(txtMssv.Text);
                MessageBox.Show("Đã xóa thành công sinh viên có mã " + txtMssv.Text);
                dgvSv.DataSource = lib.LoadSV();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            lib.SuaSV(txtMssv.Text, txtHodem.Text, txtTen.Text, dtpkNgaysinh.Text, cobGioitinh.Text, txtCmnd.Text, txtSdt.Text, txtKhoa.Text, txtLop.Text);
            dgvSv.DataSource = lib.LoadSV();
            MessageBox.Show("Đã sửa thông tin sinh viên thành công");
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {

            dgvSv.DataSource = lib.TimSV(txtTimkiem.Text);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
           frmInDSSV indssv=new frmInDSSV();
           indssv.ShowDialog();
          
        }

       
    }
}
