using _03._Raiding.Utilities.Messages;

namespace _03._Raiding.Models.Heroes
{
    public class Warrior : Hero
    {
        protected string name;
        public Warrior(string name)
        {
            Name = name;
            Power = 100;
        }
        public override string Name { get => name; set => name = value; }
        public override int Power { get; set; }
        public override string CastAbility()
            => string.Format(OutputMessages.DAMAGE_ABILITY, this.GetType().Name, Name, Power);
    }
}
