using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Block : Transform
    {
        public Image BlockTexture { get; set; }

        public Block(int inputX, int inputY)
        {
            x = inputX;
            y = inputY;
        }
    }
}
