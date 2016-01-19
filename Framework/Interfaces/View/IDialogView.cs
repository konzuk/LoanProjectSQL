namespace Framework.Interfaces.View
{
    public interface IDialogView : IViewBase
    {
        IContentView OwnerView { get; set; }
    }
}