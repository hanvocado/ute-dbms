create database QLNSG21_Data
GO
use QLNSG21_Data
GO
CREATE TABLE ChucVu (
	MaCV NVARCHAR(10) PRIMARY KEY,
	TenCV NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE NhanVien (
    MaNV NVARCHAR(10) PRIMARY KEY,
    Ho NVARCHAR(50) NOT NULL,
    Ten NVARCHAR(50) NOT NULL,
    GioiTinh NVARCHAR(10) NOT NULL,
    NgaySinh DATE NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SDT NVARCHAR(20) NOT NULL UNIQUE,
    Email NVARCHAR(50) NOT NULL UNIQUE,
    CCCD NVARCHAR(12) NOT NULL UNIQUE,
    MaPB NVARCHAR(10),
    MaCV NVARCHAR(10) NOT NULL,
    MaHD NVARCHAR(10),
	CONSTRAINT RightPhoneNum CHECK (LEN(SDT) = 10)
);
GO
CREATE TABLE PhongBan (
    MaPB NVARCHAR(10) PRIMARY KEY,
    TenPB NVARCHAR(50) NOT NULL,
    SDT NVARCHAR(20) NOT NULL,
    MaTrP NVARCHAR(10),
    CONSTRAINT ValidPhoneNum CHECK (LEN(SDT) = 10)
);

GO 

GO
CREATE TABLE HopDong (
    MaHD NVARCHAR(10) PRIMARY KEY,
    MaNV NVARCHAR(10) UNIQUE NOT NULL,
    LuongCoBan INT NOT NULL,
    NgayBD DATE NOT NULL,
    NgayKT DATE NOT NULL
);
GO
-- Khóa ngoại bảng PhongBan
ALTER TABLE PhongBan ADD CONSTRAINT fk_MaTrP
	FOREIGN KEY (MaTrP) REFERENCES NhanVien(MaNV)
	ON UPDATE NO ACTION
	ON DELETE NO ACTION;
GO
-- Khóa ngoại bảng Hợp đồng
ALTER TABLE HopDong ADD CONSTRAINT fk_HD_MaNV
	FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE NO ACTION
	ON DELETE NO ACTION;
GO
-- Khóa ngoại bảng Nhân viên
ALTER TABLE NhanVien ADD CONSTRAINT fk_NV_MaPB
	FOREIGN KEY (MaPB) REFERENCES PhongBan (MaPB)
	ON UPDATE NO ACTION
	ON DELETE NO ACTION;
ALTER TABLE NhanVien ADD CONSTRAINT fk_NV_MaCV
	FOREIGN KEY (MaCV) REFERENCES ChucVu (MaCV)
	ON UPDATE NO ACTION
	ON DELETE NO ACTION;
ALTER TABLE NhanVien ADD CONSTRAINT fk_NV_MaHD
	FOREIGN KEY (MaHD) REFERENCES HopDong (MaHD)
	ON UPDATE NO ACTION
	ON DELETE NO ACTION;
GO
CREATE TABLE NguoiPhuThuoc (
    MaNV NVARCHAR(10) NOT NULL,
    HoTen NVARCHAR(50) NOT NULL,
    NgaySinh DATE NOT NULL,
    QuanHe NVARCHAR(50) NOT NULL,
    PRIMARY KEY (MaNV, HoTen),
    CONSTRAINT fK_NPT_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE Thang (
    MaThang NVARCHAR(6) PRIMARY KEY,
    MoTa NVARCHAR(MAX),
    SoNgayCongChuan INT NOT NULL
);
GO
CREATE TABLE ThuongPhat (
    MaThuongPhat NVARCHAR(10) PRIMARY KEY,
    Loai NVARCHAR(50) NOT NULL,
    SoTien INT NOT NULL,
    LyDo NVARCHAR(MAX) NOT NULL
);
GO
CREATE TABLE ctThuongPhat (
    MaNV NVARCHAR(10) NOT NULL,
    MaThuongPhat NVARCHAR(10) NOT NULL,
    MaThang NVARCHAR(6) NOT NULL,
    NgayThuongPhat INT NOT NULL,
    PRIMARY KEY (MaNV, MaThuongPhat, MaThang, NgayThuongPhat),
    CONSTRAINT ValidNgay CHECK (NgayThuongPhat BETWEEN 1 AND 31),
    CONSTRAINT fK_ctTP_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_ctTP_MaThuongPhat FOREIGN KEY (MaThuongPhat) REFERENCES ThuongPhat(MaThuongPhat)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_ctTP_MaThang FOREIGN KEY (MaThang) REFERENCES Thang(MaThang)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE ChamCong (
    MaCC NVARCHAR(10) PRIMARY KEY,
    MoTa NVARCHAR(MAX),
    HeSo FLOAT NOT NULL
);
GO
CREATE TABLE ctChamCong (
    MaNV NVARCHAR(10) NOT NULL,
    MaCC NVARCHAR(10) NOT NULL,
    MaThang NVARCHAR(6) NOT NULL,
    NgayChamCong INT NOT NULL,
    PRIMARY KEY (MaNV, MaThang, NgayChamCong),
    CONSTRAINT fK_ctCC_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_ctCC_MaCC FOREIGN KEY (MaCC) REFERENCES ChamCong(MaCC)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_ctCC_MaThang FOREIGN KEY (MaThang) REFERENCES Thang(MaThang)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE BaoHiem (
    MaLoai NVARCHAR(10) PRIMARY KEY,
    TenBH NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE ctBaoHiem (
	MaNV NVARCHAR(10) NOT NULL,
    MaBH NVARCHAR(10) PRIMARY KEY,
    MaLoai NVARCHAR(10) NOT NULL,
    NgayBD DATE NOT NULL,
    NgayKT DATE NOT NULL,
    CONSTRAINT fK_ctBH_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_ctBH_MaLoai FOREIGN KEY (MaLoai) REFERENCES BaoHiem(MaLoai)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE NghiPhep (
    MaNV NVARCHAR(10) NOT NULL,
    MaThang NVARCHAR(6) NOT NULL,
    NgayNghiPhep INT NOT NULL,
    GhiChu NVARCHAR(MAX) NOT NULL,
    PRIMARY KEY (MaNV, MaThang, NgayNghiPhep),
    CONSTRAINT fK_NP_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_NP_MaThang FOREIGN KEY (MaThang) REFERENCES Thang(MaThang)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE LoaiTaiKhoan (
    MaLoai NVARCHAR(10) PRIMARY KEY,
    Ten NVARCHAR(50) NOT NULL
);
GO
CREATE TABLE TaiKhoan (
    TenDangNhap NVARCHAR(10) PRIMARY KEY,
    MatKhau NVARCHAR(255) NOT NULL,
    MaLoai NVARCHAR(10) NOT NULL,
    CONSTRAINT fK_TK_TenDangNhap FOREIGN KEY (TenDangNhap) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_TK_MaLoai FOREIGN KEY (MaLoai) REFERENCES LoaiTaiKhoan(MaLoai)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
GO
CREATE TABLE PhuCap (
	MaPhuCap NVARCHAR(10) PRIMARY KEY,
	LoaiPhuCap NVARCHAR(10) NOT NULL
);
GO
CREATE TABLE ctPhuCap (
    MaNV NVARCHAR(10) NOT NULL,
    MaPhuCap NVARCHAR(10) NOT NULL,
    MaThang NVARCHAR(6) NOT NULL,
    NgayPhuCap INT NOT NULL,
    SoTien INT NOT NULL,
    PRIMARY KEY (MaNV, MaPhuCap, MaThang, NgayPhuCap),
    CONSTRAINT fK_PC_MaNV FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_PC_MaPhuCap FOREIGN KEY (MaPhuCap) REFERENCES PhuCap(MaPhuCap)
	ON UPDATE CASCADE
    ON DELETE NO ACTION,
    CONSTRAINT fK_PC_MaThang FOREIGN KEY (MaThang) REFERENCES Thang(MaThang)
	ON UPDATE CASCADE
    ON DELETE NO ACTION
);
-- Thêm dữ liệu cho bảng ChucVu
INSERT INTO ChucVu (MaCV, TenCV)
VALUES
('CV01', 'Giám Đốc'),
('CV02', 'Trưởng Phòng'),
('CV03', 'Nhân Viên'),
('CV04', 'Thực Tập Sinh');
GO
-- Thêm dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (MaNV, Ho, Ten, GioiTinh, NgaySinh, DiaChi, SDT, Email, CCCD, MaPB, MaCV, MaHD)
VALUES
('NV01', 'Nguyen', 'Anh', 'Nam', '1990-05-12', '123 ABC Street', '0123456789', 'anh.nguyen@gmail.com', '123456789012',NULL, 'CV01', NULL),
('NV02', 'Le', 'Bao', 'Nam', '1985-10-23', '456 DEF Street', '0987654321', 'bao.le@gmail.com', '234567890123', NULL, 'CV02', NULL),
('NV03', 'Tran', 'Chi', 'Nữ', '1992-07-15', '789 GHI Street', '0123456790', 'chi.tran@gmail.com', '345678901234', NULL, 'CV03', NULL),
('NV04', 'Pham', 'Dung', 'Nữ', '1995-03-10', '101 JKL Street', '0987654322', 'dung.pham@gmail.com', '456789012345', NULL, 'CV04', NULL);
GO
-- Thêm dữ liệu cho bảng PhongBan
INSERT INTO PhongBan (MaPB, TenPB, SDT, MaTrP)
VALUES
('PB01', 'Phòng Nhân Sự', '0123456789', 'NV01'),
('PB02', 'Phòng Kế Toán', '0987654321', 'NV02'),
('PB03', 'Phòng IT', '0123456790', 'NV03'),
('PB04', 'Phòng Kế Toán', '0987654321', 'NV05');
GO

-- Thêm dữ liệu cho bảng HopDong
INSERT INTO HopDong (MaHD, MaNV, LuongCoBan, NgayBD, NgayKT)
VALUES
('HD01', 'NV01', 20000000, '2023-01-01', '2024-01-01'),
('HD02', 'NV02', 15000000, '2022-06-15', '2023-06-15'),
('HD03', 'NV03', 18000000, '2021-09-01', '2022-09-01'),
('HD04', 'NV04', 10000000, '2023-03-10', '2024-03-10');
GO
-- Cập nhật MaPB, MaCV, MaHD cho MaNV = 'NV01'
UPDATE NhanVien
SET MaPB = 'PB01', MaCV = 'CV01', MaHD = 'HD01'
WHERE MaNV = 'NV01';

-- Cập nhật MaPB, MaCV, MaHD cho MaNV = 'NV02'
UPDATE NhanVien
SET MaPB = 'PB02', MaCV = 'CV02', MaHD = 'HD02'
WHERE MaNV = 'NV02';

-- Cập nhật MaPB, MaCV, MaHD cho MaNV = 'NV03'
UPDATE NhanVien
SET MaPB = 'PB03', MaCV = 'CV03', MaHD = 'HD03'
WHERE MaNV = 'NV03';

-- Cập nhật MaPB, MaCV, MaHD cho MaNV = 'NV04'
UPDATE NhanVien
SET MaPB = 'PB03', MaCV = 'CV04', MaHD = 'HD04'
WHERE MaNV = 'NV04';
GO
-- Thêm dữ liệu cho bảng NguoiPhuThuoc
INSERT INTO NguoiPhuThuoc (MaNV, HoTen, NgaySinh, QuanHe)
VALUES
('NV01', 'Nguyen Thi Minh', '2015-06-12', 'Con'),
('NV02', 'Le Van Phuc', '2018-04-25', 'Con'),
('NV03', 'Tran Van Hai', '2017-12-19', 'Con'),
('NV04', 'Pham Thi Ha', '2020-01-01', 'Con');
GO
-- Thêm dữ liệu cho bảng Thang
INSERT INTO Thang (MaThang, MoTa, SoNgayCongChuan)
VALUES
('012023', 'Tháng 01 Năm 2023', 22),
('022023', 'Tháng 02 Năm 2023', 20),
('032023', 'Tháng 03 Năm 2023', 23),
('042023', 'Tháng 04 Năm 2023', 21);
GO
-- Thêm dữ liệu cho bảng ThuongPhat
INSERT INTO ThuongPhat (MaThuongPhat, Loai, SoTien, LyDo)
VALUES
('TP01', 'Thưởng', 5000000, 'Hoàn thành công việc xuất sắc'),
('TP02', 'Phạt', 1000000, 'Đi làm muộn'),
('TP03', 'Thưởng', 2000000, 'Đóng góp ý tưởng tốt'),
('TP04', 'Phạt', 500000, 'Không hoàn thành công việc đúng hạn');
-- Thêm dữ liệu cho bảng ctThuongPhat
-- nếu là 05 thì sai
GO
INSERT INTO ctThuongPhat (MaNV, MaThuongPhat, MaThang, NgayThuongPhat)
VALUES
('NV01', 'TP01', '012023', '15'),
('NV02', 'TP02', '022023', '10'),
('NV03', 'TP03', '032023', '20'),
('NV04', 'TP04', '042023', '05');
GO
-- drop table ctThuongPhat
-- Thêm dữ liệu cho bảng ChamCong
INSERT INTO ChamCong (MaCC, MoTa, HeSo)
VALUES
('CC01', 'Đi làm đủ', 1),
('CC02', 'Nghỉ phép', 0.5),
('CC03', 'Đi làm muộn', 0.75),
('CC04', 'Nghỉ không lý do', 0);
GO
-- nếu là 05 thì sai
-- check MaThang
-- Thêm dữ liệu cho bảng ctChamCong
INSERT INTO ctChamCong (MaNV, MaCC, MaThang, NgayChamCong)
VALUES
('NV01', 'CC01', '012023', '20'),
('NV02', 'CC03', '022023', '18'),
('NV03', 'CC02', '032023', '10'),
('NV04', 'CC04', '042023', '15');
-- drop table ctChamCong
GO
-- Thêm dữ liệu cho bảng BaoHiem
INSERT INTO BaoHiem (MaLoai, TenBH)
VALUES
('BH01', 'Bảo Hiểm Y Tế'),
('BH02', 'Bảo Hiểm Xã Hội'),
('BH03', 'Bảo Hiểm Tai Nạn');
GO
-- Thêm dữ liệu cho bảng ctBaoHiem
INSERT INTO ctBaoHiem (MaNV, MaBH, MaLoai, NgayBD, NgayKT)
VALUES
('NV01', 'BH01', 'BH01', '2023-01-01', '2024-01-01'),
('NV02', 'BH02', 'BH02', '2022-06-15', '2023-06-15'),
('NV03', 'BH03', 'BH03', '2021-09-01', '2022-09-01'),
('NV04', 'BH04', 'BH01', '2023-03-10', '2024-03-10');
GO
-- check MaThang
-- Thêm dữ liệu cho bảng NghiPhep
INSERT INTO NghiPhep (MaNV, MaThang, NgayNghiPhep, GhiChu)
VALUES
('NV01', '012023', 2, 'Nghỉ phép thường niên'),
('NV02', '022023', 3, 'Nghỉ ốm'),
('NV03', '032023', 1, 'Nghỉ việc riêng'),
('NV04', '042023', 4, 'Nghỉ phép thường niên');
GO
-- Thêm dữ liệu cho bảng LoaiTaiKhoan
INSERT INTO LoaiTaiKhoan (MaLoai, Ten)
VALUES
('LTK01', 'Admin'),
('LTK02', 'User');
GO
-- Thêm dữ liệu cho bảng TaiKhoan
INSERT INTO TaiKhoan (TenDangNhap, MatKhau, MaLoai)
VALUES
('NV01', 'password1', 'LTK01'),
('NV02', 'password2', 'LTK02'),
('NV03', 'password3', 'LTK02'),
('NV04', 'password4', 'LTK02');
GO
-- Thêm dữ liệu cho bảng PhuCap
INSERT INTO PhuCap (MaPhuCap, LoaiPhuCap)
VALUES
('PC01', 'di lai'),
('PC02', 'an trua'),
('PC03', 'cho o');
GO
-- Check MaThang
-- Thêm dữ liệu cho bảng ctPhuCap
INSERT INTO ctPhuCap (MaNV, MaPhuCap, MaThang, NgayPhuCap, SoTien)
VALUES
('NV01', 'PC01', '012023', 10, 500000),
('NV02', 'PC02', '022023', 15, 300000),
('NV03', 'PC03', '032023', 20, 400000),
('NV04', 'PC01', '042023', 25, 200000);

<<<<<<< HEAD


=======
GO

CREATE OR ALTER PROCEDURE sp_GetChamCongByMaNV
    @MaNV VARCHAR(10)
AS
BEGIN
    SELECT 
        ct.NgayChamCong, 
        thg.MoTa AS Thang, 
        cong.MoTa AS MoTa, 
        cong.HeSo
    FROM 
        ctChamCong ct
    JOIN 
        ChamCong cong ON cong.MaCC = ct.MaCC
    JOIN 
        Thang thg ON thg.MaThang = ct.MaThang
    WHERE 
        ct.MaNV = @MaNV;
END;

GO

CREATE OR ALTER PROCEDURE sp_AddctChamCong
    @MaNV VARCHAR(10),
    @MaCC VARCHAR(10),
    @MaThang VARCHAR(6),
    @NgayChamCong int
AS
BEGIN
	IF EXISTS (SELECT 1 FROM ctChamCong WHERE MaNV = @MaNV AND MaThang = @MaThang AND NgayChamCong = @NgayChamCong)
		BEGIN
			RAISERROR('Đã chấm công cho ngày này', 16, 1);
		END
    ELSE
		BEGIN
			INSERT INTO ctChamCong (MaNV, MaCC, MaThang, NgayChamCong)
			VALUES (@MaNV, @MaCC, @MaThang, @NgayChamCong);
		END    
END;

GO

CREATE OR ALTER PROCEDURE sp_GetAllctChamCong
AS
BEGIN
    SELECT 
		ct.MaNV,
        ct.NgayChamCong, 
        thg.MoTa AS Thang, 
        cong.MoTa AS MoTa, 
        cong.HeSo
    FROM 
        ctChamCong ct
    JOIN 
        ChamCong cong ON cong.MaCC = ct.MaCC
    JOIN 
        Thang thg ON thg.MaThang = ct.MaThang
END;

GO

CREATE OR ALTER PROCEDURE sp_GetctChamCong
    @MaNV VARCHAR(10),
	@MaThang VARCHAR(6)
AS
BEGIN
	IF (@MaThang IS NULL)
		BEGIN
			SELECT 
				ct.MaNV,
				ct.NgayChamCong, 
				thg.MoTa AS Thang, 
				cong.MoTa AS MoTa, 
				cong.HeSo
			FROM 
				ctChamCong ct
			JOIN 
				ChamCong cong ON cong.MaCC = ct.MaCC
			JOIN 
				Thang thg ON thg.MaThang = ct.MaThang
			WHERE 
				ct.MaNV = @MaNV;
		END
	ELSE
	   	BEGIN
			SELECT 
				ct.MaNV,
				ct.NgayChamCong, 
				thg.MoTa AS Thang, 
				cong.MoTa AS MoTa, 
				cong.HeSo
			FROM 
				ctChamCong ct
			JOIN 
				ChamCong cong ON cong.MaCC = ct.MaCC
			JOIN 
				Thang thg ON thg.MaThang = ct.MaThang
			WHERE 
				ct.MaNV = @MaNV and ct.MaThang = @MaThang;
		END
END;

GO

CREATE OR ALTER PROCEDURE sp_UpdatectChamCong
    @MaNV VARCHAR(10),
    @MaCC VARCHAR(10),
    @MaThang VARCHAR(6),
    @NgayChamCong int
AS
BEGIN
    -- Kiểm tra xem bản ghi có tồn tại trước khi cập nhật
    IF EXISTS (SELECT 1 FROM ctChamCong WHERE MaNV = @MaNV AND MaThang = @MaThang AND NgayChamCong = @NgayChamCong)
    BEGIN
        UPDATE ctChamCong
        SET MaCC = @MaCC
        WHERE MaNV = @MaNV AND MaThang = @MaThang AND NgayChamCong = @NgayChamCong;
    END
    ELSE
    BEGIN
        RAISERROR('Record not found', 16, 1);
    END
END;

GO

CREATE OR ALTER PROCEDURE sp_DeletectChamCong
    @MaNV VARCHAR(10),
    @MaThang VARCHAR(6),
    @NgayChamCong int
AS
BEGIN
        DELETE FROM ctChamCong WHERE MaNV = @MaNV AND MaThang = @MaThang AND NgayChamCong = @NgayChamCong;
END;

GO

CREATE OR ALTER PROCEDURE sp_AddNghiPhep
    @MaNV VARCHAR(10),
    @MaThang VARCHAR(6),
    @NgayNghiPhep int,
	@GhiChu NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO NghiPhep (MaNV, MaThang, NgayNghiPhep, GhiChu) VALUES (@MaNV, @MaThang, @NgayNghiPhep, @GhiChu);
END;

GO

CREATE OR ALTER PROCEDURE sp_GetNghiPhepByMaNV
    @MaNV VARCHAR(10)
AS
BEGIN
    SELECT 
        NgayNghiPhep, 
        thg.MoTa AS Thang, 
        GhiChu
    FROM 
        NghiPhep np
    JOIN 
        Thang thg ON thg.MaThang = np.MaThang
    WHERE 
        MaNV = @MaNV;
END;

GO

-----------------VIEW NHAN VIEN-------------
CREATE OR ALTER VIEW v_QuanLyNhanVien AS SELECT nv.MaNV, nv.Ho, nv.Ten, nv.GioiTinh, nv.NgaySinh, nv.DiaChi, nv.SDT, nv.Email, nv.CCCD, pb.TenPB AS TenPhongBan, cv.TenCV AS TenChucVu
FROM NhanVien nv JOIN PhongBan pb ON nv.MaPB = pb.MaPB JOIN ChucVu cv ON nv.MaCV = cv.MaCV;

GO

-----------------VIEW BAO HIEM--------------
CREATE OR ALTER VIEW v_QuanLyBaoHiem AS SELECT nv.MaNV, nv.Ho, nv.Ten, bh.MaLoai
AS MaBaoHiem, bh.TenBH, ctbh.MaBH, ctbh.NgayBD AS NgayBatDauBaoHiem, ctbh.NgayKT AS NgayKetThucBaoHiem
FROM NhanVien nv JOIN ctBaoHiem ctbh ON nv.MaNV = ctbh.MaNV JOIN BaoHiem bh ON ctbh.MaLoai = bh.MaLoai;

GO

-----------------VIEW HOP DONG---------------
CREATE OR ALTER VIEW v_QuanLyHopDong AS SELECT nv.MaNV, nv.Ho, nv.Ten, hd.MaHD, hd.LuongCoBan, hd.NgayBD
AS NgayBatDauHopDong, hd.NgayKT AS NgayKetThucHopDong FROM NhanVien nv JOIN HopDong hd ON nv.MaHD = hd.MaHD;

GO

---TINH LUONG---
CREATE OR ALTER PROCEDURE sp_TinhLuongTheoThang 
    @MaThang VARCHAR(6),
    @MaNV VARCHAR(10) = NULL -- Thêm MaNV để chỉ tính lương cho nhân viên cụ thể
AS
BEGIN
    -- Bảng tạm chứa số ngày công
    DECLARE @ChamCongThang TABLE (
        MaNV VARCHAR(10),
        SoNgayCong FLOAT
    );
    INSERT INTO @ChamCongThang (MaNV, SoNgayCong)
    SELECT MaNV, SUM(HeSo)
    FROM ctChamCong ct 
    JOIN ChamCong cc ON ct.MaCC = cc.MaCC
    WHERE MaThang = @MaThang 
    AND (@MaNV IS NULL OR ct.MaNV = @MaNV) -- Lọc theo MaNV nếu có
    GROUP BY MaNV, MaThang;

    -- Bảng tạm chứa thông tin người phụ thuộc
    DECLARE @NguoiPhuThuoc TABLE (
        MaNV VARCHAR(10),
        SoNguoiPhuThuoc INT,
        GiamTruGiaCanh INT
    );
    INSERT INTO @NguoiPhuThuoc (MaNV, SoNguoiPhuThuoc, GiamTruGiaCanh)
    SELECT MaNV, COUNT(*), ISNULL(COUNT(*), 0) * 4400000
    FROM NguoiPhuThuoc
    WHERE (@MaNV IS NULL OR MaNV = @MaNV) -- Lọc theo MaNV nếu có
    GROUP BY MaNV;

    -- Bảng tạm chứa phụ cấp tháng
    DECLARE @PhuCapThang TABLE (
        MaNV VARCHAR(10),
        TongPhuCap INT DEFAULT 0
    );
    INSERT INTO @PhuCapThang (MaNV, TongPhuCap)
    SELECT MaNV, ISNULL(SUM(SoTien), 0)
    FROM ctPhuCap
    WHERE MaThang = @MaThang
    AND (@MaNV IS NULL OR MaNV = @MaNV) -- Lọc theo MaNV nếu có
    GROUP BY MaNV, MaThang;

    -- Bảng tạm chứa thưởng phạt tháng
    DECLARE @ThuongPhatThang TABLE (
        MaNV VARCHAR(10),
        TongThuongPhat INT DEFAULT 0
    );
    INSERT INTO @ThuongPhatThang (MaNV, TongThuongPhat)
    SELECT MaNV, ISNULL(SUM(SoTien), 0)
    FROM ctThuongPhat ctp
    JOIN ThuongPhat tp ON ctp.MaThuongPhat = tp.MaThuongPhat
    WHERE MaThang = @MaThang
    AND (@MaNV IS NULL OR ctp.MaNV = @MaNV) -- Lọc theo MaNV nếu có
    GROUP BY MaNV, MaThang;

    -- Bảng tạm chứa bảo hiểm
    DECLARE @BaoHiem TABLE (
        MaNV VARCHAR(10),
        BH01 FLOAT DEFAULT 0,
        BH02 FLOAT DEFAULT 0,
        BH03 FLOAT DEFAULT 0
    );
    INSERT INTO @BaoHiem (MaNV, BH01, BH02, BH03)
    SELECT bh.MaNV,
           SUM(CASE WHEN bh.MaLoai = 'BH01' THEN 0.015 * hd.LuongCoBan ELSE 0 END),
           SUM(CASE WHEN bh.MaLoai = 'BH02' THEN 0.01 * hd.LuongCoBan ELSE 0 END),
           SUM(CASE WHEN bh.MaLoai = 'BH03' THEN 0.08 * hd.LuongCoBan ELSE 0 END)
    FROM ctBaoHiem bh
    JOIN HopDong hd ON bh.MaNV = hd.MaNV
    WHERE (@MaNV IS NULL OR bh.MaNV = @MaNV) -- Lọc theo MaNV nếu có
    GROUP BY bh.MaNV;

    -- Số ngày công chuẩn
    DECLARE @SoNgayCongChuan INT;
    SELECT @SoNgayCongChuan = SoNgayCongChuan
    FROM Thang WHERE MaThang = @MaThang;

    -- Tính lương chịu thuế
    DECLARE @LuongChiuThue TABLE (
        MaNV VARCHAR(10),
        LuongCoBan INT,
        GiamTruGiaCanh INT,
        TongPhuCap INT,
        TongThuongPhat INT,
        BH01 INT, BH02 INT, BH03 INT,
        TongTienBaoHiem INT,
        SoNgayCong INT,
        LuongChiuThue INT
    );
    INSERT INTO @LuongChiuThue (MaNV, LuongCoBan, GiamTruGiaCanh, TongPhuCap, TongThuongPhat, BH01, BH02, BH03, TongTienBaoHiem, SoNgayCong, LuongChiuThue)
    SELECT 
        nv.MaNV, LuongCoBan, ISNULL(npt.GiamTruGiaCanh, 0), ISNULL(pc.TongPhuCap, 0), ISNULL(tp.TongThuongPhat, 0),
        BH01, BH02, BH03, ISNULL(bhct.BH01, 0) + ISNULL(bhct.BH02, 0) + ISNULL(bhct.BH03, 0), ISNULL(SoNgayCong, 0),
        ( ( (hd.LuongCoBan / @SoNgayCongChuan * ISNULL(cc.SoNgayCong, 0)) + ISNULL(pc.TongPhuCap, 0) + ISNULL(tp.TongThuongPhat, 0) )
    - (ISNULL(bhct.BH01, 0) + ISNULL(bhct.BH02, 0) + ISNULL(bhct.BH03, 0)) - ISNULL(npt.GiamTruGiaCanh, 0))
    FROM NhanVien nv
    JOIN HopDong hd ON nv.MaNV = hd.MaNV
    LEFT JOIN @ChamCongThang cc ON nv.MaNV = cc.MaNV
    LEFT JOIN @NguoiPhuThuoc npt ON nv.MaNV = npt.MaNV
    LEFT JOIN @PhuCapThang pc ON nv.MaNV = pc.MaNV
    LEFT JOIN @ThuongPhatThang tp ON nv.MaNV = tp.MaNV
    LEFT JOIN @BaoHiem bhct ON nv.MaNV = bhct.MaNV
    WHERE @MaNV IS NULL OR nv.MaNV = @MaNV; -- Lọc theo MaNV nếu có

    -- Tính thuế thu nhập cá nhân
    DECLARE @ThueThuNhapCaNhan TABLE (
        MaNV VARCHAR(10),
        Thue INT
    );
    INSERT INTO @ThueThuNhapCaNhan (MaNV, Thue)
    SELECT nv.MaNV,
        CASE
            WHEN LuongChiuThue <= 5000000
                THEN LuongChiuThue * 5 / 100
            WHEN LuongChiuThue <= 10000000
                THEN LuongChiuThue * 10 / 100
            WHEN LuongChiuThue <= 18000000
                THEN LuongChiuThue * 15 / 100
            WHEN LuongChiuThue <= 32000000
                THEN LuongChiuThue * 20 / 100
            WHEN LuongChiuThue <= 52000000
                THEN LuongChiuThue * 25 / 100
            WHEN LuongChiuThue <= 80000000
                THEN LuongChiuThue * 30 / 100
            ELSE LuongChiuThue * 35 / 100
        END AS ThueThuNhapCaNhan
    FROM NhanVien nv
    LEFT JOIN @LuongChiuThue lct ON nv.MaNV = lct.MaNV
    WHERE @MaNV IS NULL OR nv.MaNV = @MaNV; -- Lọc theo MaNV nếu có

    -- Kết quả lương của nhân viên
    SELECT nv.MaNV, Ho, Ten, LuongCoBan, BH01, BH02, BH03,
            (BH01 + BH02 + BH03) AS TongTienBaoHiem,
            @SoNgayCongChuan AS SoNgayCongChuan,
            TongPhuCap, GiamTruGiaCanh, LuongChiuThue, 
            SoNgayCong, Thue, TongThuongPhat, (LuongChiuThue - Thue) AS LuongThucLanh
    FROM NhanVien nv
    LEFT JOIN @LuongChiuThue lct ON nv.MaNV = lct.MaNV
    LEFT JOIN @ThueThuNhapCaNhan thue ON nv.MaNV = thue.MaNV
    WHERE @MaNV IS NULL OR nv.MaNV = @MaNV; -- Lọc theo MaNV nếu có
END;

GO

CREATE OR ALTER TRIGGER tr_NghiPhep_ctChamCong_CheckNghiPhep
ON NghiPhep
AFTER INSERT
AS
BEGIN
    DECLARE @MaNV NVARCHAR(10),
		@MaThang NVARCHAR(6),
		@NgayNghiPhep INT,
		@Nam NVARCHAR(4),
		@SoNgayDaNghi INT,
		@MaCC NVARCHAR(10);

    -- Lấy thông tin từ bản ghi mới được thêm vào
    SELECT @MaNV = i.MaNV,
           @MaThang = i.MaThang,
           @NgayNghiPhep = i.NgayNghiPhep
    FROM inserted i;

	-- Tách năm từ 4 ký tự cuối trong MaThang
    SELECT @Nam = SUBSTRING(@MaThang, 3, 4);

    -- Đếm số ngày nghỉ phép trong năm
    SELECT @SoNgayDaNghi = COUNT(*)
    FROM NghiPhep
    WHERE MaNV = @MaNV AND RIGHT(MaThang, 4) = @Nam;

    -- Xác định MaCC dựa trên số ngày đã nghỉ phép, 13 là do tính inserted
    IF (@SoNgayDaNghi >= 13)
        SELECT @MaCC = MaCC FROM ChamCong WHERE MoTa LIKE N'%ghỉ không lương%';
    ELSE
        SELECT @MaCC = MaCC FROM ChamCong WHERE MoTa LIKE N'%ghỉ phép năm%';

    -- Thêm bản ghi vào bảng ctChamCong
    INSERT INTO ctChamCong (MaNV, MaCC, MaThang, NgayChamCong) 
    VALUES (@MaNV, @MaCC, @MaThang, @NgayNghiPhep);
END;
