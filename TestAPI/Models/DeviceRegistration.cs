using System.ComponentModel.DataAnnotations;

namespace TestAPI.Models
{
    public class DeviceRegistration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Year { get; set; }
        public string Month { get; set; }
        public string DeviceType { get; set; }
        public int NumberOfUsers { get; set; }
    }
}