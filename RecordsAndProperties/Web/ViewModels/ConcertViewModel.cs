using Shared.Enums;

namespace Web.ViewModels
{
    public class ConcertViewModel : EventViewModel
    {
        public int ArtistCosts { get; set; }
        public CostType ArtistCostType { get; set; }
        public override string ApiEndpoint => "/concert";
    }
}