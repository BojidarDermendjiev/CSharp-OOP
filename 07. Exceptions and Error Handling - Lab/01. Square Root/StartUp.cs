namespace _01._Square_Root
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            int readNumberFromConsole = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(CheckingNnumberIsNegativeAndReturnSqrt(readNumberFromConsole));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }
        private static int CheckingNnumberIsNegativeAndReturnSqrt(int readNumberFromConsole)
            => readNumberFromConsole < 0 ? throw new ArgumentException("Invalid number.") : (int)Math.Sqrt(readNumberFromConsole);
    }
    }
}
