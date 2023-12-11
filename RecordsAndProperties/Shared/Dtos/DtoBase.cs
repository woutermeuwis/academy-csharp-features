using System;
using Shared.Enums;

namespace Shared.Dtos
{
#if FULLCLASS
    public abstract class DtoBase
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string Name { get; set; }
        public EventType EventType { get; set; }
        public string Venue { get; set; }

        protected DtoBase()
        { }
        
        protected DtoBase(int id, DateTimeOffset date, string name, EventType eventType, string venue)
        {
            Id = id;
            Date = date;
            Name = name;
            EventType = eventType;
            Venue = venue;
        }
    }

#elif RECORD
    public abstract record DtoBase(int Id, DateTimeOffset Date, string Name, EventType EventType, string Venue);

#else
    public abstract class DtoBase
    {
        public int Id { get; init; }
        public DateTimeOffset Date { get; init; }
        public string Name { get; init; }
        public EventType EventType { get; init; }
        public string Venue { get; init; }

        protected DtoBase()
        {
            
        }

        protected DtoBase(int id, DateTimeOffset date, string name, EventType eventType, string venue)
        {
            Id = id;
            Date = date;
            Name = name;
            EventType = eventType;
            Venue = venue;
        }
    }
#endif
}