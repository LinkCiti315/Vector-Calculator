using System;

namespace Vector_Calculator
{
    class Program
    {
        Vector userInput = InputVector();
        static void Main(string[] args)
        {
            Vector test1 = new Vector(1, 2, 3);
            Vector test2 = new Vector(-1, 2, -3);

            // This should be 0, 4, 0
            Console.WriteLine(test1.ToString());
            Console.WriteLine(test1.GetMagnitude());
            Console.WriteLine(test1.GetDirection());
            Console.WriteLine(test1.Add());
            Console.WriteLine(test1.Negate());
            Console.WriteLine(test1.GetMagnitude());
        }

        static Vector InputVector()
        {
            string UserInput = Console.ReadLine();
            float x = Convert.ToInt32(UserInput.Split(",")[0]);
            float y = Convert.ToInt32(UserInput.Split(",")[1]);
            float z = Convert.ToInt32(UserInput.Split(",")[2]);
        }

        static void Scaler()
        {
            string UserScaler = Console.ReadLine();

            double UserScalerInt = Convert.ToInt32(UserScaler);
        }
    }
}
