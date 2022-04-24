using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;
namespace QLyKTXSV
{
    public partial class frmInPhong : Form
    {
        public frmInPhong()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Hàm hiển thị trang in danh sách Phòng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmInPhong_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection
                (@"Data Source=DESKTOP-CDO0SQ2\SQLEXPRESS;Initial Catalog=QUANLYKYTUCXA;User ID=sa; pwd= @Duyen54kmt");
            SqlDataAdapter adapter = new SqlDataAdapter("Select* From Phong", conn);
            //Đổ DL vào Dataset
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Phong");
            //Lấy thiết kế trang in từ report
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLyKTXSV.ReportPhong.rdlc";
            //Lấy dữ liệu từ trong DataSet đổ vào ReportDataSource
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables[0];
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            //Bắt đầu hiển thị ra reportViewer
            this.reportViewer1.RefreshReport();
        }
    }
}
