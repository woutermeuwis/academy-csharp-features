using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
    public class EventDto : DtoBase
    {
        public int Capacity { get; }
        public int Sold { get; }
        public CostType VenueCostType { get; }
        public CostType MarketingCostType { get; }

        protected EventDto() : base()
        {
        }

        protected EventDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold)
            : base(id, date, name, eventType, venue)
        {
            VenueCostType = venueCostType;
            MarketingCostType = marketingCostType;
            Capacity = capacity;
            Sold = sold;
        }
    }

#elif RECORD
    public record EventDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, CostType VenueCostType, CostType MarketingCostType, int Capacity, int Sold)
        : DtoBase(Id, Date, Name, EventType, Venue);

#else
    public class EventDto : DtoBase
    {
        public int Capacity { get; }
        public int Sold { get; }
        public CostType VenueCostType { get; }
        public CostType MarketingCostType { get; }

        public EventDto() : base()
        {
        }

        public EventDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold)
            : base(id, date, name, eventType, venue)
        {
            VenueCostType = venueCostType;
            MarketingCostType = marketingCostType;
            Capacity = capacity;
            Sold = sold;
        }
    }

#endif
}