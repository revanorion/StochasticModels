using System;

namespace CentralLimitTheorem
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, z;
            for (z = 0; z < 3; z++)
            {
                Console.Write("Input n: ");
                int.TryParse(Console.ReadLine(), out n);
                calculate(n);
            }
            Console.WriteLine();
        }

        public static void calculate(int n)
        {
            Random R = new Random();
            int i = 1, j=1;
            double c = 0.0;
            for (i=1; i < 1000;i++)
            {
                double S=0.0, X = 0.0;
                for (j=1; j <= n; j++)
                {

                    //case 1
                    //X = case1(R);

                    //case 2
                    //X = case2(R);

                    //case 3
                    X = case3(R);


                    S = S + X;
                }
                if ((S / n > 0.45) && (S / n < 0.55))
                    c++;
            }
            Console.WriteLine("{0}", c / 1000);
            Console.WriteLine();
        }
        static double case1(Random R)
        {
            return R.NextDouble();
        }
        static double case2(Random R)
        {
            return -.5 * Math.Log(1 - R.NextDouble());
        }
        static double case3(Random R)
        {
            var r = R.NextDouble();
            if (r <= 0.8)
                return 0.2;
            else if (r > .8)
                return 1.7;
            return 0.0;
        }
    }
}
