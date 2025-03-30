using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Entities
{
    public class EcoSport : IVehicle
    {
        public void Accelerate()
        {
            Console.WriteLine($"Accelerating {nameof(EcoSport)}");
        }
    }
}
