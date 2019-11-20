using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1.Models
{
    public class Flight
    {
        private string flyFrom;
        private string flyTo;
        private DateTime DepartDate;
        private DateTime ReturnDate;

        public string FlyFrom { get => flyFrom; set => flyFrom = value; }
        public string FlyTo { get => flyTo; set => flyTo = value; }
        public DateTime Depart { get => DepartDate; set => DepartDate = value; }
        public DateTime Return { get => ReturnDate; set => ReturnDate = value; }


        public Flight() { }

        public Flight(string _flyfrom, string _flyTo, DateTime _DepartDate,DateTime _ReturnDate)
        {
            FlyFrom = _flyfrom;
            FlyTo = _flyTo;
            Depart = _DepartDate;
            Return = _ReturnDate;
        }

        public List<Flight> getFlight()
        {
            List<Flight> flightList = new List<Flight>();
            Return.Add(new Flight("TLV", "JFK", '2013-01-29', '2013-01-29'));
            return flightList;

        }


    }


 




}