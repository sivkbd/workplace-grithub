using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    public class backbutton
    {
        private Stack<string> _history; // Stack to keep track of the page history
        private string _currentPage;

        public backbutton()
        {
            _history = new Stack<string>();
            _currentPage = "home"; // Start on the home page
        }

        public void navigateTo(string page)
        {
            _history.Push(_currentPage); // Save current page to history
            _currentPage = page; // Navigate to new page
            Console.WriteLine("Navigated to: "+_currentPage);
        }

        public string goBack()
        {
            if (_history.Count > 0)
            {
                _currentPage = _history.Pop(); // Go back to the previous page
                Console.WriteLine("Returned to: "+_currentPage);
            }
            else
            {
                Console.WriteLine("No previous page to go back to.");
            }
            return _currentPage; // Return the current page after going back
        }

        public string getCurrentPage()
        {
            return _currentPage; // Return the current page
        }
    }
}
