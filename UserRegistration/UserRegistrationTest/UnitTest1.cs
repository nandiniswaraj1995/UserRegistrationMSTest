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
        [TestMethod]
        public void Given_Valid_Email_Id_Should_Returrns_True()
        {
            bool result = pattern.isValidEmail("nasdsf@gmail.com");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Invalid_Email_Id_Should_Returrns_False()
        {
            bool result = pattern.isValidEmail("nandini12@gmail.com.com.co");
            Assert.AreNotEqual(true, result);
        }
        [TestMethod]
        public void Given_Valid_Mobile_Number_Should_Returrns_True()
        {
            bool result = pattern.isValidMobileNumber("91 9123456780");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Invalid_Mobile_Number_Should_Returrns_False()
        {
            bool result = pattern.isValidMobileNumber("1234567890");
            Assert.AreNotEqual(true, result);
        }

        [TestMethod]
        public void Given_Password_Have_Minimum_8_Character_Should_Returrns_True()
        {
            bool result = pattern.isValidPassword("addfdsfA2df");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_Less_Then_8_Character_Should_Returrns_False()
        {
            bool result = pattern.isValidPassword("asdf");
            Assert.AreNotEqual(true, result);
        }




    }
}
