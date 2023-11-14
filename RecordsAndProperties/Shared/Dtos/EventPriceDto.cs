using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public class EventPriceDto : DtoBase
    {
        public int PercentageSold { get; }
        public int TicketPrice { get; }

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
}