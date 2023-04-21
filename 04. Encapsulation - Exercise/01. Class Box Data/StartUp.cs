namespace _01._Class_Box_Data
{
    using Core;
    using Core.Contracts;
    public class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}
