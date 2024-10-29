using System;

namespace ConsoleApplication2
{
    public class zoom_in_and_out // Ensure this class is public
    {
        private double _zoomLevel;

        public zoom_in_and_out()
        {
            _zoomLevel = 1.0; // Default zoom level
        }

        public void zoomIn()
        {
            _zoomLevel += 0.1; // Increase zoom level
            Console.WriteLine("Zoomed In: Current Zoom Level is "+_zoomLevel);
        }

        public void zoomOut()
        {
            if (_zoomLevel > 0.1) // Prevent zooming out too much
            {
                _zoomLevel -= 0.1; // Decrease zoom level
                Console.WriteLine("Zoomed Out: Current Zoom Level is "+_zoomLevel);
            }
            else
            {
                Console.WriteLine("Cannot zoom out further.");
            }
        }

        public double GetZoomLevel()
        {
            return _zoomLevel; // Return the current zoom level
        }
    }
}
