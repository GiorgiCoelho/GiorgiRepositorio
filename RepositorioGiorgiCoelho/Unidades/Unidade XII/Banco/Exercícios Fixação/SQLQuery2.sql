SET IDENTITY_INSERT [dbo].[Aluno] ON
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email ], [Telefone], [Altura], [Aprovado]) VALUES (1, N'Giorgi', N'giorgi_coelho@hotmail.com', N'32267676', CAST(1.68 AS Decimal(3, 2)), 1)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email ], [Telefone], [Altura], [Aprovado]) VALUES (2, N'João', N'joao@hotmail.com', N'32242424', CAST(1.73 AS Decimal(3, 2)), 1)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email ], [Telefone], [Altura], [Aprovado]) VALUES (3, N'Ana', N'ana@hotmail.com', N'32232323', CAST(1.56 AS Decimal(3, 2)), 0)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email ], [Telefone], [Altura], [Aprovado]) VALUES (4, N'Camila', N' camila@hotmail.com', N'32252525', CAST(1.40 AS Decimal(3, 2)), 1)
INSERT INTO [dbo].[Aluno] ([Id], [Nome], [Email ], [Telefone], [Altura], [Aprovado]) VALUES (5, N'Carlos', N'carlos@hotmail.com', N'32278787', CAST(1.90 AS Decimal(3, 2)), 0)
SET IDENTITY_INSERT [dbo].[Aluno] OFF