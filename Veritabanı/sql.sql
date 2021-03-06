USE [KafeOtomasyonu]
GO
CREATE TABLE [dbo].[adisyon](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masaAdi] [varchar](50) NULL,
	[baslamaTarihi] [datetime] NOT NULL CONSTRAINT [DF_adisyon_baslamaTarihi]  DEFAULT (getdate()),
	[bitisTarihi] [datetime] NULL,
	[ucret] [money] NULL CONSTRAINT [DF_adisyon_ucret]  DEFAULT ((0)),
 CONSTRAINT [PK_adisyon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[adisyonAyrinti] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[adisyonAyrinti](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adisyonId] [int] NULL,
	[urun] [varchar](100) NULL,
	[fiyat] [money] NULL,
	[adet] [int] NULL CONSTRAINT [DF_adisyonAyrinti_adet]  DEFAULT ((1)),
	[tarih] [datetime] NOT NULL CONSTRAINT [DF_adisyonAyrinti_tarih]  DEFAULT (getdate()),
 CONSTRAINT [PK_adisyonAyrinti] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[masalar] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[masalar](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[masaAdi] [varchar](50) NULL,
	[durum] [tinyint] NULL CONSTRAINT [DF_masalar_durum]  DEFAULT ((0)),
	[adisyonId] [int] NOT NULL CONSTRAINT [DF_masalar_adisyonId]  DEFAULT ((0)),
 CONSTRAINT [PK_masalar] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[urunler] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[urunler](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[urun] [varchar](100) NULL,
	[kategori] [varchar](50) NULL,
	[fiyat] [money] NULL,
 CONSTRAINT [PK_urunler] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[userLoginLog] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[userLoginLog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kadi] [varchar](50) NULL,
	[girisZamani] [datetime] NOT NULL CONSTRAINT [DF_userLoginLog_girisZamani]  DEFAULT (getdate()),
	[durum] [tinyint] NULL,
 CONSTRAINT [PK_userLoginLog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[kadi] [varchar](50) NULL,
	[sifre] [varchar](50) NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[masalar] ON 
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (1, N'Masa - 1', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (2, N'Masa - 2', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (3, N'Masa - 3', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (4, N'Masa - 4', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (5, N'Masa - 5', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (6, N'Masa - 6', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (7, N'Masa - 7', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (8, N'Masa - 8', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (9, N'Masa - 9', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (10, N'Masa - 10', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (11, N'Masa - 11', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (12, N'Masa - 12', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (13, N'Masa - 13', 0, 0)
INSERT [dbo].[masalar] ([id], [masaAdi], [durum], [adisyonId]) VALUES (14, N'Masa - 14', 0, 0)
SET IDENTITY_INSERT [dbo].[masalar] OFF
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [kadi], [sifre]) VALUES (1, N'Admin', N'123')
SET IDENTITY_INSERT [dbo].[users] OFF
