using System.Collections.Generic;

namespace ProftaakAxiLogic.Classes
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
