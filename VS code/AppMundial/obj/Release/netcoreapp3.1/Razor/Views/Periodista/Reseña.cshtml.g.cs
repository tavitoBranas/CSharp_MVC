#pragma checksum "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83626ad8c195ca2fbf9d077c9ef9abc2272de334"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Periodista_Reseña), @"mvc.1.0.view", @"/Views/Periodista/Reseña.cshtml")]
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
#line 1 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\_ViewImports.cshtml"
using AppMundial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\_ViewImports.cshtml"
using AppMundial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83626ad8c195ca2fbf9d077c9ef9abc2272de334", @"/Views/Periodista/Reseña.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d843c96aade944b61b8fb23ecd8b7d3cf2a607cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Periodista_Reseña : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimerObligatorio.Partido>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <br /><h2>Reseña de partido</h2><br />\r\n    \r\n    <div class=\"viewbag\">\r\n        <b><p style=\"color:green\"> ");
#nullable restore
#line 7 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                              Write(ViewBag.correcto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n        <b><p style=\"color:red\"> ");
#nullable restore
#line 8 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                            Write(ViewBag.error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></b>\r\n        <br />\r\n    </div>\r\n   \r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83626ad8c195ca2fbf9d077c9ef9abc2272de3344413", async() => {
                WriteLiteral(@"
            <table class=""table"">
                <thead>
                    <tr>
                        <td>Numero de partido</td>
                        <td>Selección</td>
                        <td>Versus</td>
                        <td>Selección</td>
                        <td></td>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td name = ""id"">");
#nullable restore
#line 25 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                                   Write(Model.IdPartido);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                         foreach (var seleccion in Model.GetSeleccionesPartido())
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>");
#nullable restore
#line 28 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                           Write(seleccion.Pais.NombrePais);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td></td>\r\n");
#nullable restore
#line 30 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Periodista\Reseña.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </tr>
            </tbody>
        </table>


        <input type=""text"" name=""titulo"" style=""border-color:black"" size=""80"" placeholder=""Titulo"" /><br /><br />
        <textarea name=""contenido"" placeholder=""Ingrese su reseña"" style=""width:600px; height:300px""></textarea><br /><br />
        <input type=""submit"" value=""Realizar reseña"" class=""btn btn-outline-dark"" />
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimerObligatorio.Partido> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
