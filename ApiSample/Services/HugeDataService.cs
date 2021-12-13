using ApiSample.Models;
using GenFu;

namespace ApiSample.Services;

public class HugeDataService
{
    public async IAsyncEnumerable<Person> LoadManyPersons()
    {
        var items = Enumerable.Range(1, 1000);
        foreach(var i in items)
        {
            yield return A.New<Person>(new Person { Id = i });
        }
    }
}
