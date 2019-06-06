using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace W3.UI.Components.UIInterfaces
{
    public interface ITab
    {
        RenderFragment ChildContent { get; }
    }
}
