using System.Drawing;
using Framework.Interfaces.Helper.@object;

namespace Framework.Base.Helper.@object
{
    public class KZColours : IKZColours
    {
        public IKZColour MainColour => new KZColour(Color.DarkOrange, Color.Orange, Color.FromArgb(255, 251, 208));
        public IKZColour MainForeColour => new KZColour(Color.White, Color.White, Color.DarkOrange);
        public IKZColour FormColour => new KZColour(Color.White, Color.LightGray, Color.LightSkyBlue);
        public IKZColour FormForeColour => new KZColour(Color.Black, Color.Black, Color.Gray);

        public IKZColour TileColour
            => new KZColour(Color.FromArgb(92, 92, 92), Color.FromArgb(110, 110, 110), Color.FromArgb(110, 110, 110));

        public IKZColour TileForeColour => new KZColour(Color.White, Color.Orange, Color.Orange);
    }
}