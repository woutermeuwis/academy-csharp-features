using System;
using Shared.Enums;

namespace Shared.Dtos
{
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
}