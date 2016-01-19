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
        public ObjectFinder(List<object> thelist, object theObj)
        {
            searchThisList = thelist;
            typeToFind = theObj;
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
            
        }

            
        }