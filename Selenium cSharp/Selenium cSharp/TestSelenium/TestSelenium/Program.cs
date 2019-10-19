using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;
using System.Text.RegularExpressions;



namespace TestSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = "[0-9]{2}-[0-9]{2}-[0-9]{4}";
            string input;
            string fecha;
            input = Console.ReadLine();

            Match m = Regex.Match(input, pattern);
            //fecha = Regex.Replace(input, pattern,);
            Console.WriteLine(m.ToString());
            Console.ReadKey();
        }
    }
}
