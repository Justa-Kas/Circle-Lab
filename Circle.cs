using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Lab
{
    class Circle
    {
        private double Radius { get; set; }

        public Circle(double radius)
        {
            this.Radius = Radius;
        }
        public double CalculateCircumference(double radius)
        {
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }

        public string CalculateFormattedCircumference(double radius)
        {
            string formattedCircumference = FormatNumber(CalculateCircumference(radius));
            return formattedCircumference;
        }

        public double CalculateArea(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        public string CalculateFormattedArea(double radius)
        {
            string formattedArea = FormatNumber(CalculateArea(radius));
            return formattedArea;
        }
            private string FormatNumber(double x)
            {
                string formattedNum = String.Format("{0:0.00}", x);
                return formattedNum;
            }
        
    }
}
