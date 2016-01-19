using System.Drawing;
using Framework.Interfaces.Helper.@object;

namespace Framework.Base.Helper.@object
{
    public class KZColour : IKZColour
    {
        public KZColour()
        {
            ActiveColour = Color.Empty;
            HoverColour = Color.Empty;
            SelectColour = Color.Empty;
        }

        public KZColour(Color color)
        {
            ActiveColour = color;
            HoverColour = color;
            SelectColour = color;
        }

        public KZColour(Color activeColor, Color hoverColor, Color selectedColor)
        {
            ActiveColour = activeColor;
            HoverColour = hoverColor;
            SelectColour = selectedColor;
        }

        public Color ActiveColour { get; set; }
        public Color HoverColour { get; set; }
        public Color SelectColour { get; set; }
    }
}