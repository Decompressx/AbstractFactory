
namespace AbstractFactory
{
    public class GnomeUnitFactory : UnitFactory
    {
        public override string CreateArcher()
        {
            return new GnomeArcher().ArcherVoice();
        }

        public override string CreateMage()
        {
            return new GnomeMage().MageVoice();
        }

        public override string CreateWarrior()
        {
            return new GnomeWarrior().WarriorVoice();
        }
    }
}
