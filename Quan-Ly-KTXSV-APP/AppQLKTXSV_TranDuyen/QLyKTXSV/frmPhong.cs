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
    public partial class frmPhong : Form
    {
        public frmPhong()
        {
            InitializeComponent();
        }
        KTXSV lib = new KTXSV();

        private void frmPhong_Load(object sender, EventArgs e)
        {
            dgvPhong.DataSource = lib.LoadPhong();
        }


      

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvPhong.CurrentRow.Index;
            txtMaphong.Text = dgvPhong.Rows[i].Cells[0].Value.ToString();
            txtSophong.Text = dgvPhong.Rows[i].Cells[1].Value.ToString();
            txtKhunha.Text = dgvPhong.Rows[i].Cells[2].Value.ToString();
            cobLoaiphong.Text = dgvPhong.Rows[i].Cells[3].Value.ToString();
            txtSlsv.Text = dgvPhong.Rows[i].Cells[4].Value.ToString();
            cobTinhtrang.Text = dgvPhong.Rows[i].Cells[5].Value.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvPhong.DataSource = lib.TimPhong(txtTim.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaphong, "");
            if (txtMaphong.Text == "")
                errorProvider1.SetError(txtMaphong, "Bạn chưa nhập phòng rồi kìa!");
            else
            {
                lib.XoaPhong(txtMaphong.Text);
                MessageBox.Show("Xóa 1 phòng thành công");
                dgvPhong.DataSource = lib.LoadPhong();

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bool tinhtrang = bool.Parse(cobTinhtrang.Text);
            int sophong = int.Parse(txtSophong.Text);
            lib.SuaPhong(txtMaphong.Text, sophong, txtKhunha.Text, cobLoaiphong.Text, txtSlsv.Text, tinhtrang);
            MessageBox.Show("Sửa thành công");
            dgvPhong.DataSource = lib.LoadPhong();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMaphong, "");
            if (txtMaphong.Text == "")
                errorProvider1.SetError(txtMaphong, "Bạn chưa nhập mã phòng rồi kìa!");
            else
            {
                lib.ThemPhong(txtMaphong.Text, txtSophong.Text, txtKhunha.Text, cobLoaiphong.Text, txtSlsv.Text, cobTinhtrang.Text);
                MessageBox.Show("Đã thêm 1 phòng thành công");
                dgvPhong.DataSource = lib.LoadSV();
            }
            
        }

        private void btnInPhong_Click(object sender, EventArgs e)
        {
            frmInPhong inphong = new frmInPhong();
            inphong.Show();
        }
       
    }
}
