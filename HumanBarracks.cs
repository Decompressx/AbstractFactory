
namespace AbstractFactory
{
    public class HumanBarracks : Barracks
    {
        public HumanBarracks() => unitFactory = new HumanUnitFactory();
    }
}
