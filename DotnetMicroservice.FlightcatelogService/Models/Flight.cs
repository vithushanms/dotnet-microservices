using System;
using System.ComponentModel.DataAnnotations;

namespace DotnetMicroservice.FlightcatelogService.Models
{
    public class Flight
    {
        [Key]
        [Required]
        public int Id {get; set;}
        [Required]
        public int FlightNumber { get; set; }
        [Required]
        public string FlightName { get; set; }
        [Required]
        public DateTime DepartureTime { get; set; }
        [Required]
        public DateTime TakeOffTime { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public bool IsAvailable {get; set;}
    }
}

