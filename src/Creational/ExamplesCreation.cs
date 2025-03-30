using DesignPatterns.Creational.AbstractFactory.Factory.Factories;
using DesignPatterns.Creational.AbstractFactory.Factory.Interfaces;
using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder.Builders;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod.Enums;
using DesignPatterns.Creational.FactoryMethod.Factory;
using DesignPatterns.Creational.FactoryMethod.Interfaces;
using DesignPatterns.Creational.Prototype.Interfaces;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Creational.Prototype.Entities;

namespace DesignPatterns.Creational
{
    public static class Examples
    {
        public static void Singleton()
        {
            // Singleton with unique instance and alloced on demand (lazy)
            var engine = Engine.GetInstance();
            engine.Play();

            // Singleton with static class, always existing
            Utils.GetPI();
            Utils.GetTime();
        }

        public static void Builder()
        {
            // Builder pattern with example for building SQL queries
            QueryBuilder postgresBulder = new PostgresQueryBuilder();
            QueryBuilder mariaDBBuilder = new MariaDBQueryBuilder();

            var postgresQuery = postgresBulder
                .Select("id", "name")
                .From("users")
                .Where("name = 'Admin'")
                .Build();

            var mariaQuery = mariaDBBuilder
                .Select("id", "name")
                .From("users")
                .Where("name = 'Admin'")
                .Build();

            Console.WriteLine(postgresQuery);
            Console.WriteLine(mariaQuery);
        }

        public static void FactoryMethod()
        {
            // Factory method with example used for creating cars of diferent types,
            // Optionally from different factories in this case
            IVehicleFactory fordFactory = new FordFactory();
            IVehicleFactory yamahaFactory = new YamahaFactory();

            IVehicle fiesta = fordFactory.CreateVehicle(VehicleEnum.EcoSport);
            IVehicle ecoSport = fordFactory.CreateVehicle(VehicleEnum.EcoSport);
            IVehicle fazer = yamahaFactory.CreateVehicle(VehicleEnum.Fazer);

            fiesta.Accelerate();
            ecoSport.Accelerate();
            fazer.Accelerate();
        }

        public static void AbstractFactory()
        {
            // Instantiate a family of integration methods
            IInvoiceIntegrationFactory brIntegration = new BrazilianInvoiceIntegrationFactory();
            IInvoiceIntegrationFactory amIntegration = new AmericanInvoiceIntegrationFactory();

            // Send for Brazilian
            InvoiceIntegration integration = new InvoiceIntegration(brIntegration);
            integration.Send(1);
            integration.Cancel(1);

            // Send for American
            integration = new InvoiceIntegration(amIntegration);
            integration.Send(2);
            integration.Cancel(2);
        }

        public static void Prototype()
        {
            // Cloning object withou knowing their concrete classes
            IShape circle = new Circle(10);
            IShape clonedCircle = circle.Clone();

            IShape react = new Rectangle(10, 20);
            IShape clonedRect = react.Clone();
        }
    }
}
