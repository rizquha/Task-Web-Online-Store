#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\AddItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cfeb7b4a45620d435e50d3bbec75e93ca8c4ec38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddItems), @"mvc.1.0.view", @"/Views/Home/AddItems.cshtml")]
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
#line 1 "D:\Users\bsi50129\.vscode\Task Web Product\Views\_ViewImports.cshtml"
using Task_Web_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\bsi50129\.vscode\Task Web Product\Views\_ViewImports.cshtml"
using Task_Web_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfeb7b4a45620d435e50d3bbec75e93ca8c4ec38", @"/Views/Home/AddItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbd70b73ec07785a6571bf1443c366b5b7d4b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_AddItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\AddItems.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\n    <br><br>\n    <h1 class=\"display-4\">Add Item To Your Store</h1>\n    <p>Always Update Your Outfit</p>\n    <ul>\n");
            WriteLiteral("        <div class=\"kotak_login\">\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfeb7b4a45620d435e50d3bbec75e93ca8c4ec383603", async() => {
                WriteLiteral("\n\t\t\t<label>Title</label>\n\t\t\t<input type=\"text\" name=\"title\"");
                BeginWriteAttribute("value", " value=\"", 285, "\"", 293, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Title\" id=\"title1\">\n \n\t\t\t<label>Rate</label>\n\t\t\t<input type=\"text\" name=\"rate\"");
                BeginWriteAttribute("value", " value=\"", 405, "\"", 413, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Rate\" id=\"rate1\">\n\n\t\t\t<label>Price</label>\n\t\t\t<input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 524, "\"", 532, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Price\" id=\"price1\">\n\n\t\t\t<label>Description</label>\n\t\t\t<input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 657, "\"", 665, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Description\" id=\"description1\">\n\n\t\t\t<label>Image</label>\n\t\t\t<input type=\"text\" name=\"image\"");
                BeginWriteAttribute("value", " value=\"", 790, "\"", 798, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Image\" id=\"image1\">\n \n\t\t\t<button type=\"submit\" class=\"tombol_login\" value=\"add\" onclick=\"javascript:AddButtonItem(this)\">Add</button><br><br>\n\t\t\t\n\t\t");
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
            WriteLiteral("\n        <button class=\"tombol_login\" value=\"cancel\" onclick=\"location.href=\'/Home/IndexAdmin\'\">Cancel</button>\n\t    </div>\n");
            WriteLiteral(@"    </ul>
</div>
<script type=""text/javascript"">
function AddButtonItem(btn)
{
    var title = document.getElementById(""title1"").value;
    var rate = document.getElementById(""rate1"").value;
    var price = document.getElementById(""price1"").value;
    var description = document.getElementById(""description1"").value;
    var image = document.getElementById(""image1"").value;

    location.href='/Home/AddStore?title='+title+'&rate='+rate+'&price='+price+'&description='+description+'&image='+image;
}
</script>");
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
