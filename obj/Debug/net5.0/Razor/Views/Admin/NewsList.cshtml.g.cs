#pragma checksum "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06c38b00764a041c53c3c1772058b194bd08a36f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_NewsList), @"mvc.1.0.view", @"/Views/Admin/NewsList.cshtml")]
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
#line 1 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\_ViewImports.cshtml"
using iwp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06c38b00764a041c53c3c1772058b194bd08a36f", @"/Views/Admin/NewsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff93514d4e8710706163cd5446c329399575f4a", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_NewsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/admin/deletenews"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c38b00764a041c53c3c1772058b194bd08a36f4699", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css""
        integrity=""sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z"" crossorigin=""anonymous"">
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js""
        integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj""
        crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js""
        integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN""
        crossorigin=""anonymous""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js""
        integrity=""sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV""
        crossorigin=""anonymous""></script>
    <link rel=""stylesheet"" href=""https");
                WriteLiteral("://use.fontawesome.com/releases/v5.15.1/css/all.css\"\r\n        integrity=\"sha384-vp86vTRFVJgpjF9jiIGPEEqYqlDwgyBgEF109VFjmqGmIY/Y4HV4d3Gp2irVfcrp\" crossorigin=\"anonymous\">\r\n\r\n\r\n    <title>Haber Sitesi</title>\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    body {
        padding-top: 70px;
    }

    .Id {
        width: 10px;
    }

    .td-img {
        width: 200px;
        height: 150px;
    }

    div.row {
        padding-right: 25px;
        padding-left: 25px;
    }

    table.table-bordered {
        border: 2px solid black;
        margin-top: 20px;
    }

    table.table-bordered>thead>tr>th {
        border: 2px solid black;
    }

    table.table-bordered>tbody>tr>td {
        border: 2px solid black;
    }

    table.table-bordered>tbody>tr>th {
        border: 2px solid black;
    }

    i {
        font-size: 30px;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c38b00764a041c53c3c1772058b194bd08a36f7644", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 72 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
Write(await Html.PartialAsync("_navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <div class=""row"">
        <div class=""col-md-12"">
            <h1 style=""display: inline;"" class=""text-white"">Tüm Haberler:</h1>
            <a style=""float: right; margin-right: 10px;"" href=""/admin/createnews"" class=""btn btn-lg btn-success"">HABER
                EKLE</a>
            <table class=""table table-bordered table-striped table-dark"">
                <thead>
                    <tr>
                        <th style=""width: 30px;"" scope=""col"">ID</th>
                        <th style=""width: 210px;"" scope=""col"">RESİM</th>
                        <th style=""width: 600px;"" scope=""col"">BAŞLIK</th>
                        <th style=""width: 40px;"" scope=""col"">SEÇİLMİŞ HABER</th>
                        <th style=""width: 70px;"" scope=""col"">TARİH</th>
                        <th style=""width: 100px;"" scope=""col"">EDİTÖR</th>
                        <th style=""width: 200px;"" scope=""col"">KONTROL</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 92 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                     foreach (var h in Model)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 95 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                                       Write(h.haberId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                            <td><a");
                BeginWriteAttribute("href", " href=\"", 3330, "\"", 3350, 1);
#nullable restore
#line 96 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
WriteAttributeValue("", 3337, h.haberResmi, 3337, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Resmi görüntüle..</a></td>\r\n                            <td>");
#nullable restore
#line 97 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                           Write(h.haberBasligi);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 99 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                                 if (h.isHome)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-check-square\" style=\"color: green;\"></i>\r\n");
#nullable restore
#line 102 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <i class=\"fas fa-times-circle\" style=\"color: red;\"></i>\r\n");
#nullable restore
#line 106 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </td>\r\n                            <td>");
#nullable restore
#line 108 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                           Write(h.haberTarihi.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 109 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                           Write(h.haberYazari);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06c38b00764a041c53c3c1772058b194bd08a36f12188", async() => {
                    WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"Id\"");
                    BeginWriteAttribute("value", " value=\"", 4252, "\"", 4270, 1);
#nullable restore
#line 112 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
WriteAttributeValue("", 4260, h.haberId, 4260, 10, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                                    <button type=\"submit\" class=\"btn btn-sm btn-danger mr-1\">SİL</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 4458, "\"", 4491, 2);
                WriteAttributeValue("", 4465, "/admin/editnews/", 4465, 16, true);
#nullable restore
#line 116 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
WriteAttributeValue("", 4481, h.haberId, 4481, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-primary mr-1\">DÜZENLE</a>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 4576, "\"", 4604, 2);
                WriteAttributeValue("", 4583, "/news/read/", 4583, 11, true);
#nullable restore
#line 117 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
WriteAttributeValue("", 4594, h.haberId, 4594, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-warning\">HABERE GİT</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 120 "C:\Users\kemal\Documents\VS_Projects\iwp\Views\Admin\NewsList.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591