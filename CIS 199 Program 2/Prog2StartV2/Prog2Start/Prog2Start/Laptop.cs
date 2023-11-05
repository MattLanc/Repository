using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class Laptop : Computer
    {
        private int fixedTDP;
        private string laptopModel;

        public Laptop(string manufacturer, string laptopModel, CPU cpu, int fixedTDP) : base(manufacturer, cpu)
        {
            LaptopModel = laptopModel;
            FixedTDP = fixedTDP;
        }


        public string LaptopModel
        {
            get
            {
                return laptopModel;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    laptopModel = value.Trim();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        private int FixedTDP
        {
            get
            {
                return fixedTDP;
            }
            set
            {
                if (value >= 0 && value <= 2000)
                {
                    fixedTDP = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }


        public override double CalcTDP()
        {
            return FixedTDP;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer} \nLaptop Model: {LaptopModel}\nCPU Details: {CPU}";
        }
    }
}
