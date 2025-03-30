using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Entities
{
    public class Fiesta : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(Fiesta)}");
        }
    }
}
