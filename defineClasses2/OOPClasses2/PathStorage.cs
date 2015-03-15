using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOPClasses2
{
    class PathStorage
    {
        public static void SaveFile(Path path,string fileName)
        {
            StreamWriter writer = new StreamWriter("..//..//path" +fileName+ ".txt");
            using (writer)
            {
               writer.Write(path);
            }
        }

        public static Path LoadFile(string filePath)
        {
            Path loadPath = new Path();
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                string currentLine = reader.ReadLine();
                while (!string.IsNullOrEmpty(currentLine))
                {
                    double[] coord = currentLine.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x=>double.Parse(x)).ToArray(); 
                    loadPath.AddPoint(new Point3D(coord[0], coord[1], coord[2])); 
                    currentLine = reader.ReadLine(); 

                }

                return loadPath;

            }
        }

    }
}