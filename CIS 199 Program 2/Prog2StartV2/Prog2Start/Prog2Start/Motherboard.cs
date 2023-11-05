using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class Motherboard
    {
        private string manufacturer;
        private string model;
        private string socket;
        private int powerDraw;

        public Motherboard(string manufacturer, string model, string socket, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
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
                if (!string.IsNullOrWhiteSpace(value))
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
            return $"Motherboard: {Manufacturer} {Model}, Socket: {Socket}, Power Draw: {PowerDraw} Watts";
        }
    }
}
