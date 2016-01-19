using System.Drawing;
using DevExpress.Utils;

namespace Framework.Interfaces.Helper.@object
{
    public interface IKZAppearanceSetter
    {
        void SetAppearance(AppearanceObject appearance, Font font = null, Color backColor = default(Color),
            Color foreColor = default(Color));
    }
}