#pragma checksum "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0a81234da682dcfd3b1b6de79b3f64d5947cfc3"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0a81234da682dcfd3b1b6de79b3f64d5947cfc3", @"/Views/Planta/ListarPlanta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d9490da7bf9b7360ec3d43a6cbad1e23b1f38a4", @"/Views/_ViewImports.cshtml")]
    public class Views_Planta_ListarPlanta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Dominio.Planta>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Planta/ListarPlantaMasBajaQueXCentimetros"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Planta/BuscarPlantaDeXCentimetrosOMas"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Planta/BuscarPlantaPorAmbiente"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
   ViewData["title"] = "ListarPlanta";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Lista de Plantas</h1>\n\n<p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc36758", async() => {
                WriteLiteral("Nueva Planta");
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
            WriteLiteral("\n</p>\n<!---->\n<h2>Filtrar Lista de Plantas por altura maxima</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc37985", async() => {
                WriteLiteral("\n    <label>Filtrar por altura, mas bajas que:</label><br>\n    <input type=\"number\" name=\"altura\" id=\"miAlturaMaxima\"/>\n    <br /><br>\n    <input type=\"submit\" value=\"Filtrar\" onclick=\"return ValidarDatosAlturaMaxima();\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br>\n<p>");
#nullable restore
#line 20 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<h2>Filtrar Lista de Plantas por altura minima</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc310386", async() => {
                WriteLiteral("\n    <label>Filtrar por altura, mas altas que:</label><br>\n    <input type=\"number\" name=\"altura\" id=\"miAlturaMinima\" />\n    <br /><br>\n    <input type=\"submit\" value=\"Filtrar\" onclick=\"return ValidarDatosAlturaMinima();\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br>\n<p>");
#nullable restore
#line 30 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<h2>Filtrar Lista de Plantas por Ambiente</h2>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc312784", async() => {
                WriteLiteral("\n    <label>Filtrar por ambiente:</label><br>\n    <input type=\"text\" name=\"Ambiente\" id=\"miAmbiente\" />\n    <br /><br>\n    <input type=\"submit\" value=\"Filtrar\" onclick=\"return ValidarDatosAmbiente();\" />\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<br>\n<p>");
#nullable restore
#line 40 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
Write(ViewBag.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>Tipo</th>\n            <th>");
#nullable restore
#line 48 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 49 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 50 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 51 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 52 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 53 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 54 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
           Write(Html.DisplayNameFor(model => model.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 59 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th>");
#nullable restore
#line 62 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.MiTipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 63 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombreCientifico));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 64 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.NombresVulgares));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 65 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 66 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.Ambiente));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 67 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.AlturaMaxima));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 68 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.FotoUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <th>");
#nullable restore
#line 69 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
               Write(Html.DisplayFor(modelitem => item.FichaCuidados));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc321060", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
AddHtmlAttributeValue("", 2620, item.NombreCientifico, 2620, 22, false);

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
            WriteLiteral("</td>\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc322790", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
AddHtmlAttributeValue("", 2713, item.NombreCientifico, 2713, 22, false);

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
            WriteLiteral("</td>\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0a81234da682dcfd3b1b6de79b3f64d5947cfc324523", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "asp-rout-id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 72 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
AddHtmlAttributeValue("", 2808, item.NombreCientifico, 2808, 22, false);

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
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 74 "C:\Users\Nicol\Downloads\Obligatorio1Programacion3-main (1)\Obligatorio1Programacion3-main\Obligatorio2022P3\ObligatorioP3\Views\Planta\ListarPlanta.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<script>
    function ValidarDatosAlturaMaxima() {
        let altura = parseFloat(document.getElementById(""miAlturaMaxima"").value);
        let validacion = true;

        if (isNaN(altura) || altura <= 0) {
            alert(""Error en la altura ingresada"");
            validacion = false;
        }

        return validacion;
    }

    function ValidarDatosAlturaMinima() {
        let altura = parseFloat(document.getElementById(""miAlturaMinima"").value);
        let validacion = true;

        if (isNaN(altura) || altura <= 0) {
            alert(""Error en la altura ingresada"");
            validacion = false;
        }

        return validacion;
    }

    function ValidarDatosAmbiente() {
        let miAmbiente = document.getElementById(""miAmbiente"").value;
        let validacion = true;

        if (miAmbiente != null && miAmbiente != """") {
            alert(""Error en la altura ingresada"");
            validacion = false;
        }
        return validacion;
    }
</script>");
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
