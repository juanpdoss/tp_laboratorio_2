USE [master]
GO
/****** Object:  Database [TP4]    Script Date: 23/11/2020 03:56:55 ******/
CREATE DATABASE [TP4]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TP4', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TP4_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TP4_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TP4] SET  MULTI_USER 
GO
ALTER DATABASE [TP4] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TP4] SET QUERY_STORE = OFF
GO
USE [TP4]
GO
/****** Object:  Table [dbo].[armasBlancas]    Script Date: 23/11/2020 03:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[armasBlancas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[material] [nvarchar](50) NOT NULL,
	[longitud] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[armasDeFuego]    Script Date: 23/11/2020 03:56:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[armasDeFuego](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
	[precio] [float] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[capacidadCargador] [int] NOT NULL,
	[calibre] [float] NOT NULL,
 CONSTRAINT [PK_armasDeFuego] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[armasBlancas] ON 

INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (1, N'hoja ancha y curva', 44000, N'alfanje', N'acero', 110)
INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (2, N'hoja larga y aguda', 17000, N'estilete', N'hierro', 25)
INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (3, N'circular y arrojadiza', 30000, N'chakram', N'acero', 26.5)
INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (6, N'herramienta japonesa', 10000, N'kunai', N'acero', 25)
INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (8, N'espada de gran peso', 37000, N'mandoble', N'hierro', 70.3)
INSERT [dbo].[armasBlancas] ([id], [descripcion], [precio], [nombre], [material], [longitud]) VALUES (1002, N'samurai', 100000, N'katana', N'acero', 65)
SET IDENTITY_INSERT [dbo].[armasBlancas] OFF
GO
SET IDENTITY_INSERT [dbo].[armasDeFuego] ON 

INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (2, N'fusil sovietico', 25000, N'ak47', 39, 7.62)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (3, N'fusil de asalto', 30000, N'm16', 30, 5.56)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (4, N'fusil de francotirador', 70000, N'AWP', 10, 7.62)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (5, N'revolver de percusion', 40000, N'LeMat', 9, 10.6)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (6, N'fusil de cerrojo', 29999, N'Mauser 1909', 5, 7.65)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (7, N'fusil de combate', 25000, N'FN FAL', 30, 7.62)
INSERT [dbo].[armasDeFuego] ([id], [descripcion], [precio], [nombre], [capacidadCargador], [calibre]) VALUES (1005, N'fusil automatico', 233333, N'famas', 30, 6)
SET IDENTITY_INSERT [dbo].[armasDeFuego] OFF
GO
USE [master]
GO
ALTER DATABASE [TP4] SET  READ_WRITE 
GO
