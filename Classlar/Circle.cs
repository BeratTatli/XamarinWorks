using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    class Circle
    {
        //Instance variable
        public double radius = 1;
        public static int numberOfCircles = 0;


        
       public Circle(double r) {
            radius = r;
            double a = r;
            //This line is local variable.
            numberOfCircles = numberOfCircles + 1;

        }

        public Circle()
        {
            numberOfCircles = numberOfCircles + 1;
        }
        
        public double getarea(int state)
        {
            double area = Math.PI * radius * radius;

            if (state == 1)
            {
                return area;
            }
            else
            {
                return (int)area;
            }

            

            //Eger asagıdakı gibi bir satır yazarsak ve fonksiyonu oyle bıtırırsek, local variable
            //oldugu ıcın program.cs de calısmayacak

            //double area =  Math.PI * radius * radius;
            //return area;b 
        }
        public static double calculateArea(double r)
        {
            return Math.PI * r * r;
        }
        public double getPerimeter()
        {
            return Math.PI * 2 * radius;
        }
     

    }
}
