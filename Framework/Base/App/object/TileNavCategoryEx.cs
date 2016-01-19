using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraBars.Navigation;

namespace Framework.Base.App.@object
{
    internal class TileNavCategoryEx : TileNavCategory
    {
        public HorzAlignment Allignment { get; set; } = HorzAlignment.Near;

        protected override Control CreateDropDownContent()
        {
            var tileBar = base.CreateDropDownContent() as TileBar;
            if (tileBar != null)
            {
                tileBar.HorizontalContentAlignment = Allignment;
                return tileBar;
            }
            return tileBar;
        }
    }
}