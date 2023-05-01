namespace _03._Raiding.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contracts;
    using Repositories;
    using IO;
    using IO.Contracts;
    using Models.Heroes;
    using _03._Raiding.Utilities.Messages;

    public class Engine : IEngine
    {
        private IReader<string> reader;
        private IWriter<string> writer;
        public Engine()
        {
            this.reader = new Reader();
            this.writer = new Writer();
        }
        public void Run()
        {
            List<Hero> heroes = new List<Hero>();
            int numberOfHeroes = int.Parse(reader.ReadLine());
            while (heroes.Count < numberOfHeroes)
            {
                string name = Console.ReadLine();
                string type = Console.ReadLine();
                try
                {
                    Hero newHero = HeroFactory.GetHero(name, type);
                    heroes.Add(newHero);
                }
                catch (ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
            int bossPower = int.Parse(Console.ReadLine());
            heroes.ForEach(x => writer.WriteLine(x.CastAbility()));
            int raidPower = heroes.Select(x => x.Power).Sum();
            writer.WriteLine(raidPower >= bossPower ? string.Format(OutputMessages.VICTORY) : string.Format(OutputMessages.DEFEAT));
        }
    }
}
