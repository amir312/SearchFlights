using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW1.Models
{
    public class Flight
    {
       public static List<Flight> flightList = new List<Flight>();

        float price;
        string flyFrom;
        string flyTo;
        string departDate;
        string returnDate;
        List<string> subflights = new List<string>();
        List<string> airlines = new List<string>();


        public float Price { get => price; set => price = value; }
        public string FlyFrom { get => flyFrom; set => flyFrom = value; }
        public string FlyTo { get => flyTo; set => flyTo = value; }
        public string DepartDate { get => departDate; set => departDate = value; }
        public string ReturnDate { get => returnDate; set => returnDate = value; }     
        public List<string> Subflights { get => subflights; set => subflights = value; }
        public List<string> Airlines { get => airlines; set => airlines = value; }


        public Flight() { }
        public Flight(float price, string flyfrom, string flyto, string departdate, string returedate, List<string> subflight, List<string> airlines )
        {
            Price = price;
            FlyFrom = flyFrom;
            FlyTo = flyto;
            DepartDate = departdate;
            ReturnDate = returedate;
            Subflights = subflight;
            Airlines = airlines;

        }

        public List<Flight> getFlight()
        {
            return flightList;

        }


    }


 




}