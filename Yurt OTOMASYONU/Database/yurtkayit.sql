USE [master]
GO
/****** Object:  Database [Yurtkayit]    Script Date: 1.11.2018 17:17:11 ******/
CREATE DATABASE [Yurtkayit]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Yurtkayit', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\Yurtkayit.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Yurtkayit_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLSERVER\MSSQL\DATA\Yurtkayit_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Yurtkayit] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Yurtkayit].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Yurtkayit] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Yurtkayit] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Yurtkayit] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Yurtkayit] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Yurtkayit] SET ARITHABORT OFF 
GO
ALTER DATABASE [Yurtkayit] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Yurtkayit] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Yurtkayit] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Yurtkayit] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Yurtkayit] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Yurtkayit] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Yurtkayit] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Yurtkayit] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Yurtkayit] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Yurtkayit] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Yurtkayit] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Yurtkayit] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Yurtkayit] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Yurtkayit] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Yurtkayit] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Yurtkayit] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Yurtkayit] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Yurtkayit] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Yurtkayit] SET  MULTI_USER 
GO
ALTER DATABASE [Yurtkayit] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Yurtkayit] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Yurtkayit] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Yurtkayit] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Yurtkayit] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Yurtkayit', N'ON'
GO
ALTER DATABASE [Yurtkayit] SET QUERY_STORE = OFF
GO
USE [Yurtkayit]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Yurtkayit]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 1.11.2018 17:17:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[Yoneticiid] [tinyint] IDENTITY(1,1) NOT NULL,
	[YoneticiAd] [varchar](20) NULL,
	[YoneticiSifre] [varchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolumler]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolumler](
	[Bolumid] [tinyint] IDENTITY(1,1) NOT NULL,
	[BolumAd] [varchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borclar]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borclar](
	[Ogrid] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](20) NULL,
	[OgrSoyad] [varchar](20) NULL,
	[OgrKalanBorc] [smallint] NULL,
 CONSTRAINT [PK_Borclar] PRIMARY KEY CLUSTERED 
(
	[Ogrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Giderler]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Giderler](
	[Odemeid] [smallint] IDENTITY(1,1) NOT NULL,
	[Elektrik] [int] NULL,
	[Su] [int] NULL,
	[Dogalgaz] [int] NULL,
	[internet] [int] NULL,
	[Gida] [int] NULL,
	[Personel] [int] NULL,
	[Diger] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasa]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasa](
	[OdemeAy] [varchar](10) NULL,
	[OdemeMiktar] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Odalar]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Odalar](
	[Odaid] [tinyint] IDENTITY(1,1) NOT NULL,
	[OdaNo] [char](3) NULL,
	[OdaKapasite] [char](1) NULL,
	[OdaAktif] [char](1) NULL,
	[OdaDurum] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Ogrid] [int] IDENTITY(1,1) NOT NULL,
	[OgrAd] [varchar](30) NULL,
	[OgrSoyad] [varchar](50) NULL,
	[OgrTC] [char](11) NULL,
	[OgrTelefon] [varchar](20) NULL,
	[OgrDogum] [varchar](20) NULL,
	[OgrBolum] [varchar](50) NULL,
	[OgrMail] [varchar](50) NULL,
	[OgrOdaNo] [char](3) NULL,
	[OgrVeliAdSoyad] [varchar](50) NULL,
	[OgrVeliTelefon] [varchar](20) NULL,
	[OgrVeliAdres] [varchar](300) NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Ogrid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[Personleid] [tinyint] IDENTITY(1,1) NOT NULL,
	[PersonelAdSoyad] [varchar](50) NULL,
	[PersonelGorevi] [varchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([Yoneticiid], [YoneticiAd], [YoneticiSifre]) VALUES (1, N'bengeldim', N'123456')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Bolumler] ON 

INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (2, N'Elektronik Mühendislik')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (3, N'Otomotiv Mühendisliği')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (4, N'Mekatronik Mühendisliki')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (5, N'Yazılım Mühendisliği')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (6, N'Edebiyat')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (7, N'Sosyal Bilimler')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (8, N'Matematik')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (9, N'Tıp')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (10, N'Diş Hekimliği')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (11, N'Veterinerlik')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (12, N'Muhasebe')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (13, N'İşletme')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (14, N'Su Ürünleri')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (15, N'Yabancı Diller')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (16, N'Coğrafya')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (17, N'Bilgisayar Öğretmenliği')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (18, N'Branş Öğretmenlikleri')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (19, N'Konservatuar')
INSERT [dbo].[Bolumler] ([Bolumid], [BolumAd]) VALUES (20, N'Uluslararası İlişkiler')
SET IDENTITY_INSERT [dbo].[Bolumler] OFF
SET IDENTITY_INSERT [dbo].[Borclar] ON 

INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (1, N'Mahmud', N'saf', 3500)
INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2, N'yakup', N'serıngol', 2222)
INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (3, N'Piç', N'Mehmet', 3000)
INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (4, N'yeoo', N'safasf', 4112)
INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (5, N'SEA', N'AES', 4403)
INSERT [dbo].[Borclar] ([Ogrid], [OgrAd], [OgrSoyad], [OgrKalanBorc]) VALUES (2002, N'SEA', N'AES', 4403)
SET IDENTITY_INSERT [dbo].[Borclar] OFF
SET IDENTITY_INSERT [dbo].[Odalar] ON 

INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (1, N'101', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (2, N'102', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (3, N'103', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (4, N'104', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (5, N'105', N'1', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (6, N'201', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (7, N'202', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (8, N'203', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (9, N'204', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (10, N'205', N'2', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (11, N'301', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (12, N'302', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (13, N'303', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (14, N'304', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (15, N'305', N'3', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (16, N'401', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (17, N'402', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (18, N'403', N'4', N'0', 1)
INSERT [dbo].[Odalar] ([Odaid], [OdaNo], [OdaKapasite], [OdaAktif], [OdaDurum]) VALUES (19, N'404', N'4', N'0', 1)
SET IDENTITY_INSERT [dbo].[Odalar] OFF
ALTER TABLE [dbo].[Borclar] ADD  CONSTRAINT [DF_Borclar_OgrKalanBorc]  DEFAULT ((3000)) FOR [OgrKalanBorc]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaAktif]  DEFAULT ((0)) FOR [OdaAktif]
GO
ALTER TABLE [dbo].[Odalar] ADD  CONSTRAINT [DF_Odalar_OdaDurum]  DEFAULT ((1)) FOR [OdaDurum]
GO
/****** Object:  StoredProcedure [dbo].[BolumEkle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BolumEkle]
@BolumID int,
@BolumAd varchar(100)
as
Insert into Bolumler values(@BolumAd)
GO
/****** Object:  StoredProcedure [dbo].[BolumGuncelle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BolumGuncelle]
@BolumID int,
@BolumAd varchar(100)
as
Update Bolumler set BolumAd=@BolumAd where Bolumid=@BolumID
GO
/****** Object:  StoredProcedure [dbo].[BolumListele]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BolumListele]
as
Select * from Bolumler
GO
/****** Object:  StoredProcedure [dbo].[BolumSil]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[BolumSil]
@BolumID int ,
@BolumAd varchar(30) 

as
Delete from Bolumler where Bolumid=@BolumID
GO
/****** Object:  StoredProcedure [dbo].[BorcEkle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BorcEkle]
@BorcID int,
@BorcluAd varchar(20),
@BorcluSoyad varchar(20),
@KalanBorc smallint
as
Insert into Borclar values(@BorcluAd,@BorcluSoyad,@KalanBorc)
GO
/****** Object:  StoredProcedure [dbo].[BorcGuncelle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BorcGuncelle]
@BorcID int,
@BorcluAd varchar(20),
@BorcluSoyad varchar(20),
@KalanBorc smallint
as
Update Borclar set OgrAd=@BorcluAd,OgrSoyad=@BorcluSoyad,OgrKalanBorc=@KalanBorc where Ogrid=@BorcID;
GO
/****** Object:  StoredProcedure [dbo].[BorcListele]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BorcListele]
as
Select * from Borclar
GO
/****** Object:  StoredProcedure [dbo].[BorcSil]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[BorcSil]
@BorcID int ,
@BorcluAd varchar(20) ,
@Borclusoyad int,
@KalanBorc smallint
as
Delete from Borclar where ogrid=@BorcID
GO
/****** Object:  StoredProcedure [dbo].[GiderEkle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GiderEkle]
@GiderID int,
@Elektrik int,
@Su int,
@Dogalgaz int,
@Internet int,
@Gida int,
@Personel int,
@Diger int
as
INsert into Giderler values(@Elektrik,@Su,@Dogalgaz,@Internet,@Gida,@Personel,@Diger)
GO
/****** Object:  StoredProcedure [dbo].[GiderGuncelle]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GiderGuncelle]
@GiderID int,
@Elektrik int,
@Su int,
@Dogalgaz int,
@Internet int,
@Gida int,
@Personel int,
@Diger int
as
Update  Giderler set Elektrik=@Elektrik,Su=@Su,Dogalgaz=@Dogalgaz,internet=@Internet,Gida=@Gida,Personel=@Personel,Diger=@Diger where Odemeid=@GiderID
GO
/****** Object:  StoredProcedure [dbo].[GiderListele]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GiderListele]
as
Select * from Giderler
GO
/****** Object:  StoredProcedure [dbo].[GiderSil]    Script Date: 1.11.2018 17:17:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GiderSil]

@GiderID int
as
Delete from Giderler where Odemeid=@GiderID
GO
USE [master]
GO
ALTER DATABASE [Yurtkayit] SET  READ_WRITE 
GO
