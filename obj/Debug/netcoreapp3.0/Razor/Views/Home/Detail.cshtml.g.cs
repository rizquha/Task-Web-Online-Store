#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b733b566f936cc806ad65b0af23f2d9ba4514337"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b733b566f936cc806ad65b0af23f2d9ba4514337", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
  
    ViewData["Title"]="Our Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 4 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<p>Detail Product</p>\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 7 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
      
        var items = ViewBag.items;
        foreach( var item in items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <h6>");
#nullable restore
#line 12 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
               Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <div>\r\n                    <img");
            BeginWriteAttribute("src", " src=", 320, "", 336, 1);
#nullable restore
#line 14 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 325, item.image, 325, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\">\r\n                </div>\r\n                <h6>Description : ");
#nullable restore
#line 16 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                             Write(item.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h6>Rate : ");
#nullable restore
#line 17 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                      Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h6>Price : ");
#nullable restore
#line 18 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                       Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <button type=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 576, "\"", 620, 3);
            WriteAttributeValue("", 586, "location.href=\'/Home/Add/", 586, 25, true);
#nullable restore
#line 19 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 611, item.id, 611, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 619, "\'", 619, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\r\n            </div>\r\n");
#nullable restore
#line 21 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
