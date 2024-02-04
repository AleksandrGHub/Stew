namespace Stew
{
    class Catalog
    {
        private int _currentYear = 2024;
        private Random _random = new Random();
        private List<Pot> _pots = new List<Pot>();

        public Catalog()
        {
            AddPots();
        }

        public void ShowOverduePots()
        {
            Console.WriteLine($"\nСписок просроченных банок.");

            Show(_pots.Where(pot => pot.YearProduction + pot.ExpirationDate < _currentYear).ToList());

            Console.ReadKey();
        }

        public void ShowPots()
        {
            Console.WriteLine("Список всех банок.");

            Show(_pots);
        }

        private void Show(List<Pot> players)
        {
            foreach (var player in players)
            {
                player.ShowInfo();
            }
        }

        private void AddPots()
        {
            int numberPots = 20;
            int minExpirationDate = 2;
            int maxExpirationDate = 5;
            int minYearProduction = 2000;
            int maxYearProduction = 2024;

            for (int i = 0; i < numberPots; i++)
            {
                _pots.Add(new Pot(_random.Next(minExpirationDate, maxExpirationDate), _random.Next(minYearProduction, maxYearProduction)));
            }
        }
    }
}