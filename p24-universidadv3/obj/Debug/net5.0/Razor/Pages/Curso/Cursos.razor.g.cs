#pragma checksum "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f52792875bfb61d5c0622f2ced6b52b4e7debfef"
// <auto-generated/>
#pragma warning disable 1591
namespace p21_universidadv1.Pages.Curso
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using p21_universidadv1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/castr/Downloads/programas/p23-universidadv3/_Imports.razor"
using p21_universidadv1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
using p21_universidadv1.Modelo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
using p21_universidadv1.Servicio;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Cursos")]
    public partial class Cursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Informacion de Cursos</h3>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(1);
            __builder.AddAttribute(2, "class", "nav-link");
            __builder.AddAttribute(3, "href", "AgregarCursos");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "<span class=\"oi oi-plus\">Agregar Nuevo</span>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 12 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
 if(obj is null) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<p>Cargando ...</p>");
#nullable restore
#line 14 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
} else {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><th>Curso Id</th>\n            <th>Titulo</th>\n            <th>Creditos</th>\n            <th>Departamento</th></thead>\n    \n    ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 24 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
         foreach (var i in obj)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 27 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                     i.CursoId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 28 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                     i.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 29 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                     i.Creditos

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 30 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                     i.Departamento.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                ");
            __builder.OpenElement(24, "td");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "class", "nav-link");
            __builder.AddAttribute(27, "href", "EditarCursos/" + (
#nullable restore
#line 32 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                                                            i.CursoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(28, "<span class=\"oi oi-pencil\">Editar</span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                     ");
            __builder.OpenElement(30, "a");
            __builder.AddAttribute(31, "class", "nav-link");
            __builder.AddAttribute(32, "href", "EliminarCursos/" + (
#nullable restore
#line 35 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
                                                               i.CursoId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(33, "<span class=\"oi oi-pencil\">Eliminar</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/castr/Downloads/programas/p23-universidadv3/Pages/Curso/Cursos.razor"
       
    List<Curso> obj;
 
    protected override void OnInitialized() {
        obj = serv.ObtenerTodo();

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ServicioCursos serv { get; set; }
    }
}
#pragma warning restore 1591
