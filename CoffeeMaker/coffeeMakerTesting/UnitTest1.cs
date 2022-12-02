using CoffeeMaker;
using Moq;

namespace coffeeMakerTesting
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Using Fake
        /// </summary>
        [TestMethod]
        public void OrderAcoffee_Should_Return_Recevied_Message()
        {
            StarbuckStore store = new StarbuckStore(new FakeStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("your order is received.", result);

        }
        [TestMethod]
        public void StubOrderAcoffee_Should_Return_Recevied_Message()
        {
            StarbuckStore store = new StarbuckStore(new StubStarbucks());
            string result = store.OrderCoffee(2, 4);
            Assert.AreEqual("your order is received.", result);

        }

        [TestMethod]
        public void MockOrderAcoffee_Should_Return_Recevied_Message()
        {
            var service = new Mock<IMakeACoffee>();
            service.Setup( x => x.CheckIngridentAvaliable()).Returns(true);
            
            service.Setup(x => x.coffeeMaking(It.IsAny<int>(),It.IsAny<int>())).Returns("your order is received.");

            var store = new StarbuckStore(service.Object);
            var result = store.OrderCoffee(2, 4);
            Assert.AreEqual("your order is received.", result);

        }


    }
}