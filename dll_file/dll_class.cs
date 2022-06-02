using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dll_file
{
    public class cat : IDog
    {
        public double addition(double a, double b)
            { return a + b; }

        public double divide(double a, double b)
        {
            { return a/ b; }
        }

        public double multiply(double a, double b)
        {
            { return a * b; }
        }

        public double subtract(double a, double b)
        {
            { return a - b; }
        }
    }

    public interface IDog 
    {
        double addition(double a, double b);
        
        double subtract(double a, double b);
        double multiply(double a, double b);
        double divide(double a, double b);
        

    }

    public class class1
    {
        public static double add(double a,double b)
        {
            return a + b;
        }
        public static double sub(double a,double b)
        {
            return  a - b;
        }
       
    }
}

