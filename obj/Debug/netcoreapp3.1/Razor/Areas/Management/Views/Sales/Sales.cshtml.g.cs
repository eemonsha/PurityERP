#pragma checksum "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb96a807cdf4be5e550263cfada92ea1d96651a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Sales_Sales), @"mvc.1.0.view", @"/Areas/Management/Views/Sales/Sales.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb96a807cdf4be5e550263cfada92ea1d96651a", @"/Areas/Management/Views/Sales/Sales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b63c55b46018869114846a8777e109287938c9a1", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Sales_Sales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("inv"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control select2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-native-menu", new global::Microsoft.AspNetCore.Html.HtmlString("false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("supplier"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4>Sales</h4>\r\n<hr />\r\n\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-md-12\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a8120", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label\">Product</label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a9846", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a10130", async() => {
                    WriteLiteral("Select One ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 16 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.pr;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <span class=""text-danger""></span>
                </div>

            </div>

        </div>



        <div class=""row mt-2"">
            <div class=""col-3 border border-secondary rounded-left"">
                <b>Product Code</b>
            </div>
            <div class=""col-3 border border-secondary"">
                <b>Product Name</b>
            </div>
            <div class=""col-3 border border-secondary"">
                <b>Unit Price</b>
            </div>
            <div class=""col-3 border border-secondary rounded-right"">
                <b>Remain Qty</b>
            </div>

        </div>
        <div class=""row mb-2"">
            <div class=""col-3 border border-secondary"">
                <input type=""text"" class=""form-control"" id=""product"" readonly />
            </div>
            <div class=""col-3 border border-secondary"">
                <input type=""text"" class=""form-control"" id=""name"" readonly />
            </div>
            <div clas");
            WriteLiteral(@"s=""col-3 border border-secondary"">
                <input type=""text"" class=""form-control"" id=""sellprice"" readonly />
            </div>
            <div class=""col-3 border border-secondary"">
                <input type=""text"" class=""form-control"" id=""rmn"" readonly />
            </div>

        </div>

        <div class=""row"">

            <div class=""col-md-6"">
                <label>Order Qty :</label>
                <input type=""number"" id=""qty"" class=""form-control"" />
            </div>

            <div class=""col-md-6"">

                <label>Amount :</label>
                <input readonly type=""text"" id=""amount"" class=""form-control"" />

            </div>


        </div>


        <div class=""row"">

            <div class=""col-md-6"">
                <label> Discount Percentage :</label>
                <input type=""text"" id=""per"" class=""form-control"" value=""0"" />
            </div>
            <div class=""col-md-6"">
                <label> Amount :</label>
    ");
            WriteLiteral(@"            <input readonly type=""text"" id=""amnt"" class=""form-control"" value=""0"" />
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6"">
                <label> vat :</label>
                <input type=""text"" id=""vap"" class=""form-control"" value=""0"" />
            </div>
            <div class=""col-md-6"">
                <label> vat :</label>
                <input type=""text"" id=""vaa"" class=""form-control"" value=""0"" />
            </div>
        </div>
        <div class=""row"">

            <div class=""col-md-12"">
                <label> Total :</label>
                <input readonly type=""text"" id=""totaltt"" class=""form-control"" />
            </div>
        </div>
        <div class=""row mt-2"">
            <div class=""col-4""></div>
            <div class=""col-4"">
                <div class=""btn-group"">
                    <button id=""additem"" class=""btn btn-success"">Add</button>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a16216", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <input type=\"hidden\" id=\"productname\"");
            BeginWriteAttribute("value", " value=\"", 3737, "\"", 3745, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    </div>\r\n\r\n    <div class=\"col-6\">\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a17861", async() => {
                WriteLiteral("Customer");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 121 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\" input-group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a19475", async() => {
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a19760", async() => {
                    WriteLiteral("Select One");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
#nullable restore
#line 123 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 123 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.cs;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                    <div class=""input-group-append"">
                        <span class=""input-group-text"">
                            <a href=""#"" data-toggle=""modal""
                               data-target=""#suppliercreate"">  <i class=""fas fa-plus-circle""></i></a>
                        </span>
                    </div>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb96a807cdf4be5e550263cfada92ea1d96651a23525", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 134 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustID);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

            </div>
        </div>

        <div class=""row mt-5"">

            <div class=""col-6"">
                <b>Total Amount</b>
            </div>
            <div class=""col-6"">
                <input type=""text"" readonly id=""totalall"" class=""form-control"" />
            </div>
        </div>
        <div class=""row"">

            <div class=""col-6"">
                <b>Total Vat</b>
            </div>
            <div class=""col-6"">
                <input type=""text"" readonly id=""totalvat"" class=""form-control"" />
            </div>
        </div>
        <div class=""row"">

            <div class=""col-6"">
                <b>Total Discount</b>
            </div>
            <div class=""col-6"">
                <input type=""text"" readonly id=""totaldis"" class=""form-control"" />
            </div>
        </div>
        <div class=""row"">

            <div class=""col-6"">
                <b>Payable Amount</b>
            </div>
            <div class=""col-6"">
           ");
            WriteLiteral(@"     <input type=""text"" readonly id=""payable"" class=""form-control"" />
            </div>
        </div>



    </div>

</div>


<h2>Item Details</h2>
<div>
    <table class=""table table-light table-hover"">
        <thead>
            <tr>

                <th>Product Name</th>
                <th>Qty</th>
                <th>Discount</th>
                <th>Vat</th>
                <th>Total</th>
                <th>Action</th>

            </tr>
        </thead>
        <tbody id=""partTable"">
        </tbody>
");
            WriteLiteral("\r\n    </table>\r\n</div>\r\n\r\n\r\n");
            WriteLiteral("<div class=\"modal fade\" id=\"suppliercreate\" tabindex=\"-1\" role=\"dialog\" aria-labelledby=\"exampleModalLabel\" aria-hidden=\"true\">\r\n    <div class=\"modal-dialog\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n");
            WriteLiteral(@"                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Create Customer</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">CustomarName</label>
                        <input type=""text"" class=""form-control"" id=""supname"" placeholder=""Name"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Customar Phone Number</label>
                        <input type=""text"" class=""form-control"" id=""supphone"" placeholder=""Number"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Area</la");
            WriteLiteral(@"bel>
                        <input type=""text"" class=""form-control"" id=""suparea"" placeholder=""Area"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Customer Address</label>
                        <input type=""text"" class=""form-control"" id=""subadd"" placeholder=""Address"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputPassword1"">Email</label>
                        <input type=""email"" class=""form-control"" id=""supemail"" placeholder=""Email"">
                    </div>

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"" id=""customermodaloff"">Close</button>
                    <button type=""submit"" class=""btn btn-primary"" id=""customercreate"">Save changes</button>
                </div>
");
            WriteLiteral("        </div>\r\n\r\n\r\n\r\n    </div>\r\n</div>\r\n\r\n\r\n<script src=\"https://cdn.snpsujon.me/snpcookie.js\"></script>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $('#customercreate').click(function () {
            var cusname = $('#supname').val();
            var cusphone = $('#supphone').val();
            var cusarea = $('#suparea').val();
            var cusadd = $('#subadd').val();
            var cusemail = $('#supemail').val();

            var mydata = {};

            mydata.CustomerName = cusname;
            mydata.CustomarPhn = cusphone;
            mydata.CustomerArea = cusarea;
            mydata.CustomarAddress = cusadd;
            mydata.CustomerEmail = cusemail;

            console.log(mydata);
            $.ajax({
                url: ""/Management/Sales/CustomerCreate"",
                type: ""POST"",
                data: { data: mydata },
                success: function (mydata) {
                    if (mydata == 1) {
                        alert(""Data has been saved"");
                    }
                    else {
                        alert(""Data has been  not saved"");
                ");
                WriteLiteral(@"    }
                },
                
            });

        });




        //For Get Product Details
        $(""#inv"").change(function () {
            var prname = $(""#inv"").val();
            /*alert(prname);*/
            if (prname != null && prname != '')
            {
                $.getJSON('");
#nullable restore
#line 301 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
                      Write(Url.Action("GetProductName"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', { proname: prname }, function (mainhead) {
                    console.log(mainhead);
                    $('#product').val(mainhead.productCode);
                    $('#name').val(mainhead.productTittle);
                    $('#sellprice').val(mainhead.salesPrice);
                    $('#rmn').val(mainhead.remainingQty);
                    $('#productname').val(mainhead.productTittle);
                    $(""#qty,#amount,#vap,#vaa,#per,#amnt"").val(""0"");


                });
            }
        });
        //add multi item to table
        $('#additem').click(function () {
            var customer = $('#supplier').val();
            var product = $('#productname').val();
            var quan = $('#qty').val();
            var discount = $('#amnt').val();
            var amount = $('#amount').val();
            var vat = $('#vaa').val();
            var total = $('#totaltt').val();

            var _tr = '<tr><td>' + product + '</td><td>' + quan + '</td><td id=""sum1"">' + discou");
                WriteLiteral(@"nt + '</td> <td>' + vat + '</td><td>' + total + '</td><td><button class=""btn btn-success removeitem"">Remove</button></td></tr>';
            $('#partTable').append(_tr);


            //for final calculation using cookie
            var totalamm = getCookie(""totalamm"");
            var totalvat = getCookie(""totalvat"");
            var totaldis = getCookie(""totaldis"");
            var payable = getCookie(""payable"");
            if (totalamm == null) {
                setCookie(""totalamm"", amount, 365);
                $('#totalall').val(amount);
            }
            else {
                totalamm = parseFloat(totalamm) + parseFloat(amount);
                setCookie(""totalamm"", totalamm, 365);
                $('#totalall').val(totalamm);
            }
            if (totalvat == null) {
                setCookie(""totalvat"", vat, 365);
                $('#totalvat').val(vat);
            }
            else {
                totalvat = parseFloat(totalvat) + parseFloat(vat);
      ");
                WriteLiteral(@"          setCookie(""totalvat"", totalvat, 365);
                $('#totalvat').val(totalvat);
            }
            if (totaldis == null) {
                setCookie(""totaldis"", discount, 365);
                $('#totaldis').val(discount);
            }
            else {
                totaldis = parseFloat(totaldis) + parseFloat(discount);
                setCookie(""totaldis"", totaldis, 365);
                $('#totaldis').val(totaldis);
            }
            if (payable == null) {
                setCookie(""payable"", total, 365);
                $('#payable').val(total);
            }
            else {
                payable = parseFloat(payable) + parseFloat(total);
                setCookie(""payable"", payable, 365);
                $('#payable').val(payable);
            }





        });
        //delete data from multi table
        $(""body"").on(""click"", "".removeitem"", function () {

            var product = $('#productname').val();
            if (confirm(""D");
                WriteLiteral(@"o you want to delete: "" + product)) {
                $(this).closest('tr').remove();

            }



        });


        //delete cookie on load
        function Onload() {
            setCookie(""totalvat"", null, -1);
            setCookie(""payable"", null, -1);
            setCookie(""totalamm"", null, -1);
            setCookie(""totaldis"", null, -1);
        }
        window.onload = Onload();

    </script>

    <script>
        //change quantity to change ammount
        $(""#qty"").change(function () {
            var name = $(""#inv"").val();
            var Quantity = $(""#qty"").val();

        /*    alert(Quantity);*/
            if (Quantity != 0 && name != null && name != '')
            {
                $.getJSON('");
#nullable restore
#line 409 "D:\Project\PurityERP\Areas\Management\Views\Sales\Sales.cshtml"
                      Write(Url.Action("GetAmount"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"', { name: name, Quantity: Quantity}, function (mainhead) {
                    console.log(mainhead);
                    $('#amount').val(mainhead);
                    $('#vap').keyup();
                    $('#per').keyup();

                });

            }

        });


        //for change discount percent
        $('#per').keyup(function () {
            var amount = $('#amount').val();
            var per = $('#per').val();
            var dip = ((amount * per) / 100);
            $('#amnt').val(dip);
            $('#vap').keyup();

        });

        //for change vat 
        $('#vap').keyup(function () {
            var vamount = $('#amount').val();
            var discount = $('#amnt').val();
            var vat = $('#vap').val();

            var vatamnt = (((vamount - discount) * vat) / 100);
            $('#vaa').val(vatamnt);
        });

        //for total after calculation
        $(""#qty,#amount,#vap,#vaa,#per,#amnt"").on('keyup change', function () {");
                WriteLiteral(@"
            var vamount = $('#amount').val();
            var discount = $('#amnt').val();
            var vat = $('#vaa').val();
            var total = (parseFloat(vamount - discount) + parseFloat(vat));
            $('#totaltt').val(total);
        })




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
