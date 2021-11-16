namespace hotelRes_V_03.Data.Models
{
    public class Invoice_Bill
    {
        public int Id { get; set; }
        public string Guest_id { get; set; }
        public string Hotel_code { get; set; }
        public int payment_method { get; set; }
        public int room_service_charge { get; set; }

        public int total_cost { get; set; }
    }
}
