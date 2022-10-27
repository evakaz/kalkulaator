using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulaator_console
{
    public delegate double PerformCalculation(double arv1, double arv2);

    class Calculator
    {

        public static double calc2(string operation, double arv1, double arv2)
        {
            var operations = new Dictionary<string, PerformCalculation>();
            operations.Add("+", (double arv1, double arv2) => { return arv1 + arv2; });
            operations.Add("-", (double arv1, double arv2) => { return arv1 - arv2; });
            operations.Add("*", (double arv1, double arv2) => { return arv1 * arv2; });
            operations.Add("/", (double arv1, double arv2) => { 
                if (arv2 == 0)
                {
                    throw new DivideByZeroException("You cannot divide by zero.");
                }
                return arv1 / arv2; 
            });

            PerformCalculation action;
            if (operations.TryGetValue(operation, out action))
            {
                return action(arv1, arv2);
            }

            // when operation is not "+" "-" "*" "/"

            throw new ApplicationException("Not supported operation");
        }

        /*public static double? calc3(string operation, double arv1, double arv2)
        {
            var operations = new Dictionary<string, PerformCalculation>();
            operations.Add("+", (double arv1, double arv2) => { return arv1 + arv2; });
            operations.Add("-", (double arv1, double arv2) => { return arv1 - arv2; });
            operations.Add("*", (double arv1, double arv2) => { return arv1 * arv2; });
            operations.Add("/", (double arv1, double arv2) => { return arv1 / arv2; });

            PerformCalculation action;
            if (operations.TryGetValue(operation, out action))
            {
                return action(arv1, arv2);
            }
            else
            {
                return null;
            }
        }*/
    }
}
