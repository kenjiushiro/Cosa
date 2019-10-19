using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUGUS
{
    public class MyScheduling : Chrome
    {
        public MyScheduling(string chromedriverPath) : base(chromedriverPath)
        {
        }

        public MyScheduling(string chromedriverPath, string url) : base(chromedriverPath, url)
        {
        }
    }
}
