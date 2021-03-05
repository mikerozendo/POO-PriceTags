using System;
using System.Collections.Generic;
using System.Globalization;


namespace PriceTags.Entities
{
    class UsedProduct : Product
    {
        protected DateTime ManufactureDate {  get;  set; }

        public UsedProduct(string nameProduct, double priceProduct, DateTime manufacture) :
            base(nameProduct, priceProduct)
        {
            ManufactureDate = manufacture;
        }
        public sealed override string PriceTag()
        {
            return Name + " $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + " (Manufacture date: " + ManufactureDate.ToString("dd/MM/yyyy") + ")"; 
        }
    }
}
