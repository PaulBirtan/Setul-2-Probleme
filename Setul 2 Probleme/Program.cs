using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Setul_2_Probleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Problema dorita: ");
            int prob = int.Parse(Console.ReadLine());
            while (prob != 0)
            {
                switch (prob)
                {
                    case 1:
                        Problema1();
                        break;
                    case 2:
                        Problema2();
                        break;
                    case 3:
                        Problema3();
                        break;
                    case 4:
                        Problema4();
                        break;
                    case 5:
                        Problema5();
                        break;
                    case 6:
                        Problema6();
                        break;
                    case 7:
                        Problema7();
                        break;
                    case 8:
                        Problema8();
                        break;
                    case 9:
                        Problema9();
                        break;
                    case 10:
                        Problema10();
                        break;
                    case 11:
                        Problema11();
                        break;
                    case 12:
                        Problema12();
                        break;
                    case 13:
                        Problema13();
                        break;
                    case 14:
                        Problema14();
                        break;
                    case 15:
                        Problema15();
                        break;
                    case 16:
                        Problema16();
                        break;
                    case 17:
                        Problema17();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;
                }
                prob = int.Parse(Console.ReadLine());
            }
        }

        private static void Problema1()
        {
            int n, i, nr = 0, x;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine()); //Se scrie numarul de la tastatura si apoi enter, apoi repetati
                if (x % 2 == 0)
                    nr++;
            }
            Console.Write($"Sunt {nr} numere pare");
            Console.ReadKey();
        }

        private static void Problema2()
        {
            int n, i, neg = 0, poz = 0, zero = 0, x;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine()); //citire nr + enter, repetati
                if (x < 0)
                    neg++;
                if (x > 0)
                    poz++;
                if (x == 0)
                    zero++;

            }
            Console.WriteLine($"Sunt {neg} numere negative");
            Console.WriteLine($"Sunt {poz} numere pozitive");
            Console.WriteLine($"Sunt {zero} zerouri");
            Console.ReadKey();
        }

        private static void Problema3()
        {
            int n, i, s = 0, p = 1;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                s = s + i;
                p = p * i;
            }
            Console.WriteLine($"Suma este = {s}");
            Console.WriteLine($"Produsul este = {p}");
            Console.ReadKey();
        }

        private static void Problema4()
        {
            int n, i, x, a, p=-1;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.Write($"a = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                    p = i;
            }
            Console.Write($"{a} se afla pe pozitia {p}");
            Console.ReadKey();
        }

        private static void Problema5()
        {
            int n, i, x, nr=0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i)
                    nr++;
            }
            Console.Write($"Sunt {nr} elemente egale cu pozitia pe care apar in secventa");
            Console.ReadKey();
        }

        private static void Problema6()
        {
            int n, i, x, y=0;
            bool ok = true;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (i == 0)
                    y = x;
                if (y > x)
                    ok = false;
                y = x;
            }
            if (ok == true)
                Console.Write($"Numerele din secventa sunt in ordine crescatoare");
            else
                Console.Write($"Numerele din secventa nu sunt in ordine crescatoare");
            Console.ReadKey();
        }

        private static void Problema7()
        {
            int n, i, x, max=0, min=0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    max = x;
                    min = x;
                }
                if (x > max)
                    max = x;
                if (x < min)
                    min = x;
            }
            Console.WriteLine($"Cea mai mare valoare din secventa este: {max}");
            Console.WriteLine($"Cea mai mica valoare din secvetan este: {min}");
            Console.ReadKey();
        }

        private static void Problema8()
        {
            int n, i, f1=0, f2=1, fn=0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            for (i = 2; i < n; i++)
            {
                fn = f1 + f2;
                f1 = f2;
                f2 = fn;
            }
            Console.Write($"Al n-lea numar din sirul lui Fibonacci este {fn}");
            Console.ReadKey();
        }

        private static void Problema9()
        {
            int n, i, x, y;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            bool cresc = false, descresc = false;
            Console.WriteLine($"Numerele din secventa sunt: ");
            y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != y)
                {
                    if (x > y)
                        cresc = true;
                    else
                        descresc = true;
                    y = x;
                }
            }
            if (cresc && descresc)
                Console.WriteLine($"Nu e monotona");
            else
                Console.WriteLine($"E monotona");
            Console.ReadKey ();
        }

        private static void Problema10()
        {
            int n, i, x, y, nrmax=0, nr=1;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            y = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x != y)
                    nr = 1;
                if (x == y)
                    nr++;
                if (nr > nrmax)
                    nrmax = nr;
                y = x;
            }
            Console.Write($"Numarul maxim de numere consecutive egale este: {nrmax}");
            Console.ReadKey();
        }

        private static void Problema11()
        {
            int n, i;
            double x, s = 0;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = double.Parse(Console.ReadLine());
                s = s + (1 / x);
            }
            Console.Write($"Suma inverselor numerelor este {s}");
            Console.ReadKey();
        }

        private static void Problema12()
        {

        }

        private static void Problema13()
        {
            
        }

        private static void Problema14()
        {
            
        }

        private static void Problema15()
        {
            
        }

        private static void Problema16()
        {
            
        }

        private static void Problema17()
        {
            int n, i, x, nr0=0, nr1=0, nivmax=0;
            bool ok = true;
            Console.Write($"n = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Numerele din secventa sunt: ");
            for (i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                    nr0++;
                if (x == 1)
                    nr1++;
                if (nr1 > nr0)
                    ok = false;
                if (nr0 - nr1 > nivmax)
                    nivmax = nr0 - nr1;
            }
            if (nr0 != nr1)
                ok = false;
            if (ok)
                Console.WriteLine($"Secventa este corecta");
            else
                Console.WriteLine($"Secventa nu este corecta");
            Console.WriteLine($"Nivelul maxim de incubare este: {nivmax}");
            Console.ReadKey();
        }
    }
}

