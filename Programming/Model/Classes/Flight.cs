using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Flight
    {
        private string _departure;
        private string _destination;
        private int _flightTime;

        public string Departure { get; set; }
        public string Destination { get; set; }
        public int FlightTime
        {
            get { return _flightTime; }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTime = value;
            }
        }

        public Flight()
        {

        }

        public Flight(string departure, string destination, int flightTime)
        {
            Departure = departure;
            Destination = destination;
            FlightTime = flightTime;
        }
    }
}
