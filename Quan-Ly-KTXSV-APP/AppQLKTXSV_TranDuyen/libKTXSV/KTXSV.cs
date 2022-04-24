using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace libKTXSV
{
    public class KTXSV
    {
        SqlConnection connect;
        SqlCommand cmd;
        string strconn = @"Data Source=DESKTOP-CDO0SQ2\SQLEXPRESS;Initial Catalog=QUANLYKYTUCXA;User ID=sa; pwd= @Duyen54kmt";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tbl = new DataTable();
        

        //***************FORM SINH VIÊN***************//
        #region
        /// <summary>
        /// Hàm này  trả về toàn bộ dữ liệu của bảng Sinh Viên bên CSDL 
        /// </summary>
        /// <returns></returns>
        public DataTable LoadSV()
        {
            
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from SinhVien";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }

        /// <summary>
        /// Hàm này dùng để tìm kiếm thông tin sinh viên khi truyền vào 1 chuỗi
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataTable TimSV(string s)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM SinhVien WHERE (Masv + Hodem + Ten + Gioitinh + CMND + SDT +Khoa +Lop) LIKE  N'%" + s + "%'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }

        /// <summary>
        /// Hàm này dùng để thêm 1 sinh viên vào danh sách sinh viên
        ///  (Thông tin sinh viên sẽ thêm được lấy từ phần chi tiết)
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="hodem"></param>
        /// <param name="ten"></param>
        /// <param name="ns"></param>
        /// <param name="gt"></param>
        /// <param name="cmnd"></param>
        /// <param name="sdt"></param>
        /// <param name="khoa"></param>
        /// <param name="lop"></param>
        public void ThemSV(String ma, String hodem, String ten, String ns, String gt, String cmnd, String sdt, String khoa, String lop)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO SinhVien VALUES('" + ma + "',N'" + hodem + "',N'" + ten + "','" + ns + "',N'" + gt + "','" + cmnd + "','" + sdt + "',N'" + khoa + "','" + lop + "')";
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        /// <summary>
        /// Sửa thông tin sinh viên
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="hodem"></param>
        /// <param name="ten"></param>
        /// <param name="ns"></param>
        /// <param name="gt"></param>
        /// <param name="cmnd"></param>
        /// <param name="sdt"></param>
        /// <param name="khoa"></param>
        /// <param name="lop"></param>
        public void SuaSV(String ma, String hodem, String ten, String ns, String gt, String cmnd, String sdt, String khoa, String lop)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE SinhVien SET Masv ='" + ma + "', Hodem = N'" + hodem + "',Ten = N'" + ten + "',Ngaysinh='" + ns + "',Gioitinh=N'" + gt + "',CMND='" + cmnd + "',SDT='" + sdt + "',Khoa=N'" + khoa + "',Lop='" + lop + "' WHERE Masv='" + ma + "'";
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        /// <summary>
        /// Đây là hàm xóa sinh viên khỏi Danh sách sinh viên
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable XoaSV(String ma)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE SinhVien WHERE Masv ='" + ma + "'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        #endregion
        //***************FORM PHÒNG***************//
        #region
        /// <summary>
        /// Hàm này trả về danh sách các Phòng lấy từ bên CSDL
        /// </summary>
        /// <returns></returns>
        public DataTable LoadPhong()
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from Phong";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        /// <summary>
        /// Ham sửa thông tin của 1 phòng nào đó
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="sophong"></param>
        /// <param name="khunha"></param>
        /// <param name="loaiphong"></param>
        /// <param name="slsv"></param>
        /// <param name="tinhtrang"></param>
        public void SuaPhong(String ma, int sophong, String khunha, String loaiphong, String slsv, bool tinhtrang)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE Phong SET Maphong ='" + ma + "', Sophong = '" + sophong + "',Khunha = '" + khunha + "',LoaiPhong=N'" + loaiphong + "',SoluongSV='" + slsv + "',TinhTrang='" + tinhtrang+ "' WHERE Maphong='" + ma + "'";
            cmd.ExecuteNonQuery();
            connect.Close();
        }

        /// <summary>
        /// Hàm này dùng để tìm kiếm thông tin Phòng khi truyền vào 1 chuỗi
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataTable TimPhong(string s)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM Phong WHERE (Maphong  + LoaiPhong ) LIKE  N'%" + s + "%'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        

        /// <summary>
        /// Hàm này dùng thể thêm 1 phòng vào Danh sách phòng 
        /// ( Thông tin sinh viên sẽ thêm được lấy từ phần chi tiết)
        /// </summary>
        /// <param name="ma"></param>
        /// <param name="sophong"></param>
        /// <param name="khunha"></param>
        /// <param name="loaiphong"></param>
        /// <param name="slsv"></param>
        /// <param name="tinhtrang"></param>
        public void ThemPhong(String ma, String sophong, String khunha, String loaiphong, String slsv, String tinhtrang)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO Phong VALUES('" + ma + "','" + sophong + "','" + khunha + "',N'" + loaiphong + "','" + slsv + "','" + tinhtrang + "')";
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        
        /// <summary>
        /// Đây là hàm xóa phòng khỏi Danh sách phòng
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable XoaPhong(String ma)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE Phong WHERE Maphong ='" + ma + "'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        #endregion

        //***************FORM HỢP ĐỒNG***************//
        #region
        /// <summary>
        /// Hàm này load form Hợp đồng
        /// </summary>
        /// <returns></returns>
        public DataTable LoadHD()
        {

            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "Select * from HopDong";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
            
        }
        /// <summary>
        /// Hàm tìm kiếm hợp đồng trong danh sách hợp đồng
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DataTable TimHD(string s)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "SELECT * FROM HopDong WHERE (Mahopdong + Masv + Maquanly + Maphong ) LIKE  N'%" + s + "%'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        /// <summary>
        /// Hàm thêm hợp đồng
        /// </summary>
        /// <param name="mahd"></param>
        /// <param name="masv"></param>
        /// <param name="maql"></param>
        /// <param name="maphong"></param>
        /// <param name="ngaylap"></param>
        /// <param name="ngaybd"></param>
        /// <param name="ngaykt"></param>
        public void ThemHD(String mahd, String masv, String maql, String maphong, String ngaylap, String ngaybd, String ngaykt)
        {
            
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "INSERT INTO HopDong VALUES('" + mahd + "','" + masv + "','" + maql + "','" + maphong + "','" + ngaylap + "','" + ngaybd + "','" + ngaykt + "')";
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        /// <summary>
        /// Hàm này cập nhật thông tin hợp đồng tại mã hợp đồng
        /// </summary>
        /// <param name="mahopdong"></param>
        /// <param name="masv"></param>
        /// <param name="maquanly"></param>
        /// <param name="maphong"></param>
        /// <param name="ngaylap"></param>
        /// <param name="ngaybd"></param>
        /// <param name="ngaykt"></param>
        public void SuaHD(String mahopdong, String masv, String maquanly, String maphong, String ngaylap, String ngaybd, String ngaykt)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "UPDATE HopDong SET Mahopdong ='" + mahopdong + "', Masv = '" + masv + "',Maquanly = '" + maquanly + "',Maphong='" + maphong + "',Ngaylap='" + ngaylap + "',Ngaybatdau='" + ngaybd + "',Ngayketthuc='" + ngaykt + "' WHERE Mahopdong='" + mahopdong + "'";
            cmd.ExecuteNonQuery();
            connect.Close();
        }
        /// <summary>
        /// Hàm này xóa hợp đồng
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public DataTable XoaHD(String ma)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "DELETE HopDong WHERE Mahopdong ='" + ma + "'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }

        /// <summary>
        /// Hàm trả về danh sách sinh viên theo 1 phòng nào đó
        /// </summary>
        /// <param name="sp"></param>
        /// <param name="khunha"></param>
        /// <returns></returns>
        public DataTable dssvTheoPhong(string sp, string khunha)
        {
            int sophong = int.Parse(sp);
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = " select * from SinhVien WHERE Masv IN (select Masv from HopDong  where  Maphong IN(Select Maphong from Phong where Sophong='" + sophong + "' and Khunha='" + khunha + "'))";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }
        /// <summary>
        /// Hàm thống kê phòng phù hợp cho sinh viên muốn vào ở KTX
        /// </summary>
        /// <param name="loaiphong"></param>
        /// <returns></returns>
        public DataTable dsPhongChoSvMoi(string loaiphong)
        {
            connect = new SqlConnection(strconn);
            connect.Open();
            cmd = connect.CreateCommand();
            cmd.CommandText = "EXECUTE cau9 N'" + loaiphong + "'";
            adapter.SelectCommand = cmd;
            tbl.Clear();
            adapter.Fill(tbl);
            connect.Close();
            return tbl;
        }

        #endregion

    }
}

