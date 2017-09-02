using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFirst_WCFService" in both code and config file together.
    [ServiceContract]
    public interface IFirstWCFService
    {
        [OperationContract]
        string Message();

        [OperationContract]
        int add(int x, int y);

    }
}
