CREATE TABLE [dbo].[Radnik]
(
	[ID_Radnika] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Ime] NVARCHAR(15) NOT NULL, 
    [Prezime] NVARCHAR(30) NOT NULL, 
    [Telefon] NVARCHAR(15) NOT NULL, 
    [JMBG] NVARCHAR(13) NOT NULL, 
    [Email] NVARCHAR(30) NOT NULL, 
    [FK_ID_Rukovodioca] INT NULL, 
    [Username] NVARCHAR(10) NOT NULL, 
    [Password] NVARCHAR(20) NOT NULL
)
