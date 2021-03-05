using System.Globalization;

namespace PriceTags.Entities
{
    class Product
    {
        protected string Name { get; set; }
        protected double Price { get; set; }

        public Product() { }

        public Product(string nameProduct, double priceProduct)
        {
            Name = nameProduct;
            Price = priceProduct;
        }

        public virtual string PriceTag()
        {
            return Name + " $ " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
