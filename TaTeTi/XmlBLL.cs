using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaTeTi.Xml;

namespace TaTeTi
{
    public class XmlBLL
    {
        public string RutaArchivo { get; set; }

        public XmlBLL(string rutaArchivo)
        {
            RutaArchivo = rutaArchivo;
        }

        public void GuardarXML<T>(T entidad)
        {
            using(FileStream filestream = new FileStream(RutaArchivo, FileMode.Create))
            {
               
            }
        }

    }
}
