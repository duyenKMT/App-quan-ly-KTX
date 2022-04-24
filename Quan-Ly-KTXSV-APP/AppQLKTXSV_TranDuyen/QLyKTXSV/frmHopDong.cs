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
    public partial class frmHopDong : Form
    {
        public frmHopDong()
        {
            InitializeComponent();
        }
        KTXSV lib = new KTXSV();
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dgvHopdong.DataSource = lib.LoadHD();
        }

        
#region
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
#endregion
        private void dgvHopdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHopdong.CurrentRow.Index;
            txtMahopdong.Text = dgvHopdong.Rows[i].Cells[0].Value.ToString();
            txtMasv.Text = dgvHopdong.Rows[i].Cells[1].Value.ToString();
            txtMaquanly.Text = dgvHopdong.Rows[i].Cells[2].Value.ToString();
            txtMaphong.Text = dgvHopdong.Rows[i].Cells[3].Value.ToString();
            dtpkNgaylap.Text = dgvHopdong.Rows[i].Cells[4].Value.ToString();
            dtpkNgaybd.Text = dgvHopdong.Rows[i].Cells[5].Value.ToString();
            dtpkNgaykt.Text = dgvHopdong.Rows[i].Cells[6].Value.ToString();
        }
        
        private void btnKqtimkiem_Click(object sender, EventArgs e)
        {

            dgvHopdong.DataSource = lib.TimHD(txtTimkiem.Text);
        }

        private void btnKqsv_Click(object sender, EventArgs e)
        {
            
            frmThongKeSvTheoPhong tksv = new frmThongKeSvTheoPhong();
            tksv.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmThongKeSvTheoPhong tksv = new frmThongKeSvTheoPhong();
            tksv.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDsPhongChoSvMoi dsp = new frmDsPhongChoSvMoi();
            dsp.ShowDialog();
        }

        private void btnThemhd_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMahopdong, "");
            if (txtMahopdong.Text == "")
                errorProvider1.SetError(txtMahopdong, "Bạn chưa nhập mã hợp đồng rồi kìa");

            errorProvider1.SetError(txtMasv, "");
            if (txtMasv.Text == "")
                errorProvider1.SetError(txtMasv, "Bạn chưa nhập mã sinh viên rồi kìa");
            errorProvider1.SetError(txtMaquanly, "");
            if (txtMaquanly.Text == "")
                errorProvider1.SetError(txtMaquanly, "Bạn chưa nhập mã quản lý rồi kìa");

            errorProvider1.SetError(txtMaphong, "");
            if (txtMaphong.Text == "")
                errorProvider1.SetError(txtMaphong, "Bạn chưa nhập mã phòng rồi kìa");
            else
            {
                lib.ThemHD(txtMahopdong.Text, txtMasv.Text, txtMaquanly.Text, txtMaphong.Text, dtpkNgaylap.Text, dtpkNgaybd.Text, dtpkNgaykt.Text);
                MessageBox.Show("Thêm thành công");
                dgvHopdong.DataSource = lib.LoadHD();
            }
            
             
        }

        private void XoaHd_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMahopdong, "");
            if (txtMahopdong.Text == "")
                errorProvider1.SetError(txtMahopdong, "Bạn chưa nhập mã hợp đồng rồi kìa");
            else
            {
                lib.XoaHD(txtMahopdong.Text);
                MessageBox.Show("Xóa thành công");
                dgvHopdong.DataSource = lib.LoadHD();
            }
            
            
        }

        private void btnIndsHD_Click(object sender, EventArgs e)
        {
            frmInDSHD inDSHD = new frmInDSHD();
            inDSHD.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lib.SuaHD(txtMahopdong.Text, txtMasv.Text, txtMaquanly.Text, txtMaphong.Text, dtpkNgaylap.Text, dtpkNgaybd.Text, dtpkNgaykt.Text);
            dgvHopdong.DataSource = lib.LoadHD();
            MessageBox.Show("Sửa thành công");
        }
    }
}
