USE [master]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyEventProcessingLogin##]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [##MS_PolicyEventProcessingLogin##] WITH PASSWORD=N'rTpqhkB6JXJWXhmmKqm1kTRBBiT+b6hauHeZkRDnhsc=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyEventProcessingLogin##] DISABLE
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [##MS_PolicyTsqlExecutionLogin##]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [##MS_PolicyTsqlExecutionLogin##] WITH PASSWORD=N'9DEKkryjmYPi+D/CLvmsHPaH2cayMQTv6nTMZGggMsE=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [##MS_PolicyTsqlExecutionLogin##] DISABLE
GO
/****** Object:  Login [DESKTOP-K9Q59SF\Quoc Toan]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [DESKTOP-K9Q59SF\Quoc Toan] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [distributor_admin]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [distributor_admin] WITH PASSWORD=N'Z40/KT8uKFL2tdSL6TyCImm5ZRjkA7BtlpUWn90lXHA=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
ALTER LOGIN [distributor_admin] DISABLE
GO
/****** Object:  Login [NT AUTHORITY\SYSTEM]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT AUTHORITY\SYSTEM] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT Service\MSSQL$SERVER]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT Service\MSSQL$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLAgent$SERVER]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT SERVICE\SQLAgent$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLTELEMETRY$SERVER]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT SERVICE\SQLTELEMETRY$SERVER] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\SQLWriter]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT SERVICE\SQLWriter] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/****** Object:  Login [NT SERVICE\Winmgmt]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [NT SERVICE\Winmgmt] FROM WINDOWS WITH DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english]
GO
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [remoteLogin]    Script Date: 28/04/2022 07:52:49 ******/
CREATE LOGIN [remoteLogin] WITH PASSWORD=N'i3Q1LphfP2C0OqiARI7/2I6e2zw5T7aTA1xQmgG4uu8=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO
ALTER LOGIN [remoteLogin] DISABLE
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [DESKTOP-K9Q59SF\Quoc Toan]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [distributor_admin]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT Service\MSSQL$SERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLAgent$SERVER]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\SQLWriter]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [NT SERVICE\Winmgmt]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [remoteLogin]
GO
USE [Tshoes]
GO
/****** Object:  User [remoteLogin]    Script Date: 28/04/2022 07:52:49 ******/
CREATE USER [remoteLogin] FOR LOGIN [remoteLogin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [GIAMDOC]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [GIAMDOC]
GO
/****** Object:  DatabaseRole [MSmerge_33E75D5ACB324212BB32E48560AC1D13]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [MSmerge_33E75D5ACB324212BB32E48560AC1D13]
GO
/****** Object:  DatabaseRole [MSmerge_DCD0FDEB3B7B493BB63A6E57B18049EE]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [MSmerge_DCD0FDEB3B7B493BB63A6E57B18049EE]
GO
/****** Object:  DatabaseRole [MSmerge_PAL_role]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [MSmerge_PAL_role]
GO
/****** Object:  DatabaseRole [NHANVIEN]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [NHANVIEN]
GO
/****** Object:  DatabaseRole [QLCHINHANH]    Script Date: 28/04/2022 07:52:49 ******/
CREATE ROLE [QLCHINHANH]
GO
ALTER AUTHORIZATION ON ROLE::[GIAMDOC] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_33E75D5ACB324212BB32E48560AC1D13] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_DCD0FDEB3B7B493BB63A6E57B18049EE] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[MSmerge_PAL_role] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[NHANVIEN] TO [dbo]
GO
ALTER AUTHORIZATION ON ROLE::[QLCHINHANH] TO [dbo]
GO
ALTER ROLE [GIAMDOC] ADD MEMBER [remoteLogin]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [remoteLogin]
GO
ALTER ROLE [MSmerge_DCD0FDEB3B7B493BB63A6E57B18049EE] ADD MEMBER [remoteLogin]
GO
ALTER ROLE [MSmerge_33E75D5ACB324212BB32E48560AC1D13] ADD MEMBER [remoteLogin]
GO
ALTER ROLE [db_owner] ADD MEMBER [remoteLogin]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_33E75D5ACB324212BB32E48560AC1D13]
GO
ALTER ROLE [MSmerge_PAL_role] ADD MEMBER [MSmerge_DCD0FDEB3B7B493BB63A6E57B18049EE]
GO
/****** Object:  Schema [MSmerge_PAL_role]    Script Date: 28/04/2022 07:52:49 ******/
CREATE SCHEMA [MSmerge_PAL_role] AUTHORIZATION [MSmerge_PAL_role]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[NhanVienID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TenTK] [nvarchar](100) NOT NULL,
	[Fullname] [nvarchar](1000) NOT NULL,
	[Ngaykhoitao] [datetime] NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[ChiNhanh_ID] [int] NULL,
	[Active] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.Account] PRIMARY KEY CLUSTERED 
(
	[NhanVienID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Account] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[BillDetails]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BillDetails](
	[BillDetailID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ChitietSP_ID] [int] NOT NULL,
	[TenSP] [nvarchar](1000) NULL,
	[Bills_ID] [int] NULL,
	[Mau] [nvarchar](max) NULL,
	[Sizes] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Giaban] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.BillDetails] PRIMARY KEY CLUSTERED 
(
	[BillDetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[BillDetails] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[BillID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[NhanVienID] [int] NOT NULL,
	[TenChiNhanh] [nvarchar](200) NOT NULL,
	[NgaylapBill] [datetime] NOT NULL,
	[TenKhachHang] [nvarchar](200) NOT NULL,
	[SDTKhachHang] [nvarchar](100) NULL,
	[TienHang] [float] NOT NULL,
	[Discount] [float] NOT NULL,
	[ToTal] [float] NOT NULL,
	[Active] [int] NOT NULL,
	[ChiNhanhID] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.Bills] PRIMARY KEY CLUSTERED 
(
	[BillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Bills] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[Chinhanh]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chinhanh](
	[ChiNhanhID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TenChiNhanh] [nvarchar](200) NOT NULL,
	[DiaChi] [nvarchar](200) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.Chinhanh] PRIMARY KEY CLUSTERED 
(
	[ChiNhanhID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[Chinhanh] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[ChitietNhapHang]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChitietNhapHang](
	[ChitietNhaphangID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[NhapHang_ID] [int] NULL,
	[ChitietsanPham_ID] [int] NULL,
	[DonGia] [float] NOT NULL,
	[SoLuongNhap] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.ChitietNhapHang] PRIMARY KEY CLUSTERED 
(
	[ChitietNhaphangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[ChitietNhapHang] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[ChiTietSanPham]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietSanPham](
	[ChitietSPID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[SanPham_ID] [int] NULL,
	[MaSP] [nvarchar](max) NULL,
	[TenSP] [nvarchar](max) NULL,
	[Mau] [nvarchar](max) NULL,
	[Sizes] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[Kinhdoanh] [int] NOT NULL,
	[ImgURL] [nvarchar](max) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.ChiTietSanPham] PRIMARY KEY CLUSTERED 
(
	[ChitietSPID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[ChiTietSanPham] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[LoginInfoes]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginInfoes](
	[RoleName] [nvarchar](max) NULL,
	[LoginName] [nvarchar](128) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.LoginInfoes] PRIMARY KEY CLUSTERED 
(
	[LoginName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[LoginInfoes] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NhapHang]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhapHang](
	[NhapHangID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[ngaynhap] [datetime] NOT NULL,
	[NguonHang] [nvarchar](max) NULL,
	[Tienhang] [float] NOT NULL,
	[Phivanchuyen] [float] NULL,
	[Thue] [float] NULL,
	[ChiPhiKhac] [float] NULL,
	[Thanhtien] [float] NOT NULL,
	[Ghichu] [nvarchar](max) NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.NhapHang] PRIMARY KEY CLUSTERED 
(
	[NhapHangID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[NhapHang] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[NhomSP]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomSP](
	[NhomspID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TenNhomSP] [nvarchar](100) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.NhomSP] PRIMARY KEY CLUSTERED 
(
	[NhomspID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[NhomSP] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[SanPhamID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[MaSanPham] [nvarchar](100) NOT NULL,
	[TenSanPham] [nvarchar](1000) NOT NULL,
	[NhomSP_ID] [int] NOT NULL,
	[ThuongHieu_ID] [int] NOT NULL,
	[Ngaynhap] [datetime] NOT NULL,
	[GiaNhap] [int] NOT NULL,
	[Giaban] [int] NOT NULL,
	[Soluong] [int] NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.SanPham] PRIMARY KEY CLUSTERED 
(
	[SanPhamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[SanPham] TO  SCHEMA OWNER 
GO
/****** Object:  Table [dbo].[ThuongHieu]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuongHieu](
	[ThuongHieuID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[TenThuongHieu] [nvarchar](100) NOT NULL,
	[rowguid] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
 CONSTRAINT [PK_dbo.ThuongHieu] PRIMARY KEY CLUSTERED 
(
	[ThuongHieuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER AUTHORIZATION ON [dbo].[ThuongHieu] TO  SCHEMA OWNER 
GO
ALTER TABLE [dbo].[Account] ADD  CONSTRAINT [MSmerge_df_rowguid_4A9420BC971241028A9B03D0267DEA3A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[BillDetails] ADD  CONSTRAINT [MSmerge_df_rowguid_CAB19E9DE58C457D8CBAED74921798E0]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Bills] ADD  DEFAULT ((0)) FOR [ChiNhanhID]
GO
ALTER TABLE [dbo].[Bills] ADD  CONSTRAINT [MSmerge_df_rowguid_2355B5486D8B4358BF701621AC908C57]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Chinhanh] ADD  DEFAULT ('') FOR [DiaChi]
GO
ALTER TABLE [dbo].[Chinhanh] ADD  CONSTRAINT [MSmerge_df_rowguid_E4C3FDD76E01416989695F8773A8F57C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ChitietNhapHang] ADD  CONSTRAINT [MSmerge_df_rowguid_AE9D61A01B44469D865FD1580CDC3766]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ChiTietSanPham] ADD  CONSTRAINT [MSmerge_df_rowguid_9F464195F08E43879E7B69F0F1F6C18A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[LoginInfoes] ADD  DEFAULT ('') FOR [LoginName]
GO
ALTER TABLE [dbo].[LoginInfoes] ADD  CONSTRAINT [MSmerge_df_rowguid_059F43F853854DDCB8897610301F5C0F]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhapHang] ADD  CONSTRAINT [MSmerge_df_rowguid_93A58366695F44209E9011F5BFF79359]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[NhomSP] ADD  CONSTRAINT [MSmerge_df_rowguid_368AA3E4BBFB4860856B2942D2E77A9C]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[SanPham] ADD  CONSTRAINT [MSmerge_df_rowguid_C7C49795B92546D99210801ABE87487A]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[ThuongHieu] ADD  CONSTRAINT [MSmerge_df_rowguid_2D1B746D49734F419E4AA3F0520ECE49]  DEFAULT (newsequentialid()) FOR [rowguid]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Account_dbo.Chinhanh_ChiNhanh_ID] FOREIGN KEY([ChiNhanh_ID])
REFERENCES [dbo].[Chinhanh] ([ChiNhanhID])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_dbo.Account_dbo.Chinhanh_ChiNhanh_ID]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BillDetails_dbo.Bills_Bills_ID] FOREIGN KEY([Bills_ID])
REFERENCES [dbo].[Bills] ([BillID])
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_dbo.BillDetails_dbo.Bills_Bills_ID]
GO
ALTER TABLE [dbo].[BillDetails]  WITH CHECK ADD  CONSTRAINT [FK_dbo.BillDetails_dbo.ChiTietSanPham_ChitietSP_ID] FOREIGN KEY([ChitietSP_ID])
REFERENCES [dbo].[ChiTietSanPham] ([ChitietSPID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [FK_dbo.BillDetails_dbo.ChiTietSanPham_ChitietSP_ID]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Bills_dbo.Account_NhanVienID] FOREIGN KEY([NhanVienID])
REFERENCES [dbo].[Account] ([NhanVienID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_dbo.Bills_dbo.Account_NhanVienID]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Bills_dbo.Chinhanh_ChiNhanhID] FOREIGN KEY([ChiNhanhID])
REFERENCES [dbo].[Chinhanh] ([ChiNhanhID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_dbo.Bills_dbo.Chinhanh_ChiNhanhID]
GO
ALTER TABLE [dbo].[ChitietNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChitietNhapHang_dbo.ChiTietSanPham_ChitietsanPham_ID] FOREIGN KEY([ChitietsanPham_ID])
REFERENCES [dbo].[ChiTietSanPham] ([ChitietSPID])
GO
ALTER TABLE [dbo].[ChitietNhapHang] CHECK CONSTRAINT [FK_dbo.ChitietNhapHang_dbo.ChiTietSanPham_ChitietsanPham_ID]
GO
ALTER TABLE [dbo].[ChitietNhapHang]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChitietNhapHang_dbo.NhapHang_NhapHang_ID] FOREIGN KEY([NhapHang_ID])
REFERENCES [dbo].[NhapHang] ([NhapHangID])
GO
ALTER TABLE [dbo].[ChitietNhapHang] CHECK CONSTRAINT [FK_dbo.ChitietNhapHang_dbo.NhapHang_NhapHang_ID]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH CHECK ADD  CONSTRAINT [FK_dbo.ChiTietSanPham_dbo.SanPham_SanPham_ID] FOREIGN KEY([SanPham_ID])
REFERENCES [dbo].[SanPham] ([SanPhamID])
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [FK_dbo.ChiTietSanPham_dbo.SanPham_SanPham_ID]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPham_dbo.NhomSP_NhomSP_ID] FOREIGN KEY([NhomSP_ID])
REFERENCES [dbo].[NhomSP] ([NhomspID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_dbo.SanPham_dbo.NhomSP_NhomSP_ID]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_dbo.SanPham_dbo.ThuongHieu_ThuongHieu_ID] FOREIGN KEY([ThuongHieu_ID])
REFERENCES [dbo].[ThuongHieu] ([ThuongHieuID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_dbo.SanPham_dbo.ThuongHieu_ThuongHieu_ID]
GO
ALTER TABLE [dbo].[Account]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_50C424FB_E839_46A5_A41B_5F5D98D580E0] CHECK NOT FOR REPLICATION (([NhanVienID]>(5) AND [NhanVienID]<=(1005) OR [NhanVienID]>(1005) AND [NhanVienID]<=(2005)))
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [repl_identity_range_50C424FB_E839_46A5_A41B_5F5D98D580E0]
GO
ALTER TABLE [dbo].[BillDetails]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_C8F403BB_B7A9_454E_A2F2_EC4280B01FBA] CHECK NOT FOR REPLICATION (([BillDetailID]>=(1) AND [BillDetailID]<=(1001) OR [BillDetailID]>(1001) AND [BillDetailID]<=(2001)))
GO
ALTER TABLE [dbo].[BillDetails] CHECK CONSTRAINT [repl_identity_range_C8F403BB_B7A9_454E_A2F2_EC4280B01FBA]
GO
ALTER TABLE [dbo].[Bills]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_152E0485_1351_4A0A_8B90_3608AAC53E69] CHECK NOT FOR REPLICATION (([BillID]>=(1) AND [BillID]<=(1001) OR [BillID]>(1001) AND [BillID]<=(2001)))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [repl_identity_range_152E0485_1351_4A0A_8B90_3608AAC53E69]
GO
ALTER TABLE [dbo].[Chinhanh]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_0CF88F07_8A32_4007_B518_17F07687B0C8] CHECK NOT FOR REPLICATION (([ChiNhanhID]>(2) AND [ChiNhanhID]<=(1002) OR [ChiNhanhID]>(1002) AND [ChiNhanhID]<=(2002)))
GO
ALTER TABLE [dbo].[Chinhanh] CHECK CONSTRAINT [repl_identity_range_0CF88F07_8A32_4007_B518_17F07687B0C8]
GO
ALTER TABLE [dbo].[ChitietNhapHang]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_1DD2333A_E8AA_41FA_B497_7BF14892B035] CHECK NOT FOR REPLICATION (([ChitietNhaphangID]>=(1) AND [ChitietNhaphangID]<=(1001) OR [ChitietNhaphangID]>(1001) AND [ChitietNhaphangID]<=(2001)))
GO
ALTER TABLE [dbo].[ChitietNhapHang] CHECK CONSTRAINT [repl_identity_range_1DD2333A_E8AA_41FA_B497_7BF14892B035]
GO
ALTER TABLE [dbo].[ChiTietSanPham]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_45A1B0D4_8ADB_49C1_8ACF_307549D6DA30] CHECK NOT FOR REPLICATION (([ChitietSPID]>=(1) AND [ChitietSPID]<=(1001) OR [ChitietSPID]>(1001) AND [ChitietSPID]<=(2001)))
GO
ALTER TABLE [dbo].[ChiTietSanPham] CHECK CONSTRAINT [repl_identity_range_45A1B0D4_8ADB_49C1_8ACF_307549D6DA30]
GO
ALTER TABLE [dbo].[NhapHang]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_D2A35322_2D3E_4F8F_BEAC_8089AE47FB76] CHECK NOT FOR REPLICATION (([NhapHangID]>=(1) AND [NhapHangID]<=(1001) OR [NhapHangID]>(1001) AND [NhapHangID]<=(2001)))
GO
ALTER TABLE [dbo].[NhapHang] CHECK CONSTRAINT [repl_identity_range_D2A35322_2D3E_4F8F_BEAC_8089AE47FB76]
GO
ALTER TABLE [dbo].[NhomSP]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_B396C151_80F1_4B44_ACBC_0D408830CB88] CHECK NOT FOR REPLICATION (([NhomspID]>=(1) AND [NhomspID]<=(1001) OR [NhomspID]>(1001) AND [NhomspID]<=(2001)))
GO
ALTER TABLE [dbo].[NhomSP] CHECK CONSTRAINT [repl_identity_range_B396C151_80F1_4B44_ACBC_0D408830CB88]
GO
ALTER TABLE [dbo].[SanPham]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_68D0FC2F_B94D_474F_BB05_D5425729015F] CHECK NOT FOR REPLICATION (([SanPhamID]>=(1) AND [SanPhamID]<=(1001) OR [SanPhamID]>(1001) AND [SanPhamID]<=(2001)))
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [repl_identity_range_68D0FC2F_B94D_474F_BB05_D5425729015F]
GO
ALTER TABLE [dbo].[ThuongHieu]  WITH NOCHECK ADD  CONSTRAINT [repl_identity_range_1A73C109_BBC3_430E_B4A1_6124E9B0F67D] CHECK NOT FOR REPLICATION (([ThuongHieuID]>=(1) AND [ThuongHieuID]<=(1001) OR [ThuongHieuID]>(1001) AND [ThuongHieuID]<=(2001)))
GO
ALTER TABLE [dbo].[ThuongHieu] CHECK CONSTRAINT [repl_identity_range_1A73C109_BBC3_430E_B4A1_6124E9B0F67D]
GO
/****** Object:  StoredProcedure [dbo].[sp_example_111]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROC [dbo].[sp_example_111]
AS
BEGIN
	CREATE TABLE #tmp (
		NhanVienID INT,
		TenTK NVARCHAR(256),
		Fullname NVARCHAR(256),
		Ngaykhoitao DATETIME,
		MatKhau VARCHAR(256),
		ChiNhanh_ID INT,
		Active INT,
		rowguid VARCHAR(256)
	)

	INSERT #tmp 
	EXEC [dbo].sp_GetAllUSer

	INSERT #tmp 
	EXEC LINK.Tshoes.[dbo].sp_GetAllUSer

	SELECT * FROM #tmp
END
GO
ALTER AUTHORIZATION ON [dbo].[sp_example_111] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllUSer]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GetAllUSer]
AS
BEGIN
	select * from LINK.Tshoes.dbo.Account
END
GO
ALTER AUTHORIZATION ON [dbo].[sp_GetAllUSer] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_getLoginInfo]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_getLoginInfo]
@LoginName nvarchar(50)
as
begin
 declare @Id nvarchar(50)
 select @Id = name from sys.sysusers where sid = SUSER_SID(@LoginName)

 select Id = @Id , RoleName = name
 from sys.sysusers
 where uid = (select groupuid
 from sys.sysmembers
 where memberuid = (select uid from sys.sysusers
 where name = @Id))
 end
GO
ALTER AUTHORIZATION ON [dbo].[sp_getLoginInfo] TO  SCHEMA OWNER 
GO
/****** Object:  StoredProcedure [dbo].[sp_TaoTaiKhoan]    Script Date: 28/04/2022 07:52:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_TaoTaiKhoan]
@LGNAME VARCHAR(50),
@PASS VARCHAR(50),
@USERNAME VARCHAR(50),
@ROLE VARCHAR(50)
AS
BEGIN
	DECLARE @RET INT
	declare @t nvarchar(4000)
		 set @t = N'CREATE LOGIN ''''' + @LGNAME + ''''' WITH PASSWORD = ''''' + @PASS
	exec sys.sp_executesql @t
	
	EXEC sp_addrolemember @ROLE, @USERNAME

	IF @ROLE = 'GIAMDOC'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'Securityadmin'
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
	END

	IF @ROLE = 'QLCHINHANH'
	BEGIN 
	EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
	EXEC sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
	EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'

	END
	IF @ROLE = 'NHANVIEN'
	BEGIN
		EXEC sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
		EXEC sp_addsrvrolemember @LGNAME, 'sysadmin'
	END

END

GO
ALTER AUTHORIZATION ON [dbo].[sp_TaoTaiKhoan] TO  SCHEMA OWNER 
GO
