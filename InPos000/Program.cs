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
            List<Object> ObjectsToAnalyze = new List<object>();

            objectProcessor op = new objectProcessor();

            op.ProcessEmployees("exec");

            op.ProcessEmployees("sales");

            ObjectFinder of = new ObjectFinder(op.objList, new Executive());
            


           



            

            

            
            
            
           
        } 
    }
}
