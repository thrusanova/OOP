using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Globalization;
using System.IO;
namespace OOPClasses2
{
    class Test
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Point3D firstPoint = new Point3D (1, 2, 3.2);
            Point3D secondPoint = new Point3D(3, 1, 7.6);
            Point3D startPoint = Point3D.Zero;
            Console.WriteLine(startPoint);
            double distance = Distance.CalcDistance(firstPoint, secondPoint);
            Console.WriteLine(distance);
            Path path = new Path();
            path.AddPoint(firstPoint);
            path.AddPoint(secondPoint);
            Console.WriteLine(path);
           // Console.WriteLine();
                
            //  PathStorage.SaveFile(path,@"../../test.txt");
            Path loadedPath = PathStorage.LoadFile(@"../../pathStorage.txt"); 
               for (int i = 0; i < loadedPath.PointCount.Count; i++) 
          { 
                 Console.WriteLine(loadedPath.PointCount[i]); 
           } 

           // Console.WriteLine(loadedPath); 
              PathStorage.SaveFile(path, "../../output.txt");


        }
    }
}
