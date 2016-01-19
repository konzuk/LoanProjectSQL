using System;
using DevExpress.XtraSplashScreen;
using Framework.Interfaces.App.resolve;

namespace Framework.Base.App.resolve
{
    public partial class SplashScreen1 : SplashScreen, ISplashScreenView
    {
        public enum SplashScreenCommand
        {
        }

        public SplashScreen1()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}