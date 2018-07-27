using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloWorldUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        string message = "Hello World";
        [TestMethod]
        public void ConsoleTest()
        {
            
            HelloWorldAPI.APIGateway _ConsoleTest = new HelloWorldAPI.APIGateway("Console");
            _ConsoleTest.setMessage(message);

            Assert.AreEqual(message, _ConsoleTest.getMessage());
        }

        [TestMethod]
        public void DatabaseTest()
        {

            HelloWorldAPI.APIGateway _DatabaseTest = new HelloWorldAPI.APIGateway("Database");
            _DatabaseTest.setMessage(message);

            Assert.AreEqual(message, _DatabaseTest.getMessage());
        }

        [TestMethod]
        public void MobileTest()
        {

            HelloWorldAPI.APIGateway _MobileTest = new HelloWorldAPI.APIGateway("Database");
            _MobileTest.setMessage(message);

            Assert.AreEqual(message, _MobileTest.getMessage());
        }


    }
}
