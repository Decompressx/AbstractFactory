
namespace AbstractFactory
{
    public class GnomeBarracks : Barracks
    {
        public GnomeBarracks() => unitFactory = new GnomeUnitFactory();

    }
}
