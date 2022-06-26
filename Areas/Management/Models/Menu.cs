using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PurityERP.Areas.Management.Models
{
    public class Menu
    {
        [Key]
        public int MenuID { get; set; }
        public string ManuName { get; set; }

    }
    public class SubMenu
    {
        [Key]
        public int SubMenuID { get; set; }
        public string SubManuName { get; set; }
        public string Controller { get; set; }
        public string Area { get; set; }
        public string Action { get; set; }
        public int MainMenuID { get; set; }
        
    }
    public class RolebasedMenu
    {
        [Key]
        public int RBMenuID { get; set; }
        public int SubMenuID { get; set; }
        public int UserTypeID { get; set; }
        public int UserID { get; set; }
        public bool ActiveStatus { get; set; }

    }

    public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }
        public string UserTypeName { get; set; }
    }
   

}
