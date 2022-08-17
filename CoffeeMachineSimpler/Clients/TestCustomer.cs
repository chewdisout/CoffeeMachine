using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSimpler.Clients
{
    public class TestCustomer : IClient
    {
        private int _money = 100;
        public int Money { get => _money; set => _money = value; }

        private string _lastCoffeeMade = "none";
        public string LastCoffeeMade { get => _lastCoffeeMade; set => _lastCoffeeMade = value; }

        private int _madeCupsOfCoffee = 0;
        public int MadeCupsOfCoffee { get => _madeCupsOfCoffee; set => _madeCupsOfCoffee = value; }

        private string _moneyCurrency = "Euro";
        public string MoneyCurrency { get => _moneyCurrency; set => _moneyCurrency = value; }

        private string _name = "Egor";
        public string Name { get => _name; set => _name = value; }
    }
}
