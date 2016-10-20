using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            double J = 1, N = 0, M = N;           
            Random a = new Random();
            List<double> experiment = new List<double>{ 1, 2, 3, 4, 5, 10, 25, 50, 100, 1000, 10000 };
            while (true)
            {
                N++;                
                if (a.NextDouble() > (N / 365))
                    continue;
                M += N + 1;
                if(experiment.Contains(J))
                    Console.WriteLine("{0} {1} {2}", J, N + 1, M / J);
                if (experiment.Last() == J)
                    break;
                N = 0;
                ++J;
            }
        }
    }
}
