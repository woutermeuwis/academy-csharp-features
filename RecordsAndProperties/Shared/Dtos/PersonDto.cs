using System;

namespace Shared.Dtos
{
    public record PersonDto(int Id, int Age)
    {
        public string Name { get; }
        public string City { get; }
        
        public string DoNotDoThis { get; set; }

        public void Method()
        {
            Console.WriteLine("Methods are also possible");
        }
        
        // Only positional properties (Id, Age) are added to the constructor / deconstructor by default
        // Extra constructors and deconstructors can be added, as long as they do not override the default ones

        public void Deconstruct(out string name, out string city)
        {
            name = Name;
            city = City;
        }
    }
}