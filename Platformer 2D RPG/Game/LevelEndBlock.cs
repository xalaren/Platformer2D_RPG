namespace Platformer_2D_RPG.Game
{
    class LevelEndBlock : Block
    {
        public LevelEndBlock(int inputX, int inputY, int frameWidth) : base(inputX, inputY)
        {
            width = 35;
            height = 40;

            if (inputX <= frameWidth / 2)
            {
                BlockTexture = TexturesResourceFile.levelEndArrow_1;
            }
            else
            {
                BlockTexture = TexturesResourceFile.levelEndArrow_2;
            }
        }
    }
}
