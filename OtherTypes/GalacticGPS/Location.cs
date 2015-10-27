using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGPS
{
    struct Location
    {
        private double latitude;
        private double longitude;

        public double Latitude
        {
            get
            {
                return this.latitude;
            }
            set
            {
                if (value < 0 || value > 90)
                {
                    throw new ArgumentOutOfRangeException("latitude","latitude must bein range 0-90");
                }
                this.latitude = value;
            }
        }

        public double Longitude
        {
            get
            {
                return this.longitude;
            }
            set
            {
                if (value < 0 || value > 180)
                {
                    throw new ArgumentOutOfRangeException("longitude", "longitude must bein range 0-90");
                }
                this.longitude = value;
            }
        }

        public Planet Planet { get; set; }

        public Location(double longitude, double latitude, Planet planet) : this()
        {
            this.Longitude = longitude;
            this.Latitude = latitude;
            this.Planet = planet;
        }

        public override string ToString()
        {
            return string.Format("<{0}>, <{1}> - <{2}>",this.Latitude,this.longitude,this.Planet);
        }
    }
}
