#pragma checksum "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7d3d315d301d74cb1a54da0d55cd579a527bcbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Transactions), @"mvc.1.0.view", @"/Views/Home/Transactions.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7d3d315d301d74cb1a54da0d55cd579a527bcbb", @"/Views/Home/Transactions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dbd70b73ec07785a6571bf1443c366b5b7d4b50", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Transactions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
  
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-center"">
    <h1 class=""display-4"">Transactions Page</h1>
    <p>Always Monitoring Transactions In Your Store</p>
</div><br>
<div class=""text-right"">
    <button type=""button"" class=""btn btn-info"" id=""export"" onclick=""location.href='/Home/ExportTransactions'"">Export</button>
</div>
<hr class=""mb-4"">
<div class=""container"">
    <div class=""row"">
        <div class=""col-2"">
            <h5 class=""text-center""><b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbspNo</b></h5>
        </div>
        <div class=""col-2"">
            <h5 class=""text-center""><b>Order Date</b></h5>
        </div>
        <div class=""col-2"">
            <h5 class=""text-center""><b>Name</b></h5>
        </div>
        <div class=""col-2"">
            <h5 class=""text-center""><b>Phone Number</b></h5>
        </div>
        <div class=""col-2"">
            <h5><b>&nbsp&nbsp&nbspItems <Address></Address></b></h5>
        </div>
        <div class=""col-2"">
            <h5><b>&nbsp&nbsp&nbsp&nbsp&nbsp&nbspTotal Pric");
            WriteLiteral("e</b></h5>\n        </div>\n    </div>\n</div>\n<hr class=\"mb-4\">\n<div class=\"container\">\n");
#nullable restore
#line 36 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
      
        var items = ViewBag.display;
        int counter=0;
        int idPurchase=0;
        foreach( var item in items)
        {
            counter++;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
             if(counter==1)
            {
                idPurchase = @item.idPurchase;
                

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<li class=""list-group-item d-flex justify-content-between lh-condensed"" style=""background-color: lightgray;"">
                <div class=""container"">
                <div class=""row"">
                <div class=""col-2"">
                    <h5 class=""text-center"">");
#nullable restore
#line 50 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                       Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n                <div class=\"col-2\">\n                    <h5 class=\"text-center\">");
#nullable restore
#line 53 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                       Write(item.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n                <div class=\"col-2\">\n                    <h5 class=\"text-center\">");
#nullable restore
#line 56 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                       Write(item.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 56 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                                       Write(item.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                </div>\n                <div class=\"col-2\">\n                    <h5 class=\"text-center\">");
#nullable restore
#line 59 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                       Write(item.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>     \n                </div>\n                <div class=\"col-2\">\n                    <h5>");
#nullable restore
#line 62 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                   Write(item.namaBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 62 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                      Write(item.totalBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>     \n                </div>\n                <div class=\"col-2\">\n                    <h5 class=\"text-center\">");
#nullable restore
#line 65 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                       Write(item.totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp\n                    <button style=\"height: 30px;padding-top:4px;\" class=\"text-right\" onclick=\"javascript:Process(this)\" id=\"process\"");
            BeginWriteAttribute("value", " value=\"", 2525, "\"", 2544, 1);
#nullable restore
#line 66 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
WriteAttributeValue("", 2533, idPurchase, 2533, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Process</button>     \n                </div>\n                </div>\n                </div>\n                </li>\n");
#nullable restore
#line 71 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                 if(@item.idPurchase==idPurchase)
                {
                    counter--;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""list-group-item d-flex justify-content-between lh-condensed"" style=""background-color: lightgray;"">
                    <div class=""container"">
                    <div class=""row"">
                    <div class=""col-2"">
                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-2"">
                    </div>
                    <div class=""col-2"">
                        <h5>");
#nullable restore
#line 89 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                       Write(item.namaBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 89 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                          Write(item.totalBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>     \n                    </div>\n                    <div class=\"col-2\">\n                    </div>\n                    </div>\n                    </div>\n                    </li>\n");
#nullable restore
#line 96 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <hr class=\"mb-4\">\n");
#nullable restore
#line 98 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                    idPurchase = @item.idPurchase;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<li class=""list-group-item d-flex justify-content-between lh-condensed"" style=""background-color: lightgray;"">
                    <div class=""container"">
                    <div class=""row"">
                    <div class=""col-2"">
                        <h5 class=""text-center"">");
#nullable restore
#line 103 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <div class=\"col-2\">\n                        <h5 class=\"text-center\">");
#nullable restore
#line 106 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                           Write(item.orderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <div class=\"col-2\">\n                        <h5 class=\"text-center\">");
#nullable restore
#line 109 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                           Write(item.firstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 109 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                                           Write(item.lastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    </div>\n                    <div class=\"col-2\">\n                        <h5 class=\"text-center\">");
#nullable restore
#line 112 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                           Write(item.phoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>     \n                    </div>\n                    <div class=\"col-2\">\n                        <h5>");
#nullable restore
#line 115 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                       Write(item.namaBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral(" : ");
#nullable restore
#line 115 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                          Write(item.totalBarang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>     \n                    </div>\n                    <div class=\"col-2\">\n                        <h5 class=\"text-center\">");
#nullable restore
#line 118 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                                           Write(item.totalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
                        <button style=""height: 30px;padding-top:4px;"" class=""text-right"">Process</button>     

                    </div>
                    </div>
                    </div>
                    </li>
");
#nullable restore
#line 125 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 125 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Asus A456UQ\Downloads\Task-Web-Online-Store-1.4.6\Task Web Product\Views\Home\Transactions.cshtml"
             
            
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<script type=\"text/javascript\">\nfunction Process(btn)\n{\n    var id = btn.id;\n    idPurchase = document.getElementById(id).value;\n    console.log(\"Masuk\");\n    location.href=\'/Home/Process/\'+idPurchase;\n}\n<script>");
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