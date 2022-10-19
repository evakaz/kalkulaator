
using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulaator_console
{
    class Calculator
    {
        public double Liita(double arv1, double arv2)
            {
            double result = arv1 + arv2;
            return result;
            }

        public double Lahuta(double arv1, double arv2)
        {
            double result = arv1 - arv2;
            return result;
        }

        public double Korruta(double arv1, double arv2)
        {
            double result = arv1 * arv2;
            return result;
        }

        public double Jaga(double arv1, double arv2)
        {
            double result = arv1 / arv2;
            return result;
        }
    }
}
