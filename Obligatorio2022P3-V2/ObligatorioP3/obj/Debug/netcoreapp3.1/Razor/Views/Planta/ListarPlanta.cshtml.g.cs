#pragma checksum "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddb7f76a7586f80baa7d8f93c03788dc4289fccf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planta_ListarPlanta), @"mvc.1.0.view", @"/Views/Planta/ListarPlanta.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddb7f76a7586f80baa7d8f93c03788dc4289fccf", @"/Views/Planta/ListarPlanta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5472c275319adcc3bbf76be9d1a4801509e30f6", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_ListarPlanta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Planta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Alta", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VisualisarImagen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FichaCuidados", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
   ViewData["title"] = "ListarPlanta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Lista de Plantas</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddb7f76a7586f80baa7d8f93c03788dc4289fccf4468", async() => {
                WriteLiteral("Crear nueva planta");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<!---->\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 16 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 17 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 18 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 19 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 20 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 21 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 22 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.FotoPlanta));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th>");
#nullable restore
#line 31 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombreTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 32 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 33 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 34 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 35 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
#nullable restore
#line 36 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddb7f76a7586f80baa7d8f93c03788dc4289fccf10715", async() => {
                WriteLiteral("Ver Imagen");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 37 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
AddHtmlAttributeValue("", 1455, item.NombreCientifico, 1455, 22, false);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddb7f76a7586f80baa7d8f93c03788dc4289fccf12417", async() => {
                WriteLiteral("Ver Ficha de Cuidados");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 38 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
AddHtmlAttributeValue("", 1561, item.NombreCientifico, 1561, 22, false);

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
            WriteLiteral("</th>\r\n                \r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\10 Programacion\GitHub\Obligatorio1Programacion3\Obligatorio2022P3-V2\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
