#pragma checksum "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43280b8c9d641e00efd2021868a6c638db0e18cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_ListarPlantaMasBajaQueXCentimetros), @"mvc.1.0.view", @"/Views/Planta/ListarPlantaMasBajaQueXCentimetros.cshtml")]
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
#line 1 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\_ViewImports.cshtml"
using ObligatorioP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\_ViewImports.cshtml"
using ObligatorioP3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43280b8c9d641e00efd2021868a6c638db0e18cc", @"/Views/Planta/ListarPlantaMasBajaQueXCentimetros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9490da7bf9b7360ec3d43a6cbad1e23b1f38a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_ListarPlantaMasBajaQueXCentimetros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Planta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
       ViewData["title"] = "ListarPlantaMasBajaQueXCentimetros";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <h1>Listado de Plantas segun altura maxima</h1>\n\n\n    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>Tipo</th>\n                <th>");
#nullable restore
#line 13 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 14 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 15 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 16 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 17 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 18 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 19 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
               Write(Html.DisplayNameFor(model => model.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n");
#nullable restore
#line 24 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>");
#nullable restore
#line 27 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.MiTipo.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 28 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 29 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 30 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 31 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 32 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 33 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <th>");
#nullable restore
#line 34 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
                   Write(Html.DisplayFor(modelitem => item.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43280b8c9d641e00efd2021868a6c638db0e18cc11238", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 35 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
AddHtmlAttributeValue("", 1607, item.NombreCientifico, 1607, 22, false);

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
            WriteLiteral("</td>\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43280b8c9d641e00efd2021868a6c638db0e18cc12994", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 36 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
AddHtmlAttributeValue("", 1704, item.NombreCientifico, 1704, 22, false);

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
            WriteLiteral("</td>\n                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43280b8c9d641e00efd2021868a6c638db0e18cc14753", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
AddHtmlAttributeValue("", 1803, item.NombreCientifico, 1803, 22, false);

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
            WriteLiteral("</td>\n                </tr>\n");
#nullable restore
#line 39 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlantaMasBajaQueXCentimetros.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Dominio.Planta>> Html { get; private set; }
    }
}
#pragma warning restore 1591
