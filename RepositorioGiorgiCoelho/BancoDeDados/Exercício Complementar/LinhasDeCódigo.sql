--SELECT * from Funcionario order by Sobrenome

--SELECT * from Funcionario order by Funcao

--SELECT * from Funcionario where Salario > 1000 order by PrimeiroNome, Sobrenome

--SELECT SUM(Salario) from Funcionario

-- === MESMA COISA ===
--SELECT Funcionario.PrimeiroNome, Departamento.Nome from Funcionario inner join Departamento on Funcionario.Departamento_ID = Departamento.Id
--SELECT F.PrimeiroNome,F.Funcao, D.Nome from Funcionario as F inner join Departamento as D on F.Departamento_ID = D.Id order by PrimeiroNome;

--SELECT SUM(F.Salario), D.Nome from Funcionario as F inner join Departamento as D on F.Departamento_ID = D.Id group by D.Nome

--DELETE Departamento from Departamento left outer join Funcionario on Departamento.Id = Funcionario.Departamento_ID where Funcionario.Departamento_ID is null

--DELETE from Departamento where Id = 2

--SELECT Departamento.Nome, Funcionario.Funcao from Funcionario inner join Departamento on Funcionario.Departamento_ID = Departamento.Id where Funcao = 'Diretor'

--SELECT * from Funcionario where Salario between 4500 and 7500 order by PrimeiroNome

--SELECT Funcionario.PrimeiroNome, Departamento.Nome from Funcionario inner join Departamento on Funcionario.Departamento_ID = Departamento.Id where PrimeiroNome like 'G%'

--SELECT count(*) from Funcionario

--SELECT AVG(Salario) from Funcionario

--SELECT Departamento.Nome, MIN(Funcionario.Salario) as 'Menor Pagamento' From Funcionario join Departamento on Funcionario.Departamento_ID = Departamento.Id group by Departamento.Nome

--SELECT Departamento.Nome, MAX(Funcionario.Salario) as 'Maior Pagamento' From Funcionario join Departamento on Funcionario.Departamento_ID = Departamento.Id group by Departamento.Nome

--SELECT Funcionario.PrimeiroNome, Departamento.Nome from Funcionario join Departamento on Funcionario.Departamento_ID = Departamento.Id order by Departamento.Nome, Funcionario.PrimeiroNome