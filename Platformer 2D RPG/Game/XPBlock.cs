namespace Platformer_2D_RPG.Game
{
    class XPBlock : Block
    {
        public XPBlock(int inputX, int inputY) : base(inputX, inputY)
        {
            width = 18;
            height = 18;
            BlockTexture = TexturesResourceFile.xpBlockSprite_1;
        }
    }
}
