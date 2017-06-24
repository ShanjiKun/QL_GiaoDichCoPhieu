--Create by Vinh Huynh 6/22/2017
--A: NDT vừa tạo giao dịch. B: NDT đang chờ giao dịch
CREATE PROCEDURE SP_TaoGDKhopLenh(
	--Parameter
	@loaiLenh_A varchar(1),
	@gia_A float,
	@maCP_A varchar(10),
	@soLuong_A int,
	@maTK_A varchar(20)
)
AS
SET XACT_ABORT ON
BEGIN TRAN
BEGIN TRY
   -----------------------------------------------------------------------------------------
   DECLARE @maGD_A int
   DECLARE @ngayGD_A varchar(50)
   SET @ngayGD_A = GETDATE()
   --Insert new Transaction
	INSERT INTO LENHDAT(NgayGD, LoaiLenh, PhuongThuc, SoLuong, MaCP, Gia, MaTK, TrangThai)
		   VALUES(@ngayGD_A, @loaiLenh_A, 'LO', @soLuong_A, @maCP_A, @gia_A, @maTK_A, 'CHO')
	SELECT @maGD_A = @@IDENTITY

	--Local var
	DECLARE @trangThaiGD_A varchar(10)

	DECLARE @maGD_B int
	DECLARE @gia_B float
	DECLARE @soLuong_B int
	DECLARE @trangThaiGD_B varchar(10)
	DECLARE @maTK_B varchar(20)

	DECLARE @ketThuc int --1: Kết thúc. 0: Khớp tiếp
	SET @ketThuc = 0
	-----------Create Temp table----------
	CREATE TABLE #temp(
		MaGD int,
		Gia float NOT NULL,
		SoLuong int NOT NULL,
		MaTK varchar(20) NOT NULL,
		TrangThai varchar(10) NOT NULL
	)

	DECLARE @currentDate varchar(10)
	SELECT @currentDate = CONVERT(varchar(10), GetDate(),126)
	IF(@loaiLenh_A = 'M')
	BEGIN
		INSERT INTO #temp
		SELECT MaGD, Gia, SoLuong, MaTK, TrangThai
		FROM LENHDAT 
		WHERE NgayGD>@currentDate AND LoaiLenh='B' AND MaCP=@maCP_A AND Gia<=@gia_A AND (TrangThai='CHO' OR TrangThai='MOTPHAN')
		ORDER BY Gia ASC, NgayGD ASC
	END
	ELSE
	BEGIN
		INSERT INTO #temp
		SELECT MaGD, Gia, SoLuong, MaTK, TrangThai
		FROM LENHDAT 
		WHERE NgayGD>@currentDate AND LoaiLenh='M' AND MaCP=@maCP_A AND Gia>=@gia_A AND (TrangThai='CHO' OR TrangThai='MOTPHAN')
		ORDER BY Gia DESC, NgayGD ASC
	END
	--------------------------------------------------------------------------------
	---Get MaGDs
	DECLARE cs_GD CURSOR FOR SELECT MaGD, Gia, SoLuong, MaTK, TrangThai FROM #temp
	OPEN cs_GD
	FETCH NEXT FROM cs_GD INTO @maGD_B, @gia_B, @soLuong_B, @maTK_B, @trangThaiGD_B
	WHILE @@FETCH_STATUS = 0
	BEGIN
		--Join Transaction
		--Tinh SoLuongKhop
		DECLARE @flag int --0: Số lượng A < số lượng B. 1:SL A = SL B. 2:SL A > SL B
		DECLARE @soLuongKhop int

		IF (@trangThaiGD_B = 'MOTPHAN')
		BEGIN
			DECLARE @slB_DaKhop int
			SELECT @slB_DaKhop=SUM(SoLuongKhop) FROM LENHKHOP WHERE MaGD=@maGD_B GROUP BY MaGD
			SET @soLuong_B = @soLuong_B - @slB_DaKhop
		END

		if (@soLuong_A < @soLuong_B)
		BEGIN
			SET @soLuongKhop = @soLuong_A
			SET @flag = 0
			SET @ketThuc = 1
		END
		ELSE IF (@soLuong_A = @soLuong_B)
			BEGIN
				SET @soLuongKhop = @soLuong_A
				SET @flag = 1
				SET @ketThuc = 1
			END
			ELSE
			BEGIN
				SET @soLuongKhop = @soLuong_B
				SET @soLuong_A = @soLuong_A - @soLuong_B
				SET @flag = 2
				SET @ketThuc = 0
			END

		--Update tables
		--Init var---
		DECLARE @maNDT_A varchar(20)
		DECLARE @maNDT_B varchar(20)

		DECLARE @trangThai_A varchar(10)
		DECLARE @trangThai_B varchar(10)

		DECLARE @kieuKhop_A varchar(10)
		DECLARE @kieuKhop_B varchar(10)

		DECLARE @soLuongCP_A_Update int
		DECLARE @soLuongCP_B_Update int

		DECLARE @soTien_A_Update float
		DECLARE @soTien_B_Update float
		--Set var------------------------------------------------------
		---Get Trang Thai cua A
		SElECT @trangThaiGD_A=TrangThai FROM LENHDAT WHERE MaGD=@maGD_A
		---Get NDT---
		SELECT @maNDT_A=MaNDT FROM TAIKHOAN_NGANHANG WHERE MaTK=@maTK_A
		SELECT @maNDT_B=MaNDT FROM TAIKHOAN_NGANHANG WHERE MaTK=@maTK_B
		--------------
		IF (@flag = 0)
		BEGIN
			SET @trangThai_A = 'HET'
			SET @trangThai_B = 'MOTPHAN'
			----
			IF(@trangThaiGD_A = 'MOTPHAN')
			BEGIN
				SET @kieuKhop_A = 'MOTPHAN'
			END
			ELSE
			BEGIN
				SET @kieuKhop_A = 'KHOPHET'
			END

			SET @kieuKhop_B = 'MOTPHAN'
		END
		ELSE IF(@flag = 1)
			BEGIN
				SET @trangThai_A = 'HET'
				SET @trangThai_B = 'HET'
				----
				IF(@trangThaiGD_A = 'MOTPHAN')
				BEGIN
					SET @kieuKhop_A = 'MOTPHAN'
				END
				ELSE
				BEGIN
					SET @kieuKhop_A = 'KHOPHET'
				END

				IF(@trangThaiGD_B = 'MOTPHAN')
				BEGIN
					SET @kieuKhop_B = 'MOTPHAN'
				END
				ELSE
				BEGIN
					SET @kieuKhop_B = 'KHOPHET'
				END
			END
			ELSE
			BEGIN
				SET @trangThai_A = 'MOTPHAN'
				SET @trangThai_B = 'HET'
				----
				SET @kieuKhop_A = 'MOTPHAN'

				IF(@trangThaiGD_B = 'MOTPHAN')
				BEGIN
					SET @kieuKhop_B = 'MOTPHAN'
				END
				ELSE
				BEGIN
					SET @kieuKhop_B = 'KHOPHET'
				END
			END
		----------------------
		DECLARE @giaKhop float
		IF (@loaiLenh_A = 'B') -- A bán => B mua
		BEGIN
			SET @soLuongCP_A_Update = -@soLuongKhop
			SET @soLuongCP_B_Update = @soLuongKhop
			---
			SET @soTien_A_Update = @soLuongKhop*@gia_B
			SET @soTien_B_Update = -@soLuongKhop*@gia_B
			---
			SET @giaKhop = @gia_B
		END
		ELSE
		BEGIN
			SET @soLuongCP_A_Update = @soLuongKhop
			SET @soLuongCP_B_Update = -@soLuongKhop
			---
			SET @soTien_A_Update = -@soLuongKhop*@gia_A
			SET @soTien_B_Update = @soLuongKhop*@gia_A
			---
			SET @giaKhop = @gia_A
		END
		----------UPDATE-------------
		DECLARE @slhtCoPhieu int
		DECLARE @slhtTien float
		---Update AAAAAAAA---
		-------------------------------------------------------------------------------
		UPDATE LENHDAT SET TrangThai = @trangThai_A WHERE MaGD = @maGD_A
		-------------------------------------------------------------------------------
		INSERT INTO LENHKHOP(MaGD, NgayGioKhop, SoLuongKhop, GiaKhop, KieuKhop)
				VALUES ( @maGD_A, GETDATE(), @soLuongKhop, @giaKhop, @kieuKhop_A)
		-------------------------------------------------------------------------------
		IF NOT EXISTS (SELECT 1 FROM SOHUU WHERE MaNDT=@maNDT_A AND MaCP=@maCP_A)
		BEGIN
			INSERT INTO SOHUU VALUES(@maNDT_A, @maCP_A, 0)
		END
		SELECT @slhtCoPhieu=SoLuong FROM SOHUU WHERE MaNDT=@maNDT_A AND MaCP=@maCP_A
		SET @slhtCoPhieu = @slhtCoPhieu + @soLuongCP_A_Update
		UPDATE SOHUU SET SoLuong = @slhtCoPhieu WHERE MaNDT=@maNDT_A AND MaCP = @maCP_A
		-------------------------------------------------------------------------------
		SELECT @slhtTien=SoTien FROM TAIKHOAN_NGANHANG WHERE MaTK = @maTK_A
		SET @slhtTien = @slhtTien + @soTien_A_Update
		UPDATE TAIKHOAN_NGANHANG SET SoTien = @slhtTien WHERE MaTK = @maTK_A
		-------------------------------------------------------------------------------
		---Update BBBBBBBB---
		-------------------------------------------------------------------------------
		UPDATE LENHDAT SET TrangThai = @trangThai_B WHERE MaGD = @maGD_B
		-------------------------------------------------------------------------------
		INSERT INTO LENHKHOP(MaGD, NgayGioKhop, SoLuongKhop, GiaKhop, KieuKhop)
				VALUES ( @maGD_B, GETDATE(), @soLuongKhop, @giaKhop, @kieuKhop_B)
		-------------------------------------------------------------------------------
		IF NOT EXISTS (SELECT 1 FROM SOHUU WHERE MaNDT=@maNDT_B AND MaCP=@maCP_A)
		BEGIN
			INSERT INTO SOHUU VALUES(@maNDT_B, @maCP_A, 0)
		END
		SELECT @slhtCoPhieu=SoLuong FROM SOHUU WHERE MaNDT=@maNDT_B AND MaCP=@maCP_A
		SET @slhtCoPhieu = @slhtCoPhieu + @soLuongCP_B_Update
		UPDATE SOHUU SET SoLuong = @slhtCoPhieu WHERE MaNDT=@maNDT_B AND MaCP = @maCP_A
		-------------------------------------------------------------------------------
		SELECT @slhtTien=SoTien FROM TAIKHOAN_NGANHANG WHERE MaTK = @maTK_B
		SET @slhtTien = @slhtTien + @soTien_B_Update
		UPDATE TAIKHOAN_NGANHANG SET SoTien = @slhtTien WHERE MaTK = @maTK_B
		-------------------------------------------------------------------------------
		if(@ketThuc = 1) break
		FETCH NEXT FROM cs_GD INTO @maGD_B, @gia_B, @soLuong_B, @maTK_B, @trangThaiGD_B
	END
	CLOSE cs_GD
	DEALLOCATE cs_GD
	---DROP TEMP
	DROP TABLE #temp
	-----------------------------------------------------------------------------------------
COMMIT
END TRY
BEGIN CATCH
   ROLLBACK

   DECLARE @ErrorMessage NVARCHAR(4000);
   DECLARE @ErrorSeverity INT;
   DECLARE @ErrorState INT;

   SELECT 
   @ErrorMessage = ERROR_MESSAGE(),
   @ErrorSeverity = ERROR_SEVERITY(),
   @ErrorState = ERROR_STATE();

   RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState)
END CATCH