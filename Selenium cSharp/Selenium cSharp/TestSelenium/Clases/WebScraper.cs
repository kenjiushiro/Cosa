using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronWebScraper;

namespace Clases
{
    class WebScraper
    {
        WebScraper scraper;
        
        public WebScraper()
        {
            scraper = new WebScraper();
        }

        public string paginaWeb(string url)
        {
            ScrapedData data = new ScrapedData();
            Request request = new Request();
            request.Url = url;
            return "asd";
        }


    }
}
