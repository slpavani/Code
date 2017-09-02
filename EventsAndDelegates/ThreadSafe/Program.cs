using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafe
{
    class Program
    {
        static Calculate objCal =new Calculate();
        static void Main(string[] args)
        {
            Thread t1= new Thread(objCal.Multiply);
            t1.Start();
            objCal.Multiply();
            Console.ReadLine();
        }
    }

    class Calculate
    {
        public int Num1, Num2;
        Random o= new Random();

        public void Multiply()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (this)
                {
                    Num1 = o.Next(1, 2);
                    Num2 = o.Next(1, 2);
                    int result = Num1 * Num2;
                    Num1 = 0;
                    Num2 = 0;
                    Console.WriteLine(result);
                }
            }
        }
    }
   
}
