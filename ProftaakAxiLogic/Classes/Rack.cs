using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProftaakAXI.Classes
{
    public class Rack
    {
        private List<Plank> Planks = new();

        public IReadOnlyList<Plank> GetPlanks()
        {
            return Planks;
        }
        public void CreatePlank(Plank plank)
        {
            Planks.Add(plank);
        }

        public void RemovePlank(Plank plank)
        {
            Planks.Remove(plank);
        }
    }
}
