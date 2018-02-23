using System;

namespace InvoiceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // declarations
            Invoice mbInvoice = new Invoice("Intel - Core i7-7700K 4.2GHz Quad-Core Processor", "BX80677I77700K", 339.99m, 3);
            Invoice cpuInvoice = new Invoice("ASRock - Z270M-ITX/ac Mini ITX LGA1151 Motherboard", "Z270M-ITX/ac", 112.98m, 3);
            Invoice ramInvoice = new Invoice("Team - Vulcan 16GB (2 x 8GB) DDR4-3000 Memory", "TLGD416G3000HC16CDC01", 184.99m, 3);
            Invoice gpuInvoice = new Invoice("Asus - GeForce GTX 1070 8GB Dual Series Video Card", "DUAL-GTX1070-O8G", 799.00m, 3);

            // output
            Console.WriteLine("Invoice No. 1\nProduct:\t{0}\nModel:\t\t{1}\nPrice:\t\t{2:C}\nQuantity:\t{3}\nInvoice Total:\t{4:C}\n", 
                mbInvoice.PartDescription, mbInvoice.PartNumber, mbInvoice.PartPrice, mbInvoice.PartQuantity, mbInvoice.GetInvoiceAmount());
            Console.WriteLine("Invoice No. 2\nProduct:\t{0}\nModel:\t\t{1}\nPrice:\t\t{2:C}\nQuantity:\t{3}\nInvoice Total:\t{4:C}\n",
                cpuInvoice.PartDescription, cpuInvoice.PartNumber, cpuInvoice.PartPrice, cpuInvoice.PartQuantity, cpuInvoice.GetInvoiceAmount());
            Console.WriteLine("Invoice No. 3\nProduct:\t{0}\nModel:\t\t{1}\nPrice:\t\t{2:C}\nQuantity:\t{3}\nInvoice Total:\t{4:C}\n",
                ramInvoice.PartDescription, ramInvoice.PartNumber, ramInvoice.PartPrice, ramInvoice.PartQuantity, ramInvoice.GetInvoiceAmount());
            Console.WriteLine("Invoice No. 4\nProduct:\t{0}\nModel:\t\t{1}\nPrice:\t\t{2:C}\nQuantity:\t{3}\nInvoice Total:\t{4:C}\n",
                gpuInvoice.PartDescription, gpuInvoice.PartNumber, gpuInvoice.PartPrice, gpuInvoice.PartQuantity, gpuInvoice.GetInvoiceAmount());
            Console.WriteLine("Order Total:\t{0:C}\n", 
                (mbInvoice.GetInvoiceAmount() + cpuInvoice.GetInvoiceAmount() + ramInvoice.GetInvoiceAmount() + gpuInvoice.GetInvoiceAmount()));

            // hold console open
            Console.WriteLine("Press any  key to close console window...");
            Console.ReadKey();
        }
    }
}
