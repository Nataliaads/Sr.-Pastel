using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PASTELARIA.Camadas.DAL
{
    public class Cliente
    {
        private string strCon = Conexao.getConexao();
        public List<MODEL.Cliente> Select()
        {   //com quem ele vai conectar e o comando;
            List<MODEL.Cliente> listaCliente = new List<MODEL.Cliente>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select*from Cliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try //tentar execultar o que esta aqui
            {
                conexao.Open();

                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection); //abrir e fechar conexão
                while (dados.Read())
                {
                    MODEL.Cliente cliente = new MODEL.Cliente();
                    cliente.idCliente = Convert.ToInt32(dados["idCliente"].ToString());
                    cliente.nome = dados["nome"].ToString();
                    cliente.endereco = dados["endereco"].ToString();
                    listaCliente.Add(cliente);

                }
            }
            catch //execao
            {
                Console.WriteLine("Deu erro no select de Cliente...");
            }
            finally
            {
                conexao.Close();
            }

            return listaCliente;

        }

       public void Insert(Camadas.MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Cliente values (@nome, @endereco);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na inserção de clientes");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(Camadas.MODEL.Cliente cliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Cliente set nome=@nome, endereco=@endereco";
            sql += " where idCliente=@idCliente"; //continuar a linha
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("DEus erro no update de cliente!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete (int idCliente)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Cliente where idCliente=@idCliente";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idCliente", idCliente);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Deu erro na remoção de Cliente!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
