using DesignPatterns.Creational.Prototype.Interfaces;

namespace DesignPatterns.Creational.Prototype.Entities
{
    public class Rectangle : IShape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public IShape Clone()
        {
            return new Rectangle(width, height); 
        }

        public void Draw()
        {
            Console.WriteLine($"Rectangle with width {width} and height {height} is drawn.");
        }
    }
}
