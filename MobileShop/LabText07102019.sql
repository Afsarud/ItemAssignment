USE [MobileShop]
GO
/****** Object:  Table [dbo].[Mobile]    Script Date: 10/7/2019 6:05:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mobile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[IMEI] [varchar](15) NULL,
	[Price] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Mobile] ON 

INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (9, N'Afsar', N'1234', 200)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (10, N'Afsar', N'1234', 200)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (11, N'Imran', N'3452', 300)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (12, N'Imran', N'3452', 300)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (13, N'Amir', N'23', 200)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (14, N'Amir', N'23', 200)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (15, N'Rony', N'1234567', 500)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (16, N'Rony', N'1234567', 500)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (17, N'Mansur', N'12345685', 400)
INSERT [dbo].[Mobile] ([Id], [Name], [IMEI], [Price]) VALUES (18, N'Sukomer', N'239', 300)
SET IDENTITY_INSERT [dbo].[Mobile] OFF
