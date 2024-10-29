using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApplication3.Tests
{
    [TestClass]
    public class Contact_usTests
    {
        [TestMethod]
        public void TestButtonMethod()
        {
            // Arrange
            Contact_us contactUs = new Contact_us();

            // Act & Assert
            try
            {
                contactUs.button(); // Call the button method
                Assert.IsTrue(true); // If it runs without exception, test passes
            }
            catch (Exception)
            {
                Assert.Fail("The button method threw an exception.");
            }
        }
    }
}
