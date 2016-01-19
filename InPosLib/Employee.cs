using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPosLib
{
    public class Employee
    {
     
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public float  Salary{ get; set; }

       
    }
    public class Executive

    {
        public Employee emp = new Employee();
       
        public int OptionGrant { get; set; }
    }
    public class SalesPerson
    {
        public Employee emp = new Employee();
        
        public float YTD_Sales { get; set; }

        //public SalesPerson()
        //{

        //}
    }
}
