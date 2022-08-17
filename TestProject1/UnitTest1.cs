using CoffeeMachineSimpler;
using CoffeeMachineSimpler.Coffee;
using CoffeeMachineSimpler.Clients;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
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
        public void TestMethod2()
        {
            string moneyAreReturnedState = "Your money are back for the last coffee you made";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Capuchino capuchino = new Capuchino();
            TestCustomer customer = new TestCustomer();

            coffeeMachine.MakeCupCoffee(capuchino, customer);
            Assert.AreEqual(moneyAreReturnedState, coffeeMachine.ReturnMoneyForCoffee(customer), "Client is a thief");
        }

        [TestMethod]
        public void TestMethod3()
        {
            string moneyAreReturnedState = "Catch your cash";

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            Capuchino capuchino = new Capuchino();
            TestCustomer customer = new TestCustomer();

            coffeeMachine.InsertMoney(customer, 50);
            Assert.AreEqual(moneyAreReturnedState, coffeeMachine.ReturnBalance(customer), "Client is a thief");
        }
    }
}