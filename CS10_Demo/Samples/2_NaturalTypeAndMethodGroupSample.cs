namespace CS10_Demo.Samples;

public class NaturalTypeAndMethodGroupSample_Old
{
	public static void Run()
	{
		// Old style, lambda is transformed to the delegate behind the scenes
		Func<string, int> converter = s => int.Parse(s);
		PassingOn(converter);
	}

	static void PassingOn(Func<string, int> converter)
	{
		// This method accepts a convert.
		// This is rather strict as the delegate passed to the function is defined
		// as having a single string param and an int return type
	}

	static void PassingOn1(Delegate converter)
	{
		// nothing new here, Delegate is the base type of all delegates (like action or string)
		// This method can figure out how to call the converter by examining the metadata at runtime
	}
}

public class NaturalTypeAndMethodGroupSample_New
{
	public static void Run()
	{
		// lambdas no longer have to be cast to a delegate, they have a natural type in C#10
		// they are now naturally of a delegate type.
		//PassingOn(s => int.Parse(s));
		
		// the issue above is that the types of the parameter cannot be inferred, this is easy to fix!
		PassingOn((string s) => int.Parse(s));
		
		// method groups now also have a natural type:
		var p = Parse;
		var x = p("22");
	}

	static void PassingOn(Delegate converter)
	{

	}

	static int Parse(string s)
		=> int.Parse(s);
}