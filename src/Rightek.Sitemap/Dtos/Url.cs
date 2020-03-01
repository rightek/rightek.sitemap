using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Rightek.Sitemap.Dtos
{
    public class Url
    {
        [XmlElement("loc")]
        public string Location { get; set; }

        [XmlElement("lastmod")]
        public DateTime? LastModified { get; set; }

        public bool ShouldSerializeLastModified() { return LastModified.HasValue; }

        [XmlElement("changefreq")]
        public ChangeFrequency? ChangeFrequency { get; set; }

        public bool ShouldSerializeChangeFrequency() { return ChangeFrequency.HasValue; }

        [XmlElement("priority")]
        public double? Priority { get; set; }

        public bool ShouldSerializePriority() { return Priority.HasValue; }

        [XmlElement("image", Namespace = "http://www.google.com/schemas/sitemap-image/1.1")]
        public List<Image> Images { get; set; }

        public bool ShouldSerializeImages() { return Images != null && Images.Count > 0; }
    }
}