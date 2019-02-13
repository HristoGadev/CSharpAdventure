using System;
namespace ClassBox
{
    public class Box
    {
        //length, width and height
        private double lenght;
        private double width;
        private double height;

        public Box(double lenght, double width, double height)
        {
            this.Lenght = lenght;
            this.Height = height;
            this.Width = width;
        }
        public double Lenght
        {
            get { return lenght; }
            set
            {
                Validation(value, "Lenght");
                lenght = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                Validation(value, "Width");
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                Validation(value, "Height");
                height = value;
            }
        }
        public void Validation(double value, string side)
        {
            if (value <= 0)
            {
                Exception ex = new Exception($"{side} cannot be zero or negative.");
                Console.WriteLine(ex.Message);
                Environment.Exit(0);
            }
        }
        public double GetSurfaceArea(Box box)
        {
            return 2 * box.Lenght * box.Height + 2 * box.Lenght * box.Width + 2 * box.Height * box.Width;
        }
        public double GetLateralServiceArea(Box box)
        {
            return 2 * box.Lenght * box.Height + 2 * box.Height * box.Width;
        }
        public double GetVolume(Box box)
        {
            return box.Lenght * box.Height * box.Width;
        }
    }
}
