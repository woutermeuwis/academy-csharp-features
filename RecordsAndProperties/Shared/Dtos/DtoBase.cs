using System;
using Shared.Enums;

namespace Shared.Dtos
{
    public abstract class DtoBase
    {
        public int Id { get; }
        public DateTimeOffset Date { get; }
        public string Name { get; }
        public EventType EventType { get; }
        public string Venue { get; }

        protected DtoBase(int id, DateTimeOffset date, string name, EventType eventType, string venue)
        {
            Id = id;
            Date = date;
            Name = name;
            EventType = eventType;
            Venue = venue;
        }
    }
}