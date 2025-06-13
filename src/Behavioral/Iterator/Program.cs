using Iterator.Refactored;

Console.WriteLine("=== Bad Example ===");
var service = new Iterator.Bad.ProductService();
int page = 1;
int pageSize = 10;
List<Iterator.Bad.Product> products;

do
{
    products = service.GetPage(page++, pageSize);
    foreach (var product in products)
    {
        Console.WriteLine(product.Name);
    }

} while (products.Count == pageSize);

Console.WriteLine();
Console.WriteLine("=== Refactored Example ===");
var collection = new ProductCollection();
var iterator = collection.CreateIterator(pageSize: 10);

while (iterator.HasNext())
{
    var product = iterator.Next();
    Console.WriteLine(product.Name);
}