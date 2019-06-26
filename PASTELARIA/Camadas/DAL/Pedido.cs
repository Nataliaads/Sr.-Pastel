using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Camadas.DAL
{
    public class Pedido
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Pedido> Select()
        {
            List<MODEL.Pedido> lstPedido = new List<MODEL.Pedido>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Pedido";
            SqlCommand cmd = new SqlCommand(sql, conexao);

            //COLOCAR DENTRO DO TRY DEPOIS
            conexao.Open();
            SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (dados.Read())
            {
                MODEL.Pedido pedido = new MODEL.Pedido();
                pedido.idPedido = Convert.ToInt32(dados["idPedidos"].ToString());
                pedido.cliente = Convert.ToInt32(dados["idCliente"].ToString());
                pedido.dataPedido = Convert.ToDateTime(dados["dataPedido"].ToString());
                pedido.produto = Convert.ToInt32(dados["idProduto"].ToString());
                lstPedido.Add(pedido);

            }

            try
            {
                
            }
            catch
            {
                Console.WriteLine("Erro no select do Pedido!");
            }
            finally
            {
                conexao.Close();
            }
            return lstPedido;
        }

        public void Insert(MODEL.Pedido pedido)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Pedido values(@dataPedido, @idCliente, @idProduto)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@dataPedido", pedido.dataPedido);
            cmd.Parameters.AddWithValue("@idCliente", pedido.cliente);
            cmd.Parameters.AddWithValue("@idProduto", pedido.produto);
            conexao.Open();
            cmd.ExecuteNonQuery();
            try
            {
                
            }
            catch
            {
                Console.WriteLine("Deu erro no insert do Pedido!");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Update(MODEL.Pedido pedido)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Pedido set cliente=@cliente, dataPedido=@dataPedido where idPedido=@idPedido";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPedido", pedido.idPedido);
            cmd.Parameters.AddWithValue("@cliente", pedido.cliente);
            cmd.Parameters.AddWithValue("@dataPedido", pedido.dataPedido);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no update de pedido");
            }
            finally
            {
                conexao.Close();
            }

        }

        public void Delete(int idPedido)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Pedido where idPedido=@idPedido";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idPedido", idPedido);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no delete de pedidos...");
            }
            finally
            {
                conexao.Close();
            }
        }



    }
}
