using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// In the Laptop Class I just did something similar to Computer, I created a constructor that defined the manufacturere, laptopmodel, CPU, and fixed Total Drawn Power. I also ran 
// into an issue with this class with not being able to take manufactur and CPU from computer and put it into this class.
namespace Assignment_0_MTL
{
    internal class Laptop : Computer
    {
        private int fixedTDP;
        private string laptopmodel;
        private object CPU;


        public Laptop( string manufacturer, string laptopmodel, object CPU, int fixedTDP)
        {
            LaptopModel = laptopmodel;
        }
        public string LaptopModel
        {
            get
            {
                return laptopmodel;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    laptopmodel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }


            }


        }
        public override string ToString()
        {
            return $"{laptopmodel}\n" +
                $"CPU: {CPU}\n" +
                $"FixedTDP: {fixedTDP}\n";
        }
    }
}
