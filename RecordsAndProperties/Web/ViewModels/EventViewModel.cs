using System;
using Shared.Enums;

namespace Web.ViewModels
{
    public class EventViewModel : ViewModelBase
    {
        public CostType VenueCostType { get; set; }
        public CostType MarketingCostType { get; set; }
        public int Capacity { get; set; }
        public int Sold { get; set; }
        public virtual string ApiEndpoint => string.Empty;
        
        public EventViewModel()
        {
            Date = DateTimeOffset.Now.AddMonths(1);
            EventType = EventType.Unknown;
        }
    } 
}