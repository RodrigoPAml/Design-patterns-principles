using DesignPatterns.Creational.AbstractFactory.Entities.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Entities.Concrete
{
    /// <summary>
    /// Concrete Invoice Cancelation
    /// </summary>
    public class AmericanInvoiceCancelation : IInvoiceCancelation
    {
        public void CancelInvoiceNote(long invoiceNoteId)
        {
            Console.WriteLine($"Canceling invoice note with id {invoiceNoteId} to american government");
        }
    }
}
