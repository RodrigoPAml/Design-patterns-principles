using DesignPatterns.Creational.AbstractFactory.Entities.Abstract;
using DesignPatterns.Creational.AbstractFactory.Entities.Concrete;
using DesignPatterns.Creational.AbstractFactory.Factory.Interfaces;

namespace DesignPatterns.Creational.AbstractFactory.Factory.Factories
{
    /// <summary>
    /// Brazilian Invoice Integration Factory
    /// </summary>
    public class BrazilianInvoiceIntegrationFactory : IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation()
        {
            return new BrazilianInvoiceCancelation();
        }

        public IInvoiceSender CreateInvoiceSender()
        {
            return new AmericanInvoiceSender();
        }
    }
}
