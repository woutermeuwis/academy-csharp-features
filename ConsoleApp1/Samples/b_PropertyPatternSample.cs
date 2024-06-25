namespace ConsoleApp1.Samples
{
	public class Employee
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Type { get; set; }
		public string Region { get; set; }
		public Employee ReportsTo { get; set; }
	}
	
	public static class PropertyPatternSample
	{
		public static bool IsUsBasedWithUkManager(Employee e)
		{
			return e is { Region: "US", ReportsTo: { Region: "UK" } };
		}
		
		public static bool IsUsBasedWithUkManager(object o)
		{
			return o is Employee e &&
			       e is { Region: "US", ReportsTo: { Region: "UK" } };
		}
		
		public static bool IsUsBasedWithUkManager_Shorter(object o)
		{
			return o is Employee { Region: "US", ReportsTo: { Region: "UK" } };
		}
	}
}