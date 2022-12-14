USE [BookBizDBnew]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[authorid] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NULL,
	[author_ID] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AUTHORS] PRIMARY KEY CLUSTERED 
(
	[authorid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book_Author]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book_Author](
	[book_id] [int] NOT NULL,
	[person_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book_Type]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book_Type](
	[book_type_id] [int] IDENTITY(1,1) NOT NULL,
	[book_type_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BOOK_TYPE] PRIMARY KEY CLUSTERED 
(
	[book_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[book_id] [int] IDENTITY(1,1) NOT NULL,
	[book_type_id] [int] NULL,
	[enterprise_id] [int] NULL,
	[ISBN] [varchar](50) NOT NULL,
	[Title] [varchar](100) NULL,
	[UnitPrice] [money] NOT NULL,
	[YearPublished] [datetime] NULL,
	[QOH] [int] NULL,
 CONSTRAINT [PK_BOOKS] PRIMARY KEY CLUSTERED 
(
	[book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enterprise_type]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enterprise_type](
	[enterprise_type_id] [int] IDENTITY(1,1) NOT NULL,
	[enterprise_type_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ENTERPRISE_TYPE] PRIMARY KEY CLUSTERED 
(
	[enterprise_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enterprises]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enterprises](
	[enterprise_id] [int] IDENTITY(1,1) NOT NULL,
	[enterprise_type_id] [int] NOT NULL,
	[name] [varchar](50) NOT NULL,
	[street] [varchar](50) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[zip_code] [varchar](50) NOT NULL,
	[enterprise_email] [varchar](50) NOT NULL,
	[enterprise_phone] [varchar](25) NOT NULL,
	[enterprise_fax] [varchar](25) NOT NULL,
	[credit_limit] [money] NULL,
	[state] [varchar](5) NULL,
 CONSTRAINT [PK_ENTERPRISES] PRIMARY KEY CLUSTERED 
(
	[enterprise_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_book]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_book](
	[order_book_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NOT NULL,
	[book_id] [int] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_ORDER_BOOK] PRIMARY KEY CLUSTERED 
(
	[order_book_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_table]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_table](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NOT NULL,
	[enterprise_id] [int] NOT NULL,
	[order_type_id] [int] NOT NULL,
	[totalprice] [money] NOT NULL,
	[order_time] [datetime] NOT NULL,
	[order_serial_number] [varchar](50) NOT NULL,
	[state_order] [int] NULL,
 CONSTRAINT [PK_ORDER_TABLE] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_type]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_type](
	[order_type_id] [int] IDENTITY(1,1) NOT NULL,
	[order_type_name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ORDER_TYPE] PRIMARY KEY CLUSTERED 
(
	[order_type_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[person_id] [int] IDENTITY(1,1) NOT NULL,
	[roleid] [int] NULL,
	[first_name] [varchar](50) NOT NULL,
	[last_name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[phonenb] [varchar](50) NOT NULL,
	[state] [varchar](5) NULL,
 CONSTRAINT [PK_PERSONS] PRIMARY KEY CLUSTERED 
(
	[person_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[roleid] [int] IDENTITY(1,1) NOT NULL,
	[rolename] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ROLE] PRIMARY KEY CLUSTERED 
(
	[roleid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 2022-08-11 12:42:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[person_id] [int] NULL,
	[password] [varchar](50) NOT NULL,
	[username] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (1, 1, N'xxs20220801')
INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (2, 10, N'Jason 2022-08-03')
INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (3, 11, N'Kathy 2022-08-03 12:00:00 AM')
INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (4, 12, N'Bert 2022-08-03 12:00:00 AM')
INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (5, 14, N'Jamie 2022-08-04')
INSERT [dbo].[Authors] ([authorid], [person_id], [author_ID]) VALUES (6, 15, N'Kevin 2022-08-04')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
INSERT [dbo].[Book_Author] ([book_id], [person_id]) VALUES (1, 1)
INSERT [dbo].[Book_Author] ([book_id], [person_id]) VALUES (2, 11)
INSERT [dbo].[Book_Author] ([book_id], [person_id]) VALUES (2, 12)
INSERT [dbo].[Book_Author] ([book_id], [person_id]) VALUES (4, 14)
INSERT [dbo].[Book_Author] ([book_id], [person_id]) VALUES (5, 15)
GO
SET IDENTITY_INSERT [dbo].[Book_Type] ON 

INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (1, N'--Choose--')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (2, N'operating system')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (3, N'database')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (4, N'Office Software')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (5, N'Web Programming')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (6, N'game development ')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (7, N'mobile development')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (8, N'Graphics/Multimedia')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (9, N'artificial intelligence')
INSERT [dbo].[Book_Type] ([book_type_id], [book_type_name]) VALUES (10, N'Programming language')
SET IDENTITY_INSERT [dbo].[Book_Type] OFF
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([book_id], [book_type_id], [enterprise_id], [ISBN], [Title], [UnitPrice], [YearPublished], [QOH]) VALUES (1, 2, 2, N'978-1496145093', N'Linux for Beginners', 32.7200, CAST(N'2014-01-01T00:00:00.000' AS DateTime), 15)
INSERT [dbo].[Books] ([book_id], [book_type_id], [enterprise_id], [ISBN], [Title], [UnitPrice], [YearPublished], [QOH]) VALUES (2, 10, 7, N'978-0596009205', N'Head First Java: A Brain-Friendly Guide ', 77.0800, CAST(N'2022-08-03T14:05:50.000' AS DateTime), 81)
INSERT [dbo].[Books] ([book_id], [book_type_id], [enterprise_id], [ISBN], [Title], [UnitPrice], [YearPublished], [QOH]) VALUES (4, 10, 19, N'978-1518800276', N'C#: Learn C# in One Day and Learn It Well. C# for Beginners with Hands-on Project', 15.4400, CAST(N'2022-08-04T14:40:08.667' AS DateTime), 12)
INSERT [dbo].[Books] ([book_id], [book_type_id], [enterprise_id], [ISBN], [Title], [UnitPrice], [YearPublished], [QOH]) VALUES (5, 4, 20, N'978-1911174653', N'Essential Office 365 Second Edition: The Illustrated Guide to using Microsoft Office', 47.5100, CAST(N'2018-05-12T14:42:35.000' AS DateTime), 9)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[Enterprise_type] ON 

INSERT [dbo].[Enterprise_type] ([enterprise_type_id], [enterprise_type_name]) VALUES (1, N'client')
INSERT [dbo].[Enterprise_type] ([enterprise_type_id], [enterprise_type_name]) VALUES (2, N'publisher')
SET IDENTITY_INSERT [dbo].[Enterprise_type] OFF
GO
SET IDENTITY_INSERT [dbo].[Enterprises] ON 

INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (2, 1, N'Champlain College Saint-Lambert', N'900 Riverside Drive1', N'St-Lambert', N'J4P 3P2', N'admissions@crcmail.net', N'450-672-7360', N'450-672-9299', 5000.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (3, 1, N'Collège LaSalle', N'2000, Sainte-Catherine Street West', N'Montréal', N'H3H 2T2', N'admission@collegelasalle.com', N'514 939-2006', N'514 939-2006', 10000.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (4, 2, N'Premier Press', N'-v', N'Montreal', N'-', N'Premier Press@', N'-', N'-', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (7, 2, N'Wrox', N'1', N'Montreal', N'1', N'Wrox@11', N'1', N'1', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (10, 2, N'Murach', N'-', N'-', N'-', N'Murach@', N'-', N'-', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (11, 2, N'Prentice Hall', N'-', N'-', N'-', N'Prentice Hall@', N'-', N'-', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (12, 1, N'Vanier College', N'821 Avenue Sainte-Croix', N'Montreal', N'H4L 3X9', N'admission@vaniercollege.com', N'514-744-7500', N'514-744-7500', 14747.6800, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (13, 1, N'Dawson College', N'3040 Sherbrooke St. W,', N'Montreal', N'H3Z 1A4', N'info@dawsoncollege.qc.ca', N'514 931-8731', N'514 931-8731', 3969.1200, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (14, 1, N'xx', N'123', N'4312', N'43214', N'432143', N'3214', N'3124132', 0.0000, N'1')
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (15, 1, N'HERZING COLLEGE MONTREAL', N'1616 Boulevard Rene-Levesque Ouest', N'Montreal', N'H3H 1P8', N'mtl-info@herzing.ca', N' (514) 935-7494', N'(514) 933-6182', 1768.7600, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (16, 2, N' Independently published', N'-', N'-', N'-', N'-', N'-', N'-', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (17, 2, N'Summer press', N'1', N'1', N'1', N'1', N'1', N'1', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (18, 1, N'University of Montreal 1', N'2900, boul. édouard-Montpetit', N'Montréal', N'H3T 1J4', N'n', N'(514) 343-6111', N'(514) 343-6111', 4827.2500, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (19, 2, N'LCF Publishing', N'1', N'1', N'1', N'1', N'1', N'1', 0.0000, NULL)
INSERT [dbo].[Enterprises] ([enterprise_id], [enterprise_type_id], [name], [street], [city], [zip_code], [enterprise_email], [enterprise_phone], [enterprise_fax], [credit_limit], [state]) VALUES (20, 2, N'Elluminet Press', N'-', N'-', N'-', N'--', N'-', N'-', 0.0000, NULL)
SET IDENTITY_INSERT [dbo].[Enterprises] OFF
GO
SET IDENTITY_INSERT [dbo].[order_book] ON 

INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (1, 12, 2, 3)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (2, 14, 2, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (3, 14, 1, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (4, 15, 2, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (5, 15, 1, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (6, 16, 1, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (9, 17, 2, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (10, 17, 1, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (11, 22, 4, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (12, 24, 4, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (13, 25, 1, 3)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (14, 25, 2, 2)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (16, 27, 2, 3)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (17, 28, 2, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (18, 28, 1, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (19, 28, 4, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (20, 28, 5, 1)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (21, 30, 5, 0)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (22, 32, 2, 0)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (23, 33, 2, 0)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (24, 35, 2, 0)
INSERT [dbo].[order_book] ([order_book_id], [order_id], [book_id], [quantity]) VALUES (25, 36, 1, 0)
SET IDENTITY_INSERT [dbo].[order_book] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_table] ON 

INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (9, 7, 2, 1, 0.0000, CAST(N'2022-08-03T22:13:53.397' AS DateTime), N'20220803221353392', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (10, 7, 2, 1, 0.0000, CAST(N'2022-08-03T22:15:01.097' AS DateTime), N'20220803221501093', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (11, 7, 2, 1, 0.0000, CAST(N'2022-08-03T22:33:09.390' AS DateTime), N'20220803223309384', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (12, 7, 3, 1, 231.2400, CAST(N'2022-08-03T22:35:26.757' AS DateTime), N'20220803223526751', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (13, 7, 2, 1, 0.0000, CAST(N'2022-08-03T22:40:54.680' AS DateTime), N'20220803224054675', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (14, 7, 2, 1, 0.0000, CAST(N'2022-08-03T22:43:11.200' AS DateTime), N'20220803224311193', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (15, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:04:00.293' AS DateTime), N'20220803230400289', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (16, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:07:43.130' AS DateTime), N'20220803230743124', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (17, 7, 12, 1, 109.8000, CAST(N'2022-08-03T23:13:58.120' AS DateTime), N'20220803231358088', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (18, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:29:04.247' AS DateTime), N'20220803232904241', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (19, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:30:59.137' AS DateTime), N'20220803233059131', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (20, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:31:43.570' AS DateTime), N'20220803233143566', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (21, 7, 2, 1, 0.0000, CAST(N'2022-08-03T23:35:38.340' AS DateTime), N'20220803233538339', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (22, 3, 2, 1, 0.0000, CAST(N'2022-08-04T16:33:08.247' AS DateTime), N'20220804163308237', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (23, 3, 2, 1, 0.0000, CAST(N'2022-08-04T16:35:34.490' AS DateTime), N'20220804163534485', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (24, 3, 2, 1, 0.0000, CAST(N'2022-08-04T16:37:26.003' AS DateTime), N'20220804163725999', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (25, 3, 12, 1, 252.3200, CAST(N'2022-08-04T16:42:54.740' AS DateTime), N'20220804164254735', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (26, 3, 13, 1, 30.8800, CAST(N'2022-08-04T16:47:51.683' AS DateTime), N'20220804164751679', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (27, 3, 15, 1, 231.2400, CAST(N'2022-08-04T17:22:08.897' AS DateTime), N'20220804172208855', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (28, 3, 18, 1, 172.7500, CAST(N'2022-08-04T17:24:23.620' AS DateTime), N'20220804172423617', 2)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (29, 3, 2, 1, 0.0000, CAST(N'2022-08-08T23:31:25.627' AS DateTime), N'20220808233125619', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (30, 3, 3, 1, 47.5100, CAST(N'2022-08-08T23:33:29.407' AS DateTime), N'20220808233329403', 3)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (31, 3, 2, 1, 0.0000, CAST(N'2022-08-09T00:53:17.190' AS DateTime), N'20220809005317186', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (32, 3, 3, 1, 77.0800, CAST(N'2022-08-09T00:55:21.050' AS DateTime), N'20220809005521047', 3)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (33, 3, 3, 1, 77.0800, CAST(N'2022-08-09T01:00:20.723' AS DateTime), N'20220809010020719', 3)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (34, 3, 2, 1, 0.0000, CAST(N'2022-08-09T01:00:37.200' AS DateTime), N'20220809010037197', 0)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (35, 3, 3, 1, 77.0800, CAST(N'2022-08-09T01:08:07.883' AS DateTime), N'20220809010807882', 3)
INSERT [dbo].[Order_table] ([order_id], [person_id], [enterprise_id], [order_type_id], [totalprice], [order_time], [order_serial_number], [state_order]) VALUES (36, 7, 3, 1, 32.7200, CAST(N'2022-08-09T01:17:19.780' AS DateTime), N'20220809011719777', 3)
SET IDENTITY_INSERT [dbo].[Order_table] OFF
GO
SET IDENTITY_INSERT [dbo].[order_type] ON 

INSERT [dbo].[order_type] ([order_type_id], [order_type_name]) VALUES (1, N'sale')
INSERT [dbo].[order_type] ([order_type_id], [order_type_name]) VALUES (2, N'buy')
SET IDENTITY_INSERT [dbo].[order_type] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (1, 5, N'sded111', N'aasdd', N'eqrgt@gmail.com', N'696-987-9658', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (2, 1, N'Henry ', N'Brown', N'Henry@gmail.com', N'435-669-9632', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (3, 4, N'Mary', N'Brown', N'Mary@gmail.com', N'555-666-9999', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (4, 4, N'Jennifer ', N'Bouchard', N'Jennifer@gmail.com', N'666-666-6666', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (5, 2, N'Thomas ', N'Moore', N'Moore@gmail.com', N'123-999-8888', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (6, 3, N'Peter', N'Wang', N'Peter@gmail.com', N'558-888-7777', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (7, 1003, N'admin', N'admin', N'admin@', N'111-111-1111', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (8, 1002, N'staff', N'staff', N'stuff1@gmail.com', N'456-456-4567', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (9, 1002, N'nani', N'xd', N'nani@gmail.com', N'666-999-7777', N'1')
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (10, 5, N'Jason ', N'Cannon', N'Jason @', N'-', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (11, 5, N'Kathy ', N'Sierra ', N'kathy@', N'fdaf', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (12, 5, N'Bert ', N'Bates', N'Bert @', N'fdasfdas', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (13, 1002, N'Angle', N'Fan', N'Angle@', N'445-666-1234', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (14, 5, N'Jamie ', N'Chan', N'Jamie @xxx.com', N'32143547', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (15, 5, N'Kevin', N'Wilson ', N'Kevin@xxx.com', N'12456', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (16, 1002, N'fan', N'yy', N'2341', N'4314', NULL)
INSERT [dbo].[Persons] ([person_id], [roleid], [first_name], [last_name], [email], [phonenb], [state]) VALUES (17, 3, N'Abram', N'G', N'Abram@', N'123-123-3333', NULL)
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (1, N'MIS Manager')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (3, N'Inventory Controller')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (4, N'Order Clerk')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (5, N'Author')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (1002, N'Staff')
INSERT [dbo].[Role] ([roleid], [rolename]) VALUES (1003, N'--Choose--')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (1, 2, N'123', N'Henry')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (2, 3, N'123', N'Mary')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (3, 4, N'123', N'Jennifer')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (4, 5, N'123', N'Thomas')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (5, 6, N'123', N'Peter')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (6, 7, N'admin', N'admin')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (7, 16, N'123', N'fan')
INSERT [dbo].[User] ([user_id], [person_id], [password], [username]) VALUES (8, 17, N'123', N'Abram')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Books] ADD  DEFAULT ((0)) FOR [QOH]
GO
ALTER TABLE [dbo].[order_book] ADD  DEFAULT ((1)) FOR [quantity]
GO
ALTER TABLE [dbo].[Order_table] ADD  DEFAULT (getdate()) FOR [order_time]
GO
ALTER TABLE [dbo].[Order_table] ADD  DEFAULT ((0)) FOR [state_order]
GO
ALTER TABLE [dbo].[Authors]  WITH CHECK ADD  CONSTRAINT [FK_AUTHORS_REFERENCE_PERSONS] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([person_id])
GO
ALTER TABLE [dbo].[Authors] CHECK CONSTRAINT [FK_AUTHORS_REFERENCE_PERSONS]
GO
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_AUT_REFERENCE_BOOKS] FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_BOOK_AUT_REFERENCE_BOOKS]
GO
ALTER TABLE [dbo].[Book_Author]  WITH CHECK ADD  CONSTRAINT [FK_BOOK_AUT_REFERENCE_PERSONS] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([person_id])
GO
ALTER TABLE [dbo].[Book_Author] CHECK CONSTRAINT [FK_BOOK_AUT_REFERENCE_PERSONS]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_BOOKS_REFERENCE_BOOK_TYP] FOREIGN KEY([book_type_id])
REFERENCES [dbo].[Book_Type] ([book_type_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_BOOKS_REFERENCE_BOOK_TYP]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_BOOKS_REFERENCE_ENTERPRI] FOREIGN KEY([enterprise_id])
REFERENCES [dbo].[Enterprises] ([enterprise_id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_BOOKS_REFERENCE_ENTERPRI]
GO
ALTER TABLE [dbo].[Enterprises]  WITH CHECK ADD  CONSTRAINT [FK_ENTERPRI_REFERENCE_ENTERPRI] FOREIGN KEY([enterprise_type_id])
REFERENCES [dbo].[Enterprise_type] ([enterprise_type_id])
GO
ALTER TABLE [dbo].[Enterprises] CHECK CONSTRAINT [FK_ENTERPRI_REFERENCE_ENTERPRI]
GO
ALTER TABLE [dbo].[order_book]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_BO_REFERENCE_BOOKS] FOREIGN KEY([book_id])
REFERENCES [dbo].[Books] ([book_id])
GO
ALTER TABLE [dbo].[order_book] CHECK CONSTRAINT [FK_ORDER_BO_REFERENCE_BOOKS]
GO
ALTER TABLE [dbo].[order_book]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_BO_REFERENCE_ORDER_TA] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order_table] ([order_id])
GO
ALTER TABLE [dbo].[order_book] CHECK CONSTRAINT [FK_ORDER_BO_REFERENCE_ORDER_TA]
GO
ALTER TABLE [dbo].[Order_table]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_TA_REFERENCE_ENTERPRI] FOREIGN KEY([enterprise_id])
REFERENCES [dbo].[Enterprises] ([enterprise_id])
GO
ALTER TABLE [dbo].[Order_table] CHECK CONSTRAINT [FK_ORDER_TA_REFERENCE_ENTERPRI]
GO
ALTER TABLE [dbo].[Order_table]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_TA_REFERENCE_ORDER_TY] FOREIGN KEY([order_type_id])
REFERENCES [dbo].[order_type] ([order_type_id])
GO
ALTER TABLE [dbo].[Order_table] CHECK CONSTRAINT [FK_ORDER_TA_REFERENCE_ORDER_TY]
GO
ALTER TABLE [dbo].[Order_table]  WITH CHECK ADD  CONSTRAINT [FK_ORDER_TA_REFERENCE_PERSONS] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([person_id])
GO
ALTER TABLE [dbo].[Order_table] CHECK CONSTRAINT [FK_ORDER_TA_REFERENCE_PERSONS]
GO
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD  CONSTRAINT [FK_PERSONS_REFERENCE_ROLE] FOREIGN KEY([roleid])
REFERENCES [dbo].[Role] ([roleid])
GO
ALTER TABLE [dbo].[Persons] CHECK CONSTRAINT [FK_PERSONS_REFERENCE_ROLE]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_USER_REFERENCE_PERSONS] FOREIGN KEY([person_id])
REFERENCES [dbo].[Persons] ([person_id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_USER_REFERENCE_PERSONS]
GO
