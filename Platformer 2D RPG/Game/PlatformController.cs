using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class PlatformController : IObjectController
    {
        private List<Platform> platforms = new List<Platform>();

        public List<Platform> Platforms { get => platforms; }

        public PlatformController()
        {
            Generate();
        }

        public void Generate()
        {
            if (Level.PlatformsData != null)
            {
                for (byte i = 0; i < Level.PlatformsData.GetLength(0); i++)
                {
                    platforms.Add(new Platform(
                        Level.PlatformsData[i, 0],
                        Level.PlatformsData[i, 1],
                        Level.PlatformsData[i, 2],
                        Level.PlatformsData[i, 3]));
                }
            }
        }

        public void Draw(Graphics g, ObjectsDrawer drawer)
        {
            for (byte i = 0; i < platforms.Count; i++)
            {
                drawer.DrawPlatform(g, platforms[i]);
            }
        }
    }
}
