#pragma checksum "D:\Sujon\PurityERP\Areas\Management\Views\Reports\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9735850b27c64ef13717555075319387f7f3a355"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Reports_Index), @"mvc.1.0.view", @"/Areas/Management/Views/Reports/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9735850b27c64ef13717555075319387f7f3a355", @"/Areas/Management/Views/Reports/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Reports_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h3 class=""text-center m-4"">All Report</h3>



    <table class=""table table-striped table-bordered"">
        <thead>
            <tr class=""text-center"">
                <th>Report Title</th>
                <th>Perameter</th>
            </tr>
        </thead>
        <tbody>
            <tr class=""text-center"">
                <td>
                    Accountwise Transactions Report
                </td>
                <td>
                    <button type=""button"" class=""btn btn-primary"" id=""proqr"">Pro Print</button>
                    <!--Report-->
");
            WriteLiteral("                </td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
