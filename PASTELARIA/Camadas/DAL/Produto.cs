using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PASTELARIA.Camadas.DAL
{
    public class Produto
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Produto> SelectByIdProduto(int idProduto)
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto where idProduto=@idProduto;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.idProduto = Convert.ToInt32(dados["idProduto"].ToString());
                    produto.nome = dados["nome"].ToString();
                    lstProdutos.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Produtos deu problema");
            }
            finally
            {
                conexao.Close(); 
            }
            return lstProdutos;
        }


        public List<MODEL.Produto> SelectByNome(string nome)
        {
            List<MODEL.Produto> lstProdutos = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select * from Produto where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@nome", "%" + nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.idProduto = Convert.ToInt32(dados["idProduto"].ToString());
                    produto.nome = dados["nome"].ToString();
                    lstProdutos.Add(produto);

                }
            }
            catch
            {
                Console.WriteLine("Consulta Select de Produtos deu problema");
            }
            finally
            {
                conexao.Close(); 
            }
            return lstProdutos;
        }

        public List<MODEL.Produto> Select()
        {
            List<MODEL.Produto> listaProduto = new List<MODEL.Produto>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Select*from Produto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Produto produto = new MODEL.Produto();
                    produto.idProduto = Convert.ToInt32(dados["idProduto"].ToString());
                    produto.nome = dados["nome"].ToString();
                    produto.preco = Convert.ToSingle(dados["preco"].ToString());
                    listaProduto.Add(produto);
                }
            }
            catch
            {
                Console.WriteLine("Problema no select do produto!");
            }
            finally
            {
                conexao.Close();
            }
            return listaProduto;
        }
        public void Insert(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Insert into Produto values(@nome, @preco);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            //cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@preco", produto.preco);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no insert do produto!");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Update(MODEL.Produto produto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Update Produto set nome=@nome, preco=@preco where idProduto=@idProduto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", produto.idProduto);
            cmd.Parameters.AddWithValue("@nome", produto.nome);
            cmd.Parameters.AddWithValue("@preco", produto.preco);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no Update do produto!");
            }
            finally
            {
                conexao.Close();
            }
        }
        public void Delete(int idProduto)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "Delete from Produto where idProduto=@idProduto";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro no delete do produto!");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
