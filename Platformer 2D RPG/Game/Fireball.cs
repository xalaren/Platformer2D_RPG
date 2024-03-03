namespace Platformer_2D_RPG.Game
{
    class Fireball : Block
    {
        public int Speed { get; private set; }
        public sbyte Direction { get; set; }

        public Fireball(int inputX, int inputY, sbyte inputDirection) : base(inputX, inputY)
        {
            width = 16;
            height = 16;
            Speed = 4;
            Direction = inputDirection;
            BlockTexture = TexturesResourceFile.fireball_1;
        }
    }
}
