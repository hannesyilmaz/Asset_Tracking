using System;
using System.Collections.Generic;

namespace AssetTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<MobilePhone> mobilePhones = new List<MobilePhone>();

            Console.WriteLine("Välkommen till Asset Tracking: ");
            Console.WriteLine("Vill du registrera en Laptop eller en Mobiltelefon: ");
            var laptopOrMobile = Console.ReadLine();
            Console.Write("Skriv in din produkt model: ");
            var amodel = Console.ReadLine();
            Console.Write("Skriv in priset: ");
            var aprice = Console.ReadLine();
            Console.Write("Skriv in din inköpsdatum in följande format 'yyyy - MM - dd': ");
            var apurchaseDate = Console.ReadLine();

            int price;
            if (!int.TryParse(aprice, out price))
            {
                Console.WriteLine("Invalid price input. Please enter a valid integer value.");
                return;
            }

            DateTime purchaseDate;
            if (!DateTime.TryParse(apurchaseDate, out purchaseDate))
            {
                Console.WriteLine("Invalid purchase date input. Please enter a valid date value.");
                return;
            }

            var firstPhone = new MobilePhone(amodel, price, purchaseDate);
            Console.WriteLine($" This model is: {firstPhone.Model} and the price is: {firstPhone.Price} with purchase date {firstPhone.PurchaseDate}.");
            mobilePhones.Add(firstPhone);
        }
    }
}
