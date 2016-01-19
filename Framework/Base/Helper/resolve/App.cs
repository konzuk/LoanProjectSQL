using System.Drawing;
using Framework.Base.Helper.@class;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.Helper.resolve;

namespace Framework.Base.Helper.resolve
{
    public class App : HelperObject, IApp
    {
        public IAppCategory AppCategory { get; set; }
        public IAppGroup AppGroup { get; set; }
        public Image Image { get; set; }
        public IKZBindingList<IFunction> Functions { get; set; }
    }
}