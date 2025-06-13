namespace AbstractFactory.Refactored;
public interface IReportComponentFactory
{
    IHeaderRenderer CreateHeaderRenderer();
    IBodyRenderer CreateBodyRenderer();
}