using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.Helper.resolve;
using Framework.Interfaces.Model.Home;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace Framework.Base.View.Home
{
    public partial class HomeView : ContentView<IHomeModel>, IContentView
    {
        public HomeView(IUnityContainer container)
            : base(container)
        {
            InitializeComponent();
            SetAppearanceItem();
            Load += HomeView_Load;
        }

        public IHomeModel HomeModel { get; set; }
        public IKZBindingList<IApp> ListApps { get; set; }

        private Dictionary<int, TileGroup> DicTileGroups { get; } = new Dictionary<int, TileGroup>();

        public Action<IApp> ItemClick { get; set; }

        public override void BindModel()
        {
            var manager = GetModelBindingManager(HomeModel);
        }

        private TileGroup AddAppGroup(IAppGroup appGroup)
        {
            if (!DicTileGroups.ContainsKey(appGroup.Id))
            {
                var tileGroup2 = new TileGroup
                {
                    Name = appGroup.Name,
                    Tag = appGroup.Id
                };
                tileControl1.Groups.Add(tileGroup2);

                DicTileGroups.Add(appGroup.Id, tileGroup2);
            }

            return DicTileGroups[appGroup.Id];
        }


        private void AddAppItem(IApp app)
        {
            var tileItem2 = new TileItem
            {
                AllowGlyphSkinning = DefaultBoolean.True,
                ItemSize = TileItemSize.Wide,
                Id = app.Id,
                Tag = app
            };

            tileItem2.ItemClick += TileItem2_ItemClick;

            tileItem2.Elements.Add(new TileItemElement
            {
                Image = app.Image,
                ImageAlignment = TileItemContentAlignment.BottomRight,
                Text = app.Name
            });
            var group = AddAppGroup(app.AppGroup);

            group.Items.Add(tileItem2);
        }

        private void TileItem2_ItemClick(object sender, TileItemEventArgs e)
        {
            var tileItem = sender as TileItem;
            if (tileItem != null)
            {
                var app = tileItem.Tag as IApp;
                ItemClick?.Invoke(app);
            }
        }

        private void SetAppearanceItem()
        {
            tileControl1.IndentBetweenItems = 30;
            tileControl1.Orientation = Orientation.Vertical;

            tileControl1.AppearanceItem.Hovered.BackColor = KZHelper.KZColours.TileColour.HoverColour;
            tileControl1.AppearanceItem.Hovered.ForeColor = KZHelper.KZColours.TileForeColour.HoverColour;
            tileControl1.AppearanceItem.Hovered.Options.UseBackColor = true;
            tileControl1.AppearanceItem.Hovered.Options.UseForeColor = true;

            tileControl1.AppearanceItem.Normal.BackColor = KZHelper.KZColours.TileColour.ActiveColour;
            tileControl1.AppearanceItem.Normal.ForeColor = KZHelper.KZColours.TileForeColour.ActiveColour;
            tileControl1.AppearanceItem.Normal.Options.UseBackColor = true;
            tileControl1.AppearanceItem.Normal.Options.UseForeColor = true;

            tileControl1.AppearanceItem.Pressed.BackColor = KZHelper.KZColours.TileColour.SelectColour;
            tileControl1.AppearanceItem.Pressed.ForeColor = KZHelper.KZColours.TileForeColour.SelectColour;
            tileControl1.AppearanceItem.Pressed.Options.UseBackColor = true;
            tileControl1.AppearanceItem.Pressed.Options.UseForeColor = true;

            tileControl1.AppearanceItem.Selected.BackColor = KZHelper.KZColours.TileColour.SelectColour;
            tileControl1.AppearanceItem.Selected.ForeColor = KZHelper.KZColours.TileForeColour.SelectColour;
            tileControl1.AppearanceItem.Selected.Options.UseBackColor = true;
            tileControl1.AppearanceItem.Selected.Options.UseForeColor = true;
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            if (ListApps != null && ListApps.Count > 0)
            {
                foreach (var app in ListApps)
                {
                    AddAppItem(app);
                }
            }
        }
    }
}