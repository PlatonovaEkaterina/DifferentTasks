USE [master]
GO

/****** Object:  Database [OtdelKadrov]    Script Date: 02.10.2022 3:50:34 ******/
CREATE DATABASE [OtdelKadrov]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtdelKadrov', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtdelKadrov.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtdelKadrov_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\OtdelKadrov_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtdelKadrov].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [OtdelKadrov] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [OtdelKadrov] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [OtdelKadrov] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [OtdelKadrov] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [OtdelKadrov] SET ARITHABORT OFF 
GO

ALTER DATABASE [OtdelKadrov] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [OtdelKadrov] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [OtdelKadrov] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [OtdelKadrov] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [OtdelKadrov] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [OtdelKadrov] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [OtdelKadrov] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [OtdelKadrov] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [OtdelKadrov] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [OtdelKadrov] SET  DISABLE_BROKER 
GO

ALTER DATABASE [OtdelKadrov] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [OtdelKadrov] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [OtdelKadrov] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [OtdelKadrov] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [OtdelKadrov] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [OtdelKadrov] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [OtdelKadrov] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [OtdelKadrov] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [OtdelKadrov] SET  MULTI_USER 
GO

ALTER DATABASE [OtdelKadrov] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [OtdelKadrov] SET DB_CHAINING OFF 
GO

ALTER DATABASE [OtdelKadrov] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [OtdelKadrov] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [OtdelKadrov] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [OtdelKadrov] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [OtdelKadrov] SET QUERY_STORE = OFF
GO

ALTER DATABASE [OtdelKadrov] SET  READ_WRITE 
GO
