using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
    public class SportsGameDto : EventDto
    {
        public int NumberOfPlayers { get; }
        public int CostsPerPlayer { get; }

        public SportsGameDto() : base()
        {
        }

        public SportsGameDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int numberOfPlayers, int costsPerPlayer)
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            NumberOfPlayers = numberOfPlayers;
            CostsPerPlayer = costsPerPlayer;
        }
    }

#elif RECORD
    public record SportsGameDto(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue, CostType VenueCostType, CostType MarketingCostType, int Capacity, int Sold, int NumberOfPlayers, int CostsPerPlayer)
        : EventDto(Id, Date, Name, EventType, Venue, VenueCostType, MarketingCostType, Capacity, Sold);

#else
    public class SportsGameDto : EventDto
    {
        public int NumberOfPlayers { get; }
        public int CostsPerPlayer { get; }

        public SportsGameDto(int id, DateTimeOffset date, string name, EventType eventType, string venue, CostType venueCostType, CostType marketingCostType, int capacity, int sold, int numberOfPlayers, int costsPerPlayer)
            : base(id, date, name, eventType, venue, venueCostType, marketingCostType, capacity, sold)
        {
            NumberOfPlayers = numberOfPlayers;
            CostsPerPlayer = costsPerPlayer;
        }
    }

#endif
}