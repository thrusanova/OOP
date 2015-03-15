using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attributes
{
    [VersionAttribute("2.10")]
    class AttrTest
    {
        static void Main()
        {

            Type type = typeof(AttrTest); 
             var attribute = type.GetCustomAttributes(false); 
 
           foreach (VersionAttribute item in attribute) 
             { 
                 Console.WriteLine(item.GetType().Name); 
                 Console.WriteLine("Version[{0}.{1}]", item.Major, item.Minor); 
             } 

        }
    }
}
