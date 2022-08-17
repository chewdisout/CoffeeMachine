using CoffeeMachineSimpler.Coffee;

namespace CoffeeMachineSimpler
{
    public class CoffeeMachine
    {
        public int MilkAmount = 1000;
        public int SugarAmount = 5;
        public string[] SyrupsInStock = { "Strawberry", "Caramel" };
        public string Currency = "Euro";
        public int Balance = 0;
        public string[] CoffeeTypes = { "Capuchino", "ChocolateCoffee" };

        public string MakeCupCoffee(ICoffee coffeeType, IClient client)
        {
            if (client.MoneyCurrency != this.Currency) return "Invalid currency";
            if (client.Money < coffeeType.Price) return "Influence amount of money";
            if (this.MilkAmount >= coffeeType.MilkAmount) this.MilkAmount -= coffeeType.MilkAmount;
            else return "No milk in the coffee machine";
            if (this.SugarAmount >= coffeeType.SugarAmount) this.SugarAmount -= coffeeType.SugarAmount;
            else return "No sugar in the coffee machine";
            if (coffeeType.Syrup == "none" || coffeeType.Syrup == SyrupsInStock[0] || coffeeType.Syrup == SyrupsInStock[1])
            {
                client.LastCoffeeMade = coffeeType.CoffeeName;
                client.Money -= coffeeType.Price;
                client.MadeCupsOfCoffee++;
                return "Your " + coffeeType.CoffeeName + " is ready";
            }
            else
            {
                return "There is no " + coffeeType.Syrup + " syrup in stock";
            }
        }

        public string ReturnMoneyForCoffee(IClient client) 
        {
            if (client.MadeCupsOfCoffee == 0) return "Ops, you haven't made any coffee";
            else 
            {
                if (client.LastCoffeeMade == "Capuchino")
                {
                    client.Money += new Capuchino().Price;
                }
                return "Your money are back for the last coffee you made";
            }
        }

        public bool InsertMoney(IClient client, int insertMoney)
        {
            if (client.MoneyCurrency == "Euro" && client.Money >= insertMoney)
            {
                this.Balance += insertMoney;
                return true;
            }
            else return false;
        }

        public string ReturnBalance(IClient client)
        {
            if (this.Balance <= 0) return "Your balance is too low";
            else
            { 
                client.Money += this.Balance;
                return "Catch your cash";
            }
        }

        public string GetCoffeeInStock()
        {
            string coffeTypes = "We have: ";
            foreach (string coffee in CoffeeTypes)
            {
                coffeTypes += coffee + ", ";
            }
            return coffeTypes.Remove(coffeTypes.Length - 2);
        }
    }
}