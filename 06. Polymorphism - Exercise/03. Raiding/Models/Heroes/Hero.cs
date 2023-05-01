namespace _03._Raiding.Models.Heroes
{
    using Contracts;
    public abstract class Hero : IHero
    {
        public abstract string Name { get; set; }
        public abstract int Power { get; set; }
        public abstract string CastAbility();
    }
}
