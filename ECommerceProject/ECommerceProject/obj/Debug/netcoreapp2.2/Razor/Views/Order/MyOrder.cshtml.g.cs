#pragma checksum "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79ae79dce5d3418e68ec081547058adfcfe23a83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_MyOrder), @"mvc.1.0.view", @"/Views/Order/MyOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/MyOrder.cshtml", typeof(AspNetCore.Views_Order_MyOrder))]
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
#line 1 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\_ViewImports.cshtml"
using ECommerceProject;

#line default
#line hidden
#line 3 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\_ViewImports.cshtml"
using ECommerceProject.ViewModel;

#line default
#line hidden
#line 1 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
using ECommerceProject.Models;

#line default
#line hidden
#line 4 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ae79dce5d3418e68ec081547058adfcfe23a83", @"/Views/Order/MyOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b30e352df74995894374d6a4461f3edd7bae51b", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_MyOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetOrderDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 5 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
  
    ViewData["Title"] = "MyOrder";

#line default
#line hidden
            BeginContext(195, 23, true);
            WriteLiteral("\r\n<h1>My Order</h1>\r\n\r\n");
            EndContext();
            BeginContext(218, 1180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79ae79dce5d3418e68ec081547058adfcfe23a835590", async() => {
                BeginContext(224, 418, true);
                WriteLiteral(@"
    <div class=""col-6"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th>Order No</th>
                    <th>Name</th>
                    <th>Phone No</th>
                    <th>Address</th>
                    <th>Order Date</th>
                    <th>Order Deatils</th>
                </tr>
            </thead>
            <tbody>
");
                EndContext();
#line 25 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
                BeginContext(707, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(780, 12, false);
#line 29 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                   Write(item.OrderNo);

#line default
#line hidden
                EndContext();
                BeginContext(792, 53, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>");
                EndContext();
                BeginContext(846, 9, false);
#line 31 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                   Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(855, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(887, 12, false);
#line 32 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                   Write(item.PhoneNo);

#line default
#line hidden
                EndContext();
                BeginContext(899, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(931, 12, false);
#line 33 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                   Write(item.Address);

#line default
#line hidden
                EndContext();
                BeginContext(943, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(975, 14, false);
#line 34 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                   Write(item.OrderDate);

#line default
#line hidden
                EndContext();
                BeginContext(989, 57, true);
                WriteLiteral("</td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1046, 87, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79ae79dce5d3418e68ec081547058adfcfe23a839006", async() => {
                    BeginContext(1122, 7, true);
                    WriteLiteral("Details");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                                                                              WriteLiteral(item.Id);

#line default
#line hidden
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
                EndContext();
                BeginContext(1133, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 39 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Order\MyOrder.cshtml"
                }

#line default
#line hidden
                BeginContext(1204, 97, true);
                WriteLiteral("            </tbody>\r\n        </table>\r\n        <div class=\"form-group text-right\">\r\n            ");
                EndContext();
                BeginContext(1301, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "79ae79dce5d3418e68ec081547058adfcfe23a8312080", async() => {
                    BeginContext(1345, 12, true);
                    WriteLiteral("Back to Home");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1361, 30, true);
                WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1398, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591