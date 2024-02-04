namespace Stew
{
    class Pot
    {
        public Pot(int expirationDate, int yearProduction)
        {
            Name = "Тушёнка";
            ExpirationDate = expirationDate;
            YearProduction = yearProduction;
        }

        public string Name { get; private set; }
        public int ExpirationDate { get; private set; }
        public int YearProduction { get; private set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name}\tгод производства: {YearProduction}\tсрок годности: {ExpirationDate} года");
        }
    }
}