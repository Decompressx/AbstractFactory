
namespace AbstractFactory
{
    public class ElfBarracks : Barracks
    {
        public ElfBarracks() => unitFactory = new ElfUnitFactory();
    }
}
