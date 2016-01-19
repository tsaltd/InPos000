using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPosLib
{
    public class objectProcessor
    {
        public List<object> objList = new List<object>();

        public SalesPerson spTemplate = new SalesPerson();

        public Executive exTemplate = new Executive();

        public void ProcessEmployees(string eType)
        {
            switch (eType)
            {
                case "exec":
                    createExecutives();
                    break;

                case "sales":
                    createSalesPeople();
                    break;
                default:
                    break;
            }

        }

        private void createSalesPeople()
        {
            SalesPerson sp = new SalesPerson();

            sp.emp.Age = 34;
            sp.emp.Department = "Marketing";
            sp.emp.Name = "Frank Wills";
            sp.emp.Salary = 23500.00F;
            sp.YTD_Sales= 1039400;

            objList.Add(sp);


            sp.emp.Age = 55;
            sp.emp.Department = "HR";
            sp.emp.Name = "Mary Tee";
            sp.emp.Salary = 67500.00F;
            sp.YTD_Sales = 9556400;

            objList.Add(sp);



        }

        private void createExecutives()
        {
            Executive exec = new Executive();

            exec.emp.Age = 34;
            exec.emp.Department = "Marketing";
            exec.emp.Name = "Frank Wills";
            exec.emp.Salary = 23500.00F;
            exec.OptionGrant = 100000;

            objList.Add(exec);


            exec.emp.Age = 55;
            exec.emp.Department = "HR";
            exec.emp.Name = "Mary Tee";
            exec.emp.Salary = 67500.00F;
            exec.OptionGrant = 980000;

            objList.Add(exec);


        }
    }
}
