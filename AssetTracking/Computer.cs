using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    class Computer: Asset
    {
        public Computer()
        {

        }

        public Computer(string Model, int Price, DateTime PurchaseDate)
        {
            this.Model = Model;
            this.Price = Price;
            this.PurchaseDate = PurchaseDate;
        }
    }
}
