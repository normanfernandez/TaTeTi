using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TaTeTi.Xml
{
    public static class XmlSudaca
    {

        public static T Deserialize<T>(string xml)
        {
            TextReader reader = new StringReader(xml);
            XmlSerializer s = new XmlSerializer(typeof(T));
            return (T)s.Deserialize(reader);
        }


        public static string Serialize<T>(T obj)
        {
            XmlSerializer s = new XmlSerializer(typeof(T));
            MemoryStream ms = new MemoryStream();
            s.Serialize(ms, obj);
            return Encoding.ASCII.GetString(ms.ToArray());
        }
    }
}
