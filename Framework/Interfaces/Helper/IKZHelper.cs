using Framework.Interfaces.Helper.@object;
using Microsoft.Practices.Unity;

namespace Framework.Interfaces.Helper
{
    public interface IKZHelper
    {
        IUnityContainer Container { get; set; }
        IKZColours KZColours { get; }
        IKZFonts KZFonts { get; }
        IKZBinaryFile KZBinaryFile { get; }
        IKZAppearanceSetter KZAppearanceSetter { get; }
    }
}