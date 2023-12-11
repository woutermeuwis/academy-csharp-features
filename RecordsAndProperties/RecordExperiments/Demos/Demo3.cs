using System;
using Shared.Dtos;
using Shared.Enums;

namespace RecordExperiments.Demos
{
    public class Demo3
    {
        public static void Run()
        {
            Clone_Demo();
        }

        static void Clone_Demo()
        {
#if RECORDS
            EventPriceDto dto = new(1, DateTimeOffset.Now, "Test", EventType.Concert, "Music Hall", 80, 100);
            
            DtoBase dto2 = dto with { Name = "Concert" };
            
            (dto == dto2).PrintEquality();
            
            dto2.ToString().Print(); 
            
            dto2.GetType().FullName.Print();
#else
            "DEMO 3 only runs in RECORDS build config!".Print();
#endif
        }
    }
}