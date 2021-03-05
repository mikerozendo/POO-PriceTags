using System.Globalization;

namespace PriceTags.Entities
{
    class ImportedProduct : Product
    {
        private double CustomFee { get; set; }

        public ImportedProduct(string nameProduct, double priceProduct, double customFee) : 
            base(nameProduct, priceProduct)
        {
            CustomFee = customFee;
        }
        public double TotalPrice()
        {
            return Price + CustomFee;
        }
        public sealed override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2", CultureInfo.InvariantCulture)
                + " " + "(Customs fee: $" + CustomFee.ToString("F2", CultureInfo.InvariantCulture) + ")";
        }
    }
}
