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
        List<int> locations = new List<int>();
        public ObjectFinder(List<object> thelist, object theObj)
        {
            List<object> searchThisList = new List<object>();
            searchThisList = thelist;
            object typeToFind = new object();
            typeToFind = theObj;

            public bool In()
            {
                object result = thelist.Find(x => typeof(x) == typeToFind );
            }

            //foreach (var item in searchThisList)
            //{
            //    int here = searchThisList.FindIndex(x => (item.GetType() == typeToFind.GetType()));
            //    //int here = searchThisList.FindIndex(x => (item.GetType() == typeToFind.GetType()));
            //    locations.Add(here);
                
            //    //if (item.GetType() == typeToFind.GetType())
            //    //    found = true;
            //    ////int where = 
            //    ////    locations.Add(indexof,)

            //    //   // int oddIndex = elements.FindIndex(x => x % 2 != 0);
                    

            }
        }
    }
            


