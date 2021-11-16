using System;

namespace hotelRes_V_03.Data.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public string GuestId { get; set; }
        public string Hotel_code { get; set; }
        public DateTime CheckIn_date { get; set; }
        public DateTime CheckOut_date { get; set; }
        public string number_of_guest { get; set; }
     
    }
}
