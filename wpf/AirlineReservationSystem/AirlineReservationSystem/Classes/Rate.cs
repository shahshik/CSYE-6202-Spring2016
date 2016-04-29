using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineReservationSystem.Classes
{
    public class Rate : SeatingCapacity
    {
        public String flightId;
        public String seatType;
        public String rate;
        public String @OldFlightId;
    }
}
