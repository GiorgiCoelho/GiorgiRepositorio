Select SUM(Altura) as SomaAltura--faz a soma 
from Aluno;
Select SUM(Altura) as SomaAlturaReprovados from Aluno where Aprovado = 'false';-- soma da altura de quem tá reprovado
Select Count(*) as QuantidadeAlunos From Aluno
Select Max(altura) as MaiorAltura from Aluno
Select Min(altura) as MenorAltura from Aluno
Select Count(*) as APROVADOS From Aluno where Aprovado = 'true';
