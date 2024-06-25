using System.Text;

namespace CS10_Demo.Samples;

public class InterpolatedStrings {
	public static void Run()
	{
		// old:
		var s = "A string";
		var i = 12;
		var interpolated = $"String: {s}, int {i}";
		var behindTheScenes = string.Format("String: {0}, int: {1}", s, i);

		var sb = new StringBuilder();
		sb.Append($"String: {s}, int {i}");
	}
}