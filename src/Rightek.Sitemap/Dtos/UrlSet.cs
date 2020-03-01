using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rightek.Sitemap.Dtos
{
    [XmlRoot("urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class UrlSet
    {
        [XmlElement("url")]
        public List<Url> Items { get; set; } = new List<Url>();
    }
}