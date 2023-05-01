namespace _04._Wild_Farm
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
