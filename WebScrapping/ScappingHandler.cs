using HtmlAgilityPack;
using System.Net;

namespace WebScrapping
{
    public class ScappingHandler
    {
        public static string Search(string param)
        {
            string res = string.Empty;
            string url = "https://www.google.com/search?q=" + Uri.EscapeDataString(param);

            using(WebClient client = new WebClient())
            {
                string html = client.DownloadString(url); //Descarga el html temporalmente
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                HtmlNodeCollection nodos = doc.DocumentNode.SelectNodes("//div[@class='BNeawe s3v9rd AP7Wnd']"); //Busca por la clase seleccionada de la web, cambiarla en base a la misma.

                if(nodos != null && nodos.Count > 0)
                {
                   string result = string.Empty;

                    foreach (HtmlNode node in nodos)
                    {
                        result += node.InnerText.Trim() + ". \n ";
                    }
                    res = result;
                }
                else
                {
                    res = "No se encontraron resultados";
                }
            }

            return res;
        }
    }
}