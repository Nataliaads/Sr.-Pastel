using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Camadas.BLL
{
    public class Produto
    {
        public List<MODEL.Produto> SelectById(int idProduto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByIdProduto(idProduto);
        }

        public List<MODEL.Produto> SelectByNome(string nome)
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.SelectByNome(nome);
        }

        public List<MODEL.Produto> Select()
        {
            DAL.Produto dalProd = new DAL.Produto();
            return dalProd.Select();
        }

        public void Insert(MODEL.Produto produto)
        {

            DAL.Produto dalProd = new DAL.Produto();
            if (produto.nome != string.Empty)
                dalProd.Insert(produto);
        }

        public void Update(MODEL.Produto produto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (produto.nome != "")
                dalProd.Update(produto);
        }

        public void Delete(int idProduto)
        {
            DAL.Produto dalProd = new DAL.Produto();
            if (idProduto > 0)
                dalProd.Delete(idProduto);

        }

    }
}



