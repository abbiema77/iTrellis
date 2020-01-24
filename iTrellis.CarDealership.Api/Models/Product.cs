using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace iTrellis.CarDealership.Api.Models
{
    public class Product
    {
        public string Make { get; set; }
        public string Year { get; set; }
        public Color Color { get; set; }
        public decimal Price { get; set; }
        public bool HasSunroof { get; set; }
        public bool IsFourWheelDrive { get; set; }
        public bool HasLowMiles { get; set; }
        public bool HasPowerWindows { get; set; }
        public bool HasNavigation { get; set; }
        public bool HasHeatedSeats { get; set; }
    }

    public enum Color
    {
        Red,
        White,
        Gray,
        Silver,
        Black
    }
}