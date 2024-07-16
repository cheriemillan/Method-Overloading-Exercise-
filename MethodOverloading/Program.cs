namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        public static double? Add(double num1, double num2)
        {
            double result = num1 + num2;
            return result;
        }

        public static string Add(int num1, int num2, bool answer)
        {
            var result = num1 + num2;
            if (answer == true && result > 1)
            {
                return $"{result} dollars";
                
            } else if (answer == true && result == 1)
            {
                return $"{result} dollar";
            }
            else
            {
                return "Wrong amount or no money";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 3) + " dollars");
            Console.WriteLine(Add(3.5, 1.4) + " dollars");
            Console.WriteLine(Add(3, 2, true));
    }
    }
}
