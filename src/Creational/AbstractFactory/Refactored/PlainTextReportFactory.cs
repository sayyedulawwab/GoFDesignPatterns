namespace AbstractFactory.Refactored;
public class PlainTextReportFactory : IReportComponentFactory
{
    public IHeaderRenderer CreateHeaderRenderer() => new PlainTextHeaderRenderer();
    public IBodyRenderer CreateBodyRenderer() => new PlainTextBodyRenderer();
}
