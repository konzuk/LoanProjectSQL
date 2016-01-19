using System;
using System.Linq;
using DevExpress.Utils.MVVM;
using DevExpress.XtraEditors;
using Framework.Base.App.@object;
using Framework.Interfaces.Helper;
using Framework.Interfaces.Helper.resolve;
using Microsoft.Practices.Unity;

namespace Framework.Base.View
{
    public partial class ContentView<TModel> : XtraUserControl
        where TModel : class
    {
        private IApp _app;

        public ContentView(IUnityContainer container)
        {
            InitializeComponent();
            Load += ContentView_Load;
            AssignName();
            BindEvent();

            KZHelper = container.Resolve<IKZHelper>();
        }

        public IKZHelper KZHelper { get; set; }

        public IApp App
        {
            get { return _app; }
            set
            {
                _app = value;
                if (_app != null && _app.Functions != null && _app.Functions.Any())
                {
                    panelFunctions.Visible = _app.Functions != null && _app.Functions.Any();

                    var functionsButtons = new AppFunctionsView(KZHelper.Container);
                    functionsButtons.InitializeButtons(_app.Functions);
                }
            }
        }

        protected MVVMContextFluentAPI<TModel> GetModelBindingManager(TModel model)
        {
            var mvvmContext = new MVVMContext();
            mvvmContext.ContainerControl = this;
            mvvmContext.SetViewModel(typeof (TModel), model);
            var fluentAPI = mvvmContext.OfType<TModel>();
            return fluentAPI;
        }


        private void ContentView_Load(object sender, EventArgs e)
        {
            BindModel();
        }

        public virtual void AssignName()
        {
        }

        public virtual void BindEvent()
        {
        }

        public virtual void BindModel()
        {
        }
    }
}