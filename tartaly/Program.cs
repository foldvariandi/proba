using System;

namespace tartaly
{
    class Program
    { 
        Console.WriteLine("Szia User");

        static double korTerulete(double sugar)
        {
            double terulet = Math.Pow(sugar, 2) * Math.PI;
            return terulet;
        }

        static double palastTerulete(int magassag, double sugar)
        {
            return 2 * magassag * sugar * Math.PI;
        }

        static double hengerFelszine(int magassag, double sugar)
        {
            return 2 * korTerulete(sugar) + palastTerulete(magassag, sugar); 
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Milyen magas?");
            int magassag;
            magassag = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Mekkora az átmérője?");
            double sugar;
            sugar = Convert.ToInt32(Console.ReadLine())/2;

            //Itt számoljuk ki a kör területét
            //double kor = Math.Pow(sugar, 2) * Math.PI;
            /*double kor = korTerulete(sugar);

            //Itt számoljuk ki a palást területét
            double palast = palastTerülete(magassag, sugar);
            */

            //Itt számoljuk ki a henger felszínét
            double felszin = hengerFelszine(magassag, sugar);

            //Ennyi doboz festék kell
            double doboz = Math.Ceiling(felszin /2);
            Console.WriteLine("{0} doboz festéket kell vásárolni!", doboz);



            Console.ReadKey();
        }
    }
}
