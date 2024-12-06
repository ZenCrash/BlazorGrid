namespace BlazorGrid.FluentUi.Data
{
  public class Person
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Title { get; set; }
    public Sex Gender { get; set; }

    public enum Sex
    {
      Male,
      Female,
      A,
			B,
			C,
			D,
			E,
			F,
			G,
			H,
			I,
			J,
		}
  }
}
