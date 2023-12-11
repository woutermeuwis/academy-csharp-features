using Shared.Enums;

namespace Web.ViewModels
{
    public class MultiDayConferenceViewModel : ConferenceViewModel
    {
        public int NumberOfDays { get; set; }
        public CostType AccomodationCostType { get; set; }
        public override string ApiEndpoint => "/multidayconference";
    }
}