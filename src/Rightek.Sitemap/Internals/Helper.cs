using System.IO;
using System.Xml.Serialization;

namespace Rightek.Sitemap.Internals
{
    internal static class Helper
    {
        public static string GetXml<T>(T o)
        {
            using (var sw = new StringWriter())
            {
                var ns = new XmlSerializerNamespaces();
                ns.Add("image", "http://www.google.com/schemas/sitemap-image/1.1");

                var xs = new XmlSerializer(typeof(T));
                xs.Serialize(sw, o, ns);

                return sw.ToString();
            }
        }
    }
}