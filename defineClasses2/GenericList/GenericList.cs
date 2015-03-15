//Write a generic class  GenericList<T>  that keeps a list of elements of some parametric type  T .
// Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor.
// Implement methods for adding element, accessing element by index, removing element by index, 
//inserting element at given position, clearing the list, finding element by its value and  ToString() .
// Check all input parameters to avoid accessing elements at invalid positions.

using System;
using System.Collections.Generic;
using System.Text; 
using System.Threading.Tasks;
using System.Linq;

namespace TElements
{
 public  class GenericList<T> where T :IComparable
    {
     //task 5
     private T[] genericArr;
     private int count = 0;
      private T[] List { get; set; } 
        public int Capacity { get; private set; } 
         public int Length{ get;private set; } 

     public GenericList(int capacity=0)
     {
         this.Capacity = capacity;
         this.genericArr=new T[capacity];
     }
     public int Index
     {
         get
         {
             return this.count;
         }
     }
     public void Add(T element)
     {
         if (count == genericArr.Length)
         {
             GrowCapacity();
         }
         this.genericArr[count] = element;
         count++;
     }
     public void Remove(int index)
     {
         if (this.genericArr.Length>index && index>=0 )
         {
             T[] newList = new T[this.genericArr.Length - 1];
             bool mark = true;
             for (int i = 0; i < genericArr.Length-1; i++)
             {
                 if (index==i)
                 {
                     mark = false;
                 }
                 if (mark==true)
                 {
                     newList[i] = this.genericArr[i];
                 }
                 else
                 {
                     newList[i] = this.genericArr[i + 1];
                 }
             }
             this.genericArr = newList;
         }
         else
         {
             throw new IndexOutOfRangeException("Invalid index");
         }
     }
     
         public void Clear() 
         { 
            this.Length = 0; 
             this.Capacity = 0; 
         } 

     public void Insert(T element, int index)
     {
         if (this.genericArr.Length > index && index >= 0)
         {
             T[] newList = new T[this.genericArr.Length + 1];
             bool mark = true;
             for (int i = 0; i < genericArr.Length; i++)
             {
                 if (index == i)
                 {
                     mark = false;
                     genericArr[index] = element;
                 }
                 if (mark == true)
                 {
                     newList[i] = this.genericArr[i];
                 }
                 else
                 {
                     newList[i] = this.genericArr[i - 1];
                 }
             }
             this.genericArr = newList;
         }
         else
         {
             throw new IndexOutOfRangeException("Invalid index");
         }
     }
     //task 6
     private void GrowCapacity()
     {
         T[] newArray = new T[genericArr.Length * 2];
         Array.Copy(genericArr, 0, newArray, 0, genericArr.Length);
         genericArr = newArray;
     }
     public T Min()
     {
         dynamic smallestElement = int.MaxValue;
         for (int i = 0; i < genericArr.Length; i++)
         {
             if (genericArr[i]<smallestElement)
             {
                 smallestElement = this.genericArr[i];
             }
         }
         return smallestElement;
     }
     public T Max()
     {
         dynamic biggestElement = int.MinValue;
         for (int i = 0; i < genericArr.Length; i++)
         {
             if (genericArr[i]>biggestElement)
             {
                 biggestElement = this.genericArr[i];
             }
         }
         return biggestElement;
     }
     public override string ToString()
     {
         StringBuilder result = new StringBuilder();
         foreach (var element in genericArr)
         {
             result.Append(element.ToString());
         }
         return result.ToString();
     }
    }
}
