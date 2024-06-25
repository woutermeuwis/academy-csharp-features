namespace ConsoleApp1.Samples
{
	public class Teacher
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Subject { get; set; }

		public Teacher(string firstName, string lastName, string subject)
		{
			FirstName = firstName;
			LastName = lastName;
			Subject = subject;
		}

		public void Deconstruct(out string firstName, out string lastName, out string subject)
		{
			firstName = FirstName;
			lastName = LastName;
			subject = Subject;
		}
	}
	
	public class Student
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Teacher Teacher { get; set; }
		public int Grade { get; set; }

		public Student(string firstName, string lastName, Teacher teacher, int grade)
		{
			FirstName = firstName;
			LastName = lastName;
			Teacher = teacher;
			Grade = grade;
		}

		public void Deconstruct(out string firstName, out string lastName, out Teacher teacher, out int grade)
		{
			firstName = FirstName;
			lastName = LastName;
			teacher = Teacher;
			grade = Grade;
		}
	}
	
	public static class PositionalPatternSample
	{
		public static bool IsInSeventhGrade(Student s)
		{
			return s is Student(_, _, _, 7);
		}

		public static bool IsInMathClass(Student s)
		{
			return s is Student(_, _, Teacher(_, _, "Math"), _);
		}

		public static bool IsInSeventhGradeMath(Student s)
		{
			return s is Student(_, _, Teacher(_, _, "Math"), 7);
		}
		
		public static bool IsInSeventhGradeMath_SHORT(Student s)
		{
			return s is (_, _, (_, _, "Math"), 7);
		}
	}
}