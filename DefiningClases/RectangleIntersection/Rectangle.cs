namespace DefiningClasses
{
    class Rectangle
    {
        private string id;
        private double width;
        private double heigth;
        private double x;
        private double y;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Heigth
        {
            get { return heigth; }
            set { heigth = value; }
        }

        public double X
        {
            get { return x; }
            set { x = value; }
        }

        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public bool Intersection(Rectangle rectangle)
        {
            bool outside =
                X + Width < rectangle.X ||
                rectangle.X + rectangle.Width < X ||
                Y + Heigth < rectangle.Y ||
                rectangle.Y + rectangle.Heigth < Y;
            return !outside;
        }
    }
}