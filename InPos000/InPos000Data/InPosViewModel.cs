
using System.Collections.Generic;
using InPosLib;

namespace InPos000Data
{
    public class InPosViewModel
    {
        public List<InPosLookups> EmployeeClasses = new List<InPosLookups>();
        public enum EmployeeType{Employee = 1, Executive, SalesPerson };

        public InPosViewModel()
        {
            // InPosLookups lookupItem  = new InPosLookups();

            EmployeeClasses.Add(new InPosLookups(1, "Employee"));
            EmployeeClasses.Add(new InPosLookups(2, "Executive"));
            EmployeeClasses.Add(new InPosLookups(3, "Sales Person"));
        }




    }
}
