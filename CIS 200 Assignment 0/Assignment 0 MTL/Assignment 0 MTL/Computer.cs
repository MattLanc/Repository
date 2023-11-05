using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_0_MTL
{
    internal abstract class Computer
    {
        private string Manufacturer;
        private object CPU;
        private int totalpowerdraw;
        public Computer(string manufacturer, object CPU)
        {
            Manufacturer = manufacturer;
            TheCPU = CPU;
        }
          
        public string Manufacturer 
        {
            get
            {
                return Manufacturer;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    Manufacturer = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public object TheCPU
        {
            get
            {
                return CPU;
            }
            set
            {
                    
            }
        }

        public int CalcTDP()
        {
            return totalpowerdraw;
        }
        public override string ToString()
        {
            return $"{Manufacturer}\n" +
                $"CPU: {CPU}\n";
               
        }

    }
}
