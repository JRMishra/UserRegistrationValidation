using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserValidationTesting
{
    [TestClass]
    public class ValidationTesting
    {
        [TestMethod]
        [DataRow("Jyoti")]
        [DataRow("JYOTI")]
        [DataRow("Jyoti Ranjan")]
        public void TestFirstNameValidation_ValidNames(string fName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyFirstName(fName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Jr")]
        [DataRow("jyoti")]
        [DataRow("Jy@ti")]
        public void TestFirstNameValidation_InvalidNames(string fName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyFirstName(fName);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

    }
}
