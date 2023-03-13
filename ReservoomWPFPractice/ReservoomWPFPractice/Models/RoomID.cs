using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservoomWPFPractice.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }


        public RoomID(int floorNumber, int roomNumber)
        {
            FloorNumber = floorNumber;
            RoomNumber = roomNumber;
        }

        public override string ToString()
        {
            return $"{FloorNumber} {RoomNumber}";
        }

        public override bool Equals(object? obj)
        {
            return obj is RoomID roomID &&
                   FloorNumber == roomID.FloorNumber &&
                   RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }

        public static bool operator ==(RoomID roomID1, RoomID room1D2)
        {
            if (roomID1 is null && room1D2 is null)
            {
                return true;
            }

            return !(roomID1 is null) && roomID1.Equals(room1D2);
        }

        public static bool operator !=(RoomID roomID1, RoomID roomID2)
        {
            return !(roomID1 == roomID2);
        }
    }
}
