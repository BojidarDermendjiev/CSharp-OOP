namespace CustomStack
{
    using System;
    public class StartUp
    {
        static void Main()
        {
            StackOfStrings stack = new StackOfStrings();
            stack.IsEmpty();
            stack.AddRange(new string[] { "1", "2", "3", "4", });
        }
    }
}
