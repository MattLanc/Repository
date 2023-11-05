using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    abstract class Desktop : Computer
    {
        private int numFans;

        public Desktop(string manufacturer, CPU cpu, GPU gpu, Motherboard motherboard, int numFans) : base(manufacturer, cpu)
        {
            GPU = gpu;
            Motherboard = motherboard;
            NumFans = numFans;
        }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer} \nCPU Details: {CPU}\nGPU Details: {GPU}\nMotherboard Details: {Motherboard}\nNumber of Fans: {NumFans}";
        }

        public bool CPUCheck()
        {
            return CPU.Socket == Motherboard.Socket;
        }

        public Motherboard Motherboard
        {
            get; set;
        }

        public GPU GPU
        {
            get; set;
        }

        public int NumFans
        {
            get
            {
                return numFans;
            }
            set
            {
                if (value >=0 && value <=12)
                {
                    numFans = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
