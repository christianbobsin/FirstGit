using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerialization.MeuXML
{
    [XmlRoot( "root" )]
    public class CoisaEmXML
    {

        [XmlElement( "Nome")]
        public String Nome { get; set; }
        
        [XmlElement( "Idade")]
        public int Idade { get; set; }

    }
}
