using System;

namespace Classlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle(2.0);

            Circle c3 = new Circle();
            Circle c4 = new Circle(3.0);


            Circle c5 = new Circle();
            Circle c6 = new Circle(4.0);
            //Number of circles statik bir deger,bundan dolayı duragandır yanı etkılenmez ve Circle. yazarak istediğimiz gibi erişebiliriz.
            Circle.numberOfCircles++;
            Console.WriteLine("Daire sayısı statik degiskenle: {0}",Circle.numberOfCircles);

            Console.WriteLine("c1 alanı : {0}",c1.getarea(1));

            //Console.WriteLine("C1 Çevre değeri : {0}", c1.getarea());
            //Console.WriteLine("C1 Alan değeri : {0}", c1.getPerimeter());
            //Console.WriteLine("C2 Çevre değeri : {0}", c2.getarea());
            //Console.WriteLine("C2 Alan değeri : {0}", c2.getPerimeter());

        }
    }
}
