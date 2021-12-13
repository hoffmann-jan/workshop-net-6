Person person1 = new(0, "Foo", "Bar");
Person person2 = new(0, "Foo", "Bar");

Console.WriteLine(person1);
Console.WriteLine(person1 == person2);

// Erbt von Klasse; Referencetype; Overrides ToString
// Compares like a Valuetype
// good for data from database
public record Person(int Id, string Firstname, string Lastname);

//
public record struct PersonRS(int Id, string Firstname, string Lastname);


// docu : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/record
// 101  : https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
