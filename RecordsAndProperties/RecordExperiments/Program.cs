using System;
using System.Linq;
using System.Reflection;

namespace RecordExperiments
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var className = $"Demo{Environment.GetEnvironmentVariable("Demo")}";
            Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.FullName?.EndsWith(className)??false)
                .Select(t => (Action)Delegate.CreateDelegate(typeof(Action), null, t.GetMethod("Run", BindingFlags.Static | BindingFlags.Public)))
                .FirstOrDefault()
                ?.Invoke();
        }
    }
}