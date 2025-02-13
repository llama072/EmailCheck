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
    }
}
