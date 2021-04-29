class Class1
        {
            public static Tuple<double, double> Calculator(double a, double b)//declare type of tupple
            {
                return new Tuple<double, double>((a + b), (a * b));//declare number and value of tupple
            }
            static void Main(string[] args)
            {
                Tuple<double, double> output = Class1.Calculator(3.5, 2.0);
                Console.WriteLine("Sum = " + output.Item1 + "Multiplication Value= " + output.Item2);
                Console.ReadLine();
            }
        }