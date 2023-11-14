using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public class EventDto : DtoBase
    {
        public int Capacity { get; }
        public int Sold { get; }
        public CostType VenueCostType { get; }
        public CostType MarketingCostType { get; }
        
        protected EventDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold) 
            : base(id, date, name, eventType, venue)
        {
            VenueCostType = venueCostType;
            MarketingCostType = marketingCostType;
            Capacity = capacity;
            Sold = sold;
        }
    }
}