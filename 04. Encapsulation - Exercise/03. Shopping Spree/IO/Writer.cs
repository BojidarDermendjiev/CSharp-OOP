namespace _03._Shopping_Spree.IO
{
    using Contracts;
    public class Writer : IWriter
    {
        public void Write(string value)
        {
            System.Console.Write(value);
        }

        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }
    }
}
