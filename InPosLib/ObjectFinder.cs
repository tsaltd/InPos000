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
        //public bool In()
        //{
            foreach (var item in searchThisList)
            {
                if (item.GetType() == typeToFind.GetType())
                    return true;
             }
            return false;
            }
        }
            
        


