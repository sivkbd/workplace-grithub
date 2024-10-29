using System;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            payment p1 = new payment(); // Create an instance of payment
            secure s1 = new secure(p1); // Pass it to the secure constructor
            s1.button(); // Call the button method

            // Zoom in and out class
            zoom_in_and_out zoom = new zoom_in_and_out(); // This should now be recognized

            // Example of zooming in and out
            zoom.zoomIn();  // Zoom in
            zoom.zoomIn();  // Zoom in again
            zoom.zoomOut(); // Zoom out
            zoom.zoomOut(); // Zoom out again
            zoom.zoomOut(); // Attempt to zoom out further


            backbutton backBtn = new backbutton();

            // Simulate navigation
            backBtn.navigateTo("page1");
            backBtn.navigateTo("page2");
            backBtn.navigateTo("page3");

            // Go back
            backBtn.goBack(); // Should return to page2
            backBtn.goBack(); // Should return to page1
            backBtn.goBack(); // Should return to home
            backBtn.goBack(); // Should indicate no previous page
        }
    }
}
