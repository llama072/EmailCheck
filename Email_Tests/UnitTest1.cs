using System;
using Email;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Email_Tests
{
    [TestClass]
    public class EmailValidatorTests
    {
        [TestMethod]
        public void IsValidEmail_ReturnsTrue()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("test@test.com");

            //assert

            Assert.IsTrue(result);

        }

        [TestMethod]
        public void EmailWithoutAtSymbol_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("testtest.com");

            //assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void EmailWithMultipleAtSymbols_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("tes@@ttest.com");

            //assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void EmailWithoutDomain_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("test@");

            //assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void EmailWithoutLocalPart_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("@example.com");

            //assert

            Assert.IsFalse(result);

        }

        [TestMethod]
        public void EmailWithoutTLD_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("test@examp");

            //assert

            Assert.IsFalse(result);



        }
        [TestMethod]
        public void EmptyEmail_ReturnsFalse()
        {
            //arranage

            var validator = new Email_Validator();

            //act

            bool result = validator.IsValidEmail("");

            //assert

            Assert.IsFalse(result);

        }
    }
}
