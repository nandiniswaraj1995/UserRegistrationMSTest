using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;
namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        Pattern pattern = new Pattern();

        [TestMethod]
        public void Given_Valid_First_Name_Should_Returrns_True()
        {
            bool result = pattern.isValidFirstName("Nandini");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Invalid_First_Name_Should_Returrns_False()
        {
            bool result = pattern.isValidFirstName("nandini");
            Assert.AreNotEqual(true, result);
        }
        [TestMethod]
        public void Given_Valid_Last_Name_Should_Returrns_True()
        {
            bool result = pattern.isValidLastName("Swaraj");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Invalid_Last_Name_Should_Returrns_False()
        {
            bool result = pattern.isValidLastName("swaraj");
            Assert.AreNotEqual(true, result);
        }
       

    }
}
