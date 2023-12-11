using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
    public class MultiDayConferenceDto : ConferenceDto
    {
        public int NumberOfDays { get; }
        public CostType AccomodationCostType { get; }

        public MultiDayConferenceDto() : base()
        { }
        
        public MultiDayConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts, int cateringCosts, int numberOfDays, CostType accomodationCostType) 
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold, badgeCosts, cateringCosts)
        {
            NumberOfDays = numberOfDays;
            AccomodationCostType = accomodationCostType;
        }
    }

#elif RECORD
    public record MultiDayConferenceDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, CostType VenueCostType, CostType MarketingCostType, int Capacity, int Sold, int BadgeCosts, int CateringCosts, int NumberOfDays, CostType AccomodationCostType)
        : ConferenceDto(Id, Date, Name, EventType, Venue, VenueCostType, MarketingCostType, Capacity, Sold, BadgeCosts, CateringCosts);

#else
    public class MultiDayConferenceDto : ConferenceDto
    {
        public int NumberOfDays { get; }
        public CostType AccomodationCostType { get; }
        
        public MultiDayConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts, int cateringCosts, int numberOfDays, CostType accomodationCostType) 
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold, badgeCosts, cateringCosts)
        {
            NumberOfDays = numberOfDays;
            AccomodationCostType = accomodationCostType;
        }
    }

#endif
}