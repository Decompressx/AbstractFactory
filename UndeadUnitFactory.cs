
namespace AbstractFactory
{
    public class UndeadUnitFactory : UnitFactory
    {
        public override string CreateArcher()
        {
            return new UndeadArcher().ArcherVoice();
        }

        public override string CreateMage()
        {
            return new UndeadMage().MageVoice();
        }

        public override string CreateWarrior()
        {
            return new UndeadWarrior().WarriorVoice();
        }
    }
}
