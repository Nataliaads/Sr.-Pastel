using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Camadas.BLL
{
    public class Pedido
    {

        public List<MODEL.Pedido> Select()
        {
            DAL.Pedido dalPedido = new DAL.Pedido();
            return dalPedido.Select();
        }

        public void Insert(MODEL.Pedido pedido)
        {
            DAL.Pedido dalPedido = new DAL.Pedido();
            dalPedido.Insert(pedido);
        }

        public void Update(MODEL.Pedido pedido)
        {
            DAL.Pedido dalPedido = new DAL.Pedido();
            dalPedido.Update(pedido);
        }

        public void Delete(int idPedido)
        {
            DAL.Pedido dalProd = new DAL.Pedido();
            dalProd.Delete(idPedido);
        }


    }
}
