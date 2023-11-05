using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_0_MTL
{
    internal class CPU
    {
        private string manufacturer;
        private string model;
        private int clockSpeed;
        private string socket;
        private int powerDraw;

        public CPU (string model, int clockSpeed, string socket, int powerDraw)
        {
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
        }
    
        public string Manufacturer 
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) )
                {
                    manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        public string Model 
        {
            get 
            {
                return model;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace (value))
                {
                    model = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ();
                }
            } 
        } 
        public int ClockSpeed 
        { 
            get
            {
                return clockSpeed;
            }

            set
            {
                if (value >= 0 && value <= 5000)
                {
                    clockSpeed = value;
                }
                else
                {
                    clockSpeed = 2500;
                }
            }
                
        } 
        public string Socket 
        {
            get
            {
                return socket;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace (value))
                {
                    socket = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ();
                }
            }
        }   

        public int PowerDraw
        {
            get
            {
                return powerDraw;
            }

            set
            {
                if (value >= 0 && value <= 400)
                {
                    powerDraw = value;
                }
                else
                {
                    powerDraw = 200;
                }
            }

        }

        public override string ToString()
        {
            return $"{Model}\n" +
                $"Clock Speed: {ClockSpeed} MHz\n" +
                $"Socket: {Socket}\n" +
                $"Power Draw: {PowerDraw} Watt\n";
        }
    }
}
