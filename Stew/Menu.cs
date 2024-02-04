namespace Stew
{
    class Menu
    {
        private string _exitCommand = "Выход";
        private string _showOverduePotsCommand = "Просрочка";
        private Catalog _catalog = new Catalog();

        public void Work()
        {
            string userInput;

            do
            {
                Console.Clear();
                ShowInfo();
                _catalog.ShowPots();

                userInput = Console.ReadLine();

                if (userInput == _showOverduePotsCommand)
                {
                    _catalog.ShowOverduePots();
                }
            }
            while (_exitCommand == userInput == false);
        }

        private void ShowInfo()
        {
            Console.WriteLine($"***************** Команды меню *****************\nПоказать просроченные банки, команда: {_showOverduePotsCommand}\nДля выхода введите команду: {_exitCommand}\n");
        }
    }
}