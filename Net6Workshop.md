# .Net 6 Workshop

## Links

[Announcment](https://devblogs.microsoft.com/dotnet/announcing-net-6/)

[C# 10](https://devblogs.microsoft.com/dotnet/welcome-to-csharp-10/)

[ASP-Core-Net-6](https://devblogs.microsoft.com/dotnet/announcing-asp-net-core-in-net-6/)

asp.net-hacker.rocks - Blog
JuergenGutsch - Git => https://github.com/JuergenGutsch/developer-open-space-aspnet

## Tools von Jürgen Gutsch

Cmder - CMD-Tool
Typora - Markdown Editor
Insomnia - GRPC Client ähnlich Postman => Insomnia.rest


## GenFu Package zur Generierung von Testdatensätzen

dotnet add package GenFu
=> A.New<Person>(new Person { Id = i });


## Net 6 NEW

IAsyncDisposable

IAsyncEnumerable zur Reduzierung von Speicherverbrauch, weil nicht gebuffert
Ist duchimplementiert von EF 6 bis Outputstream im Net 6

dotnet watch run => dotnet watch

Gefahr bei Verwendung von Blazor WASM - zu viel Logik in den Client zu haben


## Blazor Demos

### ApiSample

Swagger, IAsyncEnumerable, GenFu

Program.cs
- Swagger with minimal API and additinal meta information

Services/HugeDataService.cs
- IAsyncEnumerable, GenFu


### Blazor App

Parameters, DynamicComponent, HeadContent for meta tag, ErrorBoundary - if a component fails the site will be up

Components/MyComponent.razoor
- Component with required Parameter

Pages/Index.razor
- HeadContent, Component, Dynamic Component
- Error Boundary - usa at page level
- Get Parameter from Query => in uri : ?parameter=value

JavaScript
- wwwroot/BlazorApp.lib.module.js - adds mycomponent to ui
- Program.cs


### GprcDemo

Simple GprcService (Server) - Tool Insomnia as test client


### MvcApp

W3CLogging, HttpLogging

Program.cs

### RecordsSample

very short demo with docu inside

### SimpleApp

minimal api
