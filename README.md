# Rightek.Sitemap
Simple sitemap generator. Image and SiteMapIndex are supported.

## Basic Usage
```cs
ISitemapGenerator sitemapGenerator = new SitemapGenerator();

var urlSet = new UrlSet();
urlSet.Items.Add(new Url
{
	ChangeFrequency = ChangeFrequency.monthly,
	Location = "http://example.com",
	LastModified = DateTime.Now.AddDays(-1),
	Priority = .5
});

var sitemap = sitemapGenerator.GetXml(urlset);
```
Output:
```xml
<?xml version="1.0" encoding="utf-16"?>
<urlset xmlns:image="http://www.google.com/schemas/sitemap-image/1.1" xmlns="http://www.sitemaps.org/schemas/sitemap/0.9">
  <url>
    <loc>http://example.com</loc>
    <lastmod>2020-02-29T12:49:29.1233504+03:30</lastmod>
    <changefreq>monthly</changefreq>
    <priority>0.5</priority>
  </url>
</urlset>
```

## Nuget [![nuget](https://img.shields.io/nuget/v/Rightek.Sitemap.svg?color=%23268bd2&style=flat-square)](https://www.nuget.org/packages/Rightek.Sitemap) [![stats](https://img.shields.io/nuget/dt/Rightek.Sitemap.svg?color=%2382b414&style=flat-square)](https://www.nuget.org/stats/packages/Rightek.Sitemap?groupby=Version)

`PM> Install-Package Rightek.Sitemap`

## License
MIT

---
Made with ♥ by people @ [Rightek](http://rightek.ir)
