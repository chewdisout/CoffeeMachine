using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSimpler
{
    public interface ICoffee
    {
        public string CoffeeName { get; set; }
        public int MilkAmount{ get; set; }
        public int SugarAmount { get; set; }
        public string Syrup { get; set; }
        public int Price { get; set; }
    }
}
