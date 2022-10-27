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
            Console.WriteLine("Sisesta arv1: ");
            arv1AsString = Console.ReadLine();
            try
            {
                arv1 = double.Parse(arv1AsString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Sisesta arv2: ");
            arv2AsString = Console.ReadLine();
            try
            {
                arv2 = double.Parse(arv2AsString);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Sisesta tehe: ");
            teheAsString = Console.ReadLine();
            try
            {
                var result = Calculator.calc2(teheAsString, arv1, arv2);
                Console.WriteLine(result);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
