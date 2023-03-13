using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ReservoomWPFPractice.Exceptions;
using ReservoomWPFPractice.Models;

namespace ReservoomWPFPractice
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Bober");
            try
            {
                hotel.MakeReservation(new Reservation(
                        new RoomID(1, 3),
                        "Vitalii",
                        new DateTime(2023, 1, 3),
                        new DateTime(2023, 1, 9)));
                hotel.MakeReservation(new Reservation(
                    new RoomID(1, 2),
                    "Vitalii",
                    new DateTime(2023, 1, 10),
                    new DateTime(2023, 1, 11)));
            }
            catch (ReservationConflictException)
            {
                
            }

            IEnumerable<Reservation> reservations = hotel.GetReservationsForUser("Vitalii");


            base.OnStartup(e);
        }
    }
}
