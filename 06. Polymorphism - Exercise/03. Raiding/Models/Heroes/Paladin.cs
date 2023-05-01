namespace _03._Raiding.Models.Heroes
{
    using Utilities.Messages;
    public class Paladin : Hero
    {
        protected string name;
        public Paladin(string name)
        {
            Name = name;
            Power = 100;
        }
        public override string Name { get => name; set => name = value; }
        public override int Power { get; set; }
        public override string CastAbility()
            => string.Format(OutputMessages.HEAL_ABILITY, this.GetType().Name, Name, Power);
    }
}
