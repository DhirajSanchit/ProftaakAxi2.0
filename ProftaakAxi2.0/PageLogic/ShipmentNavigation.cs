using System.Collections.Generic;
using ProftaakAXI.Classes;
using ProftaakAXI.Containers;
using ProftaakAXI.Data;

namespace ProftaakAXI.PageLogic
{
    public class ShipmentNavigation
    {
        public void OnLoad()
        {
           Toolbox.ShipmentContainer.LoadProcessableShipments();
        }
    }
}