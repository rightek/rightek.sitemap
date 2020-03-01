using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rightek.Sitemap.Dtos
{
    [XmlRoot("sitemapindex", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    public class SiteMapIndex
    {
        [XmlElement("sitemap")]
        public List<Sitemap> Items { get; private set; } = new List<Sitemap>();
    }
}