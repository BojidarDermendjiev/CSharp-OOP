namespace _05._Play_Catch
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        static Action<int[]> print = elements => Console.WriteLine(string.Join(", ", elements));
        static void Main()
        {
            int countOfExceptions = default;
            var arrayOfNumbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            while (countOfExceptions < 3)
            {
                var inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (inputLine[0])
                    {
                        case "Replace":
                            Replace(arrayOfNumbers, int.Parse(inputLine.Skip(1).First()), int.Parse(inputLine.Last()));
                            break;
                        case "Print":
                            Print(arrayOfNumbers, int.Parse(inputLine.Skip(1).First()), int.Parse(inputLine.Last()));
                            break;
                        case "Show":
                            Show(arrayOfNumbers, int.Parse(inputLine.Last()));
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    countOfExceptions++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    countOfExceptions++;
                }
            }
            print(arrayOfNumbers);
        }
        private static void Replace(int[] arrayOfNumbers, int index, int replaceElement)
            => arrayOfNumbers[index] = replaceElement;
        private static void Print(int[] arrayOfNumbers, int startIndex, int endIndex)
        {
            Queue<int> elements = new Queue<int>();
            for (int currentElementIndex = startIndex; currentElementIndex <= endIndex; currentElementIndex++)
                elements.Enqueue(arrayOfNumbers[currentElementIndex]);
            print(elements.ToArray());
        }
        private static void Show(int[] arrayOfNumbers, int indexForShow)
            => Console.WriteLine(arrayOfNumbers[indexForShow]);
    }
}
