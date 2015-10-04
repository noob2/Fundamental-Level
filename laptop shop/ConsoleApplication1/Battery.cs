using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Battery
    {
        private string batteryType;
        private float batteryLifeInHours;

        public string BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No battery specified !");
                }
                else
                {
                    this.batteryType = value;
                }
            }
        }

        public float BatteryLifeInHours
        {
            get
            {
                return this.batteryLifeInHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Battery life is too short !");
                }
                else
                {
                    this.batteryLifeInHours = value;
                }
            }
        }

        public Battery(string batteryType = "# # # #", float batteryLifeInHours = 0)
        {
            this.BatteryType = batteryType;
            this.BatteryLifeInHours = batteryLifeInHours;
        }
    }
}
