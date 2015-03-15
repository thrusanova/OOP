
using System.Collections.Generic;

namespace OOPClasses2
{
    public class Path
    {
        private List<Point3D> pointCount;
        public List<Point3D> PointCount
        {
            get { return this.pointCount; }
            set { this.pointCount = value; }
        }
        public Path()
        {
            this.pointCount = new List<Point3D>();
        }
        public void AddPoint(Point3D point)
        {
            this.pointCount.Add(point);
        }
        public void RemovePoint(Point3D point)
        {
            this.pointCount.Remove(point);
        }
        
        }
    }

