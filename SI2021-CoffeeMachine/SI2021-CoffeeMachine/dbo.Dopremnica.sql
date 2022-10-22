CREATE TABLE [dbo].[Dopremnica] (
    [ID_Dopremnice]    INT IDENTITY (1, 1) NOT NULL,
    [FK_ID_Proizvoda]  INT NOT NULL,
    [FK_ID_Dobavljaca] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([ID_Dopremnice] ASC),
	CONSTRAINT FK_ID_Proizvoda
	FOREIGN KEY (FK_ID_Proizvoda) REFERENCES dbo.Proizvod(ID_Proizvoda) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ID_Dobavljac
	FOREIGN KEY (FK_ID_Dobavljaca) REFERENCES dbo.Dobavljac(ID_Dobavljaca) ON DELETE CASCADE ON UPDATE CASCADE
);

