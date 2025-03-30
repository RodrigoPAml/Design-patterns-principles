using DesignPatterns.Creational.FactoryMethod.Entities;
using DesignPatterns.Creational.FactoryMethod.Enums;
using DesignPatterns.Creational.FactoryMethod.Interfaces;

namespace DesignPatterns.Creational.FactoryMethod.Factory
{
    public class YamahaFactory : IVehicleFactory
    {
        public IVehicle CreateVehicle(VehicleEnum type)
        {
            switch (type)
            {
                case VehicleEnum.Fazer:
                    return new Fazer();
                default:
                    return null;
            }
        }
    }
}
