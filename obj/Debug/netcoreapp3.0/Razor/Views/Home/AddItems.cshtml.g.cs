#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\AddItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd1ac28cad0bea2f6bb5ea362a218f504006f92a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd1ac28cad0bea2f6bb5ea362a218f504006f92a", @"/Views/Home/AddItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
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
  
    ViewData["Title"]="Add Item To Your Store";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <br><br>\r\n    <h1 class=\"display-4\">Add Item To Your Store</h1>\r\n    <p>Always Update Your Outfit</p>\r\n    <ul>\r\n");
            WriteLiteral("        <div class=\"kotak_login\">\r\n\t\t<h3>Add Item</h3> \r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd1ac28cad0bea2f6bb5ea362a218f504006f92a3662", async() => {
                WriteLiteral("\r\n\t\t\t<label>Title</label>\r\n\t\t\t<input type=\"text\" name=\"title\"");
                BeginWriteAttribute("value", " value=\"", 338, "\"", 346, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Title ..\" id=\"title1\">\r\n \r\n\t\t\t<label>Rate</label>\r\n\t\t\t<input type=\"text\" name=\"rate\"");
                BeginWriteAttribute("value", " value=\"", 464, "\"", 472, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Rate ..\" id=\"rate1\">\r\n\r\n\t\t\t<label>Price</label>\r\n\t\t\t<input type=\"text\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 589, "\"", 597, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Price ..\" id=\"price1\">\r\n\r\n\t\t\t<label>Description</label>\r\n\t\t\t<input type=\"text\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 728, "\"", 736, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Description ..\" id=\"description1\">\r\n\r\n\t\t\t<label>Image</label>\r\n\t\t\t<input type=\"text\" name=\"image\"");
                BeginWriteAttribute("value", " value=\"", 867, "\"", 875, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form_login"" placeholder=""Image .."" id=""image1"">
 
			<button type=""submit"" class=""tombol_login"" value=""add"" onclick=""javascript:AddButtonItem(this)"">Add</button>
            <button type=""submit"" class=""tombol_login"" value=""cancel"" onclick=""javascript:CancelButtonItem(this)"">Cancel</button>
			<br>
		");
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
            WriteLiteral("\r\n\t    </div>\r\n");
            WriteLiteral(@"    </ul>
</div>
<script type=""text/javascript"">
function AddButtonItem(btn)
{
    var title = document.getElementById(""title"").value;
    var rate = document.getElementById(""rate"").value;
    var price = document.getElementById(""price"").value;
    var description = document.getElementById(""description"").value;
    var image = document.getElementById(""image"").value;
    location.href='/Home/AddItem?title='+title+'&rate='+rate+'&price='+price+'&description='+description+'&image='+image;
}
function CancelButtonItem(button)
{
    location.href='/Home/IndexAdmin';

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
