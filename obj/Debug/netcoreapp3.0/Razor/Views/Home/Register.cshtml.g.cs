#pragma checksum "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed7ef7b6a4599a3ece8edb741fead35aaffc02c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Register), @"mvc.1.0.view", @"/Views/Home/Register.cshtml")]
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
#line 1 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\_ViewImports.cshtml"
using Task_Web_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\_ViewImports.cshtml"
using Task_Web_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed7ef7b6a4599a3ece8edb741fead35aaffc02c8", @"/Views/Home/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbd70b73ec07785a6571bf1443c366b5b7d4b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("\n<div class=\"text-center\">\n    <ul>\n");
#nullable restore
#line 4 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Register.cshtml"
          
		var eror="";
		eror=ViewBag.error;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"kotak_login\">\n\t\t<h2>Silahkan login</h2> <br>\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed7ef7b6a4599a3ece8edb741fead35aaffc02c83678", async() => {
                WriteLiteral("\n\t\t\t<label>Username</label>\n\t\t\t<input type=\"text\" name=\"username\"");
                BeginWriteAttribute("value", " value=\"", 222, "\"", 230, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Username atau email\" id=\"username1\">\n \n\t\t\t<label>Password</label>\n\t\t\t<input type=\"password\" name=\"password\"");
                BeginWriteAttribute("value", " value=\"", 371, "\"", 379, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Password\" id=\"password1\">\n            \n            <label>Email</label>\n\t\t\t<input type=\"text\" name=\"email\"");
                BeginWriteAttribute("value", " value=\"", 519, "\"", 527, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form_login\" placeholder=\"Email\" id=\"email1\">\n \n\t\t\t<button type=\"submit\" class=\"tombol_login\" value=\"REGISTER\" onclick=\"javascript:RegisterButton(this)\">Register</button>\n\t\t\t<br>\n\t\t");
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
            WriteLiteral("\n\t\t<h6>");
#nullable restore
#line 22 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Register.cshtml"
       Write(eror);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n\n\t    </div>\n");
            WriteLiteral(@"    </ul>
</div>

<script type=""text/javascript"">
function RegisterButton(btn)
{
    var uname = document.getElementById(""username1"").value;
	var pass = document.getElementById(""password1"").value;
    var email = document.getElementById(""email1"").value;
	location.href='/Home/RegisUser?username='+uname+'&password='+pass+'&email='+email;
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
