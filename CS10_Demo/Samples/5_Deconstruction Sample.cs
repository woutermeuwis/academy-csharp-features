namespace CS10_Demo.Samples;

public class Deconstruction_Sample
{
	public record class Address(string Street, string City);
	
	public static void Run()
	{
		var addr = new Address("Main", "Washington");
		var (street, city) = addr;
		
		// names are not relevant and can be anything!
		var (hello, world) = addr;
		
		// can be used for existing variables!
		string s, c;
		(s, c) = addr;
		
		// In the past we had to either declare all variables while deconstructing
		// or use a set of predefined variables, now we can mix!
		string x;
		(x, string y) = addr;
	}
}