using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Archivos.Excepciones;
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

        //public List<string> GetListByTag(string tagname)
        //{
        //    List<string> lista = new List<string>();
        //    //documento.

        //}


        public static void DownloadFile(string version,string filepath)
        {
            
            string urlAddress;
            filepath = Path.Combine(filepath, "chromedriverwin_32.rar");
            urlAddress = string.Format("http://chromedriver.storage.googleapis.com/{0}/chromedriver_win32.zip", version);
            using (WebClient clientD = new WebClient())
            {
                clientD.DownloadFile(urlAddress, filepath);
            };
        }
    }
}
