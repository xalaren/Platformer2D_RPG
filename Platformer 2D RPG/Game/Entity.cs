using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class Entity : Transform
    {
        private int speed;
        private int moveStart;
        private int moveEnd;

        public int Speed { get => speed; set => speed = value; }
        public int MoveStart { get => moveStart; set => moveStart = value; }
        public int MoveEnd { get => moveEnd; set => moveEnd = value; }
        public int LivesAmount { get; set; }

        public Image EntitySprite { get; set; }

        public Entity(int inputX, int inputY,
            int inputBorder1, int inputBorder2, int inputSpeed)
        {
            x = inputX;
            y = inputY;
            width = 40;
            height = 32;
            moveStart = inputBorder1;
            moveEnd = inputBorder2;
            speed = inputSpeed;

            LivesAmount = 2;
            DefineTexture();
        }

        public void DefineTexture()
        {
            if (speed > 0)
            {
                EntitySprite = TexturesResourceFile.entitySprite_2;
            }
            else
            {
                EntitySprite = TexturesResourceFile.entitySprite_1;
            }
        }
    }
}
