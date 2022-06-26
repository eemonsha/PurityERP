using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.ViewModel
{
    public class MenuVM
    {
        public int MenuID { get; set; }
        public string ManuName { get; set; }
        public int SubMenuID { get; set; }
        public string SubManuName { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public string Action { get; set; }
        public int MainMenuID { get; set; }
        public int RBMenuID { get; set; }
        public string UserTypeName { get; set; }
        public int UserTypeID { get; set; }
        public int UserID { get; set; }
    }
}
