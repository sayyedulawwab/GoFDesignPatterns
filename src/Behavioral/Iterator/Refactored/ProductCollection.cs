namespace Iterator.Refactored;
public class ProductCollection
{
    private readonly List<Product> _products;

    public ProductCollection()
    {
        _products = Enumerable.Range(1, 50)
            .Select(i => new Product { Id = i, Name = $"Product {i}" })
            .ToList();
    }

    public IProductIterator CreateIterator(int pageSize)
    {
        return new ProductIterator(_products, pageSize);
    }
}
