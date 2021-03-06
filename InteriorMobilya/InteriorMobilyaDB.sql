USE [master]
GO
/****** Object:  Database [InteriorMobilyaDB]    Script Date: 1.8.2017 19:56:29 ******/
CREATE DATABASE [InteriorMobilyaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InteriorMobilyaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\InteriorMobilyaDB.mdf' , SIZE = 4160KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'InteriorMobilyaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\InteriorMobilyaDB_log.ldf' , SIZE = 1040KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [InteriorMobilyaDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [InteriorMobilyaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [InteriorMobilyaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [InteriorMobilyaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [InteriorMobilyaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [InteriorMobilyaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [InteriorMobilyaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [InteriorMobilyaDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [InteriorMobilyaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET RECOVERY FULL 
GO
ALTER DATABASE [InteriorMobilyaDB] SET  MULTI_USER 
GO
ALTER DATABASE [InteriorMobilyaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [InteriorMobilyaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [InteriorMobilyaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [InteriorMobilyaDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [InteriorMobilyaDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 1.8.2017 19:56:29 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [uniqueidentifier] NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [uniqueidentifier] NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [uniqueidentifier] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[UserName] [nvarchar](256) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [uniqueidentifier] NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Categories]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cities]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cities](
	[CityID] [int] IDENTITY(1,1) NOT NULL,
	[CityName] [nvarchar](max) NULL,
	[CountryID] [int] NOT NULL,
 CONSTRAINT [PK_Cities] PRIMARY KEY CLUSTERED 
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Countries]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Countries](
	[CountryID] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED 
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CustomerAdresses]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerAdresses](
	[CustomerAdressID] [int] IDENTITY(1,1) NOT NULL,
	[AdressDescription] [nvarchar](max) NULL,
	[AdressTitle] [nvarchar](max) NULL,
	[CityID] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
 CONSTRAINT [PK_CustomerAdresses] PRIMARY KEY CLUSTERED 
(
	[CustomerAdressID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Customers]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[BirthDate] [datetime2](7) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[FirstName] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Gender] [bit] NULL,
	[UserID] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[OrderID] [int] NOT NULL,
	[ProductID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Orders]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] IDENTITY(1,1) NOT NULL,
	[OrderDate] [datetime2](7) NOT NULL,
	[OrderStatusID] [int] NOT NULL,
	[PaymentTypeID] [int] NOT NULL,
	[RequiredDate] [datetime2](7) NOT NULL,
	[ShippedDate] [datetime2](7) NOT NULL,
	[CustomerAdressID] [int] NULL,
	[CustomerID] [int] NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OrderStatus]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderStatus](
	[OrderStatusID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Status] [nvarchar](max) NULL,
 CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED 
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PaymentTypes]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentTypes](
	[PaymentTypeID] [int] IDENTITY(1,1) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[Type] [nvarchar](max) NULL,
 CONSTRAINT [PK_PaymentTypes] PRIMARY KEY CLUSTERED 
(
	[PaymentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Products]    Script Date: 1.8.2017 19:56:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[ImagePath] [nvarchar](max) NULL,
	[IsActive] [bit] NOT NULL,
	[ProductDescription] [nvarchar](max) NULL,
	[ProductName] [nvarchar](max) NULL,
	[UnitPrice] [decimal](18, 2) NOT NULL,
	[UnitsInStock] [smallint] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170731103451_FMigration', N'1.1.2')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170731103536_FMigration', N'1.1.2')
INSERT [dbo].[AspNetRoles] ([Id], [ConcurrencyStamp], [Name], [NormalizedName]) VALUES (N'b616cc7a-97d3-4c2f-db1a-08d4d801cce9', N'2f96601d-4e49-4ec4-aa16-f85f7cbeb64f', N'User', N'USER')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'da829efd-3cab-4b14-373d-08d4d801ccce', N'b616cc7a-97d3-4c2f-db1a-08d4d801cce9')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c04ccec1-346d-4711-6999-08d4d8f04583', N'b616cc7a-97d3-4c2f-db1a-08d4d801cce9')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'da829efd-3cab-4b14-373d-08d4d801ccce', 0, N'93fdaaa3-da1a-4ddb-9766-c5e7c306fe19', N'x@x.com', 0, 1, NULL, N'X@X.COM', N'KEREMX', N'AQAAAAEAACcQAAAAELebcAHq5OH7cI4YnvFYX5KbWqKpAewBGlu5/JchcAL68vekMcmRvaZCQixQxrafWw==', NULL, 0, N'949f8720-d3ae-46fe-a3f7-5ad1f652eb76', 0, N'keremx')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'c04ccec1-346d-4711-6999-08d4d8f04583', 0, N'0688c640-af27-4fc4-acfb-2a4777a5d100', N'a@a.com', 0, 1, NULL, N'A@A.COM', N'KEREM', N'AQAAAAEAACcQAAAAECfHJNlcGh3/FNVZWF4qysSfwxn5Mlm84saAd3KUnWLlLJFo+mC+OVWG2sPzqJh51A==', NULL, 0, N'dda148a6-ef7b-4de6-bcf1-f1a11ebaf17c', 0, N'kerem')
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (1, N'Koltuk Takımları', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (2, N'Abajurlar', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (4, N'Dekoratif Işıklar', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (6, N'Ofis Sandalyeleri', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (8, N'Avizeler', 1)
INSERT [dbo].[Categories] ([CategoryID], [CategoryName], [IsActive]) VALUES (9, N'Ev Dekor Ürünleri', 1)
SET IDENTITY_INSERT [dbo].[Categories] OFF
SET IDENTITY_INSERT [dbo].[Cities] ON 

INSERT [dbo].[Cities] ([CityID], [CityName], [CountryID]) VALUES (1, N'İstanbul', 1)
INSERT [dbo].[Cities] ([CityID], [CityName], [CountryID]) VALUES (2, N'Ankara', 1)
INSERT [dbo].[Cities] ([CityID], [CityName], [CountryID]) VALUES (3, N'New york', 2)
INSERT [dbo].[Cities] ([CityID], [CityName], [CountryID]) VALUES (4, N'Berlin', 3)
INSERT [dbo].[Cities] ([CityID], [CityName], [CountryID]) VALUES (5, N'Köln', 3)
SET IDENTITY_INSERT [dbo].[Cities] OFF
SET IDENTITY_INSERT [dbo].[Countries] ON 

INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (1, N'Türkiye')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (2, N'Amerika')
INSERT [dbo].[Countries] ([CountryID], [CountryName]) VALUES (3, N'Almanya')
SET IDENTITY_INSERT [dbo].[Countries] OFF
SET IDENTITY_INSERT [dbo].[CustomerAdresses] ON 

INSERT [dbo].[CustomerAdresses] ([CustomerAdressID], [AdressDescription], [AdressTitle], [CityID], [CreatedDate], [CustomerID], [IsActive], [Name], [Phone]) VALUES (3, N'Tuzla İstanbul / Türkiye', N'Ev adresim', 1, CAST(0x070000000000000000 AS DateTime2), 3, 1, N'Kerem ÖZER', N'55555')
INSERT [dbo].[CustomerAdresses] ([CustomerAdressID], [AdressDescription], [AdressTitle], [CityID], [CreatedDate], [CustomerID], [IsActive], [Name], [Phone]) VALUES (5, N'AnKara / İstanbul', N'Ev Adresim2', 2, CAST(0x07CE882BFB711D3D0B AS DateTime2), 3, 1, N'Kerem ÖZER', N'55555')
INSERT [dbo].[CustomerAdresses] ([CustomerAdressID], [AdressDescription], [AdressTitle], [CityID], [CreatedDate], [CustomerID], [IsActive], [Name], [Phone]) VALUES (6, N'Amerika', N'Ev Adresim', 3, CAST(0x07AE2FE4469E1D3D0B AS DateTime2), 4, 1, N'Kerem ÖZER', N'555555')
SET IDENTITY_INSERT [dbo].[CustomerAdresses] OFF
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerID], [BirthDate], [CreatedDate], [FirstName], [IsActive], [LastName], [Phone], [Gender], [UserID]) VALUES (3, CAST(0x0700000000005F320B AS DateTime2), NULL, N'Kerem', 0, N'Özer', NULL, 0, N'da829efd-3cab-4b14-373d-08d4d801ccce')
INSERT [dbo].[Customers] ([CustomerID], [BirthDate], [CreatedDate], [FirstName], [IsActive], [LastName], [Phone], [Gender], [UserID]) VALUES (4, CAST(0x070000000000000000 AS DateTime2), NULL, N'Kerem 2', 0, NULL, NULL, NULL, N'c04ccec1-346d-4711-6999-08d4d8f04583')
SET IDENTITY_INSERT [dbo].[Customers] OFF
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 1, 2, CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (1, 2, 1, CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (2, 2, 1, CAST(750.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (3, 1, 1, CAST(550.00 AS Decimal(18, 2)))
INSERT [dbo].[OrderDetails] ([OrderID], [ProductID], [Quantity], [UnitPrice]) VALUES (4, 2, 2, CAST(150.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([OrderID], [OrderDate], [OrderStatusID], [PaymentTypeID], [RequiredDate], [ShippedDate], [CustomerAdressID], [CustomerID]) VALUES (1, CAST(0x07A1903F3D781D3D0B AS DateTime2), 1, 1, CAST(0x0760B83F3D781F3D0B AS DateTime2), CAST(0x07A1903F3D781F3D0B AS DateTime2), 3, 3)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [OrderStatusID], [PaymentTypeID], [RequiredDate], [ShippedDate], [CustomerAdressID], [CustomerID]) VALUES (2, CAST(0x073499B87F7B1D3D0B AS DateTime2), 1, 1, CAST(0x073499B87F7B1F3D0B AS DateTime2), CAST(0x073499B87F7B1F3D0B AS DateTime2), 5, 3)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [OrderStatusID], [PaymentTypeID], [RequiredDate], [ShippedDate], [CustomerAdressID], [CustomerID]) VALUES (3, CAST(0x0734C0D9499E1D3D0B AS DateTime2), 1, 1, CAST(0x0734C0D9499E1F3D0B AS DateTime2), CAST(0x0734C0D9499E1F3D0B AS DateTime2), 6, 4)
INSERT [dbo].[Orders] ([OrderID], [OrderDate], [OrderStatusID], [PaymentTypeID], [RequiredDate], [ShippedDate], [CustomerAdressID], [CustomerID]) VALUES (4, CAST(0x075165DEB79E1D3D0B AS DateTime2), 1, 1, CAST(0x075165DEB79E1F3D0B AS DateTime2), CAST(0x075165DEB79E1F3D0B AS DateTime2), 6, 4)
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[OrderStatus] ON 

INSERT [dbo].[OrderStatus] ([OrderStatusID], [IsActive], [Status]) VALUES (1, 1, N'Sipariş Onaylandı')
SET IDENTITY_INSERT [dbo].[OrderStatus] OFF
SET IDENTITY_INSERT [dbo].[PaymentTypes] ON 

INSERT [dbo].[PaymentTypes] ([PaymentTypeID], [IsActive], [Type]) VALUES (1, 1, N'Kapıda Ödeme')
SET IDENTITY_INSERT [dbo].[PaymentTypes] OFF
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (1, 1, N'/images/koltuktakimi1.jpg', 1, N'Koltuk Takımı', N'X Koltuk Takımı', CAST(550.00 AS Decimal(18, 2)), 55)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (2, 2, N'/images/abajur2.jpg', 1, N'SELİFTON KONİK ABAJUR KREM', N'SELİFTON KONİK ABAJUR KREM', CAST(150.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (3, 4, N'/images/dekorisik1.jpg', 1, N'DOUBLESHADE CEVİZ SALON', N'DOUBLESHADE CEVİZ SALON', CAST(499.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (4, 2, N'/images/abajur1.jpg', 1, N' ABAJUR BEJ ŞAPKALI KROM', N' ABAJUR BEJ ŞAPKALI KROM', CAST(30.00 AS Decimal(18, 2)), 3)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (5, 4, N'/images/dekorisik2.jpg', 1, N'5Lİ DOĞA BEYAZ AVİZE', N'5Lİ DOĞA BEYAZ AVİZE', CAST(1500.00 AS Decimal(18, 2)), 55)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (6, 6, N'/images/ofis1.jpg', 1, N'İNCA BEKLEME KOLTUĞU KAHVE', N'İNCA BEKLEME KOLTUĞU KAHVE', CAST(225.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (7, 1, N'/images/koltuktakimi2.jpg', 1, N'Koltuk Takımı ', N'Y Koltuk Takımı', CAST(133.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (8, 1, N'/images/koltuktakimi3.jpg', 1, N'Koltuk Takımı ', N'Z Koltuk Takımı', CAST(2500.00 AS Decimal(18, 2)), 30)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (11, 2, N'/images/abajur3.jpg', 1, N'CASABLANCA ABAJUR', N'CASABLANCA ABAJUR', CAST(249.00 AS Decimal(18, 2)), 2)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (12, 8, N'/images/avize1.jpg', 1, N'MELEKA AVİZE KAHVE ÜÇLÜ', N'MELEKA AVİZE KAHVE ÜÇLÜ', CAST(300.00 AS Decimal(18, 2)), 5)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (13, 8, N'/images/avize2.jpg', 1, N'ROMA 3LÜ DEKORATİF SARKIT AVİZE RUSTİK', N'ROMA 3LÜ DEKORATİF SARKIT AVİZE RUSTİK', CAST(150.00 AS Decimal(18, 2)), 10)
INSERT [dbo].[Products] ([ProductID], [CategoryID], [ImagePath], [IsActive], [ProductDescription], [ProductName], [UnitPrice], [UnitsInStock]) VALUES (14, 8, N'/images/avize2.jpg', 1, N'SENA ESKİTME MODERN AVİZE 3LÜ', N'SENA ESKİTME MODERN AVİZE 3LÜ', CAST(225.00 AS Decimal(18, 2)), 5)
SET IDENTITY_INSERT [dbo].[Products] OFF
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [RoleNameIndex]    Script Date: 1.8.2017 19:56:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [EmailIndex]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UserNameIndex]    Script Date: 1.8.2017 19:56:29 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Cities_CountryID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_Cities_CountryID] ON [dbo].[Cities]
(
	[CountryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerAdresses_CityID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerAdresses_CityID] ON [dbo].[CustomerAdresses]
(
	[CityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_CustomerAdresses_CustomerID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_CustomerAdresses_CustomerID] ON [dbo].[CustomerAdresses]
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDetails_ProductID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDetails_ProductID] ON [dbo].[OrderDetails]
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_OrderStatusID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_OrderStatusID] ON [dbo].[Orders]
(
	[OrderStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Orders_PaymentTypeID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_Orders_PaymentTypeID] ON [dbo].[Orders]
(
	[PaymentTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Products_CategoryID]    Script Date: 1.8.2017 19:56:29 ******/
CREATE NONCLUSTERED INDEX [IX_Products_CategoryID] ON [dbo].[Products]
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Cities]  WITH CHECK ADD  CONSTRAINT [FK_Cities_Countries_CountryID] FOREIGN KEY([CountryID])
REFERENCES [dbo].[Countries] ([CountryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cities] CHECK CONSTRAINT [FK_Cities_Countries_CountryID]
GO
ALTER TABLE [dbo].[CustomerAdresses]  WITH CHECK ADD  CONSTRAINT [FK_CustomerAdresses_Cities_CityID] FOREIGN KEY([CityID])
REFERENCES [dbo].[Cities] ([CityID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerAdresses] CHECK CONSTRAINT [FK_CustomerAdresses_Cities_CityID]
GO
ALTER TABLE [dbo].[CustomerAdresses]  WITH CHECK ADD  CONSTRAINT [FK_CustomerAdresses_Customers_CustomerID] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CustomerAdresses] CHECK CONSTRAINT [FK_CustomerAdresses_Customers_CustomerID]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Orders_OrderID] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Orders_OrderID]
GO
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products_ProductID] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products_ProductID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_CustomerAdresses] FOREIGN KEY([CustomerAdressID])
REFERENCES [dbo].[CustomerAdresses] ([CustomerAdressID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_CustomerAdresses]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_Customers] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_OrderStatus_OrderStatusID] FOREIGN KEY([OrderStatusID])
REFERENCES [dbo].[OrderStatus] ([OrderStatusID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_OrderStatus_OrderStatusID]
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD  CONSTRAINT [FK_Orders_PaymentTypes_PaymentTypeID] FOREIGN KEY([PaymentTypeID])
REFERENCES [dbo].[PaymentTypes] ([PaymentTypeID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_PaymentTypes_PaymentTypeID]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Categories_CategoryID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Categories_CategoryID]
GO
USE [master]
GO
ALTER DATABASE [InteriorMobilyaDB] SET  READ_WRITE 
GO
