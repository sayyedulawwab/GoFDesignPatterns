namespace AbstractFactory.Refactored;
public class ReportService
{
    private readonly IReportComponentFactory _factory;

    public ReportService(IReportComponentFactory factory)
    {
        _factory = factory;
    }

    public void RenderReport()
    {
        var header = _factory.CreateHeaderRenderer();
        var body = _factory.CreateBodyRenderer();

        header.Render();
        body.Render();
    }
}
