using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cafeineApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("somme de petite piece");
            double terasomme = double.Parse(Console.ReadLine());
            Console.WriteLine("nombre d'annees argent");
            double megaannees = double.Parse(Console.ReadLine());
            Console.WriteLine("toux d'interet");
            double interressement = double.Parse(Console.ReadLine());

            double simplet = terasomme * (1 + megaannees * interressement);
            double composer = terasomme * Math.Pow((1 + interressement), megaannees);

            Console.WriteLine("le bif a ete fructifier de " + terasomme + " a " + simplet +
                " pendant " + megaannees + " annees avec interet simple");
            Console.WriteLine("le bif a ete fructifier de " + terasomme + " a " + composer +
                " pendant " + megaannees + " annees avec interet simple");
            Console.ReadKey();
        }
    }
}
