using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
    public class ConferenceDto : EventDto
    {
        public int BadgeCosts { get; }
        public int CateringCosts { get; }

        public ConferenceDto():base()
        { }
        
        public ConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts, int cateringCosts) 
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            BadgeCosts = badgeCosts;
            CateringCosts = cateringCosts;
        }
    }

#elif RECORD
    public record ConferenceDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, CostType VenueCostType, CostType MarketingCostType, int Capacity, int Sold, int BadgeCosts, int CateringCosts)
        : EventDto(Id, Date, Name, EventType, Venue, VenueCostType, MarketingCostType, Capacity, Sold);

#else
    public class ConferenceDto : EventDto
    {
        public int BadgeCosts { get; }
        public int CateringCosts { get; }

        public ConferenceDto() : base()
        {
        }

        public ConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts, int cateringCosts)
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            BadgeCosts = badgeCosts;
            CateringCosts = cateringCosts;
        }
    }

#endif
}