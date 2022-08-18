using CoffeeMachineSimpler;
using CoffeeMachineSimpler.Coffee;
using CoffeeMachineSimpler.Clients;

namespace TestProject1
{
    [TestClass]
    public class TestCoffeeMachine
    {
        [TestMethod]
        public void MakingOneCapuchinoAndCheckingCustomerMoneyAfter_ClientMoney25()
        {
            string succesfullyMadeCupOfCoffee = "Your Capuchino is ready";
            int customerMoney = 75;

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Capuchino capuchino = new Capuchino();
            TestCustomer customer = new TestCustomer();

            Assert.AreEqual(succesfullyMadeCupOfCoffee, coffeeMachine.MakeCupCoffee(capuchino, customer), "Coffee isn't made correctly");
            Assert.AreEqual(customerMoney, customer.Money, "Customer didn't pay for the coffee");
        }

        [TestMethod]
        public void MakingCoffeeAndReturningMoneyForThat_MoneyAreReturned()
        {
            string moneyAreReturnedState = "Your money are back for the last coffee you made";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Capuchino capuchino = new Capuchino();
            TestCustomer customer = new TestCustomer();

            coffeeMachine.MakeCupCoffee(capuchino, customer);
            Assert.AreEqual(moneyAreReturnedState, coffeeMachine.ReturnMoneyForCoffee(customer), "Client is a thief");
        }

        [TestMethod]
        public void Insert50EuroAndReturnThem_CatchYourCash()
        {
            string moneyAreReturnedState = "Catch your cash";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            TestCustomer customer = new TestCustomer();

            coffeeMachine.InsertMoney(customer, 50);
            Assert.AreEqual(moneyAreReturnedState, coffeeMachine.ReturnBalance(customer), "Client is a thief");
        }

        [TestMethod]
        public void InsertMinus50EuroAndReturnThem_YourBalanceIsLow()
        {
            string moneyAreReturnedState = "Your balance is too low";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            TestCustomer customer = new TestCustomer();

            coffeeMachine.InsertMoney(customer, -50);
            Assert.AreEqual(moneyAreReturnedState, coffeeMachine.ReturnBalance(customer), "Client is a thief");
        }

        [TestMethod]
        public void MakeCoffeeWithNonExistingSyrup_NoSuchSyrup()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            ChocolateCoffee chocolateCoffee = new ChocolateCoffee();
            TestCustomer customer = new TestCustomer();

            string noSyrupForCoffee = "There is no " + chocolateCoffee.Syrup + " syrup in stock";

            Assert.AreEqual(noSyrupForCoffee, coffeeMachine.MakeCupCoffee(chocolateCoffee, customer), "Strange but we don't have such a syrup");
        }

        [TestMethod]
        public void ListProductsCoffeeMachineCanSell_ListAllProducts()
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            ChocolateCoffee chocolateCoffee = new ChocolateCoffee();
            Capuchino capuchino = new Capuchino();

            string coffeeInStock = "We have: " + capuchino.CoffeeName + ", " + chocolateCoffee.CoffeeName;

            Assert.AreEqual(coffeeInStock, coffeeMachine.GetCoffeeInStock(), "Check storage one more time!");
        }

        [TestMethod]
        public void InsertDollarsInCoffeeMachine_False()
        {
            bool moneyAreInserted = false;

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            TestCustomer customer = new TestCustomer();
            customer.MoneyCurrency = "Dollar";

            Assert.AreEqual(moneyAreInserted, coffeeMachine.InsertMoney(customer, 50), "Incorrect currency");
        }

        [TestMethod]
        public void MakeCoffeeWithoutIngredients_NoMilkInTheCoffeeMachine()
        {
            string withoutMilkFailedCase = "No milk in the coffee machine";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.MilkAmount = 0;
            TestCustomer customer = new TestCustomer();
            Capuchino capuchino = new Capuchino();

            Assert.AreEqual(withoutMilkFailedCase, coffeeMachine.MakeCupCoffee(capuchino, customer), "Incorrect currency");
        }
    }
}