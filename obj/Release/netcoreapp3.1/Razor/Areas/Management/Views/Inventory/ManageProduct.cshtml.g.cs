#pragma checksum "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\ManageProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "645be709dcb02ac065eae78efc4987d24bfedc32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Inventory_ManageProduct), @"mvc.1.0.view", @"/Areas/Management/Views/Inventory/ManageProduct.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Sujon\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Sujon\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Sujon\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Sujon\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"645be709dcb02ac065eae78efc4987d24bfedc32", @"/Areas/Management/Views/Inventory/ManageProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Inventory_ManageProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurityERP.Areas.Management.ViewModel.ManagementVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Product Details</h1>\r\n\r\n<div>\r\n    <h4>for ");
#nullable restore
#line 7 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\ManageProduct.cshtml"
       Write(Model.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 7 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\ManageProduct.cshtml"
                       Write(Model.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n    <hr />\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                <h6>Costing: <strong>");
#nullable restore
#line 13 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\ManageProduct.cshtml"
                                Write(Model.CostingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PurityERP.Areas.Management.ViewModel.ManagementVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
