using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Program
    {
           public static string minun_Oma_Nimi;
           public static string Minun_Oma_Nimi;

        static void Main(string[] args)
        {
            //Just a comment added
            int i = 5;

            Console.WriteLine("Hello World 6!");
            heiKnokker();
            HeiKnokker();
            minun_Oma_Nimi = "timo";
            Minun_Oma_Nimi = "Tomi";
            string kolmas = minun_Oma_Nimi + " " + Minun_Oma_Nimi;
            Console.ReadKey();
        }

        public static void heiKnokker()
        {

        }

        public static void HeiKnokker() { }

    }
}
