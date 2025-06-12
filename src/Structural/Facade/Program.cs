using Facade.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");

var fetcher = new Facade.Bad.DataFetcher();
var formatter = new Facade.Bad.Formatter();
var filter = new Facade.Bad.Filter();
var generator = new Facade.Bad.ReportGenerator();
var emailSender = new Facade.Bad.EmailSender();

var rawData = fetcher.FetchData();
var formattedData = formatter.Format(rawData);
var filteredData = filter.ApplyFilter(formattedData);
var report = generator.GenerateReport(filteredData);
emailSender.SendEmail(report);


Console.WriteLine("=== REFACTORED EXAMPLE ===");

var facade = new ReportingFacade();
facade.GenerateAndSendReport();