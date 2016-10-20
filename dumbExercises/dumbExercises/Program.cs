using System;
using System.Collections.Generic;

namespace dumbExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            calculate(0.7, 1.5);
        }

        public static void calculate(double a, double b, int? z = 10000)
        {
            var S1 = 0.0;
            var S2 = 0.0;
            var c = 0.0;
            Random R = new Random();
            List<double> t = new List<double> { -0.25, 0.00, 0.25, 0.50, 0.75, 1.00, 1.25, 1.50 };
            List<double> cs = new List<double> { 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00, 0.00 };
            for (var i = 1; i < z; i++)
            {
                //Case 1
                //var X = R.NextDouble();

                //Case 2
                //var X = -.5 * Math.Log(1 - R.NextDouble());

                //Case 3
                //var X = 0.5;

                //Case 4
                var r = R.NextDouble();
                var X = 0.0;
                if (r <= 0.8)
                    X = 0.4;
                else if (r > .8)
                    X = 0.9;

                foreach (double g in t)
                    if (X <= g)
                        cs[t.FindIndex(k => k == g)]++;
                
                S1 = S1 + X;
                S2 = S2 + Math.Pow(X, 2);
                if ((X > a) && (X <= b))
                    c = c + 1;
            }
            Console.WriteLine("{0} {1} {2}", S1 / 10000, (S2 / 10000 - Math.Pow(S1 / 10000, 2)), c / 10000);
            foreach (double g in cs)
                Console.Write("{0} ", g/z);
            Console.WriteLine();
            foreach (double g in t)
                Console.Write("{0} ", (1 - Math.Pow(Math.E,-2*g)));
        }
    }
}
