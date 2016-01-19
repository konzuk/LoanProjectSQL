using System.ComponentModel;
using DevExpress.Skins;
using DevExpress.UserSkins;

namespace LawDictionary
{
    public class SkinRegistration : Component
    {
        public SkinRegistration()
        {
            SkinManager.Default.RegisterAssembly(typeof (SkinOffice).Assembly);
        }
    }
}