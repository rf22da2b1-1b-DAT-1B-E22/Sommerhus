CREATE TABLE [dbo].[Sommerhus]
(
	[Id] INT identity(10,2) NOT NULL PRIMARY KEY,
	[Sted] NVARCHAR(25) NOT NULL,
	[PrisPrUge] INT NOT NULL,
	[AntalSenge] INT NOT NULL,
	[Rengoering] BIT NOT NULL,
	[Husdyr] BIT NOT NULL,
	[Vaskemaskine] BIT NOT NULL,
	[Opvaskemaskine] BIT NOT NULL,
	[SPA] BIT NOT NULL
	
)