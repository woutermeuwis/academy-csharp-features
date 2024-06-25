using System;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApp1.Samples
{
	public class IndicesAndRangesSample
	{
		public static void RunSample()
		{
			var numbers = Enumerable.Range(1, 10).ToArray(); // initiate an array [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]

			// copy entire array, start/end indices optional, all 4 copies are the same
			// but specifying the end might be risky if the size is subject to change
			var copy = numbers[..];
			var copy2 = numbers[0..];
			var copy3 = numbers[..10]; // the end index is exclusive, so this will include items with indices 0 through 9
			var copy4 = numbers[0..10];

			// we can also use index ^x to access the element at index `array.Length - x`
			// (note that this means ^0 is out of bounds, and ^1 returns the last element)
			var copy5 = numbers[0..^0]; // This works because while ^0 the closing index is also exclusive, so the last included element will be ^1
			var allButFirst = numbers[1..];
			var lastItemRange = numbers[^1..]; // returns arr
			var lastItem = numbers[^1]; // returns int
			var lastThree = numbers[^3..];

			// logging:
			LogArray(numbers);
			LogArray(copy);
			LogArray(copy2);
			LogArray(copy3);
			LogArray(copy4);
			LogArray(copy5);
			LogArray(allButFirst);
			LogArray(lastItemRange);
			Console.WriteLine($"{nameof(lastItem),15}: {lastItem}");
			LogArray(lastThree);
		}

		static void LogArray(int[] array, [CallerArgumentExpression("array")] string name = null)
			=> Console.WriteLine($"{name,15}: [{string.Join(", ", array)}]");

	}
}