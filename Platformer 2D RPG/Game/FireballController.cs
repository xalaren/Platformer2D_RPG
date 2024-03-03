using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class FireballController
    {
        private List<Fireball> fireballs = new List<Fireball>();

        public List<Fireball> Fireballs { get => fireballs; set => fireballs = value; }

        public void Generate(Fireball fireball)
        {
            fireballs.Add(fireball);
        }

        public void Delete(Fireball item)
        {
            fireballs.Remove(item);
        }

        public void Draw(Graphics g, ObjectsDrawer drawer)
        {
            for (int i = 0; i < fireballs.Count; i++)
            {
                drawer.DrawFireball(g, fireballs[i]);
            }
        }
    }
}
