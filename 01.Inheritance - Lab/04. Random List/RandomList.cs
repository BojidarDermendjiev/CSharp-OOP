namespace CustomRandomList
{
    using System;
    using System.Collections.Generic;
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(this.Count);
            string removed = this[index];
            this.RemoveAt(index);
            return removed;
        }
    }
}
