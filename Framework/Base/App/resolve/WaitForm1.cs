using System;
using DevExpress.XtraWaitForm;
using Framework.Interfaces.App.resolve;

namespace Framework.Base.App.resolve
{
    public partial class WaitForm1 : WaitForm, IWaitFormView
    {
        public enum WaitFormCommand
        {
        }

        public WaitForm1()
        {
            InitializeComponent();
            ProgressPanel.AutoHeight = true;
        }

        public ProgressPanel ProgressPanel { get; private set; }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            ProgressPanel.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            ProgressPanel.Description = description;
        }

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
    }
}