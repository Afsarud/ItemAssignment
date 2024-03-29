USE [CoffeeShopAssignmentUI]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 10/5/2019 8:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](200) NULL,
	[Contact] [varchar](50) NULL,
	[District] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Items]    Script Date: 10/5/2019 8:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Items](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Price] [float] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 10/5/2019 8:11:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NULL,
	[ItemId] [int] NULL,
	[Quantity] [int] NULL,
	[TotalPrice] [float] NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (1, N'Ali', N'Dhaka', N'01311369369', N'Dhaka')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (2, N'Hasan', N'Sylhet', N'01711369369', N'Shariatpur')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (3, N'Rafi', N'BNorisal', N'01811369369', N'Chadpur')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (35, N'Afsar', N'MdPur', N'12345634567', N'Shariatpur')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (36, N'Atiquer', N'Sampur', N'01826373764', N'Chadpur')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (37, N'Sumon', N'Rangpur', N'12548796548', N'Dhaka')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (38, N'sdfs', N'fsfsf', N'23223232323', N'Dhaka')
INSERT [dbo].[Customers] ([Id], [Name], [Address], [Contact], [District]) VALUES (39, N'sfddsf', N'', N'12345678987', N'Dhaka')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (1, N'Black', 120)
INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (2, N'Regular', 80)
INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (3, N'Cold', 100)
INSERT [dbo].[Items] ([ID], [Name], [Price]) VALUES (4, N'Hot', 90)
SET IDENTITY_INSERT [dbo].[Items] OFF
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([Id], [CustomerId], [ItemId], [Quantity], [TotalPrice]) VALUES (1, 1, 1, 5, 600)
INSERT [dbo].[Orders] ([Id], [CustomerId], [ItemId], [Quantity], [TotalPrice]) VALUES (2, 1, 2, 3, 240)
INSERT [dbo].[Orders] ([Id], [CustomerId], [ItemId], [Quantity], [TotalPrice]) VALUES (3, 1, 3, 2, 200)
SET IDENTITY_INSERT [dbo].[Orders] OFF
