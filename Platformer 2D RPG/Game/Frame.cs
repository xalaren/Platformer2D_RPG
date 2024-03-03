using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Frame : Transform
    {
        public Image Texture { get; set; }

        public Frame(int inputWidth, int inputHeight)
        {
            x = 0;
            y = 0;
            width = inputWidth;
            height = inputHeight;
            Texture = TexturesResourceFile.bg_1;
        }
    }
}
