using System;
using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models
{
    public class SessionDuration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        public int Hour { get; set; }
        public int SessionDurationForHour { get; set; }
        public int SessionDurationAccumulated { get; set; }
    }
}