using Framework.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework;
using Framework.Interfaces.App.resolve;
using Framework.Interfaces.View;
using Microsoft.Practices.Unity;

namespace LoanProjectSQL
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            IUnityContainer container = new UnityContainer();

            FrameworkRegister.Register(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var appview = container.Resolve<IAppView>();
            Application.Run(appview as Form);
        }
    }
}
