using DesignPatterns.Creational.FactoryMethod.Entities;
using DesignPatterns.Creational.FactoryMethod.Enums;
using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    public class FordFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleEnum type)
        {
            switch (type)
            {
                case VehicleEnum.Fiesta:
                    return new Fiesta();
                case VehicleEnum.EcoSport:
                    return new EcoSport();
                default:
                    return null;
            }
        }
    }
}
