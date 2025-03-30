using DesignPatterns.Creational.FactoryMethod.Enums;

namespace DesignPatterns.Creational.FactoryMethod.Interfaces
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle(VehicleEnum type);
    }
}
