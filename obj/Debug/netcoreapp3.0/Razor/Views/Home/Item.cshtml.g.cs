#pragma checksum "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "774ce09b413171d10dba1c88e521fd0286a75ae4"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"774ce09b413171d10dba1c88e521fd0286a75ae4", @"/Views/Home/Item.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"286fb3deb620531a59a3c8375094491d6c3d03c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Item : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task_Web_Product.Models.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pilihan1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "pilihan2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Home/Item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
  
    ViewData["Title"]="Our Product";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Our List Outfits</h1>\r\n    <p>Start Your Day With Best Outfit And Make Your Day Wonderful</p><br>\r\n    <ul>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae45113", async() => {
                WriteLiteral(@"
        <input id=""searchInput"" name=""str"" placeholder=""  Searching""style=""width: 200px;height:40px"" class=""input-sorting-searching"">
        <select name = ""Sort1"" id=""Sorting1"" style=""width: 150px; height:40px;"" class=""input-sorting-searching"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae45649", async() => {
                    WriteLiteral("Ascending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae47210", async() => {
                    WriteLiteral("Descending");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n        <select name = \"Sort2\" id=\"Sorting2\" style=\"width: 100px;height:40px\" class=\"input-sorting-searching\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae48592", async() => {
                    WriteLiteral("Name");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae410148", async() => {
                    WriteLiteral("Price");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select><br><br>\r\n        <input type=\"submit\" class=\"btn btn-lg btn-primary\" id=\"submit\" onclick=\"javascript:SearchSortButton(this)\">\r\n    ");
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
            WriteLiteral("<br>\r\n    \r\n    <hr class=\"mb-4\">\r\n");
#nullable restore
#line 24 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
          
            var items = Model.Item;
            foreach(var item in items)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <br>\r\n                    <div class=\"image\">\r\n                        <img");
            BeginWriteAttribute("src", " src=", 1333, "", 1349, 1);
#nullable restore
#line 31 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 1338, item.image, 1338, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200px\">\r\n                    </div><br>\r\n                    <strong class=\"d-inline-block mb-2 text-primary\">Rate : ");
#nullable restore
#line 33 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                                                                       Write(item.rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br>\r\n\r\n                    <b class=\"card-text mb-auto\">");
#nullable restore
#line 35 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                                            Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </b>\r\n                    <p>Rp. ");
#nullable restore
#line 37 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                      Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1655, "\"", 1683, 2);
            WriteAttributeValue("", 1662, "/Home/Detail/", 1662, 13, true);
#nullable restore
#line 38 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 1675, item.id, 1675, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><u>Details</u></a><br><br>\r\n                    <button type=\"button\" class=\"btn btn-info\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1775, "\"", 1819, 3);
            WriteAttributeValue("", 1785, "location.href=\'/Home/Add/", 1785, 25, true);
#nullable restore
#line 39 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 1810, item.id, 1810, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1818, "\'", 1818, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add to Cart</button>\r\n                    <br>\r\n                    <br>\r\n                </div>\r\n");
#nullable restore
#line 43 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul> \r\n");
#nullable restore
#line 46 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
      
    var pages = ViewBag.PerPage;
    var search = ViewBag.Search;
    var sorting1 =ViewBag.Sort1;
    var sorting2 = ViewBag.Sort2;

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
     if (Model.Pager.EndPage > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <ul class=\"pagination\">\r\n                <input name=\"Search\" id=\"PerPage\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2236, "\"", 2250, 0);
            EndWriteAttribute();
            WriteLiteral("style=\"position: relative;left:30px;width:50px;\">\r\n                <input type=\"submit\" class=\"btn btn-primary\" style=\"position: relative;left:35px;\" onclick=\"javascript: page_btn(this)\">\r\n");
#nullable restore
#line 57 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                 if (Model.Pager.CurrentPage > 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae417159", async() => {
                WriteLiteral("First");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae418327", async() => {
                WriteLiteral("Previous");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2695, "~/Home/Item?page=", 2695, 17, true);
#nullable restore
#line 63 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 2712, Model.Pager.CurrentPage - 1, 2712, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2742, "&PerPage=", 2742, 9, true);
#nullable restore
#line 63 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 2751, pages, 2751, 6, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2757, "&str=", 2757, 5, true);
#nullable restore
#line 63 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 2762, search, 2762, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2769, "&sort1=", 2769, 7, true);
#nullable restore
#line 63 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 2776, sorting1, 2776, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 2785, "&sort2=", 2785, 7, true);
#nullable restore
#line 63 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 2792, sorting2, 2792, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 65 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                 for (var halaman = Model.Pager.StartPage; halaman <= Model.Pager.EndPage; halaman++)
                {
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3038, "\"", 3099, 1);
#nullable restore
#line 69 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
WriteAttributeValue("", 3046, halaman == Model.Pager.CurrentPage ? "active" : "", 3046, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae421946", async() => {
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                                                                                                                  Write(halaman);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3136, "~/Home/Item?page=", 3136, 17, true);
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3153, halaman, 3153, 8, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3161, "&PerPage=", 3161, 9, true);
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3170, pages, 3170, 6, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3176, "&str=", 3176, 5, true);
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3181, search, 3181, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3188, "&sort1=", 3188, 7, true);
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3195, sorting1, 3195, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3204, "&sort2=", 3204, 7, true);
#nullable restore
#line 70 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3211, sorting2, 3211, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 72 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 74 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                 if (Model.Pager.CurrentPage < Model.Pager.TotalPages)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae425371", async() => {
                WriteLiteral("Next");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3442, "~/Home/Item?page=", 3442, 17, true);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3459, Model.Pager.CurrentPage + 1, 3459, 30, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3489, "&PerPage=", 3489, 9, true);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3498, pages, 3498, 6, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3504, "&str=", 3504, 5, true);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3509, search, 3509, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3516, "&sort1=", 3516, 7, true);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3523, sorting1, 3523, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3532, "&sort2=", 3532, 7, true);
#nullable restore
#line 77 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3539, sorting2, 3539, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "774ce09b413171d10dba1c88e521fd0286a75ae428112", async() => {
                WriteLiteral("Last");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3658, "~/Home/Item?page=", 3658, 17, true);
#nullable restore
#line 80 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3675, Model.Pager.TotalPages, 3675, 25, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3700, "&PerPage=", 3700, 9, true);
#nullable restore
#line 80 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3709, pages, 3709, 6, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3715, "&str=", 3715, 5, true);
#nullable restore
#line 80 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3720, search, 3720, 7, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3727, "&sort1=", 3727, 7, true);
#nullable restore
#line 80 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3734, sorting1, 3734, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 3743, "&sort2=", 3743, 7, true);
#nullable restore
#line 80 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
AddHtmlAttributeValue("", 3750, sorting2, 3750, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n");
#nullable restore
#line 82 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n");
#nullable restore
#line 84 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br><br><br>\r\n</div>\r\n<script type=\"text/javascript\">\r\nfunction SearchSortButton(btn)\r\n{\r\n    var pages = \'");
#nullable restore
#line 90 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
            Write(ViewBag.PerPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

    var search = document.getElementById(""searchInput"").value;
    var sorting1= document.getElementById(""Sort1"").value;
    var sorting2=document.getElementById(""Sort2"").value;
    location.href='/Home/Item?str='+search+'&sort1='+sorting1+'&sort2='+sorting2+'&PerPage='+pages;
}
function page_btn()
{
    var search = '");
#nullable restore
#line 99 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
             Write(ViewBag.Search);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var sorting1 =\'");
#nullable restore
#line 100 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
              Write(ViewBag.Sort1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    var sorting2 = \'");
#nullable restore
#line 101 "D:\Users\bsi50129\.vscode\Task Web Product\Views\Home\Item.cshtml"
               Write(ViewBag.Sort2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n\r\n    var page = document.getElementById(\'PerPage\').value;\r\n    var path=\'/Home/Item?str=\'+search+\'&sort1=\'+sorting1+\'&sort2=\'+sorting2+\'&PerPage=\'+page;\r\n    window.location.href = path;\r\n}\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task_Web_Product.Models.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
