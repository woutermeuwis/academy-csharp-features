namespace CS10_Demo.Samples;

public class DelegateRefreshSample
{
	public delegate int ConversionDelegate(string input);

	static int Conversion(string input)
		=> int.Parse(input);

	static int AnotherConversion(string input)
		=> int.Parse(input) + 1;

	public static void Run()
	{
		var convert = new ConversionDelegate(Conversion);
		var result = convert("SomeString");
	}
}