using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        delegate double CalAreaPointer(int r);

      //  1.private static CalAreaPointer cptr = CalculateArea;


        static void Main(string[] args)
        {
            //1.generic delegates
            //double area = cptr.Invoke(2);

            //2. anonymous methods
            //CalAreaPointer cptr = new CalAreaPointer(
            //                                         delegate(int r)
            //                                         {
            //                                             return 3.14 * r*r;
            //                                         }
            //                                        );

            //double area = cptr(20);

            
            CalAreaPointer cpointer = r => 3.14 * r * r;                    //3.lambda
            double areaL = cpointer(20);
            
            Func<Double, Double> cptr = r => 3.14 * r * r;                  //4.lambda+ func
            double area = cptr(20);
            
            Action<string> myAction = y => Console.WriteLine(y);            //5. action - returns type void
            myAction("PaVANI");
            
            Predicate<String> checkgreater5 = x => x.Length > 5;            //6.PREDICATE - return type boolean 
            Console.WriteLine(checkgreater5("pavani"));

            List<string> list = new List<string>();
            list.Add("pavani");
            list.Add("pavanii");
            list.Add("kk");

            string str = list.Find(checkgreater5);
            Console.WriteLine(str);
            //Expresion trees eg:(10+20) - (5+6)

            //(10+20) 
            BinaryExpression b1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(10),
                                                                            Expression.Constant(20));
            // (5+6)
            BinaryExpression b2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(5),
                                                                            Expression.Constant(6));
            //(10 + 20) - (5 + 6)
            BinaryExpression b3 = Expression.MakeBinary(ExpressionType.Add,b1,b2);

            //this stmt will create a delegate by parsing the expression tree
            int result = Expression.Lambda<Func<int>>(b3).Compile()();

            //LinQ
           // var x = (from i in o.customertable where o.customername == "pavani" select i);

        }

        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }

    }
}
