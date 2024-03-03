using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Platform : Transform
    {
        public Image Texture { get; set; }

        public Platform(int inputX, int inputY, int inputWidth, int inputHeight)
        {
            x = inputX;
            y = inputY;
            width = inputWidth;
            height = inputHeight;
            DefineTexture();
        }

        public void DefineTexture()
        {
            if (width == height)
            {
                if (height == 40)
                {
                    Texture = TexturesResourceFile.platformBox_1;
                }
                else if (height == 60)
                {
                    Texture = TexturesResourceFile.platformBox_2;
                }
                else if (height == 80)
                {
                    Texture = TexturesResourceFile.platformBox_3;
                }
                else
                {
                    Texture = TexturesResourceFile.platformTemplate_1;
                }
            }
            else
            {
                Texture = TexturesResourceFile.platformTemplate_1;
            }
        }
    }
}
