namespace _02._Animal_Farm
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
