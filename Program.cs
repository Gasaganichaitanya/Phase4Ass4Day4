// See https://aka.ms/new-console-template for more information
using Assessment4Phase4;

SortedList<string, Product> Products = new SortedList<string, Product>();

//Adding five sample products
Products.Add("Product2", new Product() { PName = "Face cream", PBrand = " Mamaearth", PPrice = 223, ManufacturingDate = new DateTime(day: 10, month: 08, year: 2022), ExpiryDate = new DateTime(day: 11, month: 10, year: 2025) });
Products.Add("Product1", new Product() { PName = "Shampoo", PBrand = " Dove", PPrice = 301, ManufacturingDate = new DateTime(day: 20, month: 01, year: 2023), ExpiryDate = new DateTime(day: 11, month: 10, year: 2025) });
Products.Add("Product3", new Product() { PName = "Moisturizing cream", PBrand = " Nova", PPrice = 99, ManufacturingDate = new DateTime(day: 10, month: 08, year: 2022), ExpiryDate = new DateTime(day: 11, month: 10, year: 2024) });
Products.Add("Product4", new Product() { PName = "Hair Oil", PBrand = " Parachute", PPrice = 150, ManufacturingDate = new DateTime(day: 10, month: 08, year: 2022), ExpiryDate = new DateTime(day: 11, month: 10, year: 2024) });
Products.Add("Product5", new Product() { PName = "Maggie", PBrand = " Maggi", PPrice = 49, ManufacturingDate = new DateTime(day: 10, month: 08, year: 2022), ExpiryDate = new DateTime(day: 11, month: 10, year: 2024) });
Products.Add("Product6", new Product() { PName = "Product6", PBrand = " PBrand6", PPrice = 999, ManufacturingDate = new DateTime(day: 01, month: 01, year: 2024), ExpiryDate = new DateTime(day: 01, month: 01, year: 2026) });


foreach (var product in Products)
{
    Console.WriteLine($"Product Id : {product.Key}");
    Console.WriteLine($"Product Name : {product.Value.PName}");
    Console.WriteLine($"Product Price : {product.Value.PPrice }");
    Console.WriteLine($"Product Brand {product.Value.PBrand}");
    Console.WriteLine($"Product ManufacturingDate : { product.Value.ManufacturingDate.ToLongDateString()}");
    Console.WriteLine($"Product ExpiryDate : {product.Value.ExpiryDate.ToLongDateString()}");

    Console.WriteLine("\n");
}


