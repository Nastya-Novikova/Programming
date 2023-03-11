using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    internal class Flight
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
                if (value > 0)
                {
                    _flightTime = value;
                }
                else
                {
                    throw new ArgumentException(message: "Время полета должно быть больше 0");
                }
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
