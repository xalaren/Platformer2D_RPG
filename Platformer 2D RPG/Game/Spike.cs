namespace Platformer_2D_RPG.Game
{
    class Spike : Platform
    {
        public Spike(int inputX, int inputY) :
            base(inputX, inputY, 15, 18)
        {
            Texture = TexturesResourceFile.spike_2;
        }
    }
}
