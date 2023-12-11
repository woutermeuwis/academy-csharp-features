using System;

namespace RecordExperiments
{
    public static class Extensions
    {
        public static void Print(this string s) => Console.WriteLine(s + "\n");
        public static void PrintEquality(this bool b) => Console.WriteLine(b ? "The values are equal!\n" : "The values are NOT equal!\n");
    }
}