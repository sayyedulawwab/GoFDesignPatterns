namespace Iterator.Refactored;
public class ProductIterator : IProductIterator
{
    private readonly List<Product> _products;
    private readonly int _pageSize;
    private int _currentIndex = 0;

    public ProductIterator(List<Product> products, int pageSize)
    {
        _products = products;
        _pageSize = pageSize;
    }

    public bool HasNext()
    {
        return _currentIndex < _products.Count;
    }

    public Product Next()
    {
        if (!HasNext()) throw new InvalidOperationException();

        var product = _products[_currentIndex];
        _currentIndex++;
        return product;
    }
}
