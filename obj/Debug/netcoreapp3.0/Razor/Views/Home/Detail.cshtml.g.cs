#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5218f30d0405677d71a67579c42feac1c8a5467e"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5218f30d0405677d71a67579c42feac1c8a5467e", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>Details Product</h2>\r\n<p>Check Every Single Your Favorite Product</p>\r\n<hr class=\"mb-4\">\r\n\r\n<div class=\"text-left\">\r\n");
#nullable restore
#line 7 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
      
        var items = ViewBag.items;
        foreach( var item in items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <div class=\"column-image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 302, "", 318, 1);
#nullable restore
#line 13 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 307, item.image, 307, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400px\" height=\"400px\">\r\n                </div>\r\n                <div class=\"column\">\r\n                    <h2><b>");
#nullable restore
#line 16 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                      Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\r\n                    <h3><b>Rp. ");
#nullable restore
#line 17 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                          Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3><br>\r\n                    <h4>");
#nullable restore
#line 18 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                   Write(item.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><br><br><br><br>\r\n                    <div class=\"text-center\">\r\n                        <button type=\"button\" style=\"background-color: goldenrod;width:600px;height:40px;border-color:black;\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 768, "\"", 812, 3);
            WriteAttributeValue("", 778, "location.href=\'/Home/Add/", 778, 25, true);
#nullable restore
#line 20 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 803, item.id, 803, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 811, "\'", 811, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\r\n                    </div>\r\n                </div>\r\n                <div class=\"column-rate\"><br>\r\n                    <h4 style=\"color: goldenrod;\"><b>Rate ");
#nullable restore
#line 24 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                                                     Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\r\n                </div>\r\n                \r\n            </div>\r\n");
#nullable restore
#line 28 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<br><br><br> \r\n<br><br><br>");
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
