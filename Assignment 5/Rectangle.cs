namespace Assignment_5
{
    internal class Rectangle : IRectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public double Area
        {
            get {return Width * Height;}
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area}");
        }
    }
}
