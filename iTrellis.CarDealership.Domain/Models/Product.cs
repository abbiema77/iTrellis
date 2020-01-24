using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace iTrellis.CarDealership.Api.Models
{
    public class Product
    {
        public string Make { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public bool HasSunroof { get; set; }
        public bool IsFourWheelDrive { get; set; }
        public bool HasLowMiles { get; set; }
        public bool HasPowerWindows { get; set; }
        public bool HasNavigation { get; set; }
        public bool HasHeatedSeats { get; set; }
        public List<string> Description { 
            get
            {
                var result = new List<string>();
                if (HasSunroof) result.Add("Subroof");
                if (IsFourWheelDrive) result.Add("AWD");
                if (HasLowMiles) result.Add("Low Miles");
                if (HasPowerWindows) result.Add("Power Windows");
                if (HasNavigation) result.Add("Navigation");
                if (HasHeatedSeats) result.Add("Heated Seats");

                return result;
            }
        }
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
