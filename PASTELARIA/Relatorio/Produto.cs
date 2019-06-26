using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Relatorio
{
      public class RelPedidos
        {
            public static void impPedidos()
            {
                Camadas.BLL.Pedido bllPedido = new Camadas.BLL.Pedido();
                List<Camadas.MODEL.Pedido> lstPedido = new List<Camadas.MODEL.Pedido>();
                lstPedido = bllPedido.Select();

                string folder = Funcoes.diretorioPasta();
                string arquivo = folder + @"\Relatorio.html";
                StreamWriter sw = new StreamWriter(arquivo);

                using (sw)
                {
                    sw.WriteLine("<html>");
                    sw.WriteLine("<head>");
                    sw.WriteLine("<meta http-equiv='Content-Type' " +
                                 "content='text/html; charset=utf-8'/>");
                    sw.WriteLine("<link rel='stylesheet' href='https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css' integrity='sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T' crossorigin='anonymous'>");
                    sw.WriteLine("</head>");
                    sw.WriteLine("<body>");
                    sw.WriteLine("<h1>Relatório de Pedido</h1>");
                    sw.WriteLine("<hr align='left' border:'5px' />");
                    sw.WriteLine("<table class='table table-hover'> ");
                    sw.WriteLine("<tr class='thead-dark'>");
                    sw.WriteLine("<th align='right' width='30px'>idPedido</th>");
                    sw.WriteLine("<th align='right' width='90px'>IDCliente/th>");
                    sw.WriteLine("<th align='right' width='90px'>idProduto/th>");
                    sw.WriteLine("<th align='left' width='150px'>DataPedido</th>");
                    sw.WriteLine("</tr>");
                    int cont = 0;
                    int somaGeral = 0;

                    foreach (Camadas.MODEL.Pedido pedido in lstPedido)
                    {
                        if (cont % 2 == 0)
                            sw.WriteLine("<tr class='table-primary'>");
                        else sw.WriteLine("<tr class='table-info'>");
                        sw.WriteLine("<td align='left' width='30px'>" + pedido.idPedido + "</td>");
                        sw.WriteLine("<td align='left' width='30px'>" + pedido.cliente + "</td>");
                        sw.WriteLine("<td align='left' width='30px'>" + pedido.produto + "</td>");
                        sw.WriteLine("<td align='left' width='100px'>" + string.Format("{0:C2}", pedido.dataPedido + "</td>"));
                        sw.WriteLine("</tr>");
                        somaGeral = somaGeral + cont;
                        cont++;
                    }
                    sw.WriteLine("</table>");
                    sw.WriteLine("<hr align='left' border:'5px' />");
                    sw.WriteLine("<h2>Total de Registros impressos " + cont + "</h2>");
                    sw.WriteLine("</body>");
                    sw.WriteLine("</html>");

                }
                System.Diagnostics.Process.Start(arquivo);
            }


        }
    }


