using Rightek.Sitemap.Dtos;

namespace Rightek.Sitemap.Interfaces
{
    public interface ISitemapGenerator
    {
        string GetXml(UrlSet urlset);
    }
}