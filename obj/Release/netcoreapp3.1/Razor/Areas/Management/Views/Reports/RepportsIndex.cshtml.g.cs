#pragma checksum "D:\new\PurityERP\Areas\Management\Views\Reports\RepportsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8be57eb7b23a5b7780c1739e25b5b101584b805"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Reports_RepportsIndex), @"mvc.1.0.view", @"/Areas/Management/Views/Reports/RepportsIndex.cshtml")]
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
#line 1 "D:\new\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\new\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\new\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\new\PurityERP\Areas\Management\Views\_ViewImports.cshtml"
using PurityERP.Areas.Management.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8be57eb7b23a5b7780c1739e25b5b101584b805", @"/Areas/Management/Views/Reports/RepportsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Reports_RepportsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/plugins/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<h3 class=""text-center m-4"">All Report</h3>



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
                Datewise Work Out details
            </td>
            <td>
                <button type=""button"" class=""btn btn-primary"" id=""workoutrep"">Report</button>
            </td>
        </tr>
        <tr class=""text-center"">
            <td>
                Datewise Work In details
            </td>
            <td>
                <button type=""button"" class=""btn btn-primary"" id=""workInrep"">Report</button>
            </td>
        </tr>
        <tr class=""text-center"">
            <td>
                Datewise Inventory In details
            </td>
            <td>
                <button type=""button"" class=""btn btn-primary"" id=""InvInrep"">Report</button>
            </td");
            WriteLiteral(@">
        </tr>
        <tr class=""text-center"">
            <td>
                Datewise sales details
            </td>
            <td>
                <button type=""button"" class=""btn btn-primary"" id=""Dailysalesrep"">Report</button>
            </td>
        </tr>
        <tr class=""text-center"">
            <td>
                Inventory Details
            </td>
            <td>
                <button type=""button"" class=""btn btn-primary"" id=""invendetails"">Report</button>
            </td>
        </tr>
    </tbody>
</table>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8be57eb7b23a5b7780c1739e25b5b101584b8056059", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8be57eb7b23a5b7780c1739e25b5b101584b8057162", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $('#workoutrep').click(function () {


       var host = window.origin;//publish
       // var host = ""https://localhost:44326"";
        window.open(host + '/Reports/Rep/Workoutdatewise?& ','_blank');//publish
        //window.open(host + '/Rep/Workoutdatewise?& ','_blank');
    });
    

    </script>

    <script>
        $('#workInrep').click(function () {


             var host = window.origin;//publish
           // var host = ""https://localhost:44326"";
            window.open(host + '/Reports/Rep/WorkIndatewise?& ','_blank');//publish
           // window.open(host + '/Rep/WorkIndatewise?& ', '_blank');
        });


    </script>

    <script>
        $('#InvInrep').click(function () {


            var host = window.origin;//publish
            // var host = ""https://localhost:44326"";
            window.open(host + '/Reports/Rep/InventoryIndatewise?& ', '_blank');//publish
            // window.open(host + '/Rep/InventoryIndatewise?& ', '_blank'");
                WriteLiteral(@");
        });


    </script>

    <script>
        $('#Dailysalesrep').click(function () {


            var host = window.origin;//publish
            // var host = ""https://localhost:44326"";
            window.open(host + '/Reports/Rep/SalesIndatewise?& ', '_blank');//publish
            // window.open(host + '/Rep/SalesIndatewise?& ', '_blank');
        });


    </script>

    <script>
        $('#invendetails').click(function () {


            var host = window.origin;//publish
            // var host = ""https://localhost:44326"";
            window.open(host + '/Reports/Rep/InventoryDetails?& ', '_blank');//publish
            // window.open(host + '/Rep/InventoryDetails?& ', '_blank');
        });


    </script>



    ");
            }
            );
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
