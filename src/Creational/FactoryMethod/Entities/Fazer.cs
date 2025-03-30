using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Entities
{
    public class Fazer : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(Fazer)}");
        }
    }
}
