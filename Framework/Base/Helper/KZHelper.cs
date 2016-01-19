using Framework.Interfaces.Helper;
using Framework.Interfaces.Helper.@object;
using Microsoft.Practices.Unity;

namespace Framework.Base.Helper
{
    public class KZHelper : IKZHelper
    {
        public KZHelper(IUnityContainer container)
        {
            Container = container;
        }

        public IUnityContainer Container { get; set; }

        public IKZColours KZColours => Container.Resolve<IKZColours>();

        public IKZFonts KZFonts => Container.Resolve<IKZFonts>();

        public IKZBinaryFile KZBinaryFile => Container.Resolve<IKZBinaryFile>();

        public IKZAppearanceSetter KZAppearanceSetter => Container.Resolve<IKZAppearanceSetter>();
    }
}