using System.Collections.Generic;
using ProftaakAXI.Containers;
using ProftaakAXI.DAL;
using ProftaakAXI.Data;

namespace ProftaakAXI
{
    public static class Toolbox
    {
        public static ShipmentContainer ShipmentContainer = new();
        public static DataBaseClient DataBaseClient = new();
        public static RackDAL RackDal = new();
        public static RowDAL RowDal = new();
        public static PalletDAL PalletDal = new();
        public static PlankDAL PlankDal = new();
        public static ArticleDAL ArticleDal = new();
        public static EmployeeDAL EmployeeDal = new();
        public static ShipmentDAL ShipmentDal = new();
        public static ShipmentArticleDAL ShipmentArticleDal = new();
    }
}