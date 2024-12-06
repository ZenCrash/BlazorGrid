using static BlazorGrid.FluentUi.Data.Person;

namespace BlazorGrid.FluentUi.Data
{
  public class TestManager
  {
    public ICollection<Person> GetAll()
    {
      return new List<Person>()
      {
        new Person { Id = 1, Name = "John Doe", Description = "A test person", Title = "Mr.", Gender = Sex.Male },
        new Person { Id = 2, Name = "Jane Smith", Description = "A test person", Title = "Ms.", Gender = Sex.Female },
        new Person { Id = 3, Name = "Tom Green", Description = "A test person", Title = "Mr.", Gender = Sex.Male },
        new Person { Id = 4, Name = "Alice Johnson", Description = "A test person", Title = "Ms.", Gender = Sex.Female },
        new Person { Id = 5, Name = "Charlie Brown", Description = "A test person", Title = "Mr.", Gender = Sex.Male },
        new Person { Id = 6, Name = "Sophia White", Description = "A test person", Title = "Ms.", Gender = Sex.Female },
        new Person { Id = 7, Name = "David Lee", Description = "A test person", Title = "Mr.", Gender = Sex.Male },
        new Person { Id = 8, Name = "Emma Harris", Description = "A test person", Title = "Ms.", Gender = Sex.Female },
        new Person { Id = 9, Name = "James Wilson", Description = "A test person", Title = "Mr.", Gender = Sex.Male },
        new Person { Id = 10, Name = "Olivia Clark", Description = "A test person", Title = "Ms.", Gender = Sex.Female }
      };


    }
  }
}
