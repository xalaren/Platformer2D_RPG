using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    interface IObjectController
    {
        void Generate();
        void Draw(Graphics g, ObjectsDrawer drawer);
    }
}
