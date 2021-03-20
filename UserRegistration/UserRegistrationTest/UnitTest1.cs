using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
        [TestMethod]
        public void Given_Password_Have_Minimum_1_Upper_Character_Should_Returrns_True()
        {
            bool result = pattern.isValidPassword("AAAAAAAAAAAAA");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_NO_Upper_Character_Should_Returrns_False()
        {
            bool result = pattern.isValidPassword("asdfghjcvcv");
            Assert.AreNotEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_Minimum_1_Upper_And_1_Numeric_Character_Should_Returrns_True()
        {
            bool result = pattern.isValidPassword("AAAAAA2AAAAAAA");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_No_1_Upper_And_1_Numeric_Character_Should_Returrns_False()
        {
            bool result = pattern.isValidPassword("asdfghjcvcv");
            Assert.AreNotEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_Minimum_1_Upper_And_1_Numeric_And_1_Special_Character_Should_Returrns_True()
        {
            bool result = pattern.isValidPassword("AAAAAA2A@AAAAAA");
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Given_Password_Have_No_Any_Of_1_Upper_And_1_Numeric_1_Special_Character_Should_Returrns_False()
        {
            bool result = pattern.isValidPassword("asdAghjcvcv");
            Assert.AreNotEqual(true, result);
        }
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void Given_Valid_Email_List_Should_Returrns_True(string validEmails)
        {
            Pattern pattern = new Pattern();
            Assert.IsTrue(pattern.isValidEmail(validEmails));

        }
        [TestMethod]
        [DataRow("abc")]
        [DataRow("abc@.com.my")]
        [DataRow("abc123@gmail.a")]
        [DataRow("abc123@.com")]
        [DataRow("abc123@.com.com")]
        [DataRow(".abc@abc.com")]
        [DataRow("abc()*@gmail.com")]
        [DataRow("abc@%*.com")]
        [DataRow("abc..2002@gmail.com}")]
        [DataRow("abc.@gmail.com")]
        [DataRow("abc@abc@gmail.com")]
        [DataRow("abc@gmail.com.1a")]
        [DataRow("abc@gmail.com.aa.au")]
        public void Given_Invalid_Email_List_Should_Returrns_False(string invalisEmails)
        {
            Pattern pattern = new Pattern();
            Assert.IsFalse(pattern.isValidEmail(invalisEmails));

        }






    }
}
