using hotelRes_V_03.Data.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hotelRes_V_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Invoice_BillController : ControllerBase
    {
        public Invoice_BillsService _Invoice_BillsService;
        public Invoice_BillController(Invoice_BillsService invoice_BillsService)
        {
            _Invoice_BillsService = invoice_BillsService;
        }

        //get

        [HttpGet("get-all-Invoice_Bills")]
        public IActionResult GetAllInvoice_Bill()
        {
            var allinvoice_Bills = _Invoice_BillsService.GetAllInvoice_Bill();
            return Ok(allinvoice_Bills);
        }


        //get id
        [HttpGet("get-Invoice_Bills-by-id/{id}")]
        public IActionResult GetInvoice_BillById(int id)
        {
            var invoice_BillById = _Invoice_BillsService.GetInvoice_BillById(id);
            return Ok(invoice_BillById);
        }


        //Delete

        [HttpDelete("Delete-Invoice_Bills-by-id/{id}")]
        public IActionResult DeleteInvoice_BillById(int id)
        {
            _Invoice_BillsService.DeleteInvoice_BillById(id);
            return Ok();
        }



    }
}
