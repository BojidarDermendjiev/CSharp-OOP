namespace _03._Raiding.Models.Contracts
{
    public interface IHero
    {
        public string Name { get; }
        public int Power { get; set; }
        public string CastAbility();
    }
}
