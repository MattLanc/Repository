using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class CPU
    {
        private string manufacturer;
        private string model;
        private string socket;
        private int clockSpeed;
        private int powerDraw;

        public CPU(string manufacturer, string model, int clockSpeed, string socket, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
        }

        public CPU(string model, int clockSpeed, string socket, int powerDraw)
        {
            Model = model;
            ClockSpeed = clockSpeed;
            Socket = socket;
            PowerDraw = powerDraw;
            //Manufacturer will be an empty string by default, so no need to set it.
        }


        public string Manufacturer
        {
            get
            {
                return manufacturer;
            }
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                    manufacturer = value.Trim();
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    model = value.Trim();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
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
                if (!string.IsNullOrWhiteSpace(value))
                {
                    socket = value.Trim();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
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
                if (value >= 0 && value <= 50000)
                {
                    clockSpeed = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
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
                if (value >= 0 && value <= 2000)
                {
                    powerDraw = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"CPU: {Manufacturer} {Model}, Clock Speed: {ClockSpeed} MHz, Socket: {Socket}, Power Draw: {PowerDraw} Watts";
        }
    }
}
