using System;

namespace Exercicios_Complementares_GitHub_UNIDADE_VI
{
    internal class Exercicio2_ValidadeSenha
    {
        public static string senha, senha_correta;
        public static string nome_usuario;
        public static int ultimo_dia_uso_de_conta;
        public static int dia_atual;
        public static int mes1, mes2;
        public static int verifica_validade;

        public static void Maini(String[] args)
        {
            /*
            2) Escreva um programa que verifique a validade de uma senha fornecida pelo usuário.
               A senha válida é o número NomeUsuário123. Devem ser impressas as seguintes mensagens:
               ACESSO PERMITIDO caso a senha seja válida.
               ACESSO NEGADO caso a senha seja inválida.
               Lembrando que essa senha deve ser atualizada em 15 em 15 dias, por segurança.
            */           


            entrada();
            verificacao();
            finalizacao();     
            Console.ReadKey();
        }

        private static void finalizacao()
        {
            Console.Write("Digite sua senha: ");
            senha = Console.ReadLine();
            Console.WriteLine("\n");
            Console.Clear();
            if (senha == senha_correta)
            {
                Console.Write("Acesso Permitido!");
            }
            else
            {
                Console.WriteLine("Acesso Negado!");
            }
        }

        private static void verificacao()
        {
            if (mes1 != mes2)
            {
                verifica_validade = (30 - ultimo_dia_uso_de_conta) + dia_atual;
                if (verifica_validade >= 15)
                {
                    NovaSenha();
                }

            }

            else
            {
                if (mes1 == mes2 && ((dia_atual - ultimo_dia_uso_de_conta) == 15))
                {
                    NovaSenha();
                }
            }
        }

        private static void NovaSenha()
        {
            Console.WriteLine("Digite a nova senha que deseja ser aplicada: ");
            senha_correta = Console.ReadLine();
            Console.Clear();
        }

        private static void entrada()
        {
            Console.Write("\t ----- Bem vindo ao Banco Federal Verifica Senha v1.2(BETA) -----");
            Console.WriteLine("\n");
            Console.Write("Digite o nome do usuário: ");
            nome_usuario = Console.ReadLine();
            senha_correta = nome_usuario + "123";
            Console.WriteLine("\n");
            Console.Write("Qual foi o último dia que você usou a conta? ");
            ultimo_dia_uso_de_conta = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Qual era o mês? Digite em número. Ex: JANEIRO = 1; ");
            mes1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Que dia é hoje? ");
            dia_atual = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("Qual é o mês agora? Digite em número. Ex: JANEIRO = 1; ");
            mes2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
        }
    }
}