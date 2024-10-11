using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feladat2
{
    internal class Program
    {
        static void koszones()
        {

            string reggel = "szép reggelt";
            string del = "Szép delet";
            string delutan = "szép délutánt";
            string este = "szép estét";
            string hajnal = "szép hajnalt";
            Console.WriteLine(DateTime.Now);

            int napszak = DateTime.Now.Hour + 12;
            if (napszak >= 6 && napszak <= 12) Console.WriteLine(reggel);
            if (napszak == 12) Console.WriteLine(del);
            if (napszak > 12 && napszak <= 18) Console.WriteLine(delutan);
            if (napszak > 18 && napszak <= 24) Console.WriteLine(este);
            if (napszak > 0 && napszak < 6) Console.WriteLine(hajnal);
        }
        static void Main(string[] args)
        {
            koszones();

        }
    }
}