#pragma checksum "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3bb5be76ea19f48e9c88e085f6dd394deb9d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Inventory_DetailsInventory), @"mvc.1.0.view", @"/Areas/Management/Views/Inventory/DetailsInventory.cshtml")]
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
#line 1 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3bb5be76ea19f48e9c88e085f6dd394deb9d3c", @"/Areas/Management/Views/Inventory/DetailsInventory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0dfdd7237deb7a0c28bef2cc1edd5df251c7422", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Inventory_DetailsInventory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurityERP.Areas.Management.ViewModel.ManagementVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditInventory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InventoryIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
   
    IEnumerable<PurityERP.Areas.Management.ViewModel.InventoryVM> InvTxnList 
        = ViewData["InvTxnInfo"] as IEnumerable<PurityERP.Areas.Management.ViewModel.InventoryVM>;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>

<div>
    <h4>Inventory</h4>
    <hr />

    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""form-group"">
                    <label for=""Quantity"">Inventory</label>
                    <h6>");
#nullable restore
#line 19 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                   Write(Model.Tittle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ( ");
#nullable restore
#line 19 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                   Write(Model.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral(" )</h6>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"Quantity\">Purchase detail</label>\r\n                    <h6><strong>On</strong> ");
#nullable restore
#line 25 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                       Write(Model.PurchaseDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n                    <h6>\r\n                        <strong>Qty</strong> ");
#nullable restore
#line 27 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                        Write(Model.PurchaseQuantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                                                Write(Model.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n                        <strong>Per unit cost:</strong> ");
#nullable restore
#line 28 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                                   Write(Model.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h6>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"Quantity\">Supplier</label>\r\n                    <h6>On ");
#nullable restore
#line 35 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                      Write(Model.SupplierName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"row\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"Quantity\">Current stock</label>\r\n                    <h6>");
#nullable restore
#line 42 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                   Write(Model.RemainingQty);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 42 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                       Write(Model.UnitName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                </div>
            </div>

        </div>
        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header bg-red text-info h5"">Consumptions</div>
                <div class=""card-body p-0"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th>Date</th>
                                <th>Product</th>
                                <th>Inv. Qty</th>
                                <th>Prod. Qty</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 61 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                             foreach (PurityERP.Areas.Management.ViewModel.InventoryVM cstl in InvTxnList)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 65 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.InvOutDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 68 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.ProductTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 71 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.InvOutQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 74 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.ProdQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 77 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3bb5be76ea19f48e9c88e085f6dd394deb9d3c11495", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Inventory\DetailsInventory.cshtml"
                                    WriteLiteral(Model.InventoryId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3bb5be76ea19f48e9c88e085f6dd394deb9d3c13694", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
