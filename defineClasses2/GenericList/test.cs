using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TElements
{
    class test
    {
        static void Main()
        {
            var myArr = new GenericList<int>();
            Console.WriteLine(myArr);
            Console.WriteLine("Count: {0}", myArr.Length);
            Console.WriteLine("Capacity: {0}", myArr.Capacity);
        myArr = new GenericList<int>(2);
        myArr.Add(7);
        myArr.Add(3);
        myArr.Add(4);
        Console.WriteLine(Environment.NewLine + myArr);
        Console.WriteLine("Count: {0}", myArr.Length);
        Console.WriteLine("Capacity: {0}", myArr.Capacity);
        myArr.Clear();
        myArr.Insert(0, 3);
        myArr.Insert(6, 2);
        myArr.Remove(0);
        myArr.Remove(myArr.Length); 

        Console.WriteLine(myArr);
        Console.WriteLine(Environment.NewLine + "Min value: {0}", myArr.Min());
        Console.WriteLine("Max value: {0}", myArr.Max()); 

        }
    }
}
