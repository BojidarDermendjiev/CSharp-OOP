namespace _03._Raiding.Repositories
{
    using System;
    using Models.Heroes;
    using Utilities.Messages;

    public class HeroFactory 
    {
        public static Hero GetHero(string name, string type)
        {
            if (type == nameof(Druid))
                return new Druid(name);
            else if (type == nameof(Paladin))
                return new Paladin(name);
            else if (type == nameof(Rogue))
                return new Rogue(name);
            else if (type == nameof(Warrior))
                return new Warrior(name);
            else
                throw new ArgumentException(string.Format(OutputMessages.INVALID_TYPE_OF_CLASS));
        }
    }
}
