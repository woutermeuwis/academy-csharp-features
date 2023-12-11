using System;
using Shared.Dtos;
using Shared.Enums;

namespace RecordExperiments.Demos
{
    // ReSharper disable once UnusedType.Global
    public class Demo2
    {
        #region Explanation

        // Classes are equal if their references are the same value

        // records are equal when they are of the exact same type, and all of their properties are equal

        #endregion
        
        // ReSharper disable once UnusedMember.Global
        public static void Run()
        {
            String_Test();
            Equality_Test();
        }
        
        static void String_Test()
        {
            EventPriceDto dto = new(1, DateTimeOffset.Now, "Test", EventType.Concert, "Music Hall", 80, 100);
            dto.ToString().Print();
        }

        static void Equality_Test()
        {
            var now = DateTimeOffset.Now;       
            EventPriceDto dto = new(1, now, "Test", EventType.Concert, "Music Hall", 80, 100);
            EventPriceDto dto2 = new(1, now, "Test", EventType.Concert, "Music Hall", 80, 100);

            (dto == dto2).PrintEquality();
        }
    }
}