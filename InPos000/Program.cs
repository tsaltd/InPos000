using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InPosLib;

namespace InPos000
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  Check for Object Type:");

            Console.WriteLine(  "  1 = Employee");
            Console.WriteLine(  "  2 = Executive");
            Console.WriteLine(  "  3 = SalesRep");

            //ConsoleKeyInfo info = Console.ReadLine();
            string selector = Console.ReadLine();

            
            processTests(selector);




            Console.ReadKey();
                       
        }

        private static void processTests(string selector)

        {
           // selectObjectType(selector);
            List<Object> ObjectsToAnalyze = new List<object>();

            InPosLib.ObjectProcessor op  = new ObjectProcessor();

          // objectProcessor op = new objectProcessor();

            op.ProcessEmployees("exec");

            op.ProcessEmployees("sales");

            //ObjectFinder of = new ObjectFinder(op.objList, new Employee());

            ObjectFinder TestEmployee = new ObjectFinder(op.objList, selector, true);


            bool yn = TestEmployee.In();

            Console.WriteLine(yn.ToString());
        }

            }
}
