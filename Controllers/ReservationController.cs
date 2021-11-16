using hotelRes_V_03.Data.Models;
using hotelRes_V_03.Data.Services;
using hotelRes_V_03.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace hotelRes_V_03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        public ReservationsService _ReservationsService;
        public ReservationController(ReservationsService guest_ProfilesService)
        {
            _ReservationsService = guest_ProfilesService;
        }

        //get

        [HttpGet("get-all-Reservation")]
        public IActionResult GetAllReservation()
        {
            var allReservation = _ReservationsService.GetAllReservation();
            return Ok(allReservation);
        }

        //get id
        [HttpGet("get-Reservation-by-id/{id}")]
        public IActionResult GetReservationById(int Id)
        {
            var Reservation = _ReservationsService.GetReservationById(Id);
            return Ok(Reservation);
        }


        //post
        [HttpPost("add-Reservation")]
        public IActionResult AddReservation([FromBody] ReservationVM reservation)
        {
            _ReservationsService.AddReservation(reservation);
            return Ok();
        }

        //put
        [HttpPut("Update-Reservation-by-id/{id}")]
        public IActionResult UpdateReservationById(int id, [FromBody] ReservationVM reservation)
        {
            var UpdateReservation = _ReservationsService.UpdateReservationById(id, reservation);
            return Ok(UpdateReservation);
        }

        //Delete

        [HttpDelete("Delete-Reservation-by-id/{id}")]
        public IActionResult DeleteReservationById(int id)
        {
            _ReservationsService.DeleteReservationById(id);
            return Ok();
        }


    }
}
