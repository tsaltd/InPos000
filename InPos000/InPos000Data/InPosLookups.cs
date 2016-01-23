using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InPos000Data
{
    public class InPosLookups

        // do this with anonymous classes
    {
            public int Id { get; set; }
            public string Name{ get; set; }

        public InPosLookups(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public InPosLookups()
        {
           
        }
    }

   
   

        
}

