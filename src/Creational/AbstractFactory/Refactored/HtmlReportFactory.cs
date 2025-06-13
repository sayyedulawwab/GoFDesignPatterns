namespace AbstractFactory.Refactored;
public class HtmlReportFactory : IReportComponentFactory
{
    public IHeaderRenderer CreateHeaderRenderer() => new HtmlHeaderRenderer();
    public IBodyRenderer CreateBodyRenderer() => new HtmlBodyRenderer();
}
