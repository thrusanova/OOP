using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace DefineClasses
{
  public  class Test
    {
      //task 7
      static void Main()
      {
          GSM[] testModels = new GSM[4];
          testModels[0] = new GSM("Nokia", "Nokia LTd", 450.00m, "az", new Battery("P100",200,200,BatterryType.LiIon), new Display(100,160000));
          testModels[1]=new GSM("Samsung","Samsung Corp.",360.00m,"Pesho",new Battery("L600",304,290,BatterryType.LiPoly),new Display(100,32000));
          testModels[2]=GSM.IPhone4S;
          testModels[3] = new GSM("HTC", "IM Corpor.");
          foreach (var item in testModels)
          {
              Console.WriteLine(item);
          }
          Console.WriteLine();
          var myGsm = new GSM("Nokia", "Nokia", 400m, "me", new Battery("P100", 200, 200, BatterryType.LiIon), new Display(100, 160000));
          Call callHistory1 = new Call(DateTime.Now, "0888886666", 155);
          Call callHistory2 = new Call("0998777666", 76);
          Call callHistory3 = new Call("08886756467", 100);
          List<Call> listOfCalls = new List<Call>();
          listOfCalls.Add(callHistory1);
          listOfCalls.Add(callHistory2);
          listOfCalls.Add(callHistory3);
          foreach (var call in listOfCalls)
          {
              Console.WriteLine(call);
          }
          myGsm.AddCall(callHistory3);
          Console.WriteLine("The total price of the call with the number {0} is {1:F2}",callHistory3.PhoneNumber, myGsm.CalcTotalPrice(0.37m));
          myGsm.AddCall(callHistory2);
          Console.WriteLine("The total price of the  call for my GSM {0} is {1:F2}", callHistory2.PhoneNumber, myGsm.CalcTotalPrice(0.37m));
          myGsm.AddCall(callHistory1);
          Console.WriteLine("The total price of the call for my GSM {0} is {1:F2}",callHistory1.PhoneNumber, myGsm.CalcTotalPrice(0.37m));

          var longestDuration = myGsm.CallHistory.Max(x => x.Duration);
          foreach (var call in myGsm.CallHistory)
          {
              if (call.Duration == longestDuration)
              {
                  myGsm.DelCall(call);
                  break;
              }
          }
          Console.WriteLine("The total price after removing the longest call is {0:F2}", myGsm.CalcTotalPrice(0.37m));
          myGsm.ClearHistory();
          Console.WriteLine("The total price after clearing the call histori is {0}", myGsm.CalcTotalPrice(0.37m));

      }
    }
}
