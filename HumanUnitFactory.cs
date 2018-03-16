
namespace AbstractFactory
{
    public class HumanUnitFactory : UnitFactory
    {
        public override string CreateArcher()
        {
            return new HumanArcher().ArcherVoice();
        }

        public override string CreateMage()
        {
            return new HumanMage().MageVoice();
        }

        public override string CreateWarrior()
        {
            return new HumanWarrior().WarriorVoice();
        }
    }
}
