#pragma checksum "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5961c5b574bb0390ad9f53cab5e8b5617127dd8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Delete), @"mvc.1.0.view", @"/Views/Product/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Delete.cshtml", typeof(AspNetCore.Views_Product_Delete))]
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
#line 1 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC;

#line default
#line hidden
#line 2 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\_ViewImports.cshtml"
using MyNetCoreMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5961c5b574bb0390ad9f53cab5e8b5617127dd8", @"/Views/Product/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e8349a69a9b9dbbc33631bafc0217674c3299b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteProduct"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(1, 5, false);
#line 1 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(6, 10, true);
            WriteLiteral(" Product\r\n");
            EndContext();
#line 2 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(58, 253, true);
            WriteLiteral("\r\n<h2>Delete product</h2>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Product ID</td>\r\n            <td>Product Name</td>\r\n            <td>Product Price</td>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n        <tr>\r\n            <td>");
            EndContext();
            BeginContext(312, 8, false);
#line 17 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
           Write(Model.id);

#line default
#line hidden
            EndContext();
            BeginContext(320, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(344, 10, false);
#line 18 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
           Write(Model.name);

#line default
#line hidden
            EndContext();
            BeginContext(354, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(378, 11, false);
#line 19 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
           Write(Model.price);

#line default
#line hidden
            EndContext();
            BeginContext(389, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(430, 203, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecfff3de9eb8435a92112931db76d70a", async() => {
                BeginContext(459, 45, true);
                WriteLiteral("\r\n                    <input hidden name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 504, "\"", 521, 1);
#line 22 "C:\Users\LE DANG NHAN\source\repos\WebApp\MyNetCoreMVC\Views\Product\Delete.cshtml"
WriteAttributeValue("", 512, Model.id, 512, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(522, 104, true);
                WriteLiteral(" />\r\n                    <input class=\"btn btn-danger\" type=\"submit\" value=\"Delete\" />\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(633, 127, true);
            WriteLiteral("\r\n            </td>\r\n            <td><a href=\"/\" class=\"btn btn-default\">Cancel</a></td>\r\n        </tr>\r\n    </tbody>\r\n</table>");
            EndContext();
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