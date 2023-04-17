using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    public abstract class Asset
    {
        public string Model {get; set;}
        public int Price { get; set; }
        public DateTime PurchaseDate { get; set; }

        public Asset()
        {

        }


        public Asset(string model, int price, DateTime purchaseDate)
        {
            Model = model;
            Price = price;
            PurchaseDate = purchaseDate;
        }
    }
}
