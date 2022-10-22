CREATE TABLE [dbo].[Evidencija] (
    [Opis]             NVARCHAR (200) NOT NULL,
    [Napomena]         NVARCHAR (100) NOT NULL,
    [FK_ID_Narudzbine] INT            NOT NULL,
    [FK_ID_Proizvoda]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([FK_ID_Narudzbine] ASC, [FK_ID_Proizvoda] ASC),
	CONSTRAINT FK_ID_Narudzbina
	FOREIGN KEY (FK_ID_Narudzbine) REFERENCES dbo.Narudzbina(ID_Narudzbine) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT FK_ID_Proizvod
	FOREIGN KEY (FK_ID_Proizvoda) REFERENCES dbo.Proizvod(ID_Proizvoda) ON DELETE CASCADE ON UPDATE CASCADE
);

