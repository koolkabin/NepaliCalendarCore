using System;

namespace NepaliCalendar
{
    public class AreaCalculator
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Area()
        {
            return Length * Width;
        }
        public int Volume(int Height)
        {
            return Area() * Height;
        }

    }
}
