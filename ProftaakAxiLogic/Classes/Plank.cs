using System.Collections.Generic;

namespace ProftaakAxiLogic.Classes
{
    public class Plank
    {
        private List<Pallet> Pallets = new();

        public IReadOnlyList<Pallet> GetPallets()
        {
            return Pallets;
        }

        public void CreatePallet(Pallet pallet)
        {

            Pallets.Add(pallet);
        }

        public void RemovePallet(Pallet pallet)
        {
            Pallets.Add(pallet);
        }
    }
}
