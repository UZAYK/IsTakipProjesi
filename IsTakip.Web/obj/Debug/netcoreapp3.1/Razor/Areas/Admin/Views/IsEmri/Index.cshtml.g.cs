#pragma checksum "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e18a1cd4952ec5eb42c98c038b33c69980d7a7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_IsEmri_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/IsEmri/Index.cshtml")]
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
#line 3 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakip.DTO.DTOs.AciliyetDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakip.DTO.DTOs.BildirimDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakip.DTO.DTOs.GorevDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\_ViewImports.cshtml"
using IsTakip.DTO.DTOs.AppUserDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e18a1cd4952ec5eb42c98c038b33c69980d7a7c", @"/Areas/Admin/Views/IsEmri/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75670ff94bf00d4c81f35f1867cc1965419d9f14", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_IsEmri_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListAllDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AtaPersonel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detaylandir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-hover table-sm mt-2 table-bordered mt-2"">
        <thead class=""table table-striped table-active"">
            <tr>
                <th scope=""col"">Ad</th>
                <th scope=""col"">A????klama</th>
                <th scope=""col"">Olu??turulma Tarihi</th>
                <th scope=""col"">??al????an Personel</th>
                <th scope=""col"">Aciliyet</th>
                <th scope=""col"">Rapor Say??s??</th>
                <th scope=""col"">????lemler</th>
            </tr>
        </thead>

");
#nullable restore
#line 22 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 26 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                               Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                   Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                   Write(item.OlusturulmaTarihi.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>\r\n");
#nullable restore
#line 31 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                          
                            if (item.AppUser == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-danger\">\r\n                                    <i class=\"fas fa-user-slash small\"></i> ??al????an personel yok\r\n                                </span>\r\n");
#nullable restore
#line 37 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"badge badge-success\">\r\n                                    <i class=\"fas fa-user-alt small\"></i> ");
#nullable restore
#line 41 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                                     Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                                                        Write(item.AppUser.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??al??????yor\r\n                                </span>\r\n");
#nullable restore
#line 43 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                   Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                   Write(item.Raporlar.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 51 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                          
                            if (item.AppUser == null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e18a1cd4952ec5eb42c98c038b33c69980d7a7c10154", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-user-plus mr-2\"></i> Personel Ata\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e18a1cd4952ec5eb42c98c038b33c69980d7a7c12878", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-eye mr-2\"></i> Detay G??ster\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"

                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 69 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 71 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\IsEmri\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListAllDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
