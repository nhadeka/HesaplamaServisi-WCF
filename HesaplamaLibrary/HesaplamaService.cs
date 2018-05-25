using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace HesaplamaLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class HesaplamaService : IHesaplamaService
    {
        public double Bolme(double a, double b)
        {
            return a / b;
        }

        public double Carpma(double a, double b)
        {
            return a * b;
        }

        public double Cikarma(double a, double b)
        {
            return a - b;
        }

        public double Toplama(double a, double b)
        {
            return a + b;   
        }
    }
}
