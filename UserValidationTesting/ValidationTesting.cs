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

        [TestMethod]
        [DataRow("Mishra")]
        [DataRow("MISHRA")]
        public void TestLastNameValidation_ValidNames(string lName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyLastName(lName);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("Mi")]
        [DataRow("mishra")]
        [DataRow("Mis#ra")]
        public void TestLastNameValidation_InvalidNames(string lName)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyLastName(lName);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

       
         [TestMethod]
        [DataRow("jrm@gmail.com")]
        [DataRow("jrm.cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in")]
        [DataRow("jrm100@gmail.com")]
        [DataRow("jrm-nit@1mg.co.in")]
        public void TestEmailValidation_ValidEmails(string email)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyEmail(email);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("jrm.@gmail.com")]
        [DataRow("jrm@cg@gmail.co.in")]
        [DataRow("jrm@gmail.co.in.uk")]
        [DataRow("jrm100@.gmail.com")]
        [DataRow("jrm..nit@1mg.com")]
        [DataRow("jrm.nit.@gmail.com")]
        [DataRow("jrm..nit@1mg.23")]
        public void TestEmailValidation_InvalidEmails(string email)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyEmail(email);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }


        [TestMethod]
        [DataRow("91 6231230127")]
        public void TestPhNumberValidation_ValidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPhNumber(phNum);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow("1234567890")]
        [DataRow("981236540987")]
        [DataRow("97 0123456789")]
        [DataRow("97 123456")]
        [DataRow("9 1234567890")]
        [DataRow("97 8123456789012")]
        [DataRow("97 123 456 6789")]
        public void TestPhNumberValidation_InvalidNumbers(string phNum)
        {
            //Arrange
            User user = new User();
            bool expected = true;

            //Act
            bool actual = user.VerifyPhNumber(phNum);

            //Assert
            Assert.AreNotEqual(expected, actual);
        }

    }
}
