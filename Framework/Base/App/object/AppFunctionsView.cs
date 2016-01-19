using System.Drawing;
using System.Reflection;
using DevExpress.Utils;
using DevExpress.XtraBars.Docking2010;
using Framework.Base.App.@class;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.Helper.resolve;
using Microsoft.Practices.Unity;

namespace Framework.Base.App.@object
{
    public partial class AppFunctionsView : KZUserControl
    {
        private static Image _splitterImageCore;

        public AppFunctionsView(IUnityContainer container)
            : base(container)
        {
            InitializeComponent();

            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Hovered, null,
                default(Color), KZHelper.KZColours.MainForeColour.HoverColour);
            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Normal, null,
                default(Color), KZHelper.KZColours.MainForeColour.ActiveColour);
            KZHelper.KZAppearanceSetter.SetAppearance(windowsUIButtonPanel2.AppearanceButton.Pressed, null,
                default(Color), KZHelper.KZColours.MainForeColour.SelectColour);
        }

        public static Image SplitterImage
        {
            get
            {
                if (_splitterImageCore == null)
                {
                    _splitterImageCore =
                        ResourceImageHelper.CreateBitmapFromResources("DevExpress.DevAV.Resources.Separator.png",
                            Assembly.GetExecutingAssembly());
                }
                return _splitterImageCore;
            }
        }

        public void InitializeButtons(IKZBindingList<IFunction> listFunctions)
        {
            Visible = true;
            windowsUIButtonPanel2.Buttons.Clear();
            windowsUIButtonPanel2.HidePeekForm();
            foreach (var function in listFunctions)
            {
                WindowsUIButton button;
                if (function.Name == null && function.Image == null)
                {
                    button = new WindowsUIButton
                    {
                        Enabled = false,
                        UseCaption = false,
                        Image = SplitterImage
                    };
                }
                else
                {
                    button = new WindowsUIButton(function.Name, function.Image, 0, ButtonStyle.PushButton, 0)
                    {
                        Tag = function
                    };
                    button.Click += function.ClickEventHandler;
                   
                }
                windowsUIButtonPanel2.Buttons.Add(button);
            }
        }
    }
}