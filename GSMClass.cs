using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
    //task 1
    public class GSM
    {
        public const decimal defaultPrice = 150.00m;
        public const string defaultOwner = "NoName";
        //field
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        //task 2 constructors
        public GSM(string model, string manufactuter)
            : this(model, manufactuter, defaultPrice, defaultOwner, new Battery(), new Display())
        {
            // this.model = model;
            //this.manufacturer = manufactuter;

        }

        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }
        public static GSM IPhone4S = new GSM("Iphone", "Apple", 1000.00M, "Az", new Battery("Apple", 8, 200, BatterryType.LiIon),
        new Display(900, 160000000));
        public GSM Iphone4S
        {
            get
            {
                return this.Iphone4S;
            }
        }
        //task 9
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        //task 5
        public string Model
        {
            get
            {
                return this.model;
            }
            private set
            {
                if (value.Length < 0 || value.Length > 20)
                {
                    throw new ArgumentException("The model length must be between 0 and 20 symbols");
                }
                else
                {
                    this.model = value;
                }
            }

        }
        public string Manufactuter
        {
            get
            {
                return this.manufacturer;
            }
            private set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("The manufacturer must start with capital letter");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException("The owner's name must start with capital letter");
                }
                else
                {
                    this.owner = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("The price can not be negative or 0");
                }

                else
                {
                    this.price = value;
                }
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        //task 4
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("GSM model :" + this.model);
            result.AppendLine("Manufacturer :" + this.manufacturer);
            result.AppendLine("Price :" + this.price);
            result.AppendLine("Owner :" + this.owner);
            result.AppendFormat("Battery model {0} , battery type {1},idle hours {2},talk hours {3}",
                this.battery.Model, this.battery.Type, this.battery.HoursIdle, this.battery.HoursTalk + ",");
            result.AppendFormat("Display size {0}, display numbers of colors {1}", this.display.Size, this.display.NumberOfColors);
            return result.ToString();
        }
        //task 10
        public List<Call> AddCall(Call call)
        {
            this.CallHistory.Add(call);
            return this.CallHistory;
        }
        public List<Call> DelCall(Call call)
        {
            this.CallHistory.Remove(call);
            return this.CallHistory;
        }
        public void ClearHistory()
        {
            callHistory.Clear();
        }

        //task 11
        public decimal CalcTotalPrice(decimal pricePerSec)
        {
            decimal totalPrice = 0;
            foreach (var call in this.callHistory)
            {
                totalPrice += pricePerSec * call.Duration;
            }
            return totalPrice;
        }

    }
}





