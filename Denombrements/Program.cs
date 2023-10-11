using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        /* programme denombrements
         * permet de calculer les différents types de dénombrement
         * auteur : ?
         * date : 11/10/2023
         */
        static int NombreElements()
        {
            int nb = -1;
            while (nb < 0)
            {
                Console.Write("nombre total d'éléments à gérer = ");
                try
                {
                    nb = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Veuillez saisir un nombre entier positif.");
                }
            }
            return nb;
        }

        static int NombreElementsSousEnsemble(int n)
        {
            int nb = -1;
            while (nb < 0)
            {
                Console.Write("nombre d'éléments dans le sous-ensemble = ");
                try
                {
                    nb = int.Parse(Console.ReadLine());
                    if (nb > n)
                    {
                        Console.WriteLine("Ce nombre ne peut être supérieur à " + n);
                        nb = -1;
                    }
                }
                catch
                {
                    Console.WriteLine("Veuillez saisir un nombre entier positif.");
                }
            }
            return nb;
        }
        static void Main(string[] args)
        {
            int c = 1;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());

                if (c == 0) { Environment.Exit(0); }

                if (c == 1)
                {
                    int n = NombreElements();
                    // calcul de r
                    long r = 1;
                    for (int k = 1; k <= n; k++)
                        r *= k;
                    Console.WriteLine(n + "! = " + r);
                }
                else
                {
                    if (c == 2)
                    {
                        int t = NombreElements();
                        int n = NombreElementsSousEnsemble(t);
                        // calcul de r
                        long r = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r *= k;
                        Console.WriteLine("A(" + t + "/" + n + ") = " + r);
                    }
                    else
                    {
                        int t = NombreElements();
                        int n = NombreElementsSousEnsemble(t);
                        // calcul de r1
                        long r1 = 1;
                        for (int k = (t - n + 1); k <= t; k++)
                            r1 *= k;
                        // calcul de r2
                        long r2 = 1;
                        for (int k = 1; k <= n; k++)
                            r2 *= k;
                        Console.WriteLine("C(" + t + "/" + n + ") = " + (r1 / r2));
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
