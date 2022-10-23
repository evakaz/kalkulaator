using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulaator_console
{
    public delegate double PerformCalculation(double arv1, double arv2);

    class Calculator
    {
/*
        IDictionary<string, PerformCalculation> operations;
        public Calculator()
        {
            this.operations = new Dictionary<string, PerformCalculation>();
            this.operations.Add("+", (double arv1, double arv2) => { return arv1 + arv2; });
            this.operations.Add("-", (double arv1, double arv2) => { return arv1 - arv2; });
            this.operations.Add("*", (double arv1, double arv2) => { return arv1 * arv2; });
            this.operations.Add("/", (double arv1, double arv2) => { return arv1 / arv2; });
        }

        public double calc(string operation, double arv1, double arv2)
        {
            PerformCalculation action;
            if (this.operations.TryGetValue(operation, out action))
            {
                return action(arv1, arv2);
            }

            throw new ApplicationException("Not supported operation");
        }
*/
        public static double calc2(string operation, double arv1, double arv2)
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

            throw new ApplicationException("Not supported operation");
        }
    }
}
