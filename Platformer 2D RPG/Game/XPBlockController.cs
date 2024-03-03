using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class XPBlockController : IObjectController
    {
        private List<XPBlock> xpBlocks = new List<XPBlock>();

        public List<XPBlock> XPBlocks { get => xpBlocks; set => xpBlocks = value; }

        public XPBlockController()
        {
            Generate();
        }

        public void Generate()
        {
            if (Level.XPBlocksData != null)
            {
                for (byte i = 0; i < Level.XPBlocksData.GetLength(0); i++)
                {
                    xpBlocks.Add(new XPBlock(
                        Level.XPBlocksData[i, 0],
                        Level.XPBlocksData[i, 1]));
                }
            }
        }

        public void Delete(XPBlock item)
        {
            if (xpBlocks.Contains(item))
            {
                xpBlocks.Remove(item);
            }
        }

        public void Draw(Graphics g, ObjectsDrawer drawer)
        {
            for (byte i = 0; i < xpBlocks.Count; i++)
            {
                drawer.DrawXPBlock(g, xpBlocks[i]);
            }
        }
    }
}
