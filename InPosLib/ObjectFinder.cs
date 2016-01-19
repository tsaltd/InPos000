using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPosLib
{
    class ObjectFinder
    {
        public List<object> searchThisList = new List<object>();
        public object typeToFind;
        public bool found;
        ObjectFinder(List<object> thelist, object theObj)
        {
            searchThisList = thelist;
            typeToFind = theObj;
            //var wtf = searchThisList(1)

            foreach (var item in searchThisList)
            {
                if (item.GetType() == typeToFind.GetType())
                    found = true;

            }
            
        }

            //public bool In()
            //{
            //    if (typeToFind.GetType() == typeof()) { }
            //}

        }
}
