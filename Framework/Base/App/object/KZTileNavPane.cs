using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Helper.resolve;
using Microsoft.Practices.Unity;
using Resource;

namespace Framework.Base.App.@object
{
    public sealed class KZTileNavPane : TileNavPane
    {
        public KZTileNavPane(IUnityContainer container, Form view)
        {
            KZHelper = container.Resolve<IKZHelper>();
            View = view;
            InitNavPain();
        }

        private IKZHelper KZHelper { get; }

        public Form View { get; set; }


        public IKZBindingList<IApp> ListApp { get; set; }

        public Action HomeClick { get; set; }


        public void InitNavPain()
        {
            #region navButtonHome

            var navButtonHome = new NavButton();
            navButtonHome.Alignment = NavButtonAlignment.Left;
            navButtonHome.Glyph = Icons.Home_Black_32;
            navButtonHome.ElementClick += NavButtonHome_ElementClick;

            #endregion

            //#region navButtonMenu
            //var navButtonMenu = new NavButton();
            //navButtonMenu.Caption = "Application";
            //navButtonMenu.IsMain = true;
            //#endregion

            #region navButtonUser

            var navButtonUser = new TileNavCategoryEx();
            navButtonUser.Allignment = HorzAlignment.Far;
            navButtonUser.Alignment = NavButtonAlignment.Right;
            navButtonUser.Caption = "User";
            navButtonUser.Glyph = Icons.User_Black_32;


            var tileNavItem31 = new TileNavItem();
            var tileNavItem32 = new TileNavItem();
            var tileNavItem33 = new TileNavItem();

            navButtonUser.Items.AddRange(new[]
            {
                tileNavItem31,
                tileNavItem32,
                tileNavItem33
            });

            #endregion

            #region navButtonMin

            var navButtonMin = new NavButton();
            navButtonMin.Alignment = NavButtonAlignment.Right;
            navButtonMin.Glyph = Icons.Minus_Black_32;
            navButtonMin.ElementClick += NavButtonMin_ElementClick;

            #endregion

            #region navButtonClose

            var navButtonClose = new NavButton();
            navButtonClose.Alignment = NavButtonAlignment.Right;
            navButtonClose.Glyph = Icons.Close_Black_32;
            navButtonClose.ElementClick += NavButtonClose_ElementClick;

            #endregion

            #region config

            AllowGlyphSkinning = true;
            ContinuousNavigation = true;
            Dock = DockStyle.Fill;
            ButtonPadding = new Padding(12);


            KZHelper.KZAppearanceSetter.SetAppearance(Appearance, null, KZHelper.KZColours.MainColour.ActiveColour, KZHelper.KZColours.MainForeColour.ActiveColour);

            KZHelper.KZAppearanceSetter.SetAppearance(AppearanceHovered, null, KZHelper.KZColours.MainColour.HoverColour, KZHelper.KZColours.MainForeColour.HoverColour);

            KZHelper.KZAppearanceSetter.SetAppearance(AppearanceSelected, null, KZHelper.KZColours.MainColour.SelectColour, KZHelper.KZColours.MainForeColour.SelectColour);


            

            #endregion

            Buttons.Add(navButtonHome);
            //Buttons.Add(navButtonMenu);
            Buttons.Add(navButtonUser);
            Buttons.Add(navButtonMin);
            Buttons.Add(navButtonClose);
        }

        private void NavButtonHome_ElementClick(object sender, NavElementEventArgs e)
        {
            HomeClick?.Invoke();
        }

        #region Event

        private void NavButtonMin_ElementClick(object sender, NavElementEventArgs e)
        {
            View.WindowState = FormWindowState.Minimized;
        }

        private void NavButtonClose_ElementClick(object sender, NavElementEventArgs e)
        {
            View.Close();
        }

        #endregion
    }
}