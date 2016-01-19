using System;
using System.Drawing;
using Framework.Base.Helper.@class;
using Framework.Interfaces.Helper.resolve;

namespace Framework.Base.Helper.resolve
{
    public class Function : HelperObject, IFunction
    {
        public Image Image { get; set; }
        public EventHandler ClickEventHandler { get; set; }
    }
}