//Luua konsoolirakendus, mis küsib sisse kaks arvu ning seejärel, mis tehe tende arvudega teha.
//Arvudega saab liita, lahutada, korrutada või jagada.
//Arvutused peavad toimuma eraldi klassis nimega: "Calculator", mida Program klassi Main meetod kasutab. 

using System;

namespace kalkulaator_console
{
    class Program
    {
        static void Main(string[] args)
        {
            string arv1AsString;
            string arv2AsString;
            double arv1 = 0;
            double arv2 = 0;
            string teheAsString;
            kalkulaator_console.Calculator calc = new Calculator();
            Console.WriteLine("Sisesta arv1: ");
            arv1AsString = Console.ReadLine();
            Console.WriteLine("Sisesta arv2: ");
            arv2AsString = Console.ReadLine();
            Console.WriteLine("Sisesta tehe: ");
            teheAsString = Console.ReadLine();
            arv1 = double.Parse(arv1AsString);
            arv2 = double.Parse(arv2AsString);
            if (teheAsString == "+")
            {
                Console.WriteLine(calc.Liita(arv1, arv2));
            }

            if (teheAsString == "-")
            {
                Console.WriteLine(calc.Lahuta(arv1, arv2));


            }

            if (teheAsString == "*")
            {
                Console.WriteLine(calc.Korruta(arv1, arv2));
            }

            if (teheAsString == ":")
            {
                Console.WriteLine(calc.Jaga(arv1, arv2));
            }

        }
    }
}
