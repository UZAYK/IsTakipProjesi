#pragma checksum "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95aaff89cba25019a421741542626fdd113e8f0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Gorev_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Gorev/Index.cshtml")]
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
using IsTakip.Web.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95aaff89cba25019a421741542626fdd113e8f0a", @"/Areas/Admin/Views/Gorev/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d39be6dd7bcabd4e5eb63ac987c09a35506c573", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Gorev_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GorevListViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EkleGorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-dark my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GuncelleGorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gorev", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-info my-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
 if (Model.Count != 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95aaff89cba25019a421741542626fdd113e8f0a5521", async() => {
                WriteLiteral("\r\n        <i class=\"fas fa-plus-circle mr-2\"></i> Yeni Görev\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"    <table class=""table table-sm table-hover table-bordered mt-2"">
        <thead class=""table table-striped table-active"">

            <tr>
                <th scope=""col"">Ad</th>
                <th scope=""col"">Açıklama</th>
                <th scope=""col"">Aciliyet</th>
                <th scope=""col"">Oluşturulma Tarihi</th>
                <th scope=""col"">İşlemler</th>
            </tr>

        </thead>
");
#nullable restore
#line 26 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\r\n                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                               Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>  ");
#nullable restore
#line 31 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                     Write(item.Aciklama);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>  ");
#nullable restore
#line 32 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                     Write(item.Aciliyet.Tanim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>  ");
#nullable restore
#line 33 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                     Write(item.OlusturulmaTarihi.ToString("D"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95aaff89cba25019a421741542626fdd113e8f0a8824", async() => {
                WriteLiteral("\r\n                             <i class=\"fas fa-pencil-alt mr-2\"></i> Düzenle\r\n                        ");
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
#line 35 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
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
            WriteLiteral("\r\n\r\n                          <a");
            BeginWriteAttribute("href", " href=\"", 1351, "\"", 1358, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\" data-target=\"#silmeEkrani\"\r\n                           data-Id=\"");
#nullable restore
#line 41 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"btn btn-danger btn-sm\">\r\n\r\n                            <i class=\"fas fa-trash-alt mr-2\"></i> Sil\r\n                        </a>\r\n\r\n                    </td>\r\n                </tr>\r\n            </tbody>\r\n");
#nullable restore
#line 49 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 52 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
}

else

{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center mt-3\">\r\n\r\n        <p class=\"lead\"> Sistemde kayıtlı aciliyet durumu bulunamadı.</p>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95aaff89cba25019a421741542626fdd113e8f0a12526", async() => {
                WriteLiteral("\r\n            <i class=\"fas fa-plus-circle mr-2\"></i> Yeni Görev\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\uzayk\source\repos\IsTakipProjesi\IsTakip.Web\Areas\Admin\Views\Gorev\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Modal -->
<div class=""modal fade"" id=""silmeEkrani"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">UYARI</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                Silmek istediğinizden emin misiniz?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Hayır Vazgeç</button>
                <button id=""btnSil"" type=""button"" class=""btn btn-primary"">Evet Sil</button>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("JavaScript", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#silmeEkrani"").on(""show.bs.modal"", function (event) {
                let tetikleyenElement = $(event.relatedTarget);
                let id = tetikleyenElement.data(""id"");

                $(""#btnSil"").click(function () {
                    $.ajax({
                        type: ""Get"",
                        url: ""./Gorev/SilGorev"",
                        data: { id: id },
                        dataType: ""json"",
                        contentType: ""application/json; charset=utf-8;"",
                        success: function () {
                            //alert(""işlem tamam"");
                            window.location.reload();
                        },
                        error: function (error) {
                            alert(error.statusText);
                        }
                    })
                });
            })
        });
    </script>

");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GorevListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
