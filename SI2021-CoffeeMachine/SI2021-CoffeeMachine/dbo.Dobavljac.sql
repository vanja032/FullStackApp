CREATE TABLE [dbo].[Dobavljac]
(
	[ID_Dobavljaca] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Naziv] NVARCHAR(30) NOT NULL, 
    [Adresa] NVARCHAR(50) NOT NULL
)
