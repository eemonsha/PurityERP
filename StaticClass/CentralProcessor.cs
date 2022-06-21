using PurityERP.Areas.Management.Models;
using PurityERP.Areas.Management.ViewModel;
using PurityERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.StaticClass
{
    public class CentralProcessor
    {

        //this function will be used to add/delete/edit product cost and update the cost in product table
        public static string ManagePodCost(DataContext _Db, string OperationType, List<CostManagementVM> NewCostInfo )
        {
            if (OperationType == "Add")
            {
                foreach(var item in NewCostInfo)
                {
                    var NewCost = new CostRegister()
                    {
                        ID=0,
                        ProdID=item.ProdID,
                        CostID=item.CostTypeID,
                        DateofCalculate =item.CostDate,
                        PerUnitCost=item.PerUnitCostNew,
                        CostRegID=item.CostCorrRegId,
                        CostStatus="Active"
                    };
                    _Db.Add(NewCost);
                    _Db.SaveChanges();

                    UpdateProdCost(_Db, item.ProdID);
                }
            }
            else if (OperationType == "Edit")
            {
                foreach (var item in NewCostInfo)
                {
                    var SelDel = _Db.CostRegisters.Where(x => x.ID == item.CostRegID).FirstOrDefault();
                    SelDel.PerUnitCost = item.PerUnitCostUpdate;
                    _Db.Update(SelDel);
                    _Db.SaveChanges();

                    UpdateProdCost(_Db, item.ProdID);
                }
            }
            else if (OperationType == "Delete")
            {
                foreach (var item in NewCostInfo)
                {
                    var SelDel = _Db.CostRegisters.Where(x => x.ID == item.CostRegID).FirstOrDefault();
                    SelDel.CostStatus = "Cancelled";
                    _Db.Update(SelDel);
                    _Db.SaveChanges();

                    UpdateProdCost(_Db, item.ProdID);
                }   
            }
            else
            {
                return "No changes made";
            }
            return "Ok";
        }


        //this function will be called from ManagePodCost function to update the cost against product
        private static string UpdateProdCost(DataContext _Db, int ProdId)
        {
            decimal SelCosts = _Db.CostRegisters.Where(x => x.ProdID == ProdId).Sum(x=>x.PerUnitCost);

            var SelProd = _Db.Products.Where(x => x.Id == ProdId).FirstOrDefault();
            SelProd.CostingPrice = SelCosts;
            _Db.Update(SelProd);
            _Db.SaveChanges();

            return "Ok";
        }

        

    }
}
