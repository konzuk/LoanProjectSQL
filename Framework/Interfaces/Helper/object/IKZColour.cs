using System.Drawing;

namespace Framework.Interfaces.Helper.@object
{
    public interface IKZColour
    {
        Color ActiveColour { get; set; }
        Color HoverColour { get; set; }
        Color SelectColour { get; set; }
    }
}