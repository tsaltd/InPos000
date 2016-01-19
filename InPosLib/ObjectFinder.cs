using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPosLib
{
    public class ObjectFinder
    {
        public List<object> searchThisList = new List<object>();
        public object typeToFind;
        public bool found;
        public ObjectFinder(List<object> thelist, string selector)
        {
            searchThisList = thelist;
            selectObjectType(selector);

           // typeToFind = theObj;
            //var wtf = searchThisList(1)
        }

            //foreach (var item in searchThisList)
            //{
            //    if (item.GetType() == typeToFind.GetType())
            //        found = true;

            //}

            public bool In()
            {
               object result = searchThisList.Find(x => x.GetType() == typeToFind.GetType());
               if (result != null) return true;
               return false;
            }
            void selectObjectType(string selector)
            {
                object findClass = new object();


                switch (selector)
                {
                    case "1":

                        typeToFind = new Employee();

                        break;
                    case "2":

                        typeToFind = new Executive();
                        break;
                    case "3":

                        typeToFind = new SalesPerson();
                        break;
                }
            } 

            
        }

            
        }