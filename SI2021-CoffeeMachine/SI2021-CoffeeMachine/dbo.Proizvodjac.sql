CREATE TABLE [dbo].[Proizvodjac]
(
	[ID_Proizvodjaca] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naziv] NVARCHAR(50) NOT NULL, 
    [Drzava] NVARCHAR(50) NOT NULL, 
    [Adresa] NVARCHAR(50) NOT NULL, 
    [Opis] NVARCHAR(50) NULL
)
