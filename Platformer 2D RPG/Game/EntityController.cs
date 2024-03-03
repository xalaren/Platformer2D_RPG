using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class EntityController : IObjectController
    {
        private List<Entity> entities = new List<Entity>();

        public List<Entity> Entities { get => entities; }

        public EntityController()
        {
            Generate();
        }

        public void Generate()
        {
            if (Level.EntitiesData != null)
            {
                for (byte i = 0; i < Level.EntitiesData.GetLength(0); i++)
                {
                    Entities.Add(new Entity(
                        Level.EntitiesData[i, 0],
                        Level.EntitiesData[i, 1],
                        Level.EntitiesData[i, 2],
                        Level.EntitiesData[i, 3],
                        Level.EntitiesData[i, 4]));
                }
            }
        }

        public void Delete(Entity item)
        {
            if (entities.Contains(item))
            {
                entities.Remove(item);
            }
        }

        public void Draw(Graphics g, ObjectsDrawer drawer)
        {
            for (byte i = 0; i < Entities.Count; i++)
            {
                drawer.DrawEntity(g, Entities[i]);
                drawer.DrawEntityHealthBar(g, Entities[i]);
            }
        }

        public void MoveEntity()
        {
            for (byte i = 0; i < entities.Count; i++)
            {
                if (entities[i].X + entities[i].Width < entities[i].MoveEnd &&
                    entities[i].X > entities[i].MoveStart)
                {
                    entities[i].X += entities[i].Speed;
                }
                else
                {
                    entities[i].Speed = (-1) * entities[i].Speed;
                    entities[i].X += entities[i].Speed;
                    entities[i].DefineTexture();
                }
            }
        }
    }
}
