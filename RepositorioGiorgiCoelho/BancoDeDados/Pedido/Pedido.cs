using System;
using System.Data.SqlClient;

namespace BancoDeDados.Exercícios_BD
{
    internal class Pedido
    {
        public static void Main()
        {
            //CONNECTION STRING
            string connectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\aluno\Source\Repos\GiorgiRepositorio\RepositorioGiorgiCoelho\BancoDeDados\GiorgiBD.mdf;Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //ABRINDO CONEXÃO
            sqlConnection.Open();

            CreatingData_AddPedido(sqlConnection);

            sqlConnection.Close();
        }

        private static void CreatingData_AddPedido(SqlConnection sqlConnection)
        {
            var dataPedido = DateTime.Now;
            Console.WriteLine("Digite a quantidade de produtos: ");
            var quantidade = int.Parse(Console.ReadLine());
            int produtoId = 1; //lógica de busca
            int clienteId = 2; //lógica de busca;
            string sql = String.Format(@"INSERT INTO Pedido(DataPedido, Quantidade, Produto_Id, Cliente_Id) VALUES('{0}',{1},{2},{3})", dataPedido, quantidade, produtoId, clienteId);
            SqlCommand insert = new SqlCommand(sql, sqlConnection);
            try
            {
                int i = insert.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cadastro Inserido com Sucesso!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.ToString()); //Mostrará o erro para o usuário.
            }
        }
    }
}