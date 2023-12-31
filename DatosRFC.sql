USE [Generacion23]
GO
/****** Object:  Table [dbo].[RFC]    Script Date: 24/12/2023 11:58:06 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RFC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](70) NULL,
	[apellidoPaterno] [varchar](70) NULL,
	[apellidoMaterno] [varchar](70) NULL,
	[fechaNacimiento] [date] NULL,
	[RFC] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[RFC] ON 

INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1149, N'Juan Antonio', N'Gonzalez', N'Tovar', CAST(N'2001-08-16' AS Date), N'GOTJ010816')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1150, N'Mary Rosa', N'Hurtado', N'Lopez', CAST(N'2003-07-16' AS Date), N'HULM030716')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1151, N'Pedro Antonio', N' ', N'Ichoa', CAST(N'2001-04-13' AS Date), N'ICXP010413')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1152, N'Nancy Elizabeth', N'Ochoa', N'Muñoz', CAST(N'2001-07-16' AS Date), N'OOME010716')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1162, N'Irma', N'Gonzalez', N'Ruiz', CAST(N'1994-08-19' AS Date), N'GORI940819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1163, N'Ana Juana', N'Estrada', N'X', CAST(N'1996-08-19' AS Date), N'ESXA960819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1164, N'Juan Eduardo ', N'Peña', N'X', CAST(N'1996-08-19' AS Date), N'PEXJ960819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1165, N'Andres', N'Ich', N'Rodriguez', CAST(N'1992-05-19' AS Date), N'IXRA920519')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1166, N'Raul', N'Arreta', N'Molina', CAST(N'1976-08-19' AS Date), N'AEMR760819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1167, N'Luis Gorge', N'Alcatras', N'Rodriguez', CAST(N'1994-06-02' AS Date), N'AARL940602')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1168, N'Irma', N'Gonzalez', N'Ruiz', CAST(N'1994-08-19' AS Date), N'GORI940819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1169, N'Juliana Luz', N'Gonzalez', N'Antorcha', CAST(N'1986-08-16' AS Date), N'GOAJ860816')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1170, N'Maria Angustia', N'Rosales', N'Ortega', CAST(N'1980-08-19' AS Date), N'ROOA800819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1171, N'Moises', N'Torres', N'Perez', CAST(N'2003-05-19' AS Date), N'TOPM030519')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1172, N'Jose Arturo', N'Castañeda', N'Clavel', CAST(N'2001-08-16' AS Date), N'CACX010816')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1173, N'Enrique', N'Peña', N'Nieto', CAST(N'2006-08-19' AS Date), N'PENX060819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1174, N'Maria Guadalupe', N'Perez', N'X', CAST(N'1987-05-16' AS Date), N'PEXG870516')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1176, N'Ana', N'Rivas', N'Palacio', CAST(N'2006-05-19' AS Date), N'RIPA060519')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1177, N'Jose Arturo', N'Cardenaz', N'Cruz', CAST(N'1978-08-19' AS Date), N'CACX780819')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1178, N'Maria Guadalupe', N'Perez', N'X', CAST(N'1987-05-16' AS Date), N'PEXG870516')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1179, N'Fernando', N'Mateos', N'Ortiz', CAST(N'1997-11-30' AS Date), N'MAOF971130')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1180, N'Maria Blanca', N'Ortega', N'Moralez', CAST(N'1996-04-18' AS Date), N'OEMB960418')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1181, N'Pedro', N'Ruiz', N'X', CAST(N'1998-06-19' AS Date), N'RUXP980619')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1182, N'Eduardo', N'X', N'Contrera', CAST(N'1986-05-12' AS Date), N'COXE860512')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1183, N'Jorge Luis', N'Martinez', N'Cruz', CAST(N'1996-05-19' AS Date), N'MACJ960519')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1184, N'Maria Guadalupe', N'Torres', N'Rivaz', CAST(N'1986-07-19' AS Date), N'TORG860719')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1185, N'Antonio', N'Herrera', N'X', CAST(N'2001-06-19' AS Date), N'HEXA010619')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1186, N'Enrique', N'Peña', N'Nieto', CAST(N'2003-09-15' AS Date), N'PENX030915')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1187, N'Ana', N'Peralta', N'X', CAST(N'2001-06-19' AS Date), N'PEXA010619')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1188, N'Miriam', N'X', N'Perez', CAST(N'1986-05-16' AS Date), N'PEXM860516')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1189, N'Julia', N'Morales', N'Perez', CAST(N'1996-08-16' AS Date), N'MOPJ960816')
INSERT [dbo].[RFC] ([ID], [nombre], [apellidoPaterno], [apellidoMaterno], [fechaNacimiento], [RFC]) VALUES (1190, N'Juan', N'Morales', N'Ochoa', CAST(N'1986-04-13' AS Date), N'MOOJ860413')
SET IDENTITY_INSERT [dbo].[RFC] OFF
GO
