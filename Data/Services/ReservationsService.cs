using hotelRes_V_03.Data.Models;
using hotelRes_V_03.Data.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace hotelRes_V_03.Data.Services
{
    public class ReservationsService
    {
     
            private AppDbContext _context;
            public ReservationsService(AppDbContext context)
            {
                _context = context;
            }
            public void AddReservation(ReservationVM Reservation)
            {
                var _Reservation = new Reservation()
                {
                    GuestId = Reservation.GuestId,
                    Hotel_code = Reservation.Hotel_code,
                    CheckIn_date = Reservation.CheckIn_date,
                    CheckOut_date = Reservation.CheckOut_date,
                    number_of_guest = Reservation.number_of_guest

                };
                _context.Reservations.Add(_Reservation);
                _context.SaveChanges();
            }

            public List<Reservation> GetAllReservation() => _context.Reservations.ToList();
            public Reservation GetReservationById(int ReservationId) => _context.Reservations.FirstOrDefault(n => n.Id == ReservationId);

            public Reservation UpdateReservationById(int ReservationId, ReservationVM Reservation)
            {
                var _Reservation = _context.Reservations.FirstOrDefault(n => n.Id == ReservationId);
                if (_Reservation != null)
                {
                _Reservation.GuestId = Reservation.GuestId;
                _Reservation.Hotel_code = Reservation.Hotel_code;
                _Reservation.CheckIn_date = Reservation.CheckIn_date;
                _Reservation.CheckOut_date = Reservation.CheckOut_date;
                _Reservation.number_of_guest = Reservation.number_of_guest;
                _context.SaveChanges();
                }
                return _Reservation;
            }

            public void DeleteReservationById(int ReservationId)
            {
                var _Reservation = _context.Reservations.FirstOrDefault(n => n.Id == ReservationId);
                if (_Reservation != null)
                {
                    _context.Reservations.Remove(_Reservation);
                    _context.SaveChanges();
                }
            }
        }
    }

