using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReservoomWPFPractice.Exceptions;

namespace ReservoomWPFPractice.Models
{
    public class ReservationBook
    {
        private readonly List<Reservation> reservations;

        public ReservationBook()
        {
            reservations = new List<Reservation>();
        }

        public IEnumerable<Reservation> GetReservationsForUser(string username)
        {
            return reservations.Where(r => r.Username == username);
        }

        public void AddReservation (Reservation reservation)
        {
            foreach (Reservation el in reservations)
            {
                if (el.Conflicts(reservation))
                {
                    throw new ReservationConflictException(el, reservation);
                }
                else
                {
                    reservations.Add(reservation);
                }
            }
        }



    }
}
