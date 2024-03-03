using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class SpikeController : IObjectController
    {
        private List<Spike> spikes = new List<Spike>();

        public List<Spike> Spikes { get => spikes; }

        public SpikeController()
        {
            Generate();
        }

        public void Generate()
        {
            if (Level.SpikesData != null)
            {
                for (byte i = 0; i < Level.SpikesData.GetLength(0); i++)
                {
                    spikes.Add(new Spike(
                        Level.SpikesData[i, 0],
                        Level.SpikesData[i, 1]));
                }
            }
        }

        public void Draw(Graphics g, ObjectsDrawer drawer)
        {
            for (byte i = 0; i < spikes.Count; i++)
            {
                drawer.DrawSpike(g, spikes[i]);
            }
        }
    }
}
