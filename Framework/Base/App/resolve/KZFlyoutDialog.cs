using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using Framework.Interfaces.App.resolve;
using Framework.Interfaces.Helper;
using Microsoft.Practices.Unity;

namespace Framework.Base.App.resolve
{
    public class KZFlyoutDialog : FlyoutDialog, IKZFlyoutDialog
    {
        public KZFlyoutDialog(IUnityContainer container)
        {
            KZHelper = container.Resolve<IKZHelper>();

            action = new FlyoutAction();
            CommandYes = new FlyoutCommand {Text = "យល់ព្រម", Result = DialogResult.Yes};
            CommandNo = new FlyoutCommand {Text = "មិនយល់ព្រម", Result = DialogResult.No};
            action.Commands.Add(CommandYes);
            action.Commands.Add(CommandNo);


            properties = new FlyoutProperties();
            //properties.Appearance.BackColor = Color.Blue;
            //properties.Appearance.Options.UseBackColor = true;

            properties.Appearance.Font = KZHelper.KZFonts.ContentFont;
            properties.Appearance.Options.UseFont = true;
            properties.AppearanceCaption.Font = KZHelper.KZFonts.HeaderFont;
            properties.AppearanceCaption.Options.UseFont = true;
            properties.AppearanceButtons.Font = KZHelper.KZFonts.ContentFont;
            properties.AppearanceButtons.Options.UseFont = true;
            properties.AppearanceDescription.Font = KZHelper.KZFonts.ContentFont;
            properties.AppearanceDescription.Options.UseFont = true;


            properties.ButtonSize = new Size(150, 40);
            properties.Style = FlyoutStyle.MessageBox;
        }

        private FlyoutAction action { get; }
        public FlyoutCommand CommandYes { get; set; }
        public FlyoutCommand CommandNo { get; set; }
        private FlyoutProperties properties { get; }

        public IKZHelper KZHelper { get; set; }

        private static bool canCloseFunc(DialogResult parameter)
        {
            return parameter != DialogResult.Cancel;
        }

        public bool Alert(Form Owner, string Message, Image Image = null)
        {
            action.Caption = "សំគាល់";
            action.Description = Message;
            action.Image = Image;
            return Show(Owner, action, properties, canCloseFunc) == DialogResult.Yes;
        }
    }
}