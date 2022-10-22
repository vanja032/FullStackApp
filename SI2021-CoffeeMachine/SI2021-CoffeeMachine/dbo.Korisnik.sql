CREATE TABLE [dbo].[Korisnik]
(
	[ID_Korisnika] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Username] NVARCHAR(10) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL, 
    [Email] NVARCHAR(30) NOT NULL, 
    [Ime] NVARCHAR(15) NOT NULL, 
    [Prezime] NVARCHAR(30) NOT NULL, 
    [Telefon] NVARCHAR(15) NULL, 
    [Role] NVARCHAR(20) NOT NULL
)
