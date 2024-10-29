using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2; // Ensure this matches your actual namespace

namespace UnitTestProject3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Button_ShouldCallContinuePayment()
        {
            // Arrange
            PaymentMock paymentMock = new PaymentMock();
            secure secure = new secure(paymentMock);

            // Act
            secure.button(); // Call the method in lowercase

            // Assert
            Assert.IsTrue(paymentMock.IsCalled, "continuepayment was not called.");
        }
    }

    // Mocking payment class
    public class PaymentMock : payment
    {
        public bool IsCalled { get; private set; }

        public override void continuepayment() // Override in lowercase
        {
            IsCalled = true; // Track that this method was called
        }
        [TestClass]
        public class ZoomInAndOutTests
        {
            [TestMethod]
            public void ZoomIn_IncreasesZoomLevel()
            {
                // Arrange
                zoom_in_and_out zoom = new zoom_in_and_out();

                // Act
                zoom.zoomIn();

                // Assert
                Assert.AreEqual(1.1, zoom.GetZoomLevel(), "Zoom level did not increase correctly.");
            }

            [TestMethod]
            public void ZoomOut_DecreasesZoomLevel()
            {
                // Arrange
                zoom_in_and_out zoom = new zoom_in_and_out();
                zoom.zoomIn(); // Increase zoom level to 1.1

                // Act
                zoom.zoomOut();

                // Assert
                Assert.AreEqual(1.0, zoom.GetZoomLevel(), "Zoom level did not decrease correctly.");
            }

            //[TestMethod]
            /*public void ZoomOut_PreventsNegativeZoom()
            {
                // Arrange
                zoom_in_and_out zoom = new zoom_in_and_out();

                // Act
                zoom.zoomOut(); // Try to zoom out without zooming in

                // Assert
                Assert.AreEqual(1.0, zoom.GetZoomLevel(), "Zoom level should not go below initial level.");
            }

            [TestMethod]
            public void ZoomOut_CannotGoBelowMinimum()
            {
                // Arrange
                zoom_in_and_out zoom = new zoom_in_and_out();
                zoom.zoomIn();  // Zoom in to 1.1
                zoom.zoomOut(); // Zoom out to 1.0
                zoom.zoomOut(); // Try to zoom out again

                // Assert
                Assert.AreEqual(1.0, zoom.GetZoomLevel(), "Zoom level should not go below 1.0.");
            }*/


            [TestClass]
            public class backbuttonTests
            {
                [TestMethod]
                public void navigateTo_SavesCurrentPage()
                {
                    // Arrange
                    backbutton backBtn = new backbutton();
                    backBtn.navigateTo("page1");

                    // Act
                    backBtn.navigateTo("page2");

                    // Assert
                    Assert.AreEqual("page2", backBtn.getCurrentPage(), "Current page should be page2.");
                }

                [TestMethod]
                public void goBack_ReturnsToPreviousPage()
                {
                    // Arrange
                    backbutton backBtn = new backbutton();
                    backBtn.navigateTo("page1");
                    backBtn.navigateTo("page2");

                    // Act
                    backBtn.goBack(); // Should go back to page1

                    // Assert
                    Assert.AreEqual("page1", backBtn.getCurrentPage(), "Current page should be page1 after going back.");
                }

                [TestMethod]
                public void goBack_NoPreviousPage()
                {
                    // Arrange
                    backbutton backBtn = new backbutton();

                    // Act
                    string currentPage = backBtn.goBack(); // Should indicate no previous page

                    // Assert
                    Assert.AreEqual("home", currentPage, "Current page should still be home when no previous page.");

                }
            }
        }
    }
}
