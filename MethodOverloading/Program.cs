namespace MethodOverloading
{
    public class Program
    {
        public static int? Add(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"{result} dollars");
            return null;
        }

        public static double? Add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine($"{result} dollars");
            return null;
        }

        public static string Add(int num1, int num2, bool answer)
        {
            int result = num1 + num2;
            if (answer == true)
            {
                Console.WriteLine($"{result} dollars");
            } else if ( result == 1)
            {
                Console.WriteLine($"{result} dollar");
            }
            else
            {
                Console.WriteLine("Wrong amount");
            }

            return null;
        }
        static void Main(string[] args)
        {
            Add(1,3);
            Add(3.5, 1.4);
            Add(3, 2, true);
        }
    }
}
