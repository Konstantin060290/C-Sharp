using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_4
{

    class Triangle
    {
        private double a;
        public double Prop1
        {
            get
            {
                return a;
            }

            set
            {
                a = value;
            }
        }
        private double b;
        public double Prop2
        {
            get
            {
                return b;
            }

            set
            {
                b = value;
            }
        }

        private double c;

        public double Prop3
        {
            get
            {
                return c;
            }

            set
            {
                c = value;
            }
        }
    }
}