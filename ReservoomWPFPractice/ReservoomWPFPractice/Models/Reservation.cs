using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservoomWPFPractice.Models
{
    public class Reservation
    {
        public RoomID RoomID { get; }
        public string Username { get; }
        public DateTime StarTime { get; }
        public DateTime EndTime { get; }
        public TimeSpan Length => EndTime.Subtract(StarTime);

        public Reservation(RoomID roomID, string username, DateTime starTime, DateTime endTime)
        {
            RoomID = roomID;
            Username = username;
            StarTime = starTime;
            EndTime = endTime;
        }

        public bool Conflicts(Reservation reservation)
        {
            if(reservation.RoomID != RoomID) return false;
            return reservation.StarTime < EndTime || reservation.EndTime > StarTime;
        }
    } 
}
