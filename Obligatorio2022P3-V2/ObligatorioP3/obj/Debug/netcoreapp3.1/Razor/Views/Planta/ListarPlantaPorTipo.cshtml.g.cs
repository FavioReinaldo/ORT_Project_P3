#pragma checksum "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c85825fc031371acb934487edcbe8f41daefe3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_ListarPlantaPorTipo), @"mvc.1.0.view", @"/Views/Planta/ListarPlantaPorTipo.cshtml")]
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
#line 1 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\_ViewImports.cshtml"
using ObligatorioP3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\_ViewImports.cshtml"
using ObligatorioP3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c85825fc031371acb934487edcbe8f41daefe3f", @"/Views/Planta/ListarPlantaPorTipo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5472c275319adcc3bbf76be9d1a4801509e30f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_ListarPlantaPorTipo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Planta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VisualisarImagen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FichaCuidados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
   ViewData["title"] = "ListarPlantaPorTipo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Filtrar Lista de Plantas por Tipo</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 11 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 12 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 13 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 14 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 15 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 16 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.FotoPlanta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 18 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
           Write(Html.DisplayNameFor(model => model.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 23 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 26 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombreTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 27 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 28 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 29 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 30 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 31 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
               Write(Html.DisplayFor(modelitem => item.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c85825fc031371acb934487edcbe8f41daefe3f9386", async() => {
                WriteLiteral("Ver Imagen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
AddHtmlAttributeValue("", 1408, item.NombreCientifico, 1408, 22, false);

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
            WriteLiteral("</th>\r\n                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c85825fc031371acb934487edcbe8f41daefe3f11094", async() => {
                WriteLiteral("Ver Ficha de Cuidados");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 33 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
AddHtmlAttributeValue("", 1514, item.NombreCientifico, 1514, 22, false);

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
            WriteLiteral("</th>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 36 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlantaPorTipo.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
