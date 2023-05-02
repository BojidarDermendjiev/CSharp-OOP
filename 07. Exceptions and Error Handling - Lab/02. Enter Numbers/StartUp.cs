namespace _02._Enter_Numbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            var dateForNumber = new List<int>();
            while (dateForNumber.Count < 10)
            {
                try
                {
                    if (!dateForNumber.Any())
                        dateForNumber.Add(ChekingNumberIsOutOfRangeOrNegative(1, 100));
                    else
                        dateForNumber.Add(ChekingNumberIsOutOfRangeOrNegative(dateForNumber.Max(), 100));
                }
                catch (FormatException fe)
                {
                    Console.WriteLine(fe.Message);
                }
                catch (AouOfRangeException aore)
                {
                    Console.WriteLine(aore.Message);
                }
            }
            Console.WriteLine(string.Join(", ", dateForNumber));
        }

        private static int ChekingNumberIsOutOfRangeOrNegative(int start, int end)
        {
            string inputLine = Console.ReadLine();
            int numberFromConsole;
            try
            {
                numberFromConsole = int.Parse(inputLine);
            }
            catch (FormatException)
            {
                throw new FormatException("Invalid Number!");
            }
            if (numberFromConsole <= start || end <= numberFromConsole)
                throw new AouOfRangeException($"Your number is not in range {start} - {end}!");
            return numberFromConsole;
        }
    }
    public class AouOfRangeException : Exception
    {
        public AouOfRangeException(string message) : base(message) { }
    }
}
