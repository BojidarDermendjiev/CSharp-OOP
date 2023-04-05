namespace CustomStack
{
    using System.Collections.Generic;
    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
            => this.Count == 0;
        public void AddRange(IEnumerable<string> collection)
        {
            foreach (var element in collection)
                this.Push(element);
        }
    }
}
