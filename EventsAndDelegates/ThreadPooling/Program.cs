using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPooling
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxThreads;
            int minThreads;
            int avaThreads;
            int comp1, comp2, comp3;
            ThreadPool.GetMaxThreads(out maxThreads,out comp1);
            Console.WriteLine("max threads:{0}",maxThreads);

            ThreadPool.GetMinThreads(out minThreads, out comp2);
            Console.WriteLine("min threads:{0}", minThreads);

            ThreadPool.GetAvailableThreads(out avaThreads, out comp3);
            Console.WriteLine("Available threads:{0}", avaThreads);

            Task.Run(() => { Thread.Sleep(1000); });

            ThreadPool.GetAvailableThreads(out avaThreads, out comp3);
            Console.WriteLine("New no.of Available threads:{0}", avaThreads);
            

            Console.Read();
        }
    }
}
