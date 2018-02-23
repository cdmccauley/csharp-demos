using System;

namespace InvoiceTest
{
    class Invoice
    {
        // properties
        public string PartDescription { get; set; }
        public string PartNumber { get; set; }
        public decimal PartPrice { get; set; }
        public int PartQuantity { get; set; }

        // constructor
        public Invoice(string partDescription, string partNumber, decimal partPrice, int partQuantity)
        {
            PartDescription = partDescription;
            PartNumber = partNumber;
            PartPrice = partPrice;
            PartQuantity = partQuantity;
        }

        // returns decimal representation of invoice total
        public decimal GetInvoiceAmount()
        {
            return (PartPrice * PartQuantity);
        }
    }
}
