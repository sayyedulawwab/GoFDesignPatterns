using Memento.Bad;
using Memento.Refactored;

Console.WriteLine("=== Bad Example ===");
var editor = new DocumentEditor();

editor.Write("Hello");
var snapshot = editor.GetContent();
editor.Write(" World");

Console.WriteLine("Current: " + editor.GetContent());
editor.Undo(snapshot);
Console.WriteLine("After Undo: " + editor.GetContent());

Console.WriteLine();
Console.WriteLine("=== Refactored Example ===");



var document = new Document();
var history = new History();

document.Write("Hello");
history.Save(document.CreateMemento());

document.Write(" World");
Console.WriteLine("Current: " + document.GetContent());

document.Restore(history.Undo());
Console.WriteLine("After Undo: " + document.GetContent());
