#pragma checksum "D:\RMD\Softwares\Solutions\KS IT - by me\PurityERP\PurityERP\Areas\Management\Views\Sales\SalesIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c76d532e022d264fef272bf66c40913f0c6ea9fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Management_Views_Sales_SalesIndex), @"mvc.1.0.view", @"/Areas/Management/Views/Sales/SalesIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c76d532e022d264fef272bf66c40913f0c6ea9fd", @"/Areas/Management/Views/Sales/SalesIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0dfdd7237deb7a0c28bef2cc1edd5df251c7422", @"/Areas/Management/Views/_ViewImports.cshtml")]
    public class Areas_Management_Views_Sales_SalesIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c76d532e022d264fef272bf66c40913f0c6ea9fd3443", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>1page_design</title>
    <!-- <link rel=""stylesheet"" href=""style.css""> -->
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c76d532e022d264fef272bf66c40913f0c6ea9fd4790", async() => {
                WriteLiteral(@"
    <style>
        .right {
            color: blue;
            font-family: verdana;
            font-size: 300%;
        }
    </style>





    <div class=""mt-3"">
        <div class=""row ml-2"">
            <div class=""col-md-8"">
                <div class=""row mb-3"">
                    <div class=""col-md-6"">
                        <div class=""form-outline"">
                            <input type=""search"" id=""form1"" class=""form-control"" placeholder=""Search Items"" />
                        </div>
                    </div>
                    <div class=""col-md-3"">
                        <button class=""btn btn-warning"" type=""button"">Manual Sale</button>
                    </div>
                    <div class=""col-md-3"">
                        <button class=""btn btn-warning"" type=""button"">Return Item</button>
                    </div>
                </div>
                <div class=""mb-5"">
                    <table class=""table"">
                        <thead cla");
                WriteLiteral(@"ss=""thead-dark"">
                            <tr>
                                <th scope=""col"">Item Name</th>
                                <th scope=""col"">Qty</th>
                                <th scope=""col"">Price</th>
                                <th scope=""col"">Discount</th>
                                <th scope=""col"">Tax</th>
                                <th scope=""col"">Total</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    Womens Alpaca Sweater Cray <br /> Discount 5.00% <button class=""btn btn-warning"">
                                        Store
                                        Sale
                                    </button>
                                </td>
                                <td>- <button class=""mr-2 ml-2"">1</button>+</td>
                                <td> 14</td>
         ");
                WriteLiteral(@"                       <td> 77</td>
                                <td>
                                    <div class=""form-check"">
                                        <input class=""form-check-input"" type=""checkbox"">
                                    </div>
                                </td>
                                <td>250</td>

                            </tr>
                            <tr>
                                <td>
                                    Womens Alpaca Sweater Cray <br /> Discount 5.00% <button class=""btn btn-warning"">
                                        Store
                                        Sale
                                    </button>
                                </td>
                                <td>- <button class=""mr-2 ml-2"">1</button>+</td>
                                <td> 14</td>
                                <td> 77</td>
                                <td>
                                    <div class=""f");
                WriteLiteral(@"orm-check"">
                                        <input class=""form-check-input"" type=""checkbox"">
                                    </div>
                                </td>
                                <td>250</td>

                            </tr>
                            <tr>
                                <td>
                                    Womens Alpaca Sweater Cray <br /> Discount 5.00% <button class=""btn btn-warning"">
                                        Store
                                        Sale
                                    </button>
                                </td>
                                <td>- <button class=""mr-2 ml-2"">1</button>+</td>
                                <td> 14</td>
                                <td> 77</td>
                                <td>
                                    <div class=""form-check"">
                                        <input class=""form-check-input"" type=""checkbox"">
                     ");
                WriteLiteral(@"               </div>
                                </td>
                                <td>250</td>

                            </tr>
                        </tbody>
                    </table>
                </div>



                <div style=""height: 200px;"" class=""bg-secondary d-flex flex-column"">
                    <div class=""ml-2"">
                        <p class=""pt-2"">Transction History + </p>
                        <p class=""p-2"">Subtotal</p>
                        <p class=""p-2"">Tax</p>
                        <p class=""font-weight-bold "">Total</p>

                    </div>
                </div>
                <div>
                    <div class=""row mt-3"">
                        <div class=""col-md-3"">
                            <p>Retrive</p>
                        </div>
                        <div class=""col-md-3"">
                            <p>Sales Note</p>
                        </div>
                        <div class=""col-md-6""></div>
 ");
                WriteLiteral(@"                   </div>
                    <div class=""row mt-3"">
                        <div class=""col-md-3"">
                            <button class=""btn btn-dark pl-4 pr-4 btn-lg"">Hold</button>
                        </div>

                    </div>
                    <div class=""row mt-3"">
                        <div class=""col-md-4"">
                            <button class=""btn btn-dark pl-4 pr-4 btn-lg"">Layway</button>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""row bg-info border rounded"">
                    <div class=""col-md-12"">
                        <div style=""height: 130px;"" class="" d-flex justify-content-md-center align-items-center"">
                            <div class=""ml-2 p-4"">
                                <h1");
                BeginWriteAttribute("class", " class=\"", 6444, "\"", 6452, 0);
                EndWriteAttribute();
                WriteLiteral(@">$ 386</h1>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""row mt-2"">
                    <div class=""col-md-4 "">
                        <p class=""font-weight-bold"">Payment Amount</p>
                    </div>
                    <div class=""col-md-6""></div>
                    <div class=""col-md-2"">
                        <p>500</p>
                    </div>

                </div>
                <hr class=""hr"">
                <div class=""row"">
                    <div class=""col-md-4 "">
                        <p>Customer</p>
                    </div>
                    <div class=""col-md-6""></div>
                    <div class=""col-md-2"">
                        <button class=""btn btn-warning"">+</button>
                    </div>
                </div>
                <div style=""margin-top: 100px;""></div>

                <div style=""height: 10%;"" class=""row my-3 d-flex jus");
                WriteLiteral(@"tify-content-between"">
                    <div style=""padding: 0;"" class=""col-md-3 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-info"">Cash</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-3 col-sm-6 d-flex justify-content-center "">
                        <button class=""w-100 border rounded btn btn-info"">Check</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-3 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-info"">Credit Card</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-3 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-info"">Gift Card</button>
                    </div>
                </div>
                <div style=""height: 10%;"" class=""row my-3"">

                   ");
                WriteLiteral(@" <div style=""padding: 0;"" class=""col-md-4 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-secondary"">Consigner Credit</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-4 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-secondary"">Reward Credit</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-4 col-sm-12 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-secondary"">Store Credit</button>
                    </div>
                </div>
                <hr>
                <div style=""height: 10%;"" class=""row"">

                    <div style=""padding: 0;"" class=""col-md-4 col-sm-6 d-flex justify-content-center "">
                        <button class=""w-100 border rounded btn btn-dark"">Clear</button>
                    </div>
            ");
                WriteLiteral(@"        <div style=""padding: 0;"" class=""col-md-4 col-sm-6 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-dark"">Suspend</button>
                    </div>
                    <div style=""padding: 0;"" class=""col-md-4 col-sm-12 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-dark"">Layaway</button>
                    </div>




                </div>
                <div style=""height: 10%;"" class=""row mt-5"">
                    <div style=""padding:0;"" class=""col-md-12 d-flex justify-content-center"">
                        <button class=""w-100 border rounded btn btn-success"">Finish</button>
                    </div>
                </div>
            </div>

        </div>


    </div>







    <script src=""script.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n\r\n");
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
