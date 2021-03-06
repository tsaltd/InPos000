﻿using System.Collections.Generic;

namespace InPosLib
{
    public class ObjectProcessor
    {
        public List<object> objList = new List<object>();

        public SalesPerson _spTemplate;

        public Executive _exTemplate;

        public ObjectProcessor(SalesPerson spTemplate, Executive exTemplate)
        {
            _spTemplate = spTemplate;
            _exTemplate = exTemplate;
        }

        public ObjectProcessor()
        {
            
        }
        public SalesPerson SpTemplate
        {
            get { return _spTemplate; }
            set { _spTemplate = value; }
        }

        public Executive ExTemplate
        {
            get { return _exTemplate; }
            set { _exTemplate = value; }
        }

        public void ProcessEmployees(string eType)
        {
            switch (eType)
            {
                case "exec":
                    CreateExecutives();
                    break;

                case "sales":
                    CreateSalesPeople();
                    break;
                // ReSharper disable once RedundantEmptyDefaultSwitchBranch
                default:
                    break;
            }

        }

        private void CreateSalesPeople()
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

        private void CreateExecutives()
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
