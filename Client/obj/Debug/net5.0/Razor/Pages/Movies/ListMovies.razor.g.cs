#pragma checksum "C:\Sprint3\Client\Pages\Movies\ListMovies.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54da4a5996db3a8ecbbda492dff98e31fa44bf09"
// <auto-generated/>
#pragma warning disable 1591
namespace Sprint3.Client.Pages.Movies
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Sprint3\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sprint3\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Sprint3\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Sprint3\Client\_Imports.razor"
using Sprint3.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Sprint3\Client\Pages\Movies\ListMovies.razor"
using Sprint3.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/")]
    public partial class ListMovies : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h6 class=\"display-4\">Mostrar peliculas</h6>\r\n    ");
            __builder.OpenComponent<Sprint3.Client.Pages.Components.CardMovieComponent>(1);
            __builder.AddAttribute(2, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Sprint3.Shared.Entity.Movie>>(
#nullable restore
#line 6 "C:\Sprint3\Client\Pages\Movies\ListMovies.razor"
                                 Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Sprint3\Client\Pages\Movies\ListMovies.razor"
      
    private List<Movie>Movies;
        protected override void OnInitialized()
        {
            Movies = movie.GetMovies();
        }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceMovie movie { get; set; }
    }
}
#pragma warning restore 1591
