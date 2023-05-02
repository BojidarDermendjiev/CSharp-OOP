namespace _04._Sum_of_Integers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    public class StartUp
    {
        static void Main()
        {
            int sum = default;
            Queue<string> elements = new Queue<string>(Console.ReadLine().Split());
            while (elements.Any())
            {
                int number = default;
                string element = elements.Dequeue();
                try
                {
                    number = int.Parse(element);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{element}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{element}' is out of range!");
                }
                sum += number;
                Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
            }
            Console.WriteLine($"The total sum of all integers is: {sum}");
        }
    }
}
