using System;
using System.Collections.Generic;
using System.Text;

namespace AssetTracking
{
    public class MobilePhone: Asset
    {
        public MobilePhone()
        {

        }

        public MobilePhone(string model, int price, DateTime purchaseDate)
        {
            Model = model;
            Price = price;
            PurchaseDate = purchaseDate;
        }
    }
}
