namespace ConsoleApp1.Samples
{
	public enum Color
	{
		Unknown,
		Red,
		Blue,
		Green,
		Purple,
		Orange,
		Brown,
		Yellow
	}

	public class d_TuplePatternSample
	{

		public static Color MixColor(Color c1, Color c2)
		{
			return (c1, c2) switch
			{
				(Color.Red, Color.Blue) => Color.Purple,
				(Color.Blue, Color.Red) => Color.Purple,

				(Color.Yellow, Color.Red) => Color.Orange,
				(Color.Red, Color.Yellow) => Color.Orange,

				(Color.Red, Color.Green) => Color.Brown,
				(Color.Green, Color.Red) => Color.Brown,

				(_, _) when c1 == c2 => c1,

				_ => Color.Unknown
			};
		}
	}
}