using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_01
{
    class Round
    {
        private int radius;
        private Point center;
        public Point Center { get; set; }

        public Round()
        {
            this.Center = new Point();
            this.Radius = 1;
        }

        public Round(int x, int y, int radius)
        {
            this.Center = new Point(x, y);
            this.Radius = radius;
        }
        public int Radius
        {
            get
            {
                return this.radius;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус должен быть положительным", nameof(value));
                }
                this.radius = value;
            }
        }

        public double Circuit => 2 * Math.PI * this.Radius;
        public double Area => Math.PI * this.Radius * this.Radius;

    }
}

