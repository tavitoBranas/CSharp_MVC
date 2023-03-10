#pragma checksum "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4eb2de0f0cea6d97682ce624a7f341594ab98115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operador_Reseñas), @"mvc.1.0.view", @"/Views/Operador/Reseñas.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb2de0f0cea6d97682ce624a7f341594ab98115", @"/Views/Operador/Reseñas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d843c96aade944b61b8fb23ecd8b7d3cf2a607cb", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Operador_Reseñas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrimerObligatorio.Reseña>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <br /><h3 style=\"color:darkslategrey\"><u>Reseñas de partidos según ");
#nullable restore
#line 4 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                                                                  Write(ViewBag.Periodista);

#line default
#line hidden
#nullable disable
            WriteLiteral("</u></h3><br />\r\n\r\n\r\n");
#nullable restore
#line 7 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
     if (Model.Count() != 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <td>Fecha de reseña</td>
                    <td>Fecha del Partido</td>
                    <td>Grupo</td>
                    <td>Seleccion</td>
                    <td>Selección</td>
                    <td>Reseña</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                 foreach (var Reseña in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 24 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                       Write(Reseña.FechaReseña.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                       Write(Reseña.Partido.FechaPartido.ToString("dd/MM/yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                       Write(Reseña.GrupoPartido());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 28 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                         foreach (var seleccion in Reseña.Partido.GetSeleccionesPartido())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 30 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                           Write(seleccion.Pais.NombrePais);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td class=\"text-justify\">");
#nullable restore
#line 32 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                                            Write(Reseña.ContenidoReseña);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 34 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 38 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
    }
    else{

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p><b>No existen reseñas para este periodista</b></p>\r\n");
#nullable restore
#line 41 "D:\Estudio\ORT\2S\P2\Obligatorio\Segundo Obligatorio\AppMundial\Views\Operador\Reseñas.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrimerObligatorio.Reseña>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
