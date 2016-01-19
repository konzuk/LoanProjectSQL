using System.Drawing;
using Framework.Interfaces.Helper.@object;

namespace Framework.Base.Helper.@object
{
    public class KZFonts : IKZFonts
    {
        public Font HeaderFont => new Font("Romnea", 15F);
        public Font ContentFont => new Font("Khmer OS Battambang", 12F);
    }
}