using TemplateMethod.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var csvImporter = new TemplateMethod.Bad.CsvDataImporter();
csvImporter.Import();

var jsonImporter = new TemplateMethod.Bad.JsonDataImporter();
jsonImporter.Import();


Console.WriteLine("\n=== REFACTORED EXAMPLE (TEMPLATE METHOD) ===");
DataImporter csv = new CsvDataImporter();
csv.Import();

DataImporter json = new JsonDataImporter();
json.Import();