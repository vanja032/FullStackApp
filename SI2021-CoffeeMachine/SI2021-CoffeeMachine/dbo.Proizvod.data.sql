SET IDENTITY_INSERT [dbo].[Proizvod] ON
INSERT INTO [dbo].[Proizvod] ([ID_Proizvoda], [Naziv], [Opis], [FK_ID_Proizvodjaca], [Slika_Proizvoda], [Cena]) VALUES (1, N'Laptop', N'i5 4gb RAM 500gb ', 1, N'../../Images/Laptop.jpg', CAST(50000.00 AS Decimal(18, 2)))
INSERT INTO [dbo].[Proizvod] ([ID_Proizvoda], [Naziv], [Opis], [FK_ID_Proizvodjaca], [Slika_Proizvoda], [Cena]) VALUES (2, N'Ram', N'8gb ddr4', 2, N'../../Images/Ram.jpg', CAST(8000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Proizvod] OFF
