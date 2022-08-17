using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSimpler.Coffee
{
    public class ChocolateCoffee : ICoffee
    {
        private string _coffeeName = "ChocolateCoffee";
        public string CoffeeName { get => _coffeeName; set => _coffeeName = value; }

        private int _milkAmount = 200;
        public int MilkAmount { get => _milkAmount; set => _milkAmount = value; }

        private int _sugarAmount = 0;
        public int SugarAmount { get => _sugarAmount; set => _sugarAmount = value; }

        private string _syrup = "Chocolate";
        public string Syrup { get => _syrup; set => _syrup = value; }

        private int _price = 34;
        public int Price { get => _price; set => _price = value; }
    }
}
