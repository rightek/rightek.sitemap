using System;
using System.Xml.Serialization;

namespace Rightek.Sitemap.Dtos
{
    public class Sitemap
    {
        [XmlElement("loc")]
        public string Location { get; set; }

        [XmlElement("lastmod")]
        public DateTime? LastModified { get; set; }

        public bool ShouldSerializeLastModified() { return LastModified.HasValue; }
    }
}