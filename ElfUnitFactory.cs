
namespace AbstractFactory
{
    public class ElfUnitFactory : UnitFactory
    {
        public override string CreateArcher()
        {
            return new ElfArcher().ArcherVoice();
        }

        public override string CreateMage()
        {
            return new ElfMage().MageVoice();
        }

        public override string CreateWarrior()
        {
            return new ElfWarrior().WarriorVoice();
        }
    }
}
