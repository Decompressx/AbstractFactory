using System.Windows;

namespace AbstractFactory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            cb1.Items.Add("Человек");
            cb1.Items.Add("Эльф");
            cb1.Items.Add("Нежить");
            cb1.Items.Add("Гном");

        }
        Barracks barracks;
        UnitFactory unitFactory;

        private void SelectHumanRaceButton_Click(object sender, RoutedEventArgs e)
        {
            barracks = new HumanBarracks();
        }

        private void SelectElfRaceButton_Click(object sender, RoutedEventArgs e)
        {
            barracks = new ElfBarracks();
        }
            
        private void SelectGnomeRaceButton_Click(object sender, RoutedEventArgs e)
        {
            barracks = new GnomeBarracks();
        }

        private void SelectUndeadRaceButton_Click(object sender, RoutedEventArgs e)
        {
            barracks = new UndeadBarracks();
        }

        private void CreateWarriorButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLB.Items.Add(barracks.CreateWarrior());
        }

        private void CreateArcherButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLB.Items.Add(barracks.CreateArcher());
        }

        private void CreateMageButton_Click(object sender, RoutedEventArgs e)
        {
            ResultLB.Items.Add(barracks.CreateMage());
        }

        private void SiezeBarrackButton_Click(object sender, RoutedEventArgs e)
        {
            if (cb1.SelectedItem.Equals("Человек"))
                SelectEnemyHumanFactory();
            else if (cb1.SelectedItem.Equals("Эльф"))
                SelectEnemyElfFactory();
            else if (cb1.SelectedItem.Equals("Гном"))
                SelectEnemyGnomeFactory();
            else if (cb1.SelectedItem.Equals("Нежить"))
                SelectEnemyUndeadFactory();
            barracks.ChangeRace(unitFactory);
        }
        public void SelectEnemyHumanFactory()
        {
            unitFactory = new HumanUnitFactory();
        }
        public void SelectEnemyElfFactory()
        {
            unitFactory = new ElfUnitFactory();
        }
        public void SelectEnemyGnomeFactory()
        {
            unitFactory = new GnomeUnitFactory();
        }
        public void SelectEnemyUndeadFactory()
        {
            unitFactory = new UndeadUnitFactory();
        }
    }
}
