using Rightek.Sitemap.Dtos;
using Rightek.Sitemap.Interfaces;
using Rightek.Sitemap.Internals;

namespace Rightek.Sitemap
{
    public class SitemapGenerator : ISitemapGenerator
    {
        public string GetXml(UrlSet urlSet) => Helper.GetXml(urlSet);

        public string GetXml(SiteMapIndex siteMapIndex) => Helper.GetXml(siteMapIndex);
    }
}