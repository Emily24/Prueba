#pragma checksum "C:\Sprint3\Client\Pages\Actors\ListActor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e3fdc45baae39bcd5486be6415b88f746da4be3"
// <auto-generated/>
#pragma warning disable 1591
namespace Sprint3.Client.Pages.Actors
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
#line 2 "C:\Sprint3\Client\Pages\Actors\ListActor.razor"
using Sprint3.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/actor")]
    public partial class ListActor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"display-4\">Listar actores</h1>\r\n");
            __builder.OpenComponent<Sprint3.Client.Pages.Components.CardActorsComponent>(1);
            __builder.AddAttribute(2, "Actors", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Sprint3.Shared.Entity.Actor>>(
#nullable restore
#line 5 "C:\Sprint3\Client\Pages\Actors\ListActor.razor"
                             Actors

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\r\n\"");
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "C:\Sprint3\Client\Pages\Actors\ListActor.razor"
      
    private List<Actor>Actors;
        protected override void OnInitialized()
        {
            Actors = actor.GetActors();
        }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceActor actor { get; set; }
    }
}
#pragma warning restore 1591
