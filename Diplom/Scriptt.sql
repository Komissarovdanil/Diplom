﻿USE [master]
GO
/****** Object:  Database [Dip]    Script Date: 30.04.2021 9:57:03 ******/
CREATE DATABASE [Dip]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Dip', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Dip.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Dip_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\Dip_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Dip] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Dip].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Dip] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Dip] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Dip] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Dip] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Dip] SET ARITHABORT OFF 
GO
ALTER DATABASE [Dip] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Dip] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Dip] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Dip] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Dip] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Dip] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Dip] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Dip] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Dip] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Dip] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Dip] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Dip] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Dip] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Dip] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Dip] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Dip] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Dip] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Dip] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Dip] SET  MULTI_USER 
GO
ALTER DATABASE [Dip] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Dip] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Dip] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Dip] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Dip] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Dip] SET QUERY_STORE = OFF
GO
USE [Dip]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Dip]
GO
/****** Object:  User [WSR-02\пользователь WSR2018]    Script Date: 30.04.2021 9:57:03 ******/
CREATE USER [WSR-02\пользователь WSR2018] FOR LOGIN [WSR-02\пользователь WSR2018] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [WSR-02\Olimp]    Script Date: 30.04.2021 9:57:03 ******/
CREATE USER [WSR-02\Olimp] FOR LOGIN [WSR-02\Olimp] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [KPC\инет]    Script Date: 30.04.2021 9:57:03 ******/
CREATE USER [KPC\инет] FOR LOGIN [KPC\инет] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [KPC\3-1p9]    Script Date: 30.04.2021 9:57:03 ******/
CREATE USER [KPC\3-1p9] FOR LOGIN [KPC\3-1p9] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30.04.2021 9:57:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[login] [nvarchar](50) NOT NULL,
	[pass] [nvarchar](50) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [Dip] SET  READ_WRITE 
GO
