using System.Collections.Generic;

namespace Platformer_2D_RPG.Editor
{
    class LevelsLoader
    {
        private Files files;

        public LevelsLoader()
        {
            files = new Files();
            files.ToCatalog(FilesName.DirName);
        }
        public string[] GetSpawnPoint()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.PointsFile);

            if (data.Count > 0)
            {
                return data[0].Split(' ');
            }
            else return null;
        }

        public string[] GetEndPoint()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.PointsFile);

            if (data.Count > 0)
            {
                return data[1].Split(' ');
            }
            else return null;
        }

        public string[][] GetPlatforms()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.PlatformFile);

            if (data.Count > 0)
            {
                int count = int.Parse(data[0]);
                data.RemoveAt(0);

                string[][] platformsData = new string[count][];

                for (int i = 0; i < count; i++)
                {
                    platformsData[i] = data[i].Split(' ');
                }

                return platformsData;
            }
            else return null;

        }

        public string[][] GetSpikes()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.SpikeFile);
            if (data.Count > 0)
            {
                int count = int.Parse(data[0]);
                data.RemoveAt(0);

                string[][] spikesData = new string[count][];
                for (int i = 0; i < count; i++)
                {
                    spikesData[i] = data[i].Split(' ');
                }

                return spikesData;
            }
            else return null;
        }

        public string[][] GetXPBlocks()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.XPBlockFile);

            if (data.Count > 0)
            {
                int count = int.Parse(data[0]);
                data.RemoveAt(0);

                string[][] xpBlocksData = new string[count][];
                for (int i = 0; i < count; i++)
                {
                    xpBlocksData[i] = data[i].Split(' ');
                }

                return xpBlocksData;
            }
            else return null;
        }

        public string[][] GetEntities()
        {
            List<string> data = new List<string>();
            data = files.LoadItems(FilesName.EntityFile);
            if (data.Count > 0)
            {
                int count = int.Parse(data[0]);
                data.RemoveAt(0);

                string[][] entityData = new string[count][];
                for (int i = 0; i < count; i++)
                {
                    entityData[i] = data[i].Split(' ');
                }

                return entityData;
            }
            else return null;
        }
    }
}
