using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_5
{

    public interface IRotate
    {
        void Message(object o);
    }

        class Shape
    {
        private double a;
        public double Pr1
        {
            get
            { return a; }
            set
            { a = value; }
        }
        private double b;
        public double Pr2
        {
            get
            { return b; }
            set
            { b = value; }
        }
        private double c;
        public double Pr3
        {
            get
            { return c; }
            set
            { c = value; }
        }
        private double d;
        public double Pr4
        {
            get
            { return d; }
            set
            { d = value; }
        }
        private double p;
        public double Pr5
        {
            get
            { return p; }
            set
            { p = value; }
        }
        private double s;
        public double Pr6
        {
            get
            { return s; }
            set
            { s = value; }
        }


        public Shape(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Shape(double a, double d)
        {
            this.a = a;
            this.d = d;
        }

       
    }
}
