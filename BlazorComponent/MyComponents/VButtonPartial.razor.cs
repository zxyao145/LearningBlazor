using Microsoft.AspNetCore.Components;

namespace BlazorComponent.MyComponents
{
    public partial class VButtonPartial
    {
        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public VBtnStyle BtnStyle { get; set; } = VBtnStyle.Default;

        [Parameter]
        public VBtnSize BtnSize { get; set; } = VBtnSize.Default;

        private string GetClassName()
        {
            var builder = new System.Text.StringBuilder();
            builder.Append("btn");
            if (BtnStyle != VBtnStyle.Default)
            {
                builder.Append($" btn-{BtnStyle.ToString().ToLower()}");
            }
            if (BtnSize != VBtnSize.Default)
            {
                builder.Append($" btn-{BtnSize.ToString().ToLower()}");
            }
            return builder.ToString();
        }
    }
}
