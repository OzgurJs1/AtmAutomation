USE [Bankamatik]
GO
/****** Object:  Table [dbo].[Hareketler]    Script Date: 15.01.2023 21:25:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hareketler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[musteriID] [int] NULL,
	[islem] [nvarchar](50) NULL,
	[tarih] [date] NULL,
 CONSTRAINT [PK_tbl_Hareketler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 15.01.2023 21:25:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TcNo] [nvarchar](50) NOT NULL,
	[AdSoyad] [nvarchar](80) NULL,
	[Sifre] [nvarchar](50) NULL,
	[Adres] [nvarchar](250) NULL,
	[Telefon] [nvarchar](50) NULL,
	[Bakiye] [decimal](18, 2) NULL,
	[Durum] [bigint] NULL,
 CONSTRAINT [PK_tbl_Musteriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hareketler] ON 

INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (1, 1, N'Para Yatırdı', CAST(N'2023-01-10' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (2, 2, N'Havale Yaptı', CAST(N'2023-01-04' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (3, 2, N'1500 TL Para Çekildi', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (4, 2, N'54000 TL Para Yatırıldı ', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (5, 2, N'Bakiye Sorgulandı ', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (6, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (7, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (8, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (9, 2, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (10, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (11, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (12, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (13, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (14, 1, N'1499TL Para Çekildi', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (15, 1, N' TL Para Yatırıldı!', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (16, 1, N' TL Para Yatırıldı!', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (17, 1, N'10TL Para Çekildi', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (18, 1, N'1978TL Para Çekildi', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (19, 1, N'Bakiye Sorgulandı', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (20, 1, N'1721TL Para Çekildi', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (21, 1, N' TL Para Yatırıldı!', CAST(N'2023-01-14' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (22, 7, N'1568 TL Havale/EFT gönderildi', CAST(N'2023-01-15' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (23, 8, N'1568 TL Havale/EFT alındı', CAST(N'2023-01-15' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (24, 7, N'12345 TL Havale/EFT gönderildi', CAST(N'2023-01-15' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (25, 8, N'12345 TL Havale/EFT alındı', CAST(N'2023-01-15' AS Date))
INSERT [dbo].[Hareketler] ([ID], [musteriID], [islem], [tarih]) VALUES (26, 7, N'5540 TL Para Çekildi', CAST(N'2023-01-15' AS Date))
SET IDENTITY_INSERT [dbo].[Hareketler] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([ID], [TcNo], [AdSoyad], [Sifre], [Adres], [Telefon], [Bakiye], [Durum]) VALUES (7, N'34021918952', N'Özgür AY', N'123', N'İstanbul', N'(553) 562-2547', CAST(35547.00 AS Decimal(18, 2)), 1)
INSERT [dbo].[Musteriler] ([ID], [TcNo], [AdSoyad], [Sifre], [Adres], [Telefon], [Bakiye], [Durum]) VALUES (9, N'11111111111', N'Emre Saran', NULL, N'Çorum', N'(545) 646-5465', CAST(15000.00 AS Decimal(18, 2)), 1)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO
ALTER TABLE [dbo].[Musteriler]  WITH CHECK ADD  CONSTRAINT [FK_Musteriler_Hareketler] FOREIGN KEY([ID])
REFERENCES [dbo].[Hareketler] ([ID])
GO
ALTER TABLE [dbo].[Musteriler] CHECK CONSTRAINT [FK_Musteriler_Hareketler]
GO
