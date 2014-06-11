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

            //FECHA CONEXÃO
            sqlConnection.Close();
        }
    }
}
