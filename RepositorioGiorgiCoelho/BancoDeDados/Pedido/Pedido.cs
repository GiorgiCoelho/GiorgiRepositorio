using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BancoDeDados.Pedido
{
    class Pedido
    {
        public static void Main(string[] args)
        {
            //CONNECTION STRING  
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\GiorgiRepositorio\RepositorioGiorgiCoelho\BancoDeDados\GiorgiBD.mdf;Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //ABRINDO CONEXÃO
            sqlConnection.Open();

            //=====REALIZAR COMANDOS=====

            //SELECIONA TODOS OS PRODUTOS
            //SqlCommand command = new SqlCommand("SELECT * FROM Produto",sqlConnection);

            //SqlDataReader reader = command.ExecuteReader();

            //while(reader.Read())
            //{
            //    Console.WriteLine(reader["Nome"]);
            //}


            //ATUALIZA PRODUTO
            //Console.WriteLine("Digite o ID do produto: ");
            //int id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o nome do produto: ");
            //string nome = Console.ReadLine();
            //string sqlUpdate = String.Format("UPDATE Produto SET Nome = '{0}' WHERE Id = {1}", nome, id);
            //SqlCommand command = new SqlCommand(sqlUpdate, sqlConnection);

            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if(i > 0)
            //    {
            //          Console.WriteLine("Produto Atulizado Com Sucesso!");
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Digite algo válido!");
            //}

            //DELETA PRODUTO
            //Console.WriteLine("Digite o Id do produto a ser deletado: ");
            //int id = int.Parse(Console.ReadLine());
            //string sqlDelete = String.Format("DELETE from Produto WHERE Id = {0}",id);
            //SqlCommand command = new SqlCommand(sqlDelete, sqlConnection);
            //try
            //{
            //    int i = command.ExecuteNonQuery();
            //    if(i > 0)
            //    {
            //        Console.WriteLine("Produto Deletado Com Sucesso!");
            //    }                
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Digite algo válido!");
            //}

            //INSERIR PRODUTO
            Console.WriteLine("Digite o Nome do Produto: ");
            string nome = (Console.ReadLine());
            Console.WriteLine("Digite a unidade do Produto: ");
            string unidade = (Console.ReadLine());
            Console.WriteLine("Digite o Valor do Produto: ");
            double valor = double.Parse(Console.ReadLine());
            string sqlInsert = String.Format("INSERT INTO Produto (Nome, Unidade, Valor) VALUES('{0}','{1}',{2})", nome, unidade, valor);
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

            //FECHA CONEXÃO
            sqlConnection.Close();
        }
    }
}
