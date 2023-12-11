using System;
using Shared.Enums;

namespace Shared.Dtos
{
    #if FULLCLASS
    public class EventPriceDto : DtoBase
    {
        public int PercentageSold { get; set; }
        public int TicketPrice { get; set; }
        
        public EventPriceDto()
        { }
        
        public EventPriceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, int percentageSold, int ticketPrice) 
            : base(id, date, name, eventType, venue)
        {
            PercentageSold = percentageSold;
            TicketPrice = ticketPrice;
        }

        public void Deconstruct(out int id, out DateTimeOffset date, out string name, out EventType eventType, out string venue, out int percentageSold, out int ticketPrice)
        {
            id = Id;
            date = Date;
            name = Name;
            eventType = EventType;
            venue = Venue;
            percentageSold = PercentageSold;
            ticketPrice = TicketPrice;
        }
    }

#elif RECORD

    public record EventPriceDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, int PercentageSold, int TicketPrice)
        : DtoBase(Id, Date, Name, EventType, Venue);

#else
    public class EventPriceDto : DtoBase
    {
        public int PercentageSold { get; init; }
        public int TicketPrice { get; init; }
        
        public EventPriceDto()
        { }

        public EventPriceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, int percentageSold, int ticketPrice) 
            : base(id, date, name, eventType, venue)
        {
            PercentageSold = percentageSold;
            TicketPrice = ticketPrice;
        }

        public void Deconstruct(out int id, out DateTimeOffset date, out string name, out EventType eventType, out string venue, out int percentageSold, out int ticketPrice)
        {
            id = Id;
            date = Date;
            name = Name;
            eventType = EventType;
            venue = Venue;
            percentageSold = PercentageSold;
            ticketPrice = TicketPrice;
        }
    }

#endif
}