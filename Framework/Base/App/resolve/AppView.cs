using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Animation;
using DevExpress.XtraEditors;
using Framework.Base.App.@class;
using Framework.Base.App.@object;
using Framework.Base.Helper.resolve;
using Framework.Base.View.Home;
using Framework.Interfaces.App.@class;
using Framework.Interfaces.App.resolve;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Helper.resolve;
using Microsoft.Practices.Unity;
using Resource;

namespace Framework.Base.App.resolve
{
    public partial class AppView : XtraForm, IAppView
    {
        public AppView(IUnityContainer container)
        {
            InitializeComponent();

            KZHelper = container.Resolve<IKZHelper>();

            SlideFadeTransitionManager = SetSlideFadeTransitionManager();

            GenerateApplications();
            FormClosing += AppView_FormClosing;
        }

        private IKZBindingList<IApp> ListApps { get; set; }
        private HomeView HomeView { get; set; }

        private IKZHelper KZHelper { get; }
        private Dictionary<int, HomeView> DicViews { get; } = new Dictionary<int, HomeView>();

        private bool IsHome => HomeView == OwnerControl.Tag;

        private Panel OwnerControl { get; set; }

        private TransitionManager SlideFadeTransitionManager { get; }


        private TransitionManager SetSlideFadeTransitionManager()
        {
            var transiton = new Transition();
            transiton.Control = OwnerControl;


            var slideFadeTransition1 = new SlideFadeTransition();
            slideFadeTransition1.Parameters.Background = Color.Empty;
            slideFadeTransition1.Parameters.EffectOptions = PushEffectOptions.FromLeft;
            slideFadeTransition1.Parameters.FrameInterval = 1000;
            slideFadeTransition1.Parameters.FrameCount = 4000;

            transiton.TransitionType = slideFadeTransition1;

            var manager = new TransitionManager();
            manager.Transitions.Add(transiton);

            return manager;
        }


        private void HomeClick()
        {
            LoadView(HomeView);
        }

        private void ItemClick(IApp app)
        {
            if (app != null)
            {
                if (!DicViews.ContainsKey(app.Id))
                {
                    var hv = new HomeView(KZHelper.Container)
                    {
                        ListApps = new KZBindingList<IApp>(ListApps.Where(s => s.Id == app.Id)),
                        Dock = DockStyle.Fill,
                        ItemClick = ItemClick
                    };
                    DicViews.Add(app.Id, hv);
                }

                LoadView(DicViews[app.Id]);
            }
        }

        private void GenerateApplications()
        {
            ListApps = new KZBindingList<IApp>();

            ListApps.Add(new Helper.resolve.App
            {
                Id = 1,
                Name = "Customers",
                Image = Icons.Close_Black_32,
                AppGroup = new AppGroup
                {
                    Id = 0,
                    Name = ""
                }
            });
            
            ListApps.Add(new Helper.resolve.App
            {
                Id = 2,
                Name = "Suppliers",
                Image = Icons.Home_Black_32,
                AppGroup = new AppGroup
                {
                    Id = 0,
                    Name = ""
                }
            });

            ListApps.Add(new Helper.resolve.App
            {
                Id = 3,
                Name = "Employees",
                Image = Icons.Setting_Black_32,
                AppGroup = new AppGroup
                {
                    Id = 0,
                    Name = ""
                }
            });

            HomeView = new HomeView(KZHelper.Container)
            {
                ListApps = ListApps,
                Dock = DockStyle.Fill,
                ItemClick = ItemClick
            };

            this.LoadView(HomeView);

            panelTop.Controls.Add(new KZTileNavPane(KZHelper.Container, this) { HomeClick = HomeClick });
        }

        public void LoadView(Control control)
        {
            if (OwnerControl.Tag != control)
            {
                SlideFadeTransitionManager.StartTransition(OwnerControl);
                OwnerControl.Controls.Clear();
                OwnerControl.Controls.Add(control);
                OwnerControl.Tag = control;
                SlideFadeTransitionManager.EndTransition();
            }
        }

        public bool AlertClose(string message)
        {
            return new KZFlyoutDialog(KZHelper.Container).Alert(this, message);
        }

        private void AppView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !AlertClose("តើអ្នកចង់បិទកម្មវិធីដែរឺទេ?");
        }
    }
}