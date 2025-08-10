namespace Assignment_5
{
    internal class Circle:ICircle
    {
        public int Radius { get; set; }

        public double Area
        {
            get { return Math.PI * Radius * Radius; }
        }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area}");
        }
    }
}
