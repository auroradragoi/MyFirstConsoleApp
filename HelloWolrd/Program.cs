using System;

namespace HelloWolrd
{
   /*class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }*/
    public class Asignare
    {
        public static void Main(string[] args)
        {
            int a = 3;
            int b = (a = 2) * a;
            int c = b * (b = 5);
            Console.WriteLine("a="+a + ", b="+b + ", c="+c);
            /*programul afiseaza: a = 2 deoarece a fost reinitializat la declararea lui b;
            b=5 deoarece a fost reinitializat la declararea lui c;
            c= 20 deoarece primul "b" are valoarea 4, iar al doilea are valoarea 5
            */

            double d = 2.95;
            int i = 4;
            Console.WriteLine(++d > i ? d : i);
            /*Aceasta instructiune se compileaza deoarece este un "If" scurt.
            Instructiunea verifica daca d>i, iar cum aceasta afirmatie este falsa, va afisa valoarea din else, adica valoarea lui i = 4*/

            int e = 3;
            if (++e < 4)
                if (e++ < 4)
                    Console.WriteLine(e);
                else
                    Console.WriteLine(e);
            //Acest subprogram nu va afisa nimic doarece compara daca 4<4, ceea ce este fals, iar cazul de else nu este tratat
            
            int suma = 0;
            for (int g = 1; g < 10; g++)
            {
                suma = suma + g;
            }
            Console.WriteLine("Suma este: " + suma);
            //suma este 45 Matematic putem aplica formula pentru primele n numere, n(n+1)/2 adica 9(10)/2

            //Factorialul unui numar
            int factorial = 1;
            for (int f = 1; f < 13; f++)
            {
                factorial *= f;
            }
            Console.WriteLine("Factorialul lui 12: " + factorial);

            //Aflarea minimului
            int x, y, z, min;
            x = 7;
            y = 5;
            z = 3;
            if (x < y)
                min = x;
            else
                min = y;
            if (z < min)
                min = z;
            Console.WriteLine("Minimul este " + min);

            //determinare daca un numar este par sau impar
            string valoare;
            int numar;
            Console.Write("Introduceti numarul, apoi apasati ENTER: ");
            valoare = Console.ReadLine();
            /* Converts to integer type */
            numar = Convert.ToInt32(valoare);
            if(numar%2 == 0)
                Console.WriteLine("Numarul {0} ", + numar+" este par");
            else
                Console.WriteLine("Numarul {0} ", + numar + " este impar");

            // Denumire pentru zilele saptamanii
            string zi;
            int numarZi;
            Console.Write("Introduceti numarul zilei, apoi apasati ENTER: ");
            zi = Console.ReadLine();
            numarZi = Convert.ToInt32(zi);
            switch (numarZi)
            {
                case 1: 
                    Console.WriteLine("Ziua {0}", + numarZi + " este luni");
                break;
                case 2:
                    Console.WriteLine("Ziua {0}", +numarZi + " este marti");
                break;
                case 3:
                    Console.WriteLine("Ziua {0}", +numarZi + " este miercuri");
                break;
                case 4:
                    Console.WriteLine("Ziua {0}", +numarZi + " este joi");
                break;
                case 5:
                    Console.WriteLine("Ziua {0}", +numarZi + " este vineri");
                break;
                case 6:
                    Console.WriteLine("Ziua {0}", +numarZi + " este sambata");
                break;
                case 7:
                    Console.WriteLine("Ziua {0}", +numarZi + " este duminica");
                break;
                default:
                    Console.WriteLine("Acest numar nu concordeaza cu una din zilele saptamanii");
                break;
            }
        }
    }





}
