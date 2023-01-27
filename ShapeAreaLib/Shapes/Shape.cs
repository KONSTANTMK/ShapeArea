namespace ShapeAreaLib.Shapes
{
    public abstract class Shape
    {
        public double Area;
        public string? Message;
        protected abstract double CalculateSquare(double[] list);
    }
}
