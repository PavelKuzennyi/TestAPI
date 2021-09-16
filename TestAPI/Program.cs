using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;
using TestAPI.Data;


namespace TestAPI
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            await using var context = new TestApiContext();
            await context.Database.MigrateAsync();
            var userRegistrations = await context.UserRegistrations.ToListAsync();
            var deviceRegistrations = await context.DeviceRegistrations.ToListAsync();
            
        Dictionary<string, int> months = new()
        {
            ["January"]= 1,
            ["February"]= 2,
            ["March"]= 3,
            ["April"]= 4,
            ["May"]= 5,
            ["June"]= 6,
            ["July"]= 7,
            ["August"]= 8,
            ["September"]= 9,
            ["October"]= 10,
            ["November"]= 11,
            ["December"]= 12,
        }; 
            
            Registration GetRegistration()
            {
                Registration registration = new Registration();
                string month = months.Keys.ElementAt(registration.Month);
                int year = registration.Year;
                registration.RegisteredUsers = (from registrations in userRegistrations 
                        where registrations.Year == year && registrations.Month == month 
                        select registrations.NumberOfUsers).Sum();
                var deviceTypes = (from devices in deviceRegistrations
                    where devices.Year == year && devices.Month == month
                    select devices.DeviceType).Zip(from devices in deviceRegistrations
                    where devices.Year == year && devices.Month == month
                    select devices.NumberOfUsers);

                //deviceTypesList = deviceTypes.ToList();
                //Device[] deviceList = new Device[deviceTypesList.Count()];
                //for (int i = 0; i < deviceTypesList.Count(); i++)
                //{
                //    deviceList[i].Type = deviceTypesList[i][0];
                //}

                return registration;
            }
        }
        
        
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<Startup>(); });
    }
}