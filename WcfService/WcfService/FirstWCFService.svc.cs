using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "First_WCFService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select First WCFService.svc or First WCFService.svc.cs at the Solution Explorer and start debugging.
    public class FirstWCFService : IFirstWCFService
    {
        public string Message()
        {
            return "Hello world";
        }

        public int add(int x, int y)
        {
            return x + y;
        }
    }
}
