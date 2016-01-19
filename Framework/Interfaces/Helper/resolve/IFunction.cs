using System;
using System.Drawing;
using Framework.Interfaces.Helper.@base;

namespace Framework.Interfaces.Helper.resolve
{
    public interface IFunction : IHelperObject
    {
        Image Image { get; set; }
        EventHandler ClickEventHandler { get; set; }
    }
}