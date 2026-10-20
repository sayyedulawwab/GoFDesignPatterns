# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Commands

`GoFDesignPatterns.slnx` (the XML solution format, .NET 10 SDK) holds 23 independent console apps (`net10.0`, `OutputType=Exe`), one per GoF pattern. There is no test project, no shared library, and no `Directory.Build.props`, `.editorconfig`, or `global.json`.

```bash
dotnet run --project src/Behavioral/Strategy           # run one pattern
dotnet build src/Creational/Singleton                  # build one pattern
dotnet build GoFDesignPatterns.slnx                     # build everything (0 errors; a few CS8618 nullable warnings remain)
```

Each app just prints to the console and exits. `Proxy`'s `Program.cs` calls `Thread.Sleep(6000)` twice, so it takes about 12 seconds.

## Layout

```
src/<Category>/<PatternName>/
  <PatternName>.csproj    # identical SDK-template csproj in every project
  Program.cs              # top-level statements: runs Bad, then Refactored
  Bad/                    # namespace <PatternName>.Bad
  Refactored/             # namespace <PatternName>.Refactored
```

- `<Category>` is `Behavioral`, `Creational`, or `Structural`. In the solution, projects are nested under the `src` > `<Category>` solution folders.
- The project, folder, and root namespace are the pattern name in PascalCase with no spaces (`ChainOfResponsibility`, `FactoryMethod`).
- Every example uses a backend scenario (payments, orders, notifications, config, reports, middleware) rather than textbook shapes or animals.

## Conventions for a new pattern example

- `Bad/` shows the problem without the pattern (if/else on a string, duplicated code, tight coupling). `Refactored/` applies the pattern to the same scenario.
- The two folders are self-contained: `Refactored/` redefines any model it needs (e.g. `HttpRequest`, `User`, `Product`) instead of reusing the `Bad/` one, so same-named types in both are normal.
- `Program.cs` prints `=== BAD EXAMPLE ===`, runs the bad version, then prints `\n=== REFACTORED EXAMPLE (<NAME> PATTERN) ===` and runs the refactored version on the same scenario. When type names collide, it imports one namespace and fully qualifies the other (`new Proxy.Bad.PaymentService()`).
- File-scoped namespaces, one type per file (two `Bad/` files also declare a small helper type), explicit constructors with `_camelCase` readonly fields, `var` for locals. Interfaces are `I`-prefixed. "External" work (Stripe, SMS, email, I/O) is simulated with `Console.WriteLine`; there are no NuGet packages and no async code.
- To add one: `dotnet new console -n <Name> -o src/<Category>/<Name> --framework net10.0`, then `dotnet sln GoFDesignPatterns.slnx add src/<Category>/<Name>/<Name>.csproj` (this reuses the existing `src`/`<Category>` solution folders). Add the pattern to both lists in `README.md` (the "ordered by usefulness" list and its category section), using the same GitHub `tree/main/src/...` link format.

## Quirks

- `Iterator` and a few other projects still build with CS8618 nullable warnings (non-nullable string properties without initializers).
- `Program.cs` headings are not uniform: `Iterator`, `Memento`, and `Facade` use different casing or omit the pattern name. Some files (e.g. `Mediator/Refactored/UserService.cs`) carry redundant `using System...` lines that `ImplicitUsings` already covers.
- Source files are UTF-8 with BOM and CRLF line endings.
