using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XMLSerialization.MeuXML;

namespace XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            CoisaEmXML Coiso = new CoisaEmXML();

            Coiso.Nome = "Christian";
            Coiso.Idade = 35;

        }
    }
}
