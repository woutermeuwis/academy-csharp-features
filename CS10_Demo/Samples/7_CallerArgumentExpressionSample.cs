using System.Runtime.CompilerServices;

namespace CS10_Demo.Samples;

public class CallerArgumentExpressionSample
{
	public static void Run()
	{
		var a = 42;
		var b = false;

		CheckExpression(a > 0);
		CheckExpression(true);
		CheckExpression(b);
	}

	static void CheckExpression(bool condition, [CallerArgumentExpression("condition")] string message = null)
		=> Console.WriteLine($"Condition: {message}");
}