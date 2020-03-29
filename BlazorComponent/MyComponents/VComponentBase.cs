using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BlazorComponent.MyComponents
{
    public class VComponentBase:ComponentBase
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }
    }
}
