using Platformer_2D_RPG.Game;
using System.Collections.Generic;
using System.Drawing;

namespace Platformer_2D_RPG.Editor
{
    class EditorCore
    {
        List<Platform> platforms;
        List<Spike> spikes;
        List<XPBlock> xpBlocks;
        List<Entity> entities;
        LevelsLoader loader;

        public List<Platform> Platforms
        {
            get => platforms;
            set
            {
                if (platforms.Count > 0)
                {
                    platforms = value;
                }
            }
        }

        public List<Spike> Spikes
        {
            get => spikes;
            set
            {
                if (spikes.Count > 0)
                {
                    spikes = value;
                }
            }
        }

        public List<Entity> Entities
        {
            get => entities;
            set
            {
                if (entities.Count > 0)
                {
                    entities = value;
                }
            }
        }

        public List<XPBlock> XPBlocks
        {
            get => xpBlocks;
            set
            {
                if (xpBlocks.Count > 0)
                {
                    xpBlocks = value;
                }
            }
        }

        public Ground ControlGround { get; private set; }
        public Frame ControlFrame { get; private set; }
        public LevelEndBlock ControlEndBlock { get; set; }
        public Point SpawnPoint { get; set; }
        private Files fileControl;

        public EditorCore()
        {
            loader = new LevelsLoader();
            fileControl = new Files();
            fileControl.ToCatalog(FilesName.DirName); //Переход в каталог с файлами уровня

            platforms = new List<Platform>();
            spikes = new List<Spike>();
            xpBlocks = new List<XPBlock>();
            entities = new List<Entity>();

            ControlFrame = new Frame(800, 600);
            ControlGround = new Ground(0, ControlFrame.Height - 100, 800, 200);
            SpawnPoint = new Point(0, 0);
            ControlEndBlock = new LevelEndBlock(700, (int)ControlGround.Y - 50, ControlFrame.Width);

            LoadFile();
        }

        public void SetSpawnPoint(int x, int y)
        {
            SpawnPoint = new Point(x, y);
        }

        public void SetEndBlock(int x, int y)
        {
            ControlEndBlock.X = x;
            ControlEndBlock.Y = y;
        }

        public void AddPlatform(int x, int y, int width, int height)
        {
            platforms.Add(new Platform(x, y, width, height));
        }

        public void AddSpike(int x, int y)
        {
            spikes.Add(new Spike(x, y));
        }

        public void AddXPBlock(int x, int y)
        {
            xpBlocks.Add(new XPBlock(x, y));
        }

        public void AddEntity(int x, int y, int border1, int border2, int speed)
        {
            entities.Add(new Entity(x, y, border1, border2, speed));
        }

        public void EditPlatform(int index, int x, int y, int width, int height)
        {
            Platforms[index].X = x;
            Platforms[index].Y = y;
            Platforms[index].Width = width;
            Platforms[index].Height = height;
            Platforms[index].DefineTexture();
        }

        public void EditSpike(int index, int x, int y)
        {
            Spikes[index].X = x;
            Spikes[index].Y = y;
        }

        public void EditXPBlock(int index, int x, int y)
        {
            XPBlocks[index].X = x;
            XPBlocks[index].Y = y;
        }

        public void EditEntity(int index, int x, int y, int border1, int border2, int speed)
        {
            Entities[index].X = x;
            Entities[index].Y = y;
            Entities[index].MoveStart = border1;
            Entities[index].MoveEnd = border2;
            Entities[index].Speed = speed;
        }

        public void RemovePlatform(int index)
        {
            Platforms.RemoveAt(index);
        }

        public void RemoveSpike(int index)
        {
            Spikes.RemoveAt(index);
        }

        public void RemoveXPBlock(int index)
        {
            XPBlocks.RemoveAt(index);
        }

        public void RemoveEntity(int index)
        {
            Entities.RemoveAt(index);
        }

        public void DrawObjects(Graphics g, ObjectsDrawer drawer)
        {
            drawer.DrawGround(g, ControlGround);
            drawer.DrawSpawnPoint(g, SpawnPoint);
            drawer.DrawLevelEndBlock(g, ControlEndBlock);

            if (platforms.Count > 0)
            {
                for (int i = 0; i < platforms.Count; i++)
                {
                    drawer.DrawPlatform(g, platforms[i]);
                }
            }

            if (spikes.Count > 0)
            {
                for (int i = 0; i < spikes.Count; i++)
                {
                    drawer.DrawSpike(g, spikes[i]);
                }
            }

            if (xpBlocks.Count > 0)
            {
                for (int i = 0; i < xpBlocks.Count; i++)
                {
                    drawer.DrawXPBlock(g, xpBlocks[i]);
                }
            }

            if (entities.Count > 0)
            {
                for (int i = 0; i < entities.Count; i++)
                {
                    drawer.DrawEntity(g, entities[i]);
                    drawer.DrawEntityBorderLines(g, entities[i]);
                }
            }
        }

        public void LoadFile()
        {
            string[] spPoint = loader.GetSpawnPoint();

            if (spPoint != null)
            {
                SetSpawnPoint(int.Parse(spPoint[0]), int.Parse(spPoint[1]));
            }

            string[] endPoint = loader.GetEndPoint();

            if (endPoint != null)
            {
                SetEndBlock(int.Parse(endPoint[0]), int.Parse(endPoint[1]));
            }

            string[][] plData = loader.GetPlatforms();
            if (plData != null)
            {
                for (int i = 0; i < plData.Length; i++)
                {
                    AddPlatform(int.Parse(plData[i][0]), int.Parse(plData[i][1]), int.Parse(plData[i][2]), int.Parse(plData[i][3]));
                }
            }


            string[][] spData = loader.GetSpikes();
            if (spData != null)
            {
                for (int i = 0; i < spData.Length; i++)
                {
                    AddSpike(int.Parse(spData[i][0]), int.Parse(spData[i][1]));
                }
            }

            string[][] xpData = loader.GetXPBlocks();
            if (xpData != null)
            {
                for (int i = 0; i < xpData.Length; i++)
                {
                    AddXPBlock(int.Parse(xpData[i][0]), int.Parse(xpData[i][1]));
                }
            }

            string[][] entData = loader.GetEntities();
            if (entData != null)
            {
                for (int i = 0; i < entData.Length; i++)
                {
                    AddEntity(int.Parse(entData[i][0]), int.Parse(entData[i][1]), int.Parse(entData[i][2]),
                        int.Parse(entData[i][3]), int.Parse(entData[i][4]));
                }
            }
        }

        public void SaveFile()
        {
            fileControl.DeleteFile(FilesName.PointsFile);
            fileControl.SaveItems(FilesName.PointsFile, SpawnPoint.X + " " + SpawnPoint.Y);
            fileControl.SaveItems(FilesName.PointsFile, ControlEndBlock.X + " " + ControlEndBlock.Y);


            fileControl.DeleteFile(FilesName.PlatformFile);
            fileControl.SaveItemsLine(FilesName.PlatformFile, platforms.Count.ToString());
            for (int i = 0; i < platforms.Count; i++)
            {
                string data = platforms[i].X + " " + platforms[i].Y + " " + platforms[i].Width + " " + platforms[i].Height;
                fileControl.SaveItemsLine(FilesName.PlatformFile, data);
            }

            fileControl.DeleteFile(FilesName.SpikeFile);
            fileControl.SaveItemsLine(FilesName.SpikeFile, spikes.Count.ToString());
            for (int i = 0; i < spikes.Count; i++)
            {
                string data = spikes[i].X + " " + spikes[i].Y;
                fileControl.SaveItemsLine(FilesName.SpikeFile, data);
            }

            fileControl.DeleteFile(FilesName.XPBlockFile);
            fileControl.SaveItemsLine(FilesName.XPBlockFile, xpBlocks.Count.ToString());
            for (int i = 0; i < xpBlocks.Count; i++)
            {
                string data = xpBlocks[i].X + " " + xpBlocks[i].Y;
                fileControl.SaveItemsLine(FilesName.XPBlockFile, data);
            }

            fileControl.DeleteFile(FilesName.EntityFile);
            fileControl.SaveItemsLine(FilesName.EntityFile, entities.Count.ToString());
            for (int i = 0; i < entities.Count; i++)
            {
                string data = entities[i].X + " " + entities[i].Y + " " + entities[i].MoveStart + " " + entities[i].MoveEnd + " " + entities[i].Speed;
                fileControl.SaveItemsLine(FilesName.EntityFile, data);
            }
        }
    }
}
