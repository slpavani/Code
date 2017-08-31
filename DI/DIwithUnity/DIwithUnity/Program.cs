using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;


namespace DIwithUnity
{
    //UI
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer objContainer= new UnityContainer();
            objContainer.RegisterType<Customer>();
            objContainer.RegisterType<IDal, OracleServerDal>();
            objContainer.RegisterType<IDal, SQLServerDal>();
            //Customer obj = new Customer(new SQLServerDal());
            Customer obj = objContainer.Resolve<Customer>();
            obj.CustomerName = "pavani";
            obj.Add();
        }
    }

    //Middle layer
    class Customer
    {
         private IDal odal; // <<--Unity decoupled arch
        // 1. private SQLServerDal OdalSql= new SQLServerDal();
        // 1. private OracleServerDal OdalOra = new OracleServerDal();
        public Customer(IDal idal)
        {
            odal = idal;
        }

        public string CustomerName { get; set; }
        public void Add()
        {
            //Invokes Data Acccess Layer (DAL)
          // 1,2. if (true)           //can be from config/params
          //  {
          //     //2.odal =new SQLServerDal();
          //     //1. OdalSql.add();
          //  }
          //  else
          //  {
          //     // 2.odal = new OracleServerDal();
          //     // 1. OdalOra.add();
          //  }
           odal.Add();

        }
    }

    //DAL
    class SQLServerDal : IDal
    {
        public void Add()
        {
            Console.WriteLine("DAL Added User to sql server");
        }
         
    }

    class OracleServerDal :IDal
    {
        public void Add()
        {
            Console.WriteLine("DAL Added User to Oracle server");
        }

    }

    interface IDal
    {
        void Add();
    }
}

