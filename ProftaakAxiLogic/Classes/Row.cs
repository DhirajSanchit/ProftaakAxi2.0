using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakAXI.Classes
{
    public class Row
    {
        public string Name { get; set; }

    /*     public void CreateRack(Rack rack)
         {

         }
          public void RemoveRack(Rack rack)
        {

        }   
     
     */
        public void SetName (string name)
        {
            Name = name;
        }
    }
}
