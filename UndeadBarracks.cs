
namespace AbstractFactory
{
    public class UndeadBarracks : Barracks
    {
        public UndeadBarracks() => unitFactory = new UndeadUnitFactory();
    }
}
