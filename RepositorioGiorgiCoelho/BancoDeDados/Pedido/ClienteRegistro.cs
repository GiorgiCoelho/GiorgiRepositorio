using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BancoDeDados.Pedido
{
    class ClienteRegistro
    {
        public static void Main(string[] args)
        {
            //CONNECTION STRING  
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\GiorgiRepositorio\RepositorioGiorgiCoelho\BancoDeDados\GiorgiBD.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //ABRINDO CONEXÃO
            sqlConnection.Open();

            //INSERIR PRODUTO
            InserirDados(sqlConnection);

            //MOSTRA TODOS OS DADOS
            MostraDados(sqlConnection);

            //ATUALIZA PRODUTO
            AtualizarDados(sqlConnection);

            //DELETA PRODUTO
            DeletaDados(sqlConnection);


            //FECHA CONEXÃO
            sqlConnection.Close();
        }

        private static void DeletaDados(SqlConnection sqlConnection)
        {
            Console.WriteLine("Digite o Id do cliente a ser deletado: ");
            int id = int.Parse(Console.ReadLine());
            string sqlDelete = String.Format("DELETE from Cliente WHERE Id = {0}", id);
            SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cliente Deletado Com Sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite algo válido!");
            }
        }

        private static void AtualizarDados(SqlConnection sqlConnection)
        {
            Console.WriteLine("Digite o ID do Cliente: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do cliente: ");
            string nome = Console.ReadLine();
            string sqlUpdate = String.Format("UPDATE Cliente SET PrimeiroNome = '{0}' WHERE Id = {1}", nome, id);
            SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);

            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cliente Atualizado!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite algo válido!");
            }
        }

        private static void MostraDados(SqlConnection sqlConnection)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Cliente", sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader["PrimeiroNome"]);
            }
        }

        private static void InserirDados(SqlConnection sqlConnection)
        {
            Console.WriteLine("Digite o Nome: ");
            string nome = (Console.ReadLine());
            Console.WriteLine("Digite o Sobrenome: ");
            string sobrenome = Console.ReadLine();
            Console.WriteLine("Digite a Cidade: ");
            string cidade = (Console.ReadLine());
            Console.WriteLine("Digite o Estado: ");
            string estado = Console.ReadLine();
            Console.WriteLine("Digite o CEP: ");
            string CEP = (Console.ReadLine());
            Console.WriteLine("Digite o CPF: ");
            string CPF = Console.ReadLine();
            Console.WriteLine("Digite o Telefone: ");
            string telefone = Console.ReadLine();
            string sqlInsert = String.Format("INSERT INTO Cliente (PrimeiroNome, Sobrenome, Cidade, Estado, CEP, CPF, Telefone) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", nome, sobrenome, cidade, estado, CEP, CPF, telefone);
            SqlCommand command = new SqlCommand(sqlInsert, sqlConnection);
            try
            {
                int i = command.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Produto Inserido Com Sucesso!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Digite algo válido!");
            }
        }
    }
}
