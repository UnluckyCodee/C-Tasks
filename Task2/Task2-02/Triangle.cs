using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_02
{
    class Triangle
    {
        private double a, b, c;

        public double A
        {
            get
            {
                return this.a;
            }
          set
            {
                CheckExceptions(value, this.b, this.c);
                this.a = value;
            }
        }

        public double B
        {
            get
            {
                return this.b;
            }
            set
            {
                CheckExceptions(this.a, value, this.c);
                this.b = value;
            }
        }

        public double C
        {
            get
            {
                return this.c;
            }
            set
            {
                CheckExceptions(this.a, this.b, value);
                this.c = value;
            }
        }

        private void CheckExceptions(double a, double b, double c)
        {
            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentException(" Загуглить правила создания треугольникуа лол ");
            }
        }

        public Triangle()
        {
            this.a = 1;
            this.b = 1;
            this.c = 1;
        }

        public Triangle(double a, double b, double c)
        {
            CheckExceptions(a, b, c);

            this.a = a;
            this.b = b;
            this.c = c;

        }

        public double Perimeter => this.a + this.b + this.c;
        public double Area
        {
            get
            {
                double P = this.Perimeter / 2;
                return Math.Sqrt(P * ( P - this.a) * P * ( P - this.b) * P * ( P - this.c)) ;
            }
        }
    }
}
