using DevExpress.XtraEditors;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace Framework.Base.App.@class
{
    public class KZUserControl : XtraUserControl
    {
        public KZUserControl(IUnityContainer container)
        {
            KZHelper = container.Resolve<IKZHelper>();
        }

        public IKZHelper KZHelper { get; set; }
    }
}