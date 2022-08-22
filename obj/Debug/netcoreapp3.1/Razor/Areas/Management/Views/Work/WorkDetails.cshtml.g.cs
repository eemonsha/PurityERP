#pragma checksum "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deb1c159dcb45c8896ad29d89a8bc8ace3d74db2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Work_WorkDetails), @"mvc.1.0.view", @"/Areas/Management/Views/Work/WorkDetails.cshtml")]
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
#line 1 "D:\Project\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Project\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb1c159dcb45c8896ad29d89a8bc8ace3d74db2", @"/Areas/Management/Views/Work/WorkDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Work_WorkDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PurityERP.Areas.Management.ViewModel.ManagementVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "WorkIndex", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
  
    IEnumerable<PurityERP.Areas.Management.Models.Payment> PayList
        = ViewData["PayList"] as IEnumerable<PurityERP.Areas.Management.Models.Payment>;

    IEnumerable<PurityERP.Areas.Management.Models.ProductWorkRegister> ProdReg
        = ViewData["ProdReg"] as IEnumerable<PurityERP.Areas.Management.Models.ProductWorkRegister>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<h1>Work Details</h1>\r\n\r\n<div>\r\n    <h4>for ");
#nullable restore
#line 16 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
       Write(Model.Product);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 16 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                       Write(Model.ProductCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</h4>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <div class=\"form-group\">\r\n                <h6 >Worker: <strong>");
#nullable restore
#line 21 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                Write(Model.Worker);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Nature of work <strong>");
#nullable restore
#line 22 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                       Write(Model.WorkType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Work Quanity: <strong>");
#nullable restore
#line 23 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                      Write(Model.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> cost per unit:  ");
#nullable restore
#line 23 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                                                               Write(Model.PerUnitCost);

#line default
#line hidden
#nullable disable
            WriteLiteral(" per item</h6>\r\n                <h6 >Work date: <strong>");
#nullable restore
#line 24 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                   Write(Model.WorkAsignDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Expected delivery date <strong>");
#nullable restore
#line 25 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                               Write(Model.EDD.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Delivered qty: <strong>");
#nullable restore
#line 26 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                       Write(Model.DeliveryQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Damaged qty: <strong>");
#nullable restore
#line 27 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                     Write(Model.WasteQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></h6>\r\n                <h6 >Paid amount <strong>");
#nullable restore
#line 28 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                    Write(Model.PaidAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></h6>
            </div>
        </div>

        <div class=""col-md-6"">
            <div class=""card"">
                <div class=""card-header bg-info text-info h5"">Payment history</div>
                    <div class=""card-body p-0"">
                        <table class=""table table-dark"">
                            <thead>
                                <tr>
                                    <th>Date</th>
                                    <th>Amount</th>
                                </tr>
                            </thead>
                            <tbody>
");
#nullable restore
#line 44 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                 foreach (PurityERP.Areas.Management.Models.Payment cstl in PayList)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 48 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                       Write(Html.DisplayFor(modelItem => cstl.PaymentDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 51 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                       Write(Html.DisplayFor(modelItem => cstl.PaymentAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 54 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                
            </div>

            <hr />
            <div class=""card"">
                <div class=""card-header bg-success text-info h5"">Product register</div>
                <div class=""card-body p-0"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th>Date</th>
                                <th>In/out</th>
                                <th>Quanity</th>
                                <th>Type</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 75 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                             foreach (PurityERP.Areas.Management.Models.ProductWorkRegister cstl in ProdReg)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 79 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.RegAsignDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 82 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.RegType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 85 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.RegCategoryQty));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 88 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                               Write(Html.DisplayFor(modelItem => cstl.MoveStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 91 "D:\Project\PurityERP\Areas\Management\Views\Work\WorkDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n");
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deb1c159dcb45c8896ad29d89a8bc8ace3d74db212954", async() => {
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
            WriteLiteral("\r\n</div>\r\n");
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
