using DesignPatterns.Creational.AbstractFactory.Entities.Abstract;
using DesignPatterns.Creational.AbstractFactory.Entities.Concrete;
using DesignPatterns.Creational.AbstractFactory.Factory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Factory.Factories
{
    /// <summary>
    /// American Invoice Integration Factory
    /// </summary>
    public class AmericanInvoiceIntegrationFactory : IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation()
        {
            return new AmericanInvoiceCancelation();
        }

        public IInvoiceSender CreateInvoiceSender()
        {
            return new AmericanInvoiceSender();
        }
    }
}
