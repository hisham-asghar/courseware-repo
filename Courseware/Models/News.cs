using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fizzler.Systems.HtmlAgilityPack;

namespace Courseware.Models
{
    public class News
    {
        public String Title { get; set; }
        public String Text { get; set; }
        public String Image { get; set; }
        public String Link { get; set; }

        public static String ConvertToText(HtmlAgilityPack.HtmlNode node)
        {
            String result = "";
            if (node != null & !String.IsNullOrEmpty(node.InnerText))
            {
                result = node.InnerText.Replace("\n", "").Replace("\r", "").Replace("&nbsp;", "").Trim();
            }
            return result;
        }
      
        public static List<News> GetNewsList(string url)
        {
            ScraperHelper.HttpRequestParam param = new ScraperHelper.HttpRequestParam();
            param.URL = url;
            String html = ScraperHelper.Helper.GetPagetHTML(param);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            doc.LoadHtml(html);

            var trs = doc.DocumentNode.QuerySelectorAll(".esc-default-layout-wrapper");
            string data = "";
            var listNews = new List<News>();
            foreach (var tr in trs)
            {
                News obj = new News();
                HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
                doc1.LoadHtml(tr.InnerHtml);
                var spn = doc1.DocumentNode.QuerySelectorAll("span.titletext").FirstOrDefault();
                obj.Title = ConvertToText(spn);
                data += obj.Title;
                data += ":\n";
                HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
                doc2.LoadHtml(tr.InnerHtml);
                spn = doc2.DocumentNode.QuerySelectorAll(".esc-lead-snippet-wrapper").FirstOrDefault();
                obj.Text = ConvertToText(spn);
                data += obj.Text;
                data += "\n";
                HtmlAgilityPack.HtmlDocument doc3 = new HtmlAgilityPack.HtmlDocument();
                doc3.LoadHtml(tr.InnerHtml);
                spn = doc3.DocumentNode.QuerySelectorAll(".esc-layout-thumbnail-cell a").FirstOrDefault();
                var x = spn.Attributes["href"].Value;
                data += x;
                obj.Link = x;
                data += "\n";
                HtmlAgilityPack.HtmlDocument doc4 = new HtmlAgilityPack.HtmlDocument();
                doc4.LoadHtml(tr.InnerHtml);
                spn = doc4.DocumentNode.QuerySelectorAll(".esc-layout-thumbnail-cell img").FirstOrDefault();
                if (spn != null)
                    foreach (var attr in spn.Attributes)
                    {
                        if (attr.Name.Contains("src"))
                        {
                            x = attr.Value;
                        }
                    }
                data += x;
                obj.Image = x;
                data += "\n\n";
                listNews.Add(obj);


            }
            return listNews;
        }
    }
}