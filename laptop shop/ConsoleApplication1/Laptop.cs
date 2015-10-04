using System;

namespace ConsoleApplication1
{
    class Laptop : Battery
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string ram;
        private string videoCard;
        private string hardDisk;
        private string screen;
        
        private decimal price;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No model specified !");
                }
                else
                {
                    this.model = value;
                }
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No manufacturer specified !");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Processor
        {
            get
            {
                return this.processor;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No processor specified !");
                }
                else
                {
                    this.processor = value;
                }
            }
        }

        public string Ram
        {
            get
            {
                return this.ram;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No ram specified !");
                }
                else
                {
                    this.ram = value;
                }
            }
        }

        public string VideoCard
        {
            get
            {
                return this.videoCard;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No video card specified !");
                }
                else
                {
                    this.videoCard = value;
                }
            }
        }

        public string HardDisk
        {
            get
            {
                return this.hardDisk;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No hard disk specified !");
                }
                else
                {
                    this.hardDisk = value;
                }
            }
        }

        public string Screen
        {
            get
            {
                return this.screen;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("No screen specified !");
                }
                else
                {
                    this.screen = value;
                }
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("invalid price !");
                }
                else
                {
                    this.price = value;
                }
            }
        }



        public Laptop(string model, decimal price, Battery battery = null, string manufacturer = "# # # #", string processor = "# # # #", string ram = "# # # #",
            string videoCard = "# # # #", string hardDisk = "# # # #", string screen = "# # # #")
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.VideoCard = videoCard;
            this.HardDisk = hardDisk;
            this.Screen = screen;
        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n{9}",
                this.Model,this.Price,this.Manufacturer,this.Processor,this.Ram,
                this.VideoCard,this.HardDisk,this.Screen,this.BatteryType,this.BatteryLifeInHours).ToString();
        }

    }
}
