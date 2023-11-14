using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Shared.Dtos;

namespace Api
{
    [ApiController]
    [Route("event")]
    public class EventController : Controller
    {
        private readonly EventMapper _eventMapper;
        private readonly EventRepository _eventRepository;

        public EventController(EventRepository eventRepository, EventMapper eventMapper)
        {
            _eventRepository = eventRepository;
            _eventMapper = eventMapper;
        }

        [HttpGet]
        public IActionResult GetEvents()
        {
            var entities = _eventRepository.GetAll();

            if (!entities.Any())
                return NoContent();

            var dtos = entities.Select(_eventMapper.ConvertEntityToPriceDto);
            return Ok(dtos);
        }

        [HttpGet("{eventId}")]
        public IActionResult GetEvent(int eventId)
        {
            var entity = _eventRepository.GetById(eventId);

            if (entity == null)
                return NotFound();

            var dto = _eventMapper.ConvertEntityToPriceDto(entity);
            return Ok(dto);
        }


        [HttpPost("/conference")]
        public IActionResult AddConference(ConferenceDto conferenceDto)
        {
            var entity = new ConferenceEntity();
            _eventMapper.FillConferenceEntityWithDto(conferenceDto, entity);

            _eventRepository.AddEvent(entity);

            return CreatedAtAction("GetEvent", new { eventId = entity.Id }, entity);
        }

        [HttpPost("/multidayconference")]
        public IActionResult AddMultiDayConference(MultiDayConferenceDto conferenceDto)
        {
            var entity = new MultiDayConferenceEntity();
            _eventMapper.FillMultiDayConferenceEntityWithDto(conferenceDto, entity);

            _eventRepository.AddEvent(entity);
            return CreatedAtAction("GetEvent", new { eventId = entity.Id }, entity);
        }

        [HttpPost("/concert")]
        public IActionResult AddConcert(ConcertDto concertDto)
        {
            var entity = new ConcertEntity();
            _eventMapper.FillConcertEntityWithDto(concertDto, entity);

            _eventRepository.AddEvent(entity);
            return CreatedAtAction("GetEvent", new { eventId = entity.Id }, entity);
        }

        [HttpPost("/sportsgame")]
        public IActionResult AddSportsGame(SportsGameDto sportsGameDto)
        {
            var entity = new SportsGameEntity();
            _eventMapper.FillSportsGameEntityWithDto(sportsGameDto, entity);

            _eventRepository.AddEvent(entity);
            return CreatedAtAction("GetEvent", new { eventId = entity.Id }, entity);
        }
    }
}