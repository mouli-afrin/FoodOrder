#pragma checksum "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "304426f7389516ef7d976b02473e146aadc1870b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
#line 1 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
using ECommerceProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"304426f7389516ef7d976b02473e146aadc1870b", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b30e352df74995894374d6a4461f3edd7bae51b", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(99, 154, true);
            WriteLiteral("<br /><br />\n<div class=\"row\">\n    <div class=\"col-6\">\n        <h2 class=\"text-info\">Food List</h2>\n    </div>\n    <div class=\"col-6 text-right\">\n        ");
            EndContext();
            BeginContext(253, 94, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "304426f7389516ef7d976b02473e146aadc1870b5645", async() => {
                BeginContext(297, 46, true);
                WriteLiteral("<i class=\"fas fa-plus\"></i>&nbsp; Add New Food");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(347, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
            EndContext();
            BeginContext(366, 449, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "304426f7389516ef7d976b02473e146aadc1870b7160", async() => {
                BeginContext(386, 422, true);
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""lowAmount"" />
        </div>
        <div class=""col-3"">
            <input type=""number"" class=""form-control"" name=""largeAmount"" />
        </div>
        <div class=""col-3"">
            <input type=""submit"" value=""Search"" class=""btn btn-success"" />
        </div>
        <div class=""col-3""></div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(815, 167, true);
            WriteLiteral("\n<br />\n<div>\n    <table class=\"table table-striped border\" id=\"myTable\">\n        <thead>\n            <tr class=\"table-info\">\n                <th>\n                    ");
            EndContext();
            BeginContext(983, 32, false);
#line 35 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1015, 64, true);
            WriteLiteral("\n                </th>\n                <th>\n                    ");
            EndContext();
            BeginContext(1080, 33, false);
#line 38 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 23, true);
            WriteLiteral("\n                </th>\n");
            EndContext();
            BeginContext(1245, 41, true);
            WriteLiteral("                <th>\n                    ");
            EndContext();
            BeginContext(1287, 39, false);
#line 44 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
               Write(Html.DisplayNameFor(c => c.IsAvailable));

#line default
#line hidden
            EndContext();
            BeginContext(1326, 62, true);
            WriteLiteral("\n                </th>\n                <th>\n                  ");
            EndContext();
            BeginContext(1389, 38, false);
#line 47 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
             Write(Html.DisplayNameFor(c => c.FoodTypeId));

#line default
#line hidden
            EndContext();
            BeginContext(1427, 126, true);
            WriteLiteral("\n                </th>\n                <th></th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
            EndContext();
#line 54 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1608, 45, true);
            WriteLiteral("                <tr>\n                    <td>");
            EndContext();
            BeginContext(1654, 9, false);
#line 57 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1694, 10, false);
#line 58 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1704, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
            BeginContext(1762, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(1787, 16, false);
#line 60 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(item.IsAvailable);

#line default
#line hidden
            EndContext();
            BeginContext(1803, 30, true);
            WriteLiteral("</td>\n                    <td>");
            EndContext();
            BeginContext(1834, 26, false);
#line 61 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(item.ProductTypes.FoodType);

#line default
#line hidden
            EndContext();
            BeginContext(1860, 55, true);
            WriteLiteral("</td>\n                    <td>\n                        ");
            EndContext();
            BeginContext(1915, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "304426f7389516ef7d976b02473e146aadc1870b13595", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 63 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = item.Id;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1965, 49, true);
            WriteLiteral("\n                    </td>\n                </tr>\n");
            EndContext();
#line 66 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2028, 37, true);
            WriteLiteral("        </tbody>\n    </table>\n</div>\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2082, 415, true);
                WriteLiteral(@"
    <script src=""//cdn.jsdelivr.net/npm/alertifyjs@1.11.2/build/alertify.min.js""></script>
    <script type=""text/javascript"">
        $(document).ready( function (){
            $('#myTable').DataTable({
                dom: 'Bfrtip',
                buttons: [
                    'copy', 'csv', 'excel', 'pdf', 'print'
                ]
            });
        });
        $(function(){
            var save = '");
                EndContext();
                BeginContext(2498, 16, false);
#line 82 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
                EndContext();
                BeginContext(2514, 107, true);
                WriteLiteral("\'\n            if(save!=\'\') {\n                alertify.success(save);\n            }\n            var edit = \'");
                EndContext();
                BeginContext(2622, 16, false);
#line 86 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                   Write(TempData["edit"]);

#line default
#line hidden
                EndContext();
                BeginContext(2638, 106, true);
                WriteLiteral("\'\n            if(edit!=\'\') {\n                alertify.success(edit);\n            }\n            var del = \'");
                EndContext();
                BeginContext(2745, 18, false);
#line 90 "C:\Users\MOULI\Downloads\Project 3-2(16cse047)\ECommerce MVC\ECommerceProject\ECommerceProject\Views\Product\Index.cshtml"
                  Write(TempData["delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(2763, 105, true);
                WriteLiteral("\'\n            if (del!=\'\') {\n                alertify.error(del);\n            }\n        })\n    </script>\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
