--THỰC HIỆN YÊU CẦU 6
--Liệt kê các phòng trong ký túc xá
SELECT *
FROM Phong
--Thêm 1 phòng
INSERT INTO Phong VALUES('a1409', 409, 'a1', 'nam', 4, 'True')
--Sửa thông tin 1 phòng
UPDATE Phong SET LoaiPhong = N'nữ' WHERE Maphong = 'a1409'
UPDATE Phong SET Maphong='a1407',Sophong=407,SoluongSV = 3 WHERE Maphong = 'a1409'

--Tạo 1 triger ngăn xóa 1 phòng nếu số lượng sinh viên = 0
CREATE TRIGGER trg_Phong_delete2 ON Phong
FOR DELETE AS 
BEGIN
	DECLARE @sl_sinhvien int
	DECLARE @maphong varchar(10)
	--gán số lượng sv và mã phòng cho biến
	SELECT @sl_sinhvien = SoluongSV, @maphong = Maphong FROM deleted
	--nếu số lượng sv khác 0 thì hủy bỏ thao tác xóa dữ liệu
	IF @sl_sinhvien!=0 ROLLBACK TRANSACTION
	--nếu không thì xóa
	ELSE
	DELETE Phong WHERE Maphong=@maphong
END

--Thử xóa phòng
DELETE Phong WHERE Maphong='k4303'
DELETE Phong WHERE Maphong='k5202'
 
 --THỰC HIỆN YÊU CẦU 7
 --Liệt kê các các sv trong KTX;
 SELECT Hodem,ten
 FROM SinhVien,HopDong
 Where SinhVien.Masv=HopDong.Masv
 --Dữ liệu bảng sv
SELECT * FROM SinhVien

 -- viết SQL để thêm 1 sv; 
 INSERT INTO SinhVien VALUES('K1854808', N'Nguyễn Công', N'Phượng', '5/5/2000',
							 'nam', '083764325','0566387788',N'Điện tử','54KMT')
 --Sửa thông tin 1 sv; 
 UPDATE SinhVien SET GioiTinh=N'nữ',Lop='55ĐĐK' WHERE Masv = 'K1854807'
 --Xóa 1 sv
 DELETE SinhVien WHERE Masv='K1854807'
 --Xóa 1 sv; cấu hình để không thể xóa sv nếu sv này đang có hợp đồng ở trong ktx.
 --Kiểm tra bảng hợp đồng
 SELECT * FROM HopDong

--Tạo triger kiểm tra xem sinh viên đang có hợp đồng trong ktx không
CREATE TRIGGER trg_SinhVien_delete_HopDong ON SinhVien
FOR DELETE AS 
BEGIN
	DECLARE @masv varchar(20)
	SELECT @masv=Masv FROM deleted
	--Nếu không tồn tại Masv trong bảng hợp đồng thì xóa
	IF NOT EXISTS(SELECT deleted.Masv FROM HopDong, deleted WHERE HopDong.Masv = deleted.Masv)
	DELETE SinhVien WHERE Masv=@masv
	--Ngược lại hủy thao tác
	ELSE
		ROLLBACK TRANSACTION
END
--Chạy xóa thử
  DELETE SinhVien WHERE Masv='K1854802'	--Sv đã có hợp đồng
--Sau 1 hồi test thì phát hiện ra không dùng được trigger để ngăn việc xóa sv khi đnag có hợp đồng vì FK đã check trước đã làm trigger thất bại
 --Tắt trigger
DISABLE TRIGGER trg_SinhVien_delete_HopDong
ON SinhVien

--Xóa sinh viên sau khi có triger
 DELETE SinhVien WHERE Masv='K1854805'	--Sv này chưa có hợp đồng

 ---THỰC HIỆN YÊU CẦU 8
 --Tạo thủ tục lưu trữ kiểm tra sinh viên có ở trong ktx không
 CREATE PROCEDURE cau8
(
	@masv varchar(20)
)
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM SinhVien WHERE Masv = @masv))
			PRINT N'Sinh viên này không ở trong ký túc xá'
	ELSE
			PRINT N'Sinh viên này đang ở trong ký túc xá'
END
--Gọi Procedure
EXECUTE cau8 'k1854806' -->	kQ: SV không ở trong ktx
EXECUTE cau8 'k1854813' -->	kQ: SV đang ở trong ktx
--Xóa thủ tục
DROP PROCEDURE cau8
--CÂU 9: VIẾT THỦ TỤC LIỆT KÊ PHÒNG CÒN GIƯỜNG TRỐNG VÀ PHÙ HỢP VỚI GIỚI TÍNH CHO SV MỚI MUỐN VÀO Ở TRONG KTX.

 ALTER PROCEDURE cau9
(
	@loaiphong nvarchar(10)
)
AS BEGIN
	--Nếu tồn tại phòng ít hơn 8 sv, tình trạng tốt, Loại phòng = loại phòng cần tìm hoặc = null(phòng đấy chưa có sv ở)
	IF (EXISTS (SELECT * FROM Phong WHERE SoluongSV<8 AND (LoaiPhong = @loaiphong OR LoaiPhong is NULL)  AND TinhTrang='True'))
		begin
			SELECT * FROM Phong WHERE SoluongSV<8 AND (LoaiPhong = @loaiphong OR LoaiPhong is NULL) AND TinhTrang='True'

		end
END
--Demo thủ tục
EXECUTE cau9 'nam'
EXECUTE cau9 N'nữ'

--CÂU 10: VIẾT HÀM (FUNCTION) KIỂM TRA XEM PHÒNG SV MỚI CHỌN CÓ PHÙ HỢP ĐỂ Ở CHO SV MỚI NÀY Ở KHÔNG?
ALTER FUNCTION cau10
(
	@gioitinh varchar(20),
	@maphong varchar(10)
) RETURNS Nchar(10)
AS
 BEGIN
	DECLARE @kq Nchar(10)
	DECLARE @loaiphong NVARCHAR(3)
	DECLARE @soluongsv int
	DECLARE @tinhtrangphong bit

	SELECT @loaiphong = LoaiPhong FROM Phong WHERE Maphong = @maphong
	SELECT @soluongsv = SoluongSV FROM Phong WHERE Maphong = @maphong
	SELECT @tinhtrangphong = TinhTrang FROM Phong WHERE Maphong = @maphong
	
	--Nếu tình trạng phòng là true(Có thể cho sv vào ở)
	IF(@tinhtrangphong='True')
		BEGIN
			--Phòng chưa có sv nào thì cho ở luôn
			IF(@soluongsv=0)
				SET @kq='OK'
			--Nếu phòng đang có sv ở thì xét xem giới tính có phù hợp k
			IF(@soluongsv>0 and @soluongsv<8)
			begin
				IF(@gioitinh = N'nam')
				begin
					IF(@loaiphong = N'nam')
						SET @kq = 'OK'
					IF(@loaiphong = N'nữ')
						SET @kq = 'NOT OK'
				end
				IF(@gioitinh = N'nữ')
				begin
					IF(@loaiphong = N'nam')
						SET @kq = 'NOT OK'
					IF(@loaiphong = N'nữ')
						SET @kq = 'OK'
				end
			end
		END
	--Tình trạng phòng false(Có thể là k đảm bảo cơ sở vật chất hoặc đã full giường)
	ELSE
		begin
			SET @kq='NOT OK'
		end
	RETURN @kq
 END
--Kiểm tra function đã hoạt động tốt chưa
SELECT dbo.cau10('nam', 'a1407') as 'Kết quả'
SELECT dbo.cau10('nữ', 'k2412') as 'Kết quả'
SELECT dbo.cau10('nam', 'a1406') as 'Kết quả'

--11. VIẾT TRIGGER ĐỂ CẬP NHẬT SỐ LƯỢNG SV ĐANG Ở TRONG KTX.
CREATE TRIGGER trg_HopDong_insert ON HopDong
FOR INSERT AS
BEGIN
	DECLARE @maphong varchar(10)
	DECLARE @soluongsv INT
	
	SELECT @maphong = Maphong FROM inserted
	SELECT @soluongsv = SoluongSV FROM Phong WHERE Maphong = @maphong
	--phòng chưa đầy thì cho phép thêm sv và cập nhật trường số lượng sv
	IF (@soluongsv< 8)	
		UPDATE Phong SET SoluongSV = @soluongsv+1
		WHERE Maphong = @maphong
	--Ngược lại thì hủy thao tác thêm sv
	ELSE
		ROLLBACK TRANSACTION
END

--Thử thêm 1 số sv vào ký túc xá

INSERT INTO HopDong VALUES('hd05', 'K1854803', 'ql03', 'k2412', getdate(), '2021/7/1', '2021/7/30')
INSERT INTO HopDong VALUES('hd06', 'K1854805', 'ql03', 'k5202', getdate(), '2021/7/1', '2021/7/30')
INSERT INTO HopDong VALUES('hd07', 'K1854810', 'ql03', 'k5202', getdate(), '2021/7/1', '2021/7/30')
INSERT INTO HopDong VALUES('hd08', 'K1854811', 'ql03', 'k5202', getdate(), '2021/7/1', '2021/7/30')

SELECT Maphong, SoluongSV from Phong
--12. VIẾT SQL ĐỂ GHI NHẬN 1 PHÒNG ĐÃ NỘP TIỀN ĐIỆN, NƯỚC, INTERNET CHO 1 THÁNG.

 --Tạo thủ tục lưu trữ kiểm tra phòng đã nộp tiền điện, nước cho 1 tháng chưa
 ALTER PROCEDURE pr_DienNuoc
(
	@maphong varchar(10),
	@thang varchar(7)
)
AS
BEGIN
	IF(NOT EXISTS (SELECT * FROM HopDong WHERE Maphong = @maphong))
			PRINT N'Phòng không hợp lệ hoặc chưa có ai thuê!'
	ELSE
		begin
			if(NOT EXISTS (SELECT * FROM HoaDonDienNuoc WHERE Maphong = @maphong AND Thang=@thang))
				PRINT N'Phòng '+ @maphong+ N' chưa nộp tiền điện nước tháng '+@thang;
			else
				PRINT N'Phòng '+ @maphong+ N' đã nộp tiền điện nước tháng '+@thang;
		end
END

--Check kết quả
EXECUTE pr_DienNuoc 'a1406','5/2021'
EXECUTE pr_DienNuoc 'a1406','4/2021'
EXECUTE pr_DienNuoc 'k4502','5/2021'
EXECUTE pr_DienNuoc 'k4105','6/2021'


--13. VIẾT SQL LIỆT KÊ DANH SÁCH NHỮNG PHÒNG CHƯA ĐÓNG TIỀN ĐIỆN NƯỚC INTERNET.
-->Hiển thị thông tin của các phòng ở bảng Phòng có Mã phòng thuộc bảng Hợp Đồng nhưng không thuộc bảng Hoá đơn điện nước
select Maphong,Sophong,Khunha
from Phong
WHERE Maphong IN (select Maphong
				  from HopDong 
				  where Maphong NOT IN (select Maphong
										from HoaDonDienNuoc))
										

--14. VIẾT SQL SỬA SỐ TIỀN ĐIỆN NƯỚC INTERNET ĐÃ THU CỦA 1 PHÒNG THÁNG NÀO ĐÓ.
--Sửa số tiền điện nước tháng 4 của phòng 105 khu nhà k4=425
UPDATE HoaDonDienNuoc 
SET Tongtien = 425 
FROM HoaDonDienNuoc 
WHERE Thang = '4/2021' AND Maphong ='k4105'
--Sửa số tiền điện nước tháng 5 của phòng 105 khu nhà k4
UPDATE HoaDonDienNuoc 
SET Tongtien = 399
FROM HoaDonDienNuoc,Phong
WHERE Thang = '5/2021' AND Sophong=105 AND Khunha='k4'


--15. Viết SQL tính tổng số tiền đã thu được trong 1 tháng.
--Viết 1 hàm có tham số truyền vào là tháng
--> trả về tổng tiền thu được của cả hóa đơn điện nước và hóa đơn tiền phòng
ALTER FUNCTION FN_TongTienThu(
	@thang varchar(7)
)
RETURNS MONEY 
AS BEGIN

	DECLARE @TongTienDienNuoc money;
	DECLARE @TongTienPhong money;
	--Tính tổng tiền điện nước thu được của tháng đó
	--Nếu không tìm thấy hóa đơn điện nước của tháng đang xét -> gán Tổng tiền điện nước = 0
	IF(NOT EXISTS (SELECT * FROM HoaDonDienNuoc WHERE Thang=@thang))
		SET @TongTienDienNuoc = 0;
	ELSE
		begin
			SELECT @TongTienDienNuoc=Sum(Tongtien)
			FROM HoaDonDienNuoc
			WHERE Thang=@thang; 
		end
	--Tính tổng tiền phòng thu được của tháng đó
	IF(NOT EXISTS (SELECT * FROM HoaDonPhong WHERE Thang=@thang))
		SET @TongTienPhong = 0;
	ELSE
		begin
			SELECT @TongTienPhong=Sum(Sotien)
			FROM HoaDonPhong
			WHERE Thang=@thang; 
		end
	--trả về Tổng tiền thu được ở cả 2 hóa đơn
	RETURN @TongTienDienNuoc+@TongTienPhong;
END

--Check kết quả
SELECT dbo.FN_TongTienThu('5/2021') As 'Tổng thu' 
SELECT dbo.FN_TongTienThu('4/2021') As 'Tổng thu'
SELECT dbo.FN_TongTienThu('1/2021') As 'Tổng thu'

--THỐNG KÊ SV THEO PHÒNG
select *
from SinhVien
WHERE Masv IN (select Masv
				  from HopDong 
				  where  Maphong IN(Select Maphong from Phong where Sophong='406' and Khunha='a1'))