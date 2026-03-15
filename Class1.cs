using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        string Nume { get; set; }
        string Grupa { get; set; }
        double? NotaExamen { get; set; }

        double? NotaLaborator { get; set; }

        public Class1(string nume, string grupa, double? notaExamen,double? notaLaborator)
        {
            Nume = nume;
            Grupa = grupa;
            NotaExamen = notaExamen;
            NotaLaborator = notaLaborator;
        }

        public double? Medie => (NotaExamen != null && NotaLaborator != null) ? (NotaExamen + NotaLaborator) / 2 : null;
        
        public void Afiseaza()
        {
            Console.WriteLine($"Studentul {Nume} are grupa {Grupa} , nota la examen: {NotaExamen ?? 0} si nota laborator: {NotaLaborator ?? 0}");
        }


    }
}
