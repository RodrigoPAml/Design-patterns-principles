namespace DesignPatterns.Creational.Prototype.Interfaces
{
    public interface IShape
    {
        IShape Clone();

        void Draw();
    }
}
