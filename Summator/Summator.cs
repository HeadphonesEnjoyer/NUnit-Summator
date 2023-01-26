using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {
        public static double Sum(int[] arr)
        {
           
                double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static double Average(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            //return sum
            return sum / arr.Length;
        }   

    /* ----------------------------------------------- */
      
                 public static void Test_SumTwoNumbers()
                  {
                      if (Sum(new int[] { 1, 2 }) != 3)
                      {
                          throw new Exception("1+2 != 3");
                      } else
                      {
                          Console.WriteLine("Test pass!");
                      }
                  } 


            
    }
}
    //changes
