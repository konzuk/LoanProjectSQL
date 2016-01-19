using Framework.Interfaces.Helper.resolve;

namespace Framework.Interfaces.View
{
    public interface IContentView : IViewBase
    {
        IApp App { get; set; }
    }
}