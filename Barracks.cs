
namespace AbstractFactory
{
    public class Barracks
    {
        protected UnitFactory unitFactory { get; set; }

        public string CreateWarrior()
        {
            return unitFactory.CreateWarrior();
        }
        public  string CreateMage()
        {
            return unitFactory.CreateMage();
        }
        public string CreateArcher()
        {
            return unitFactory.CreateArcher();
        }
        public void ChangeRace(UnitFactory changeFactory)
        {
            unitFactory = changeFactory;
        }
    }
}