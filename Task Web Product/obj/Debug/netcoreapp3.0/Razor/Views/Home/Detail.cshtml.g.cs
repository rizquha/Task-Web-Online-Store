#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "409e572b9146740915f2f1adae91fd82aaccb1e0"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"409e572b9146740915f2f1adae91fd82aaccb1e0", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbd70b73ec07785a6571bf1443c366b5b7d4b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h2>Details Product</h2>\n<p>Check Every Single Your Favorite Product</p>\n<hr class=\"mb-4\">\n\n<div class=\"text-left\">\n");
#nullable restore
#line 7 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
      
        var items = ViewBag.items;
        foreach( var item in items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                <div class=\"column-image\">\n                    <img");
            BeginWriteAttribute("src", " src=", 290, "", 306, 1);
#nullable restore
#line 13 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 295, item.image, 295, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"400px\" height=\"400px\">\n                </div>\n                <div class=\"column\">\n                    <h2><b>");
#nullable restore
#line 16 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                      Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>\n                    <h3><b>Rp. ");
#nullable restore
#line 17 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                          Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h3><br>\n                    <h4>");
#nullable restore
#line 18 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                   Write(item.desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4><br><br><br><br>\n                    <div class=\"text-center\">\n                        <button type=\"button\" style=\"background-color: goldenrod;width:600px;height:40px;border-color:black;\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 749, "\"", 793, 3);
            WriteAttributeValue("", 759, "location.href=\'/Home/Add/", 759, 25, true);
#nullable restore
#line 20 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
WriteAttributeValue("", 784, item.id, 784, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 792, "\'", 792, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\n                    </div>\n                </div>\n                <div class=\"column-rate\"><br>\n                    <h4 style=\"color: goldenrod;\"><b>Rate ");
#nullable restore
#line 24 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
                                                     Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h4>\n                </div>\n                \n            </div>\n");
#nullable restore
#line 28 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Detail.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<br><br><br> \n<br><br><br>");
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