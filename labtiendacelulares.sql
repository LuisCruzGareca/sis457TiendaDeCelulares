USE [master]
GO
/****** Object:  Database [LabTiendaCelulares]    Script Date: 24/06/2024 16:52:20 ******/
CREATE DATABASE [LabTiendaCelulares]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LabTiendaCelulares', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER02\MSSQL\DATA\LabTiendaCelulares.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LabTiendaCelulares_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER02\MSSQL\DATA\LabTiendaCelulares_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [LabTiendaCelulares] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LabTiendaCelulares].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LabTiendaCelulares] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET ARITHABORT OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LabTiendaCelulares] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LabTiendaCelulares] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LabTiendaCelulares] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LabTiendaCelulares] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET RECOVERY FULL 
GO
ALTER DATABASE [LabTiendaCelulares] SET  MULTI_USER 
GO
ALTER DATABASE [LabTiendaCelulares] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LabTiendaCelulares] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LabTiendaCelulares] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LabTiendaCelulares] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LabTiendaCelulares] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LabTiendaCelulares] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LabTiendaCelulares', N'ON'
GO
ALTER DATABASE [LabTiendaCelulares] SET QUERY_STORE = ON
GO
ALTER DATABASE [LabTiendaCelulares] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [LabTiendaCelulares]
GO
/****** Object:  User [tiendacelulares]    Script Date: 24/06/2024 16:52:20 ******/
CREATE USER [tiendacelulares] FOR LOGIN [tiendacelulares] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [tiendacelulares]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categorias]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categorias](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [text] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[celulares]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[celulares](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[fecha_creacion] [datetime2](6) NOT NULL,
	[fecha_modificacion] [datetime2](6) NOT NULL,
	[descripcion] [text] NOT NULL,
	[marca] [varchar](100) NOT NULL,
	[modelo] [varchar](100) NOT NULL,
	[precio] [decimal](10, 2) NOT NULL,
	[idColor] [int] NULL,
	[idCategoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[colores]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[colores](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compras]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compras](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[direccion_envio] [text] NOT NULL,
	[total] [decimal](10, 2) NOT NULL,
	[fecha_venta] [datetime2](6) NOT NULL,
	[id_usuario] [int] NULL,
	[idCelular] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 24/06/2024 16:52:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [varchar](45) NOT NULL,
	[password] [varchar](45) NOT NULL,
	[nombre] [varchar](45) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[celulares] ADD  DEFAULT (sysdatetime()) FOR [fecha_creacion]
GO
ALTER TABLE [dbo].[celulares] ADD  DEFAULT (sysdatetime()) FOR [fecha_modificacion]
GO
ALTER TABLE [dbo].[compras] ADD  DEFAULT (sysdatetime()) FOR [fecha_venta]
GO
ALTER TABLE [dbo].[compras] ADD  DEFAULT (NULL) FOR [id_usuario]
GO
ALTER TABLE [dbo].[celulares]  WITH CHECK ADD  CONSTRAINT [FK_celulares_categorias] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[categorias] ([id])
GO
ALTER TABLE [dbo].[celulares] CHECK CONSTRAINT [FK_celulares_categorias]
GO
ALTER TABLE [dbo].[celulares]  WITH CHECK ADD  CONSTRAINT [FK_celulares_colores] FOREIGN KEY([idColor])
REFERENCES [dbo].[colores] ([id])
GO
ALTER TABLE [dbo].[celulares] CHECK CONSTRAINT [FK_celulares_colores]
GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id])
GO
ALTER TABLE [dbo].[compras]  WITH CHECK ADD  CONSTRAINT [FK_compras_celulares] FOREIGN KEY([idCelular])
REFERENCES [dbo].[celulares] ([id])
GO
ALTER TABLE [dbo].[compras] CHECK CONSTRAINT [FK_compras_celulares]
GO
USE [master]
GO
ALTER DATABASE [LabTiendaCelulares] SET  READ_WRITE 
GO
