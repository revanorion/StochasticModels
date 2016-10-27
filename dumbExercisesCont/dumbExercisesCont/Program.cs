using System;

namespace dumbExercisesCont
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
            for (var i = 1; i < z; i++)
            {
                //Case 1
                //double X1 = case1(R), X2 = case1(R);

                //Case 2
                //double X1 = case2(R), X2 = case2(R);

                //Case 3
                double X1 = case3(R), X2 = case3(R);

                //Case 4
                //double X1 = case4(R), X2 = case4(R);


                var Y = X1 + X2;
                S1 = S1 + Y;
                S2 = S2 + Math.Pow(Y, 2);
                if ((Y > a) && (Y <= b))
                    c = c + 1;
            }
            Console.WriteLine("{0} {1} {2}", S1 / 10000, (S2 / 10000 - Math.Pow(S1 / 10000, 2)), c / 10000);
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
            if (r <=1 && r>=0 )
                return Math.Sqrt(r);
            else if (r > 1)
                return 1;
            return 0.0;
        }
        static double case4(Random R)
        {
            var r = R.NextDouble();            
            if (r <= 0.8)
                return 0.4;
            else if (r > .8)
                return 0.9;
            return 0.0;
        }
    }
}
