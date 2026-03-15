using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1[] s = new Class1[] {
                new Class1("Andrei","1049",5,7),
                new Class1("Alex", "1050", 6, 4),
                new Class1("Maria","1049",9,2),
                new Class1("Silvia","1060",7,null)

            };
            double sumaMedii = 0;
            int promovati = 0;
           foreach (Class1 c in s)
            {
                c.Afiseaza();
                double medieSimpla = c.Medie ?? 0;
                sumaMedii += medieSimpla;
                if (medieSimpla >= 5) promovati++;
            }
            Console.WriteLine($"Nr de studenti care au promovat este: {promovati}");
            Console.WriteLine($"Media generala este: {sumaMedii / s.Length}");
        }
    }
} 

