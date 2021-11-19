using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LabTools
{
    public class XmlHelper<T>
    {

        private XElement XDoc { get; set; }

        public XmlHelper(TextReader reader)
        {
            XDoc = XElement.Parse(reader.ReadToEnd());
        }

        public XmlHelper(XmlReader reader)
        {
            XDoc = XElement.Load(reader);
        }

        public XmlHelper(T xmlEntity)
        {
            if (xmlEntity == null)
            {
                throw new ArgumentNullException();
            }

            XmlSerializer xs = new XmlSerializer(xmlEntity.GetType());
            var writer = new Utf8StringWriter();
            xs.Serialize(writer, xmlEntity);
            string xmlStr = writer.ToString();
            XDoc = XElement.Parse(xmlStr);
        }
        /// <summary>
        /// 修改元素
        /// </summary>
        /// <param name="element">元素名</param>
        /// <param name="value">值</param>
        /// <param name="xmlNamespace">命名空间</param>
        public void ModifyElement(string element, string value, string xmlNamespace = null)
        {
            if (string.IsNullOrEmpty(xmlNamespace))
            {
                var xElement = XDoc.Element(element);
                xElement.Value = value;
            }
            else
            {
                XNamespace ns = xmlNamespace;
                var xElement = XDoc.Element(ns + element);
                xElement.Value = value;
            }
        }

        public override string ToString() => XDoc.ToString();

        public virtual T ToObject()
        {

            TextReader reader = new StringReader(XDoc.ToString());
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T obj = (T)ser.Deserialize(reader);
            return obj;
        }

        public static T ConvertXmlToObject(XmlReader reader)
        {
            XmlSerializer ser = new XmlSerializer(typeof(T));
            T obj = (T)ser.Deserialize(reader);
            return obj;
        }

        public static string ConvertObjectToXmlString(T obj)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            var writer = new Utf8StringWriter();
            xs.Serialize(writer, obj);
            return writer.ToString();
        }
        /// <summary>
        /// 修改元素
        /// </summary>
        /// <param name="reader">xml</param>
        /// <param name="element">元素</param>
        /// <param name="value">值</param>
        /// <param name="xmlNamespace">命名空间</param>
        /// <returns>xml字符串</returns>
        public static string ModifyElement(XmlReader reader, string element, string value, string xmlNamespace = null)
        {
            var doc = XElement.Load(reader);
            if (string.IsNullOrEmpty(xmlNamespace))
            {
                var xElement = doc.Element(element);
                xElement.Value = value;
            }
            else
            {
                XNamespace ns = xmlNamespace;
                var xElement = doc.Element(ns + element);
                xElement.Value = value;
            }
            return doc.ToString();
        }
    }
}
