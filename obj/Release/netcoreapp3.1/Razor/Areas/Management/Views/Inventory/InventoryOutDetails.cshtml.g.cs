#pragma checksum "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf6dc96fb74a2f745d9ac77b20955a82fa7fa77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Inventory_InventoryOutDetails), @"mvc.1.0.view", @"/Areas/Management/Views/Inventory/InventoryOutDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf6dc96fb74a2f745d9ac77b20955a82fa7fa77", @"/Areas/Management/Views/Inventory/InventoryOutDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Inventory_InventoryOutDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurityERP.Areas.Management.ViewModel.ManagementVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InventoryOutIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n\r\n<h1>InventoryOut Details </h1>\r\n\r\n<div>\r\n    <h3> ");
#nullable restore
#line 16 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
    Write(Model.ProductTittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" for  ");
#nullable restore
#line 16 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                              Write(Model.InventoryItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h3>\r\n    <h4>Details</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                <h6>Inventory Item: <strong>");
#nullable restore
#line 22 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                                       Write(Model.InventoryItem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6>Date: <strong>");
#nullable restore
#line 23 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                             Write(Model.SystemDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6>Product Tittle: <strong>");
#nullable restore
#line 24 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                                       Write(Model.ProductTittle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> </h6>\r\n                <h6>Product Quantity: <strong>");
#nullable restore
#line 25 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                                         Write(Model.ProductQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6>Inventory Quantity<strong>");
#nullable restore
#line 26 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                                         Write(Model.InventoryQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6>Per Product Inventory Quantity<strong>");
#nullable restore
#line 27 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                                                     Write(Model.PerProductInventoryQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6>Worker: <strong>");
#nullable restore
#line 28 "D:\Sujon\PurityERP\Areas\Management\Views\Inventory\InventoryOutDetails.cshtml"
                               Write(Model.Worker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf6dc96fb74a2f745d9ac77b20955a82fa7fa777017", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
