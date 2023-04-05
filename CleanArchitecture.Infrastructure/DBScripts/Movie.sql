USE [CleanArchitectureDB]
GO

/****** Object:  Table [dbo].[Movies]    Script Date: 05-04-2023 10:56:22 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Movies]') AND type in (N'U'))
DROP TABLE [dbo].[Movies]
GO

/****** Object:  Table [dbo].[Movies]    Script Date: 05-04-2023 10:56:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movies](
	[MovieId] [int] IDENTITY(1,1) NOT NULL,
	[MovieName] [nvarchar](max) NOT NULL,
	[RentalCost] [decimal](18, 2) NOT NULL,
	[RentalDuration] [int] NOT NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
------------------------------------------------------------------------------
ALTER TABLE [dbo].[Members] DROP CONSTRAINT [FK_Members_Rentals_RentalId]
GO

/****** Object:  Table [dbo].[Members]    Script Date: 05-04-2023 10:58:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Members]') AND type in (N'U'))
DROP TABLE [dbo].[Members]
GO

/****** Object:  Table [dbo].[Members]    Script Date: 05-04-2023 10:58:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Members](
	[MemberId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[RentalId] [int] NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[MemberId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

------------------------------------------------------------------------

ALTER TABLE [dbo].[MovieRentals] DROP CONSTRAINT [FK_MovieRentals_Movies_MovieId]
GO

/****** Object:  Table [dbo].[MovieRentals]    Script Date: 05-04-2023 11:00:33 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MovieRentals]') AND type in (N'U'))
DROP TABLE [dbo].[MovieRentals]
GO

/****** Object:  Table [dbo].[MovieRentals]    Script Date: 05-04-2023 11:00:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MovieRentals](
	[RentalId] [int] NOT NULL,
	[MovieId] [int] NOT NULL,
 CONSTRAINT [PK_MovieRentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC,
	[MovieId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

------------------------------------------------------

/****** Object:  Table [dbo].[Rentals]    Script Date: 05-04-2023 11:01:12 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Rentals]') AND type in (N'U'))
DROP TABLE [dbo].[Rentals]
GO

/****** Object:  Table [dbo].[Rentals]    Script Date: 05-04-2023 11:01:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rentals](
	[RentalId] [int] IDENTITY(1,1) NOT NULL,
	[RentalDate] [datetime2](7) NOT NULL,
	[RentalExpiry] [datetime2](7) NOT NULL,
	[TotalCost] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Rentals] PRIMARY KEY CLUSTERED 
(
	[RentalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

