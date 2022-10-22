CREATE TABLE [dbo].[Narudzbina]
(
	[ID_Narudzbine] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Napomena] NVARCHAR(100) NOT NULL, 
    [Opis] NVARCHAR(200) NOT NULL, 
    [Datum] DATETIME NOT NULL
)
