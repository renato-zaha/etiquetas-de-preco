// See https://aka.ms/new-console-template for more information
using etiquetasdepreco.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int numberOfProducts = int.Parse(Console.ReadLine());
List<Product> products = new List<Product>();

for (int i = 1; i <= numberOfProducts; i++)
{
    Console.WriteLine($"Product {i} data:");
    Console.Write("Common, used or imported (c/u/i)?");
    string tipoDeProduto = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);
    
    if(tipoDeProduto == "c")
    {
        products.Add(new Product() { Name = name, Price = price });
    }
    else if (tipoDeProduto == "i")
    {
        Console.Write("Customs fee: ");
        double customsFee = double.Parse(Console.ReadLine(),CultureInfo.CurrentCulture);
        products.Add(new ImportedProduct() { Name = name, Price = price, CustomsFees = customsFee }); 
    }
    else
    {
        Console.Write("Manufacture date: ");
        DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
        products.Add(new UsedProduct() { Name = name,Price=price, ManufactureDate = manufactureDate});
    }
 }
Console.WriteLine();
Console.WriteLine("PRICE TAGS:");
foreach (Product product in products)
{ 
    Console.WriteLine(product.priceTag());
}