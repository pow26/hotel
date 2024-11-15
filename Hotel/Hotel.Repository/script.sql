USE [master]
GO
/****** Object:  Database [Hotel]    Script Date: 11/9/2024 2:00:46 PM ******/
CREATE DATABASE [Hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Hotel] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotel] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotel] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotel] SET  MULTI_USER 
GO
ALTER DATABASE [Hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotel', N'ON'
GO
ALTER DATABASE [Hotel] SET QUERY_STORE = ON
GO
ALTER DATABASE [Hotel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Hotel]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingId] [int] IDENTITY(1,1) NOT NULL,
	[RoomId] [int] NULL,
	[CheckIn] [datetime] NULL,
	[CheckOut] [datetime] NULL,
	[TotalPrice] [decimal](18, 2) NULL,
	[UserId] [int] NULL,
	[Taxes] [decimal](18, 2) NULL,
	[Fee] [decimal](18, 2) NULL,
	[Adults] [tinyint] NULL,
	[Infants] [tinyint] NULL,
	[Children] [tinyint] NULL,
	[PricePerNight] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[HotelId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[LocationId] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[HotelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationId] [int] IDENTITY(1,1) NOT NULL,
	[Region] [nvarchar](50) NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[HotelId] [int] NULL,
	[IsReserved] [bit] NULL,
	[SectionId] [int] NULL,
	[Smoke] [bit] NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Section]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Section](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[PricePerNight] [decimal](18, 2) NULL,
	[RoomType] [nvarchar](50) NULL,
	[MaxAdult] [tinyint] NULL,
	[MaxChildren] [tinyint] NULL,
	[Infants] [tinyint] NULL,
	[Pets] [tinyint] NULL,
 CONSTRAINT [PK_Section] PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/9/2024 2:00:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingId], [RoomId], [CheckIn], [CheckOut], [TotalPrice], [UserId], [Taxes], [Fee], [Adults], [Infants], [Children], [PricePerNight]) VALUES (1, 1, CAST(N'2024-11-11T00:00:00.000' AS DateTime), CAST(N'2024-11-14T00:00:00.000' AS DateTime), CAST(100.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Booking] ([BookingId], [RoomId], [CheckIn], [CheckOut], [TotalPrice], [UserId], [Taxes], [Fee], [Adults], [Infants], [Children], [PricePerNight]) VALUES (2, 1, CAST(N'2024-11-09T05:39:25.097' AS DateTime), CAST(N'2024-11-10T05:39:25.097' AS DateTime), CAST(120.00 AS Decimal(18, 2)), 1, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Booking] ([BookingId], [RoomId], [CheckIn], [CheckOut], [TotalPrice], [UserId], [Taxes], [Fee], [Adults], [Infants], [Children], [PricePerNight]) VALUES (3, 1, CAST(N'2024-11-16T06:30:14.897' AS DateTime), CAST(N'2024-11-17T06:30:14.897' AS DateTime), CAST(111.00 AS Decimal(18, 2)), 2, CAST(11.00 AS Decimal(18, 2)), CAST(21.00 AS Decimal(18, 2)), 2, 2, 1, CAST(100.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[Hotel] ON 

INSERT [dbo].[Hotel] ([HotelId], [Name], [LocationId], [Description]) VALUES (1, N'Entire serviced apartment in South Korea', 1, N'The modern hanok is a combination of traditional and 21st Century Seoul-style houses. Our AirBnB House is located in the centralized location of Seoul.

Address : 90, Baekbeom-ro 90-gil, Yongsan-gu, Seoul, Republic of Korea')
INSERT [dbo].[Hotel] ([HotelId], [Name], [LocationId], [Description]) VALUES (2, N'Entire home in Mallacoota, Australia', 2, N'Enjoy a campfire or watch the moon rise over the lake as you soak in a deep bath on our three acres overlooking the magnificent Mallacoota inlet.

Recharge in the natural world with Roos, Lyrebirds and Eagles & forage in the garden. Our jetty is a great spot to launch the Kayak, catch dinner or just watch the swans and pelicans go about their day.

Wander to town via the picturesque lake boardwalk - it''ll take around 30 minutes. Alternatively, the drive is just five')
INSERT [dbo].[Hotel] ([HotelId], [Name], [LocationId], [Description]) VALUES (3, N'Entire condo in Park City, Utah, United States', 3, N'This perfectly located Ski-in studio is the best option for your next Ski trip! Easy lift access from this condo will give you the benefit of walking right to the lifts in the morning, coming back to cook lunch in between runs, then finishing off the day while soaking in the hot tub or watching the wood fire burn inside.
Our condo is located in such a way that you will be able to experience all that Park City has to offer! Minutes away from Mainstreet and steps away from the lifts.')
SET IDENTITY_INSERT [dbo].[Hotel] OFF
GO
SET IDENTITY_INSERT [dbo].[Location] ON 

INSERT [dbo].[Location] ([LocationId], [Region]) VALUES (1, N'Korea')
INSERT [dbo].[Location] ([LocationId], [Region]) VALUES (2, N'Australia')
INSERT [dbo].[Location] ([LocationId], [Region]) VALUES (3, N'United States')
SET IDENTITY_INSERT [dbo].[Location] OFF
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (1, N'100', 1, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (2, N'200', 1, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (3, N'300', 1, 0, 3, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (4, N'100A', 2, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (5, N'200B', 2, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (6, N'300C', 2, 0, 3, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (7, N'1000', 3, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (8, N'2000', 3, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (9, N'3000', 3, 0, 3, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (10, N'101', 1, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (11, N'201', 1, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (12, N'301', 1, 0, 3, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (13, N'101A', 2, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (14, N'201B', 2, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (15, N'301C', 2, 0, 3, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (16, N'1001', 3, 0, 1, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (17, N'2001', 3, 0, 2, 0)
INSERT [dbo].[Room] ([RoomId], [Name], [HotelId], [IsReserved], [SectionId], [Smoke]) VALUES (18, N'3001', 3, 0, 3, 0)
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
SET IDENTITY_INSERT [dbo].[Section] ON 

INSERT [dbo].[Section] ([SectionId], [Name], [Description], [PricePerNight], [RoomType], [MaxAdult], [MaxChildren], [Infants], [Pets]) VALUES (1, N'Single', NULL, CAST(100.00 AS Decimal(18, 2)), NULL, 1, 2, 1, 1)
INSERT [dbo].[Section] ([SectionId], [Name], [Description], [PricePerNight], [RoomType], [MaxAdult], [MaxChildren], [Infants], [Pets]) VALUES (2, N'Double', NULL, CAST(200.00 AS Decimal(18, 2)), NULL, 2, 2, 2, 2)
INSERT [dbo].[Section] ([SectionId], [Name], [Description], [PricePerNight], [RoomType], [MaxAdult], [MaxChildren], [Infants], [Pets]) VALUES (3, N'Triple', NULL, CAST(300.00 AS Decimal(18, 2)), NULL, 3, 3, 2, 2)
SET IDENTITY_INSERT [dbo].[Section] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserId], [UserName], [Password]) VALUES (1, N'guest1', N'guest1')
INSERT [dbo].[User] ([UserId], [UserName], [Password]) VALUES (2, N'guest2', N'guest2')
INSERT [dbo].[User] ([UserId], [UserName], [Password]) VALUES (3, N'guest3', N'guest3')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Room] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Room] ([RoomId])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Room]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_User]
GO
ALTER TABLE [dbo].[Hotel]  WITH CHECK ADD  CONSTRAINT [FK_Hotel_Location] FOREIGN KEY([LocationId])
REFERENCES [dbo].[Location] ([LocationId])
GO
ALTER TABLE [dbo].[Hotel] CHECK CONSTRAINT [FK_Hotel_Location]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Hotel] FOREIGN KEY([HotelId])
REFERENCES [dbo].[Hotel] ([HotelId])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Hotel]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Section] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Section] ([SectionId])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Section]
GO
USE [master]
GO
ALTER DATABASE [Hotel] SET  READ_WRITE 
GO
