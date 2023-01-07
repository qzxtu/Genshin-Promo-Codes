using HtmlAgilityPack;

namespace WebScraper
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var html = @"https://genshin-impact.fandom.com/wiki/Promotional_Code";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument htmlDoc = web.Load(html);
            var nodesu2 = from nodeuSE in htmlDoc.DocumentNode.Descendants("tr")
                          select nodeuSE;

            foreach (var tr in htmlDoc.DocumentNode.Descendants().Where(x => x.Name == "tr"))
            {
                foreach (var td in tr.Descendants().Where(x => x.Name == "code"))
                    Console.WriteLine(td.InnerText.Trim());
            }
        }
    }
}