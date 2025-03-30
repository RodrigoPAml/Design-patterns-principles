using DesignPatterns.Creational.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Factory.Interfaces
{
    /// <summary>
    /// Invoice Integration Factory Interface
    /// </summary>
    public interface IInvoiceIntegrationFactory
    {
        public IInvoiceCancelation CreateInvoiceCancelation();

        public IInvoiceSender CreateInvoiceSender();
    }
}
