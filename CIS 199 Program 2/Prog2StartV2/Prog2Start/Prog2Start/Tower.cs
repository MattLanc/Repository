using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class Tower : Desktop
    {
        private string panelType;


        public Tower(string manufacturer, CPU cpu, GPU gpu, Motherboard motherboard, int numFans, string panelType) : base(manufacturer, cpu, gpu, motherboard, numFans)
        {
            PanelType = panelType;
        }

        public override double CalcTDP()
        {
            return CPU.PowerDraw + GPU.PowerDraw + Motherboard.PowerDraw;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nPanel Type: {PanelType}";
        }

        public string PanelType
        {
            get
            {
                return panelType;
            }
            set
            {
                if (value == "glass" || value == "metal")
                {
                    panelType = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
