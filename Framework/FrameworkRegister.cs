using Framework.Base.App.resolve;
using Framework.Base.Helper;
using Framework.Base.Helper.@object;
using Framework.Base.Helper.resolve;
using Framework.Interfaces.App.resolve;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Helper.@object;
using Framework.Interfaces.Helper.resolve;
using Microsoft.Practices.Unity;

namespace Framework
{
    public static class FrameworkRegister
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IApp, App>();
            container.RegisterType<IAppGroup, AppGroup>();
            container.RegisterType<IAppCategory, AppCategory>();
            container.RegisterType<IKZHelper, KZHelper>();

            container.RegisterType<IAppView, AppView>();
            container.RegisterType<IKZColours, KZColours>();
            container.RegisterType<IKZFonts, KZFonts>();
            container.RegisterType<IKZBinaryFile, KZBinaryFile>();
            container.RegisterType<IKZAppearanceSetter, KZAppearanceSetter>();
        }
    }
}