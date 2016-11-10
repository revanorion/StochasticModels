using System;
using System.Collections.Generic;
namespace MG1Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            calculate();
        }
        public static void calculate()
        {
            double c = 0.0, T = 0.0, W = 0.0, X = 0.0, SW = 0.0, SX = 0.0;
            Random R = new Random();
            List<double> t = new List<double> { -1.00, 0.0, 0.5, 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0 };
            List<double> cs = new List<double> { 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0, 0.0 };
            for (var i = 1; i < 100000; i++)
            {
                var IA = -.625 * Math.Log(1 - R.NextDouble());
                T += IA;
                W += X - IA;
                if (W < 0) W = 0;
                if (W > 0) ++c;
                SW += W;
                //Case 1
                //X = case1(R);
                //Case 2
                //X = case2(R);
                //Case 3
                //X = case3(R);
                //Case 4
                X = case4(R);
                foreach (double g in t)
                    if (W <= g)
                        cs[t.FindIndex(k => k == g)]++;
                SX += X;
            }
            Console.WriteLine("{0} {1} {2}", SX / T, c / 100000, SW / 100000);
            Console.WriteLine();
            foreach (double g in cs)
                Console.Write("{0} ", g / 100000.0);
            Console.WriteLine();
            Console.Write("0 ");
            for (int j = 0; j <= 12; j++)
                Console.Write("{0} ", (1 - .8 * Math.Exp(-.4 * j)).ToString("#.#####"));
        }
        static double case1(Random R) { return -.5 * Math.Log(1 - R.NextDouble()); }
        static double case2(Random R) { return 0.5; }
        static double case3(Random R) { return R.NextDouble(); }
        static double case4(Random R)
        {
            var r = R.NextDouble();
            if (r <= 0.9)
                return (1.0 / 3.0);
            else if (r > .9)
                return 2.0;
            return 0.0;
        }
    }
}
