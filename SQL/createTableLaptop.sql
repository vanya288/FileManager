USE [IS]
GO

/****** Object:  Table [dbo].[Laptop]    Script Date: 11/4/2020 10:02:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Laptop](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Manufacturer] [nchar](30) NULL,
	[ScreenSize] [nchar](10) NULL,
	[Resolution] [nchar](10) NULL,
	[ScreenType] [nchar](10) NULL,
	[Touchscreen] [nchar](5) NULL,
	[Processor] [nchar](30) NULL,
	[CoreCount] [smallint] NULL,
	[ClockSignal] [int] NULL,
	[RAM] [nchar](10) NULL,
	[Capacity] [nchar](20) NULL,
	[DiskType] [nchar](10) NULL,
	[GraphicCard] [nchar](30) NULL,
	[GraphicsCardCapacity] [nchar](20) NULL,
	[OperatingSystem] [nchar](30) NULL,
	[OpticalDiscDrive] [nchar](20) NULL
) ON [PRIMARY]
GO


