using hotelRes_V_03.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace hotelRes_V_03.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Reservations.Any())
                {
                    context.Reservations.AddRange(new Reservation()
                    {
                        GuestId = "1",
                        Hotel_code = "101",
                        CheckIn_date = DateTime.Now,
                        CheckOut_date = DateTime.Now,
                        number_of_guest = "3"
                      },
                      new Reservation()
                      {
                          GuestId = "2",
                          Hotel_code = "102",
                          CheckIn_date = DateTime.Now,
                          CheckOut_date = DateTime.Now,
                          number_of_guest = "2"
                      },
                      new Reservation()
                      {
                          GuestId = "2",
                          Hotel_code = "203",
                          CheckIn_date = DateTime.Now,
                          CheckOut_date = DateTime.Now,
                          number_of_guest = "1"
                      }
                 );
              

                    context.SaveChanges();
                }
            }
        }


    }
}
