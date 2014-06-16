/*CREATE TABLE [dbo].[Funcionario]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [PrimeiroNome] VARCHAR(50) NULL, 
    [Sobrenome] VARCHAR(50) NULL, 
    [Salario] DECIMAL(11, 2) NULL, 
    [Funcao] VARCHAR(50) NULL, 
    [Departamento_ID] INT NULL
	CONSTRAINT [FK_Funcionario_Departamento_ID] FOREIGN KEY ([Departamento_ID]) REFERENCES [dbo].[Departamento] ([Id])
)*/


/*CREATE TABLE [dbo].[Departamento]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nome] VARCHAR(150) NULL
)
*/