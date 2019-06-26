using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace PASTELARIA.Relatorio
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string folder = @"c:\Relatorio";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }
    }
}
