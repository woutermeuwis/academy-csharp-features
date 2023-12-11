using System;
using Shared.Dtos;
using Shared.Enums;

namespace RecordExperiments.Demos
{
    // ReSharper disable once UnusedType.Global
    public class Demo1
    {
        // ReSharper disable once UnusedMember.Global
        public static void Run()
        {
            var dto = Constructor_Demo();
            var dto2 = Initializer_Demo();

            Deconstruct_Demo(dto);
            Deconstruct_Demo(dto2);
        }

        private static EventPriceDto Constructor_Demo()
        {
            return new EventPriceDto(1, DateTimeOffset.Now, "Test", EventType.Concert, "Music Hall", 80, 100);
        }

        private static EventPriceDto Initializer_Demo()
        {
#if !RECORDS
            return new EventPriceDto
            {
                Id = 1,
                Date = DateTimeOffset.Now,
                Name = "Test",
                EventType = EventType.Concert,
                Venue = "Music Hall",
                PercentageSold = 80,
                TicketPrice = 100
            };
#else
            return null;
#endif
        }

        private static void Deconstruct_Demo(EventPriceDto dto)
        {
            if (dto == null)
            {
                "null".Print();
                return;
            }

            var (id, date, name, eventType, venue, percentageSold, price) = dto;
            $"{id}, {date}, {name}, {eventType}, {venue}, {percentageSold}, {price}".Print();
        }
    }
}