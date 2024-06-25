namespace CS10_Demo.Samples;

public class PropertyPatternMatchSample
{
	public record Address(string Street, string City);

	public record Person(string FirstName, string LastName, Address Address);

	public static void Run()
	{
		var p = new Person("Wouter", "Meuwis", new("Lozenweg", "Hamont"));

		// old
		if (p is Person { Address: { City: "Hamont" } } person)
			Console.WriteLine(person.FirstName);
		
		// new
		if(p is Person { Address.City: "Hamont"} person2)
			Console.WriteLine(person2.FirstName);
	}
}