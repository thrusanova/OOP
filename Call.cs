using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{

   // task 8
  public  class Call
    {
        //fields
        private DateTime dateTime;
        private string phoneNumber;
        private int duration;

       //constructors
        public Call(string phoneNumber, int duration)
        {
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }
        public Call(DateTime dateTime,string phoneNumber,int duration)
        {
            this.dateTime = DateTime.Now;
            this.phoneNumber = phoneNumber;
            this.duration = duration;
        }
      //properties
      public DateTime DateTime
        {
          get
            {
                return this.dateTime;
            }
            set
            {
                this.DateTime = DateTime.Now;
            }
        }
      public string PhoneNumber
      {
          get
          {
              return this.phoneNumber;
          } 
          set
          {
              for (int i = 0; i < value.Length; i++)
              {

                  if (value.Length != 10 || !char.IsDigit(value[i]))
                  {
                      throw new ArgumentException("The number mustbe exactly 10 numbers.");
                  }
                  else
                  {
                      this.phoneNumber = value;
                  }
              }
          }
      }
      public int Duration
      {
          get
          {
              return this.duration;
          }
          set
          {
              if (value < 0)
              {
                  throw new ArgumentException("The duration must be positive.");
              }
              else
              {
                  this.duration = value;
              }
          }
      }
      public override string ToString()
      {
          return string.Format("The phone number {0} has conversation with {1} s duration at {2} ", 
              this.phoneNumber, this.duration, this.dateTime);
      }

    }
}
