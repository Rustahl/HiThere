using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace HiThere.Utilities
{
    public static class XmlSerializer<T> where T : class
    {
        public static XmlDocument Serialize(T theClass)
        {
            var memoryStream = new MemoryStream();
            var xs = new XmlSerializer(typeof(T));
            var xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);

            xs.Serialize(xmlTextWriter, theClass);
            memoryStream = (MemoryStream)xmlTextWriter.BaseStream;
            memoryStream.Position = 0;
            var document = new XmlDocument();
            document.Load(memoryStream);

            xmlTextWriter.Close();
            memoryStream.Close();
            memoryStream.Dispose();

            return document;
        }

        public static T Deserialize(TextReader fileStream)
        {
            var x = new XmlSerializer(typeof(T));
            var theClass = x.Deserialize(fileStream) as T;
            return theClass;
        }

        public static T Deserialize(MemoryStream memoryStream)
        {
            var x = new XmlSerializer(typeof(T));
            var theClass = x.Deserialize(memoryStream) as T;
            return theClass;
        }
    }
}
