using AbstractFactory.Bad;
using AbstractFactory.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var bad = new ReportRenderer(Format.Html);
bad.Render();

Console.WriteLine("\n=== REFACTORED EXAMPLE (ABSTRACT FACTORY) ===");
var htmlService = new ReportService(new HtmlReportFactory());
htmlService.RenderReport();

Console.WriteLine();

var textService = new ReportService(new PlainTextReportFactory());
textService.RenderReport();
