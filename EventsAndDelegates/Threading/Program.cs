using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            ////synchronous
            //Function1();
            //Function2();

            ////create 2 threads
            //Thread obj1=new Thread(Function1);
            //Thread obj2 = new Thread(Function2);
            //obj1.Start();
            //obj2.Start();

            //thread is created to run parallely - foreground
            Thread obj = new Thread(FunctionForeground);
            obj.Start();
           
            //thread is created to run parallely - foreground
            Thread obj2 = new Thread(FunctionBackGround);
            obj2.IsBackground = true;
            obj2.Start();
            Console.WriteLine("main thread exited");
        }

       

        private static void FunctionForeground()
        {
                Console.WriteLine("FunctionForeground entry ");
                Console.ReadLine();
                Console.WriteLine("FunctionForeground exit");
        }

        private static void FunctionBackGround()
        {
            Console.WriteLine("FunctionBackGround entry ");
            Console.ReadLine();
            Console.WriteLine("FunctionBackGround exit");
        }
        private static void Function1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func 1 :" + i.ToString());
                Thread.Sleep(4000);
            }
        }
        private static void Function2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Func 2 :" + i.ToString());
                Thread.Sleep(4000);
            }
        }
    }
}
