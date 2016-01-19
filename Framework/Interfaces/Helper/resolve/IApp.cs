using System.Drawing;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.Helper.@base;

namespace Framework.Interfaces.Helper.resolve
{
    public interface IApp : IHelperObject
    {
        IAppCategory AppCategory { get; set; }
        IAppGroup AppGroup { get; set; }
        Image Image { get; set; }
        IKZBindingList<IFunction> Functions { get; set; }
    }
}