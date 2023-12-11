namespace Web.ViewModels
{
    public class ConferenceViewModel : EventViewModel
    {
        public int BadgeCosts { get; set; }
        public int CateringCosts { get; set; }
        public override string ApiEndpoint => "/conference";
    }
}