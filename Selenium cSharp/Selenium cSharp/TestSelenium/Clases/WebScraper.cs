using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace Clases
{
    public class WebScraper
    {
        string url;
        HttpClient cliente;
        Task<string> html;
        public WebScraper(string url)
        {
            this.url = url;
            cliente = new HttpClient();
        }

        public string Html
        {
            get
            {
                html = cliente.GetStringAsync(url);
                return html.Result;
            }
        }

        public string GetTextByID(string id)
        {
            var html = cliente.GetStringAsync(url);
            HtmlDocument documento = new HtmlDocument();
            documento.LoadHtml(html.Result);
            string botVersion;

          
            return documento.GetElementbyId(id).InnerText;
          

            

        }
        
    }
}
