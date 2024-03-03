namespace Platformer_2D_RPG.Game
{
    class Transform
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
    }
}
