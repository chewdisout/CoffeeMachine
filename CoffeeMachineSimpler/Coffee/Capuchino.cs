using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSimpler.Coffee
{
    public class Capuchino : ICoffee
    {
        private string _coffeeName = "Capuchino";
        public string CoffeeName { get => _coffeeName; set => _coffeeName = value; }

        private int _milkAmount = 100;
        public int MilkAmount { get => _milkAmount; set => _milkAmount = value; }

        private int _sugarAmount = 2;
        public int SugarAmount { get => _sugarAmount; set => _sugarAmount = value; }

        private string _syrup = "none";
        public string Syrup { get => _syrup; set => _syrup = value; }

        private int _price = 25;
        public int Price { get => _price; set => _price = value; }
    }
}
