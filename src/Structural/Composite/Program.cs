using Composite.Refactored;

Console.WriteLine("=== BAD EXAMPLE ===");
var badUser = new Composite.Bad.User();
badUser.Permissions.Add("Read");
badUser.Permissions.Add("Write");

Console.WriteLine(badUser.HasPermission("Read"));     // true
Console.WriteLine(badUser.HasPermission("Execute"));  // false

Console.WriteLine("\n=== REFACTORED EXAMPLE (COMPOSITE PATTERN) ===");

// Create leaf permissions
var read = new SinglePermission("Read");
var write = new SinglePermission("Write");
var execute = new SinglePermission("Execute");

// Compose groups
var readWriteGroup = new PermissionGroup();
readWriteGroup.Add(read);
readWriteGroup.Add(write);

var adminGroup = new PermissionGroup();
adminGroup.Add(readWriteGroup);
adminGroup.Add(execute);

// Create user with read/write group
var refactoredUser = new User(readWriteGroup);
Console.WriteLine(refactoredUser.HasPermission("Read"));     // true
Console.WriteLine(refactoredUser.HasPermission("Execute"));  // false