using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace BlazorInterop.Pages
{
    public class IndexBase
    {
        [Inject]
        public IJSRuntime JsRuntime { get; set; }
    }
}
