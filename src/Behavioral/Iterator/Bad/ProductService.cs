namespace Iterator.Bad;
public class ProductService
{
    private readonly List<Product> _products;

    public ProductService()
    {
        // Simulate database
        _products = Enumerable.Range(1, 50)
            .Select(i => new Product { Id = i, Name = $"Product {i}" })
            .ToList();
    }

    public List<Product> GetPage(int pageNumber, int pageSize)
    {
        return _products
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList();
    }
}
