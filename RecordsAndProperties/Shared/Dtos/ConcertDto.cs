using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public class ConcertDto : EventDto
    {
        public int ArtistCosts { get; }
        public CostType ArtistCostType { get; }
        
        public ConcertDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int artistCosts, CostType artistCostType)
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            ArtistCosts = artistCosts;
            ArtistCostType = artistCostType;
        }
    }
}