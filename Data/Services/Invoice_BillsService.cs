using hotelRes_V_03.Data.Models;
using hotelRes_V_03.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace hotelRes_V_03.Data.Services
{
    public class Invoice_BillsService
    {
        private AppDbContext _context;
        public Invoice_BillsService(AppDbContext context)
        {
            _context = context;
        }
       

        public List<Invoice_Bill> GetAllInvoice_Bill() => _context.invoice_Bills.ToList();
        public Invoice_Bill GetInvoice_BillById(int Invoice_BillId) => _context.invoice_Bills.FirstOrDefault(n => n.Id == Invoice_BillId);


        public void DeleteInvoice_BillById(int Invoice_BillId)
        {
            var _Invoice_Bill = _context.invoice_Bills.FirstOrDefault(n => n.Id == Invoice_BillId);
            if (_Invoice_Bill != null)
            {
                _context.invoice_Bills.Remove(_Invoice_Bill);
                _context.SaveChanges();
            }
        }
    }
}
