using System;
using System.ComponentModel.DataAnnotations;
using Shared.Enums;

namespace Web.ViewModels
{
    public abstract class ViewModelBase
    {
        public int Id { get; set; }

        [Required] public DateTimeOffset Date { get; set; }

        [Required] public string Name { get; set; }

        public EventType EventType { get; set; }
        public string Venue { get; set; }
    }
}