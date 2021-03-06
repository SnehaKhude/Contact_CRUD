USE [ContactInfo]
GO
/****** Object:  Table [dbo].[ContactDetails]    Script Date: 07/07/2018 22:20:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ContactDetails](
	[ContactId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Email] [varchar](100) NULL,
	[PhoneNumber] [varchar](10) NULL,
	[Status] [bit] NULL,
 CONSTRAINT [PK_ContactDetails] PRIMARY KEY CLUSTERED 
(
	[ContactId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[ContactDetails] ON
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (1, N'Snehal2', N'Khude', N'sneha.khude4@gmail.com', N'8087621781', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (2, N'Rahul', N'Verma', N'rahul.verma@gmail.com', N'7767898029', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (6, N'Sumit', N'Jadhav', N'sumit.jadhav@gmail.com', N'9975245703', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (7, N'gokulaa', N'Jadhav', N'ABHIJIT.KHUDE4@GMAIL.COM', N'8087621781', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (8, N'gokul', N'Jadhav', N'ABHIJIT.KHUDE4@GMAIL.COM', N'8087621781', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (9, N'Sumit', N'Jadhav', N'ABHIJIT.KHUDE4@GMAIL.COM', N'8087621781', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (10, N'test', N'test', N'test', N'test', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (11, N'test', N'Jadhav', N'ABHIJIT.KHUDE4@GMAIL.COM', N'8087621781', 1)
INSERT [dbo].[ContactDetails] ([ContactId], [FirstName], [LastName], [Email], [PhoneNumber], [Status]) VALUES (12, N'gokul', N'Khude', N'ABHIJIT.KHUDE4@GMAIL.COM', N'8087621781', 1)
SET IDENTITY_INSERT [dbo].[ContactDetails] OFF
