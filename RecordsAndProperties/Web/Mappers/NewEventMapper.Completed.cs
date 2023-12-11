using System;
using Shared.Dtos;
using Web.ViewModels;

namespace Web.Mappers
{
    public class ConferenceEventMapperCompleted : NewEventMapperCompleted
    {
        public override ConferenceDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            var conferenceViewModel = (ConferenceViewModel)viewModel;
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                conferenceViewModel.BadgeCosts, conferenceViewModel.CateringCosts);
        }
    }

    public class MultiDayConferenceEventMapperCompleted : ConferenceEventMapperCompleted
    {
        public override MultiDayConferenceDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            var multiDayConferenceDto = (MultiDayConferenceViewModel)viewModel;
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                multiDayConferenceDto.BadgeCosts, multiDayConferenceDto.CateringCosts, multiDayConferenceDto.NumberOfDays, multiDayConferenceDto.AccomodationCostType);
        }
    }

    public class ConcertEventMapperCompleted : NewEventMapperCompleted
    {
        public override ConcertDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            var concertViewModel = (ConcertViewModel)viewModel;
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                concertViewModel.ArtistCosts, concertViewModel.ArtistCostType);
        }
    }

    public class SportsGameEventMapperCompleted : NewEventMapperCompleted
    {
        public override SportsGameDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            var sportsGameViewModel = (SportsGameViewModel)viewModel;
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold,
                sportsGameViewModel.NumberOfPlayers, sportsGameViewModel.CostsPerPlayer);
        }
    }
    
    public class NewEventMapperCompleted
    {
        public virtual EventDto ConvertViewModelToDto(EventViewModel viewModel)
        {
            return new(viewModel.Id, viewModel.Date, viewModel.Name, viewModel.EventType, viewModel.Venue,
                viewModel.VenueCostType, viewModel.MarketingCostType, viewModel.Capacity, viewModel.Sold);
        }


        public EventPriceViewModel ConvertPriceDtoToViewModel(EventPriceDto dto)
        {
            var (id, date, name, eventType, venue, percentageSold, price) = dto;

            return new EventPriceViewModel
            {
                Id = id,
                Date = date,
                Name = name,
                EventType = eventType,
                Venue = venue,
                PercentageSold = percentageSold,
                TicketPrice = price
            };
        }

        public void CopyBaseProperties_Action(EventViewModel source, EventViewModel destination, Action<int, EventViewModel> reportProgress)
        {
            destination.Date = source.Date;
            destination.Name = source.Name;
            destination.EventType = source.EventType;
            destination.Venue = source.Venue;
            reportProgress(48, destination);
            
            destination.VenueCostType = source.VenueCostType;
            destination.MarketingCostType = source.MarketingCostType;
            destination.Capacity = source.Capacity;
            destination.Sold = source.Sold;
            reportProgress(100, destination);
        }
    }
}