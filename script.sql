USE [master]
GO
/****** Object:  Database [preporder]    Script Date: 19/12/2024 22:28:06 ******/
CREATE DATABASE [preporder]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'preporder', FILENAME = N'D:\ça dev fort\MSSQL16.SQLEXPRESS\MSSQL\DATA\preporder.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'preporder_log', FILENAME = N'D:\ça dev fort\MSSQL16.SQLEXPRESS\MSSQL\DATA\preporder_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [preporder] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [preporder].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [preporder] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [preporder] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [preporder] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [preporder] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [preporder] SET ARITHABORT OFF 
GO
ALTER DATABASE [preporder] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [preporder] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [preporder] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [preporder] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [preporder] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [preporder] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [preporder] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [preporder] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [preporder] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [preporder] SET  DISABLE_BROKER 
GO
ALTER DATABASE [preporder] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [preporder] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [preporder] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [preporder] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [preporder] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [preporder] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [preporder] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [preporder] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [preporder] SET  MULTI_USER 
GO
ALTER DATABASE [preporder] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [preporder] SET DB_CHAINING OFF 
GO
ALTER DATABASE [preporder] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [preporder] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [preporder] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [preporder] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [preporder] SET QUERY_STORE = ON
GO
ALTER DATABASE [preporder] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [preporder]
GO
/****** Object:  Table [dbo].[CARISTE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARISTE](
	[numCariste] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[mdp] [nvarchar](50) NOT NULL,
	[codeZone] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numCariste] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMMANDE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMMANDE](
	[numCommande] [int] NOT NULL,
	[numMagasin] [int] NOT NULL,
	[dateCommande] [date] NOT NULL,
	[etat] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[numCommande] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[COMPOSER]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COMPOSER](
	[numSousComm] [int] NOT NULL,
	[numProduit] [int] NOT NULL,
	[qtLotCommande] [int] NOT NULL,
	[Problem] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[numSousComm] ASC,
	[numProduit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAGASIN]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAGASIN](
	[numMagasin] [int] NOT NULL,
	[nomMagasin] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numMagasin] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PALETTE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PALETTE](
	[numPalette] [int] NOT NULL,
	[emplacementPalette] [nvarchar](100) NOT NULL,
	[qtLotProduit] [int] NOT NULL,
	[numProduit] [int] NULL,
	[estVide] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[numPalette] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PREPARATEUR]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PREPARATEUR](
	[numPreparateur] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[mdp] [nvarchar](50) NOT NULL,
	[codeZone] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numPreparateur] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUIT]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUIT](
	[numProduit] [int] NOT NULL,
	[libelleProduit] [nvarchar](100) NOT NULL,
	[codeZone] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numProduit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RESPONSABLE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RESPONSABLE](
	[numResponsable] [int] NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[mdp] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[numResponsable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SOUS_COMMANDE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SOUS_COMMANDE](
	[numSousComm] [int] NOT NULL,
	[numCommande] [int] NOT NULL,
	[numMagasin] [int] NOT NULL,
	[idPreparateur] [int] NULL,
	[etat] [tinyint] NULL,
PRIMARY KEY CLUSTERED 
(
	[numSousComm] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ZONE]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ZONE](
	[codeZone] [int] NOT NULL,
	[libelleZone] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codeZone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CARISTE] ([numCariste], [login], [mdp], [codeZone]) VALUES (1, N'cariste_sec', N'pass1', 1)
INSERT [dbo].[CARISTE] ([numCariste], [login], [mdp], [codeZone]) VALUES (2, N'cariste_liquide', N'pass2', 2)
INSERT [dbo].[CARISTE] ([numCariste], [login], [mdp], [codeZone]) VALUES (3, N'Gérard DOUVES', N'pass3', 3)
GO
INSERT [dbo].[COMMANDE] ([numCommande], [numMagasin], [dateCommande], [etat]) VALUES (1, 1, CAST(N'2024-12-12' AS Date), 1)
INSERT [dbo].[COMMANDE] ([numCommande], [numMagasin], [dateCommande], [etat]) VALUES (2, 2, CAST(N'2024-12-13' AS Date), 0)
INSERT [dbo].[COMMANDE] ([numCommande], [numMagasin], [dateCommande], [etat]) VALUES (3, 3, CAST(N'2024-12-15' AS Date), 0)
INSERT [dbo].[COMMANDE] ([numCommande], [numMagasin], [dateCommande], [etat]) VALUES (4, 2, CAST(N'2024-12-19' AS Date), 0)
INSERT [dbo].[COMMANDE] ([numCommande], [numMagasin], [dateCommande], [etat]) VALUES (5, 2, CAST(N'2024-12-19' AS Date), 0)
GO
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (1, 1, 35, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (2, 7, 67, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (3, 13, 232, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (4, 3, 76, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (5, 1, 153, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (5, 5, 124, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (6, 2, 92, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (7, 3, 21, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (7, 4, 160, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (8, 1, 153, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (8, 5, 124, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (9, 2, 92, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (10, 3, 21, NULL)
INSERT [dbo].[COMPOSER] ([numSousComm], [numProduit], [qtLotCommande], [Problem]) VALUES (10, 4, 160, NULL)
GO
INSERT [dbo].[MAGASIN] ([numMagasin], [nomMagasin]) VALUES (1, N'Magasin Paris')
INSERT [dbo].[MAGASIN] ([numMagasin], [nomMagasin]) VALUES (2, N'Magasin Lyon')
INSERT [dbo].[MAGASIN] ([numMagasin], [nomMagasin]) VALUES (3, N'Magasin Marseille')
GO
INSERT [dbo].[PALETTE] ([numPalette], [emplacementPalette], [qtLotProduit], [numProduit], [estVide]) VALUES (1, N'A01_E00_01', 0, NULL, 1)
INSERT [dbo].[PALETTE] ([numPalette], [emplacementPalette], [qtLotProduit], [numProduit], [estVide]) VALUES (2, N'A1_E00_02', 65, 3, 0)
INSERT [dbo].[PALETTE] ([numPalette], [emplacementPalette], [qtLotProduit], [numProduit], [estVide]) VALUES (3, N'A1_E01_02', 33, 3, 0)
INSERT [dbo].[PALETTE] ([numPalette], [emplacementPalette], [qtLotProduit], [numProduit], [estVide]) VALUES (4, N'A1_E00_23', 87, 13, 0)
INSERT [dbo].[PALETTE] ([numPalette], [emplacementPalette], [qtLotProduit], [numProduit], [estVide]) VALUES (5, N'A1_E00_36', 55, 1, 0)
GO
INSERT [dbo].[PREPARATEUR] ([numPreparateur], [login], [mdp], [codeZone]) VALUES (1, N'prep_sec', N'passprep1', 1)
INSERT [dbo].[PREPARATEUR] ([numPreparateur], [login], [mdp], [codeZone]) VALUES (2, N'Yvan JADEAU', N'passprep2', 2)
INSERT [dbo].[PREPARATEUR] ([numPreparateur], [login], [mdp], [codeZone]) VALUES (3, N'prep_dph', N'passprep3', 3)
GO
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (1, N'Crème dessert Danette', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (2, N'Café Nespresso', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (3, N'Lessive OMO', 3)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (4, N'Savon de Marseille', 3)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (5, N'Nutella', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (6, N'Riz Uncle Ben''s', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (7, N'Eau minérale Evian', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (8, N'Dentifrice Colgate', 3)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (9, N'Huile d''olive Puget', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (10, N'Thé Lipton', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (11, N'Farine Francine', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (12, N'Chocolat Lindt', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (13, N'Jus de pomme Andros', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (14, N'Sirop d''érable Maple Joe', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (15, N'Gnocchis à poêler Lustucru', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (16, N'Vinaigre balsamique', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (17, N'Pâte feuilletée Croustipate', 1)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (18, N'Champagne Moët & Chandon', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (19, N'Lait demi-écrémé Candia', 2)
INSERT [dbo].[PRODUIT] ([numProduit], [libelleProduit], [codeZone]) VALUES (20, N'Petits pois Cassegrain', 1)
GO
INSERT [dbo].[RESPONSABLE] ([numResponsable], [login], [mdp]) VALUES (1, N'resp_paris', N'password1')
INSERT [dbo].[RESPONSABLE] ([numResponsable], [login], [mdp]) VALUES (2, N'resp_lyon', N'password2')
INSERT [dbo].[RESPONSABLE] ([numResponsable], [login], [mdp]) VALUES (3, N'resp_marseille', N'password3')
INSERT [dbo].[RESPONSABLE] ([numResponsable], [login], [mdp]) VALUES (4, N'LangBapt', N'admin123')
GO
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (1, 1, 1, 1, 1)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (2, 1, 1, 2, 1)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (3, 2, 2, 2, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (4, 3, 3, 1, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (5, 4, 2, 1, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (6, 4, 2, 2, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (7, 4, 2, 3, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (8, 5, 2, 1, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (9, 5, 2, 2, 0)
INSERT [dbo].[SOUS_COMMANDE] ([numSousComm], [numCommande], [numMagasin], [idPreparateur], [etat]) VALUES (10, 5, 2, 3, 0)
GO
INSERT [dbo].[ZONE] ([codeZone], [libelleZone]) VALUES (1, N'Sec')
INSERT [dbo].[ZONE] ([codeZone], [libelleZone]) VALUES (2, N'Liquide')
INSERT [dbo].[ZONE] ([codeZone], [libelleZone]) VALUES (3, N'DPH')
GO
ALTER TABLE [dbo].[CARISTE]  WITH CHECK ADD FOREIGN KEY([codeZone])
REFERENCES [dbo].[ZONE] ([codeZone])
GO
ALTER TABLE [dbo].[COMMANDE]  WITH CHECK ADD FOREIGN KEY([numMagasin])
REFERENCES [dbo].[MAGASIN] ([numMagasin])
GO
ALTER TABLE [dbo].[COMPOSER]  WITH CHECK ADD FOREIGN KEY([numProduit])
REFERENCES [dbo].[PRODUIT] ([numProduit])
GO
ALTER TABLE [dbo].[COMPOSER]  WITH CHECK ADD FOREIGN KEY([numSousComm])
REFERENCES [dbo].[SOUS_COMMANDE] ([numSousComm])
GO
ALTER TABLE [dbo].[PALETTE]  WITH CHECK ADD  CONSTRAINT [FK_Palette_Produit] FOREIGN KEY([numProduit])
REFERENCES [dbo].[PRODUIT] ([numProduit])
GO
ALTER TABLE [dbo].[PALETTE] CHECK CONSTRAINT [FK_Palette_Produit]
GO
ALTER TABLE [dbo].[PREPARATEUR]  WITH CHECK ADD FOREIGN KEY([codeZone])
REFERENCES [dbo].[ZONE] ([codeZone])
GO
ALTER TABLE [dbo].[PRODUIT]  WITH CHECK ADD FOREIGN KEY([codeZone])
REFERENCES [dbo].[ZONE] ([codeZone])
GO
ALTER TABLE [dbo].[SOUS_COMMANDE]  WITH CHECK ADD FOREIGN KEY([numCommande])
REFERENCES [dbo].[COMMANDE] ([numCommande])
GO
ALTER TABLE [dbo].[SOUS_COMMANDE]  WITH CHECK ADD FOREIGN KEY([numMagasin])
REFERENCES [dbo].[MAGASIN] ([numMagasin])
GO
ALTER TABLE [dbo].[SOUS_COMMANDE]  WITH CHECK ADD  CONSTRAINT [FK_SousCommandes_Preparateurs] FOREIGN KEY([idPreparateur])
REFERENCES [dbo].[PREPARATEUR] ([numPreparateur])
GO
ALTER TABLE [dbo].[SOUS_COMMANDE] CHECK CONSTRAINT [FK_SousCommandes_Preparateurs]
GO
/****** Object:  StoredProcedure [dbo].[prc_add_commande]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_add_commande](@numCommande int, @nomMag nvarchar(50), @dateComm date)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @idMag INT
	SELECT @idMag = numMagasin FROM MAGASIN WHERE nomMagasin = @nomMag

	INSERT INTO COMMANDE VALUES(@numCommande, @idMag, @dateComm, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[prc_add_composer]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_add_composer](@numSousComm int, @nomProduit nvarchar(255), @qtLot int)
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @numProduit INT
	SELECT @numProduit = numProduit FROM PRODUIT WHERE libelleProduit = @nomProduit

    -- Insert statements for procedure here
	INSERT INTO COMPOSER VALUES(@numSousComm, @numProduit, @qtLot)
END
GO
/****** Object:  StoredProcedure [dbo].[prc_add_sous_commande]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_add_sous_commande](@idSousComm int, @idComm int, @nomMag nvarchar(50), @nomPrep nvarchar(50))
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE @idMag INT
	DECLARE @idPrep INT

	SELECT @idMag = numMagasin FROM MAGASIN WHERE nomMagasin = @nomMag
	SELECT @idPrep = numPreparateur FROM PREPARATEUR WHERE login = @nomPrep

	INSERT INTO SOUS_COMMANDE VALUES(@idSousComm, @idComm, @idMag, @idPrep, 0)
END
GO
/****** Object:  StoredProcedure [dbo].[prc_add_user]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_add_user]

	@login NVARCHAR(50),
	@mdp NVARCHAR(50),
	@role NVARCHAR(50),
	@zone VARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Incrémentation de l'id selon le rôle
	DECLARE @id INT
	IF(@role = 'RESPONSABLE')
	BEGIN
		SET @id = (SELECT COUNT(*) FROM RESPONSABLE) + 1
	END

	ELSE IF(@role = 'CARISTE')
	BEGIN
		SET @id = (SELECT COUNT(*) FROM CARISTE) + 1
	END

	ELSE
	BEGIN
		SET @id = (SELECT COUNT(*) FROM PREPARATEUR) + 1
	END

	DECLARE @numZone INT
	SELECT @numZone = codeZone FROM ZONE WHERE libelleZone = @zone

	-- Ajout de l'utilisateur
	IF(@role = 'RESPONSABLE')
	BEGIN
		INSERT INTO RESPONSABLE VALUES(@id, @login, @mdp)
	END

	ELSE IF(@role = 'CARISTE')
	BEGIN
		INSERT INTO CARISTE VALUES(@id, @login, @mdp, @numZone)
	END

	ELSE
	BEGIN
		INSERT INTO PREPARATEUR VALUES(@id, @login, @mdp, @numZone)
	END
END
GO
/****** Object:  StoredProcedure [dbo].[prc_find_user]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_find_user]
    @login NVARCHAR(50),
    @mdp NVARCHAR(50) -- MD5 crypté
AS
BEGIN
    SET NOCOUNT ON

    IF EXISTS (
        SELECT numResponsable
        FROM RESPONSABLE
        WHERE login = @login AND mdp = @mdp
    )
    BEGIN
        PRINT 'Utilisateur trouvé : RESPONSABLE';
        SELECT 'RESPONSABLE' AS Role, numResponsable AS UserID, login
        FROM RESPONSABLE
        WHERE login = @login AND mdp = @mdp;
        RETURN;
    END

    IF EXISTS (
        SELECT numPreparateur
        FROM PREPARATEUR
        WHERE login = @login AND mdp = @mdp
    )
    BEGIN
        PRINT 'Utilisateur trouvé : PREPARATEUR';
        SELECT 'PREPARATEUR' AS Role, numPreparateur AS UserID, login
        FROM PREPARATEUR
        WHERE login = @login AND mdp = @mdp;
        RETURN;
    END

    IF EXISTS (
        SELECT numCariste
        FROM CARISTE
        WHERE login = @login AND mdp = @mdp
    )
    BEGIN
        SELECT 'CARISTE' AS Role, numCariste AS UserID, login
        FROM CARISTE
        WHERE login = @login AND mdp = @mdp;
        RETURN;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[prc_get_all_users]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_all_users]
AS
BEGIN
    SET NOCOUNT ON;

    -- Récupérer les utilisateurs responsables
    SELECT 
        numResponsable AS UserID,
        login,
        NULL AS libelleZone,
        'RESPONSABLE' AS Role
    FROM RESPONSABLE

    UNION ALL

    -- Récupérer les utilisateurs préparateurs
    SELECT 
        numPreparateur AS UserID,
        login,
        libelleZone,
        'PREPARATEUR' AS Role
    FROM PREPARATEUR p
	INNER JOIN ZONE z ON p.codeZone = z.codeZone

    UNION ALL

    -- Récupérer les utilisateurs caristes
    SELECT 
        numCariste AS UserID,
        login,
        libelleZone,
        'CARISTE' AS Role
    FROM CARISTE c
	INNER JOIN ZONE z ON c.codeZone = z.codeZone;
END;
GO
/****** Object:  StoredProcedure [dbo].[prc_get_info_commande]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_info_commande]
AS
BEGIN
	SET NOCOUNT ON;

    SELECT numCommande, nomMagasin, etat
	FROM COMMANDE c
	INNER JOIN MAGASIN m ON c.numMagasin = m.numMagasin
END
GO
/****** Object:  StoredProcedure [dbo].[prc_get_magasin]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_magasin]
AS
BEGIN
    -- Récupère tous les magasins avec leur nom et le nombre de commandes associées
    SELECT 
        m.numMagasin, nomMagasin, COUNT(*) as nbCommandes
    FROM 
        MAGASIN m
    INNER JOIN 
        COMMANDE c ON m.numMagasin = c.numMagasin
    GROUP BY 
        nomMagasin, m.numMagasin
END;
GO
/****** Object:  StoredProcedure [dbo].[prc_get_nb_commandes]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_nb_commandes]
AS
BEGIN

	SET NOCOUNT ON;

	SELECT COUNT(*) as nbCommandes FROM COMMANDE

END
GO
/****** Object:  StoredProcedure [dbo].[prc_get_nb_sous_commande]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_get_nb_sous_commande]
AS
BEGIN
	SET NOCOUNT ON;
	SELECT COUNT(*) AS nbSousCommande
	FROM SOUS_COMMANDE
END
GO
/****** Object:  StoredProcedure [dbo].[prc_update_user]    Script Date: 19/12/2024 22:28:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[prc_update_user]
	@id INT,
	@login NVARCHAR(50),
	@role NVARCHAR(50),
    @zone NVARCHAR(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DECLARE @numZone INT
	SELECT @numZone = codeZone FROM ZONE WHERE libelleZone = @zone

	IF(@role ='CARISTE')
	BEGIN
		UPDATE CARISTE SET login = @login, codeZone = @numZone WHERE numCariste = @id
	END

	ELSE IF(@role = 'PREPARATEUR')
	BEGIN
		UPDATE PREPARATEUR SET login = @login, codeZone = @numZone WHERE numPreparateur = @id
	END

	ELSE
	BEGIN
		UPDATE RESPONSABLE SET login = @login WHERE numResponsable = @id
	END
END
GO
USE [master]
GO
ALTER DATABASE [preporder] SET  READ_WRITE 
GO
