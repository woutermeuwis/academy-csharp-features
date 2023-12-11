using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
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

#elif RECORD
public record ConcertDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, CostType VenueCostType, CostType MarketingCostType, int Capacity, int Sold, int ArtistCosts, CostType ArtistCostType)
        : EventDto(Id, Date, Name, EventType, Venue, VenueCostType, MarketingCostType, Capacity, Sold);

#else
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

#endif
}