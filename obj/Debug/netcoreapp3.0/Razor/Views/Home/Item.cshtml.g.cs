#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6208ea79ba68af6794604eb9d6a537b5a3f063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Item), @"mvc.1.0.view", @"/Views/Home/Item.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6208ea79ba68af6794604eb9d6a537b5a3f063", @"/Views/Home/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
  
    ViewData["Title"]="Our Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome To Our Store</h1>\r\n    <p>Start Your Day With Best Outfit</p>\r\n    <ul>\r\n");
#nullable restore
#line 9 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
          
            var items = ViewBag.items;
            foreach(var item in items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <br>\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 419, "", 435, 1);
#nullable restore
#line 16 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 424, item.image, 424, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\">\r\n                    </div>\r\n                    <br>\r\n                    <div class=\"title\">\r\n                        <h6>");
#nullable restore
#line 20 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                       Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    </div>\r\n                    <h6>Rate : ");
#nullable restore
#line 22 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                          Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <div class=\"des\">\r\n                        <h6>Rp. ");
#nullable restore
#line 24 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                           Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 784, "\"", 812, 2);
            WriteAttributeValue("", 791, "/Home/Detail/", 791, 13, true);
#nullable restore
#line 25 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 804, item.id, 804, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a><br>\r\n                        <button type=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 897, "\"", 941, 3);
            WriteAttributeValue("", 907, "location.href=\'/Home/Add/", 907, 25, true);
#nullable restore
#line 26 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 932, item.id, 932, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 940, "\'", 940, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\r\n                    </div>\r\n                    <br>\r\n                    <br>\r\n                </div>\r\n");
#nullable restore
#line 31 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
