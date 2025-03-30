using DesignPatterns.Creational.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Entities.Concrete
{
    /// <summary>
    /// Concreate Invoice Sender
    /// </summary>
    public class AmericanInvoiceSender : IInvoiceSender
    {
        public void SendInvoiceNote(long invoiceNoteId)
        {
            Console.WriteLine($"Sending invoice note with id {invoiceNoteId} to american government");
        }
    }
}
