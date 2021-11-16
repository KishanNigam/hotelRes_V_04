namespace hotelRes_V_03.Data.ViewModels
{
    public class Invoice_BillVM
    {
        public string Guest_id { get; set; }
        public string Hotel_code { get; set; }
        public int payment_method { get; set; }
        public int room_service_charge { get; set; }

        public int total_cost { get; set; }
    }
}
