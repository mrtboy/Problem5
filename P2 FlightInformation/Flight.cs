using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_FlightInformation
{
    public class Flight
    {

        public static List<Flight> flights = new List<Flight>();

        public int Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

        public Flight() { }
        public Flight(int id, string origin, string destination, DateTime date, DateTime time)
        {
            Id = id;
            Origin = origin;
            Destination = destination;
            Date = date;
            Time = time;
            flights.Add(this);
        }

        public override string ToString()
        {
            return Id +","+ Origin+"," + Destination + ","+Date +","+ Time;
        }

    }
}
