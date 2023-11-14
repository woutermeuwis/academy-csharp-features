using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public class ConferenceDto : EventDto
    {
        public int BadgeCosts { get; }
        public int CateringCosts { get; }
        
        public ConferenceDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int badgeCosts, int cateringCosts) 
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            BadgeCosts = badgeCosts;
            CateringCosts = cateringCosts;
        }
    }
}