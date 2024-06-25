namespace ConsoleApp1.Samples
{
	public class Circle
	{
		public int Radius { get; }
		
		public Circle(int radius)
		{
			Radius = radius;
		}
	}

	public class Rectangle
	{
		public int Length { get; }
		public int Width { get; }

		public Rectangle(int length, int width)
		{
			Length = length;
			Width = width;
		}
	}

	public class Triangle
	{
		public int Side1 { get; }
		public int Side2 { get; }
		public int Side3 { get; }

		public Triangle(int side1, int side2, int side3)
		{
			Side1 = side1;
			Side2 = side2;
			Side3 = side3;
		}
	}
		
	public static class SwitchExpressionSample
	{
		public static string DisplayShapeInfo(object shape)
		{
			// reminders:
			// - No case keyword, defined by lambda
			// - No break keyword --> No fallthrough
			// - discard pattern for default case
			return shape switch
			{
				Rectangle r => $"Rectangle (l={r.Length} w={r.Width})",
				Circle c => $"Circle (r={c.Radius})",
				Triangle t => $"Triangle ({t.Side1}, {t.Side2}, {t.Side3})",
				_ => "Unknown shape"
			};
		}
		
		public static string DisplayShapeInfo_expanded(object shape)
		{
			// reminders:
			// - first match wins
			// - note difference between detailed cases (circle) and nested expressions (rect)
			return shape switch
			{
				Rectangle r => r switch
				{
					_ when r.Length==r.Width => "Square",
					_ => $"Rectangle (l={r.Length} w={r.Width})"
				},
				Circle {Radius:1} => "Small Circle!",
				Circle c => $"Circle (r={c.Radius})",
				Triangle t => $"Triangle ({t.Side1}, {t.Side2}, {t.Side3})",
				_ => "Unknown shape"
			};
		}
	}
}