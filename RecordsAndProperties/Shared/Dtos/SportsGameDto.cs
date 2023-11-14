using System;
using Shared.Enums;

namespace Shared.Dtos
{
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
}