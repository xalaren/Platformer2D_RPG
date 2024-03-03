using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Ground : Transform
    {
        public Image GroundSprite { get; set; }

        public Ground(int inputX, int inputY, int inputWidth, int inputHeight)
        {
            x = inputX;
            y = inputY;
            width = inputWidth;
            height = inputHeight;
            GroundSprite = TexturesResourceFile.ground_1;
        }
    }
}
