namespace Web.ViewModels
{
    public class SportsGameViewModel : EventViewModel
    {
        public int NumberOfPlayers { get; set; }
        public int CostsPerPlayer { get; set; }
        public override string ApiEndpoint => "/sportsgame";
    }
}