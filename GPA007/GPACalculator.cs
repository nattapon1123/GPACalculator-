using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gpax
{
    public class GPACalculator
    {
        private double gpa_sum;
        private int n;

        public GPACalculator()
        {
            gpa_sum = 0;
            n = 0;
        }

        public void SetGPA(double gpa)
        {
            gpa_sum += gpa;
            n++;
        }

        public double GetGPAX()
        {
            return n > 0 ? gpa_sum / n : 0;
        }
    }
}
