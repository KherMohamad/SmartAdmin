CREATE TABLE [dbo].[Angajati](
	[IDAngajat] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](50) NOT NULL,
	[prenume] [varchar](50) NOT NULL,
	[dataNasterii] [date] NOT NULL,
	[isManager] [varchar](2) NOT NULL,
	[idDepartament] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IDAngajat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Angajati]  WITH CHECK ADD  CONSTRAINT [fk_angajati_dept] FOREIGN KEY([idDepartament])
REFERENCES [dbo].[Departamente] ([idDepartament])
GO

ALTER TABLE [dbo].[Angajati] CHECK CONSTRAINT [fk_angajati_dept]
GO
CREATE TABLE [dbo].[Departamente](
	[idDepartament] [int] IDENTITY(1,1) NOT NULL,
	[nume] [varchar](50) NOT NULL,
	[nrAngajati] [int] NULL,
	[Venit] [decimal](18, 0) NULL,
PRIMARY KEY CLUSTERED 
(
	[idDepartament] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[istoric_angajari](
	[IDAngajat] [int] IDENTITY(1,1) NOT NULL,
	[NumeAngajat] [varchar](50) NOT NULL,
	[dataAngajare] [date] NOT NULL
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Plati](
	[idPlata] [int] IDENTITY(1,1) NOT NULL,
	[idAngajat] [int] NOT NULL,
	[idTipPlata] [int] NOT NULL,
	[valoarePlata] [int] NULL,
	[idValuta] [int] NULL,
	[dataPlata] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Plati]  WITH CHECK ADD  CONSTRAINT [fk_plati_angajati] FOREIGN KEY([idAngajat])
REFERENCES [dbo].[Angajati] ([IDAngajat])
GO

ALTER TABLE [dbo].[Plati] CHECK CONSTRAINT [fk_plati_angajati]
GO

ALTER TABLE [dbo].[Plati]  WITH CHECK ADD  CONSTRAINT [fk_plati_tipPlati] FOREIGN KEY([idTipPlata])
REFERENCES [dbo].[TipPlati] ([IDTipPlata])
GO

ALTER TABLE [dbo].[Plati] CHECK CONSTRAINT [fk_plati_tipPlati]
GO

ALTER TABLE [dbo].[Plati]  WITH CHECK ADD  CONSTRAINT [fk_plati_valute] FOREIGN KEY([idValuta])
REFERENCES [dbo].[Valute] ([idValuta])
GO

ALTER TABLE [dbo].[Plati] CHECK CONSTRAINT [fk_plati_valute]
GO

ALTER TABLE [dbo].[Plati]  WITH CHECK ADD  CONSTRAINT [chkval] CHECK  (([valoarePlata]>(0)))
GO

ALTER TABLE [dbo].[Plati] CHECK CONSTRAINT [chkval]
GO
CREATE TABLE [dbo].[TipPlati](
	[IDTipPlata] [int] IDENTITY(1,1) NOT NULL,
	[TipPlata] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IDTipPlata] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE TABLE [dbo].[Valute](
	[idValuta] [int] IDENTITY(1,1) NOT NULL,
	[numeValuta] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idValuta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]


