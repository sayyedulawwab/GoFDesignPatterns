namespace Facade.Refactored;
public class ReportingFacade
{
    private readonly DataFetcher _fetcher = new();
    private readonly Formatter _formatter = new();
    private readonly Filter _filter = new();
    private readonly ReportGenerator _generator = new();
    private readonly EmailSender _emailSender = new();

    public void GenerateAndSendReport()
    {
        var rawData = _fetcher.FetchData();
        var formattedData = _formatter.Format(rawData);
        var filteredData = _filter.ApplyFilter(formattedData);
        var report = _generator.GenerateReport(filteredData);
        _emailSender.SendEmail(report);
    }
}
