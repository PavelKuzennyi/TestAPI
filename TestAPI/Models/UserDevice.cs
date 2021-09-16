using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic.CompilerServices;

namespace TestAPI.Models
{
    public class UserDevice
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        public string DeviceName { get; set; }
        public DateTime LoginTs { get; set; }
    }
}