using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using HtmlAgilityPack;

namespace Clases
{
    public class WebScraper
    {
        string url;
        HttpClient cliente;
        Task<string> html;
        HtmlDocument documento;
        public WebScraper(string url)
        {
            this.url = url;
            cliente = new HttpClient();
            try
            {
                var htmlReq = cliente.GetStringAsync(url);
                documento = new HtmlDocument();
                documento.LoadHtml(htmlReq.Result);
            }
            catch(Exception ex)
            {
                if(ex is System.AggregateException)
                {
                    //if(exc is HttpRequestException || exc is HtmlWebException)
                    //{
                    throw new WebsiteWasNotFoundException("The website " + url + " could not be reached");
                    //}
                }
            }
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
            string botVersion;
            return documento.GetElementbyId(id).InnerText;
        }
    }
}
