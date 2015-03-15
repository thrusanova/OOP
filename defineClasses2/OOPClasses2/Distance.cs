using System;


namespace OOPClasses2
{
 public  static class Distance
    {
     public static double CalcDistance(Point3D point1,Point3D point2)
     {
         double distance = Math.Sqrt((point1.CoordX - point2.CoordX) * (point1.CoordX - point2.CoordX)+
                            (point1.CoordY - point2.CoordY) * (point1.CoordY - point2.CoordY) + (point1.CoordZ - point2.CoordZ) * (point1.CoordZ - point2.CoordZ));
         return distance;
     }

    }
}
