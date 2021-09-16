using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace TestAPI.Models
{
    public class Registration
    {
        public int Year { get; set; } = 2021;
        public int Month { get; set; } = 1;
        public int RegisteredUsers { get; set; } = 0;
        public List<Device> RegisteredDevices { get; set; } = new();
        
        
        public Registration()
        {
        }
        public Registration(int year, int month, int registeredUsers, List<Device> registeredDevices)
        {
            Year = year;
            Month = month;
            RegisteredUsers = registeredUsers;
            RegisteredDevices = registeredDevices;
        }
    }
}