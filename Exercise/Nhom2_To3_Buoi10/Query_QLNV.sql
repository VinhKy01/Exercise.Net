CREATE DATABASE QLNV

GO

USE QLNV

GO

CREATE TABLE ChucVu
(
	macv NVARCHAR(10) NOT NULL PRIMARY KEY,
	tencv NVARCHAR(30) NOT NULL,
	hsphucap INT DEFAULT 1,
)

GO

CREATE TABLE NhanVien
(
	manv NVARCHAR(10) NOT NULL PRIMARY KEY,
	holot NVARCHAR(20) NOT NULL,
	ten NVARCHAR(10) NOT NULL,
	phai NVARCHAR(10) NOT NULL CHECK (phai = N'Nam' OR phai = N'Nữ') DEFAULT N'Nam',
	ngaysinh DATE NOT NULL,
	macv NVARCHAR(10) NOT NULL

	FOREIGN KEY (macv) REFERENCES dbo.ChucVu(macv)
)

GO

CREATE TABLE Luong
(
	manv NVARCHAR(10) NOT NULL,
	ngaybd DATE NOT NULL,
	hsluong INT DEFAULT 1,
	ghichu NVARCHAR(30),

	CONSTRAINT NhanVien_pk PRIMARY KEY (manv, ngaybd),
	FOREIGN KEY (manv) REFERENCES dbo.NhanVien(manv)
)

GO

INSERT INTO dbo.ChucVu
(
    macv,
    tencv,
    hsphucap
)
VALUES
(   N'KT',    -- macv - nvarchar(10)
    N'Kế toán',    -- tencv - nvarchar(30)
    DEFAULT -- hsphucap - int
    )


GO
INSERT INTO dbo.ChucVu
(
    macv,
    tencv,
    hsphucap
)
VALUES
(   N'TP',    -- macv - nvarchar(10)
    N'Truong phong',    -- tencv - nvarchar(30)
    DEFAULT -- hsphucap - int
    )


GO
INSERT INTO dbo.ChucVu
(
    macv,
    tencv,
    hsphucap
)
VALUES
(   N'LC',    -- macv - nvarchar(10)
    N'Lao cong',    -- tencv - nvarchar(30)
    DEFAULT -- hsphucap - int
    )


GO

INSERT INTO dbo.NhanVien
(
    manv,
    holot,
    ten,
    phai,
    ngaysinh,
    macv
)
VALUES
(   N'NTD195423',       -- manv - nvarchar(10)
    N'Nguyễn Thành',       -- holot - nvarchar(20)
    N'Đặng',       -- ten - nvarchar(10)
    DEFAULT,   -- phai - nvarchar(10)
    GETDATE(), -- ngaysinh - date
    N'TP'        -- macv - nvarchar(10)
    )
   
GO



GO

UPDATE dbo.NhanVien SET phai = N'Nam' WHERE manv = N'NTD195423'

GO


GO

CREATE	PROC ThemNV
@manv NVARCHAR(10), @holot NVARCHAR(20), @ten NVARCHAR(10), @phai NVARCHAR(10), @ngaysinh DATE, @macv NVARCHAR(10)
AS
BEGIN
	insert into NhanVien values ( @manv ,  @holot ,   @ten , @phai , @ngaysinh , @macv)
END
GO

SELECT * FROM dbo.NhanVien
SELECT * FROM dbo.ChucVu

UPDATE dbo.NhanVien SET manv = N'Nam', holot = N'Nam', ten = N'Nam', phai = N'Nam', ngaysinh = GETDATE(), macv = N'TP' WHERE manv = N'NTD195423'

CREATE proc SUANV
@id nvarchar(10), @manv nvarchar(10), @holot nvarchar(20),@ten nvarchar(10), @phai nvarchar(10),  @ngaysinh date, @macv nvarchar(10)
AS
BEGIN
		UPDATE NHANVIEN
		SET manv = @manv, holot = @holot, ten = @ten, phai = @phai, ngaysinh = @ngaysinh, macv = @macv
		where manv = @id
		
END
GO

EXEC SUANV @id , @manv , @holot , @ten , @phai ,  @ngaysinh , @macv 