using System;
using System.Collections.Generic;
using System.Globalization;
using PriceTags.Entities;


namespace PriceTags
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productsList = new List<Product>();

            Console.Write("Enter the number of products: ");
            int controlExec = int.Parse(Console.ReadLine());

            for (int i = 1; i <= controlExec; i++)
            {
                Console.WriteLine("Product {0} data: ", i);

                Console.Write("Common, used or imported (c/u/i)? ");
                char validValue = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string nameProduct = Console.ReadLine();

                Console.Write("Price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (validValue == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customs = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    ImportedProduct newImported = new ImportedProduct(nameProduct, priceProduct, customs);
                    productsList.Add(newImported);
                }

                else if (validValue == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    UsedProduct newUsed = new UsedProduct(nameProduct, priceProduct, manufactureDate);
                    productsList.Add(newUsed);
                }

                else if (validValue == 'c')
                {
                    Product newCommon = new Product(nameProduct, priceProduct);
                    productsList.Add(newCommon);
                }
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine("PRICE TAGS:");
            Console.WriteLine();

            foreach (Product obj in productsList) {
               Console.WriteLine(obj.PriceTag().ToString());
                Console.WriteLine();
            }


        }
    }
}
