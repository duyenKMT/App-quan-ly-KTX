--Đặt ràng buộc ở bảng Sinh viên
ALTER TABLE SinhVien
ADD
	CONSTRAINT chk_SinhVien_Gioitinh
	CHECK (GioiTinh in ('nam', N'nữ'))

--Đặt ràng buộc ở bảng Hợp đồng
ALTER TABLE Phong ADD CONSTRAINT chk_Phong_SoLuongSV CHECK (SoluongSV> = 0 and SoluongSV< = 8)
ALTER TABLE Phong ADD CONSTRAINT chk_Phong_LoaiPhong CHECK (LoaiPhong in ('nam', N'nữ'))

--Đặt ràng buộc ở bảng Hợp đồng
ALTER TABLE HopDong ADD CONSTRAINT chk_HopDong_NgayBDvaKT CHECK (Ngaybatdau < Ngayketthuc)
ALTER TABLE HopDong ADD CONSTRAINT chk_HopDong_Ngaylap CHECK (Ngaylap < Ngaybatdau)

--Đặt check constraint cho bảng Hóa đơn điện nước
ALTER TABLE HoaDonDienNuoc ADD CONSTRAINT chk_HoaDonDienNuoc_hdDien CHECK (CSCdien > CSDdien)
ALTER TABLE HoaDonDienNuoc ADD CONSTRAINT chk_HoaDonDienNuoc_hdNuoc CHECK (CSDnuoc > CSCnuoc)
