using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PASTELARIA.Camadas.BLL
{
    public class Cliente
    {
        public void insert(Camadas.MODEL.Cliente cliente)
        {
            if(!(cliente.nome == "" || cliente.endereco == ""))
            {
                Camadas.DAL.Cliente cliDal = new Camadas.DAL.Cliente();
                cliDal.Insert(cliente);
            }
        }
    }
}
