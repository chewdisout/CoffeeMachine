using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineSimpler
{
    public interface IClient
    {
        int Money { get; set; }
        string Name { get; set; }
        string MoneyCurrency { get; set; }
        int MadeCupsOfCoffee { get; set; }
        string LastCoffeeMade { get; set; }
    }
}
