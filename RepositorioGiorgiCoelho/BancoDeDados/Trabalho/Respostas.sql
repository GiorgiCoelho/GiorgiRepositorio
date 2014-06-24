
--Questão 1
--insert into TBMatricula(Curso_Id,Aluno_Id) values(3,9)
 
--Questão 2
--select Aluno_Id, TBAluno.Nome, TBCurso.Nome from TBMatricula join TBAluno on (TBMatricula.Aluno_Id = TBAluno.Id)
--inner join TBCurso on TBMatricula.Curso_Id = TBCurso.Id order by TBCurso.Nome
 
--Questão 3
--Select Email, (DATEDIFF(YEAR, DataNascimento, GETDATE())) from TBAluno where (DATEDIFF(YEAR, DataNascimento, GETDATE())) > 17

--Questão 4
--select count(*) from TBAluno

--Questão 5
--select TBCurso.Nome, count(*) as 'Matriculados' from TBMatricula join TBAluno on (TBMatricula.Aluno_Id = TBAluno.Id) inner join TBCurso on TBMatricula.Curso_Id = TBCurso.Id group by TBCurso.Nome

--Questão 6
--Select Nome, (DATEDIFF(YEAR, DataNascimento, GETDATE())) as 'Maior de 18' from TBAluno where (DATEDIFF(YEAR, DataNascimento, GETDATE())) > 18

--Questão 7
--select Nome from TBAluno where Sexo = 'F'

--Questão 8
--select TBAluno.Nome from TBMatricula join TBAluno on (TBMatricula.Aluno_Id = TBAluno.Id) inner join TBCurso on TBMatricula.Curso_Id = TBCurso.Id where TBCurso.Nome = 'Medicina' and Sexo = 'F'
 
--Questão 9
--select Nome as 'Nomes Ordenados' from TBCurso order by Nome
 
--Questão 10
--Desenvolva um comando SQL que mostre o aluno, o seu curso e a sua idade, ordenados por Idade.
/*R:*/ --select TBAluno.Nome, TBCurso.Nome,(DATEDIFF(YEAR, DataNascimento, GETDATE())) from TBMatricula join TBAluno on (TBMatricula.Aluno_Id = TBAluno.Id) inner join TBCurso on TBMatricula.Curso_Id = TBCurso.Id order by (DATEDIFF(YEAR, DataNascimento, GETDATE()))
 
-------QUESTÕES TEÓRICAS-------
-- 01.
--SQL é uma linguagem que interage com o banco de dados.
 
--02.
--Desenvolvido no inícios dos anos 70, pela IBM em San Jose.
--Seu nome era SEQUEL.
--Em 1986, foi criado um padrão pro SQL. Quem teve esse trabalho de padronizar foi a American National Standards Institute(ANSI).
--Em 1992, 1999 e 2003, houve novas revisões.
--Hoje é conhecido como SQL e é muito usado por programadores, por ser simples e fácil de usar.
 
--03.
--Consegue interrogar a base de dados;
--Pode alterar, inserir e apagar dados;
--Tem controle sob o acesso dos utilizadores à base de dados e as operações que eles podem ter acesso;
--Consegue criar, alterar ou até remover todos os componentes de uma base de dados, por exemplo, uma tabela.
 
--04.
-- OBRIGATÓRIO: SELECT INTO(coluna) FROM NOME_TABELA
-- NÃO OBRIGATÓRIO: SELECT INTO(coluna) FROM NOME_TABELA ("WHERE","LIKE"...)
 
--05.
--É fundamental saber SQL, pelo fato de poder acessar os dados a hora que quiser, pois os dados não são perdidos. Por isso é tão importante,
--pelo fato de guardar as informações e sempre que o programador necessitar procurar alguns dados, eles estarão guardados.

