using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog2Start
{
    class AllInOne : Desktop
    {
        private int screenXSize;
        private int screenYSize;

        public const double WattsPerPixel = 0.000042;

        public AllInOne(string manufacturer, CPU cpu, GPU gpu, Motherboard motherboard, int numFans, int screenXSize, int screenYSize) : base(manufacturer, cpu, gpu, motherboard, numFans)
        {
            ScreenXSize = screenXSize;
            ScreenYSize = screenYSize;
        }

        public override double CalcTDP()
        {
            return CPU.PowerDraw + GPU.PowerDraw + Motherboard.PowerDraw + (WattsPerPixel * (ScreenXSize * ScreenYSize));
        }

        public override string ToString()
        {
            return base.ToString() + $"\nScreen X Size: {ScreenXSize}\nScreen Y Size: {ScreenYSize}";
        }

        public int ScreenXSize
        {
            get
            {
                return screenXSize;
            }
            set
            {
                if (value > 0 && value <= 20000)
                {
                    screenXSize = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public int ScreenYSize
        {
            get
            {
                return screenYSize;
            }
            set
            {
                if (value > 0 && value <= 20000)
                {
                    screenYSize = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public double AspectRatio
        {
            get
            {
                return ScreenXSize / ScreenYSize;
            }
        }
    }
}
