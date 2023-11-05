using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class GPU
    {
        private string manufacturer;
        private string model;
        private int vram;
        private int powerDraw;

        public GPU(string manufacturer, string model, int vram, int powerDraw)
        {
            Manufacturer = manufacturer;
            Model = model;
            VRAM = vram;
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

        public int VRAM
        {
            get
            {
                return vram;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    vram = value;
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
            return $"GPU {Manufacturer} {Model}, VRAM: {VRAM} MHz, Power Draw: {PowerDraw} Watts";
        }
    }
}
