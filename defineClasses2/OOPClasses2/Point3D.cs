using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClasses2
{
    //task 1 fields
    public struct Point3D
    {
        private double coordX;
        private double coordY;
        private double coordZ;

        //task 2
        private static readonly Point3D zero;
        //constructors
        public Point3D(double coordX,double coordY,double coordZ):this()
        {
            this.CoordX = coordX;
            this.CoordY = coordY;
            this.CoordZ = coordZ;
        }
        //properties
        public double CoordX
        {
            get { return this.coordX; }
            set { this.coordX = value; }
        }
        public double CoordY
        {
            get { return this.coordY; }
            set { this.coordY = value; }
        }
        public double CoordZ
        {
            get { return this.coordZ; }
            set { this.coordZ = value; }
        }
        public static Point3D Zero
        {
            get { return zero; }

        }
        static Point3D()
        {
            zero = new Point3D(0, 0, 0);
        }
        public override string ToString()
        {
            return string.Format("x={0},y={1},z={2}",this.coordX,this.coordY,this.coordZ);
        }

    
    }
}
