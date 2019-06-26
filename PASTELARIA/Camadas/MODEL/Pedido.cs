using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Camadas.MODEL
{
    public class Pedido
    {
        public int idPedido { get; set; }
        public DateTime dataPedido { get; set; }
        public  int cliente { get; set; }
        public  int produto { get; set; }
    }
}
