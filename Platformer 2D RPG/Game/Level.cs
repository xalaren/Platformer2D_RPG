using Platformer_2D_RPG.Editor;
using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    static class Level
    {
        public delegate void ChangeDetect(); //Делегат для отслеживания изменения
        public static event ChangeDetect LevelChanged;  //Событие изменения номера уровня

        private static byte currentLevel = 1;  //Определяет текущий номер уровня

        public static byte TempLivesAmount { get; set; }
        public static byte LevelsCount = 4;

        public static int[,] PlatformsData { get; set; }
        public static int[,] SpikesData { get; set; }
        public static int[,] XPBlocksData { get; set; }
        public static int[,] EntitiesData { get; set; }
        public static int XPCount { get; set; }
        public static Point SpawnPoint { get; set; }
        public static Point LevelEndPoint { get; set; }
        public static bool IsGameOver { get; set; } = false;
        public static bool IsGameEnd { get; set; } = true;
        public static bool IsLoadCustomLevel { get; set; } = false;
        public static string CustomLevelName { get; set; }
        public static uint Attempts { get; set; } = 1;
        public static string TimeResult { get; set; } = "";

        public static void InitInternalLevel()
        {
            IsLoadCustomLevel = false;
            Attempts = 1;
            CurrentLevel = 1;
        }

        public static byte CurrentLevel
        {
            get { return currentLevel; }
            set
            {
                if (currentLevel != value)
                {
                    currentLevel = value;
                    if (LevelChanged != null)
                    {
                        LevelChanged?.Invoke();
                    }
                }
            }
        }

        public static void Reset()
        {
            PlatformsData = null;
            SpikesData = null;
            XPBlocksData = null;
            XPCount = 0;
            EntitiesData = null;
            SpawnPoint = new Point(0, 0);
            LevelEndPoint = new Point(0, 0);
        }

        #region Уровень 1
        public static void LoadLevel1()
        {
            Reset();
            currentLevel = 1;
            IsLoadCustomLevel = false;

            SpawnPoint = new Point(20, 500);
            LevelEndPoint = new Point(-20, 88);

            PlatformsData = new int[,]
            {
                { 400, 450, 200, 40 },
                { 650, 410, 140, 40 },
                { 270, 400, 70, 40 },
                { 170, 350, 70, 40 },
                { 5, 285, 200, 30 },
                { 270, 240, 240, 30 },
                { 560, 190, 210, 30 },
                { 5, 128, 500, 40 },
            };

            SpikesData = new int[,]
            {
                { 470, 432 },
                { 70, 482 },
                { 90, 268 },
                { 387, 110 },
                { 257, 110 },
                { 140, 110 }
            };

            XPBlocksData = new int[,]
            {
                { 120, 476 },
                { 170, 476 },
                { 120, 354 },
                { 220, 476 },
                { 270, 476 },
                { 411, 426 },
                { 520, 426 },
                { 620, 480 },
                { 680, 480 },
                { 750, 480 },
                { 658, 383 },
                { 708, 383 },
                { 298, 377 },
                { 215, 326 },
                { 153, 257 },
                { 123, 257 },
                { 33, 257  },
                { 290, 214 },
                { 360, 214 },
                { 430, 214 },
                { 565, 280 },
                { 600, 156 },
                { 710, 156 },
                { 387, 68  },
                { 257, 68  },
                { 140, 68  }
            };
            XPCount = XPBlocksData.GetLength(0);
        }
        #endregion

        #region Уровень 2
        public static void LoadLevel2()
        {
            Reset();
            currentLevel = 2;
            IsLoadCustomLevel = false;

            SpawnPoint = new Point(760, 82);
            LevelEndPoint = new Point(-20, 275);

            PlatformsData = new int[,]
            {
                { 600, 110, 190, 30 },
                { 300, 200, 190, 30 },
                { 680, 300, 100, 30 },
                { 680, 300, 100, 30 },
                { 100, 90, 100, 40 },
                { 100, 260, 100, 40 },
                { 100, 410, 100, 40 },
                { 410, 380, 230, 30 },
                { 260, 320, 40, 40 },
                { 10, 150, 40, 40 },
                { 260, 50, 170, 30 },
                { 10, 320, 40, 40 },
                { 680, 430, 100, 30 }
            };

            SpikesData = new int[,]
            {
                { 10, 480 },
                { 40, 480 },
                { 70, 480 },
                { 650, 89 },
                { 450, 480 },
                { 480, 480 },
                { 510, 480 },
                { 540, 480 },
                { 570, 480 },
                { 185, 240 }
            };


            XPBlocksData = new int[,]
            {
                { 680, 170 },
                { 720, 200 },
                { 640, 200 },
                { 720, 260 },
                { 690, 390 },
                { 750, 390 },
                { 750, 475 },
                { 700, 475 },
                { 650, 475 },
                { 620, 350 },
                { 560, 350 },
                { 500, 350 },
                { 440, 350 },
                { 607, 84 },
                { 527, 54 },
                { 316, 146 },
                { 380, 146 },
                { 446, 146 },
                { 280, 13 },
                { 340, 13 },
                { 145, 53 },
                { 145, 223 },
                { 145, 373 },
                { 23, 115 },
                { 23, 285 },
                { 273, 285 }
            };
            XPCount = XPBlocksData.GetLength(0);

            EntitiesData = new int[,]
            {
                { 415, 347, 410, 640, 1 }
            };
        }
        #endregion

        #region Уровень 3
        public static void LoadLevel3()
        {
            currentLevel = 3;
            IsLoadCustomLevel = false;
            SpawnPoint = new Point(750, 350);
            LevelEndPoint = new Point(-20, 100);

            PlatformsData = new int[,]
            {
                { 690, 360, 100, 30 },
                { 400, 300, 200, 30 },
                { 240, 260, 130 , 40 },
                { 530, 435, 130, 30 },
                { 280, 460, 60, 30 },
                { 145, 435, 95, 30 },
                { 110, 300, 80, 40 },
                { 10, 360, 80, 40 },
                { 410, 96, 160, 40 },
                { 220, 60, 160, 40 },
                { 10, 140, 60, 60 },
                { 630, 190, 140, 40 }
            };

            SpikesData = new int[,]
            {
                { 280, 240 },
                { 350, 240 },
                { 285, 438 },
                { 320, 438 },
                { 55, 337 },
                { 700, 480 },
                { 730, 480 },
                { 760, 480 },
                { 730, 170 }
            };
            XPBlocksData = new int[,]
            {
                { 580, 270 },
                { 530, 270 },
                { 480, 270 },
                { 625, 410 },
                { 585, 410 },
                { 545, 410 },
                { 625, 480 },
                { 585, 480 },
                { 545, 480 },
                { 665, 480 },
                { 435, 430 },
                { 385, 460 },
                { 485, 460 },
                { 182, 405 },
                { 252, 475 },
                { 212, 475 },
                { 172, 475 },
                { 132, 475 },
                { 22, 455 },
                { 300, 375 },
                { 640, 160 },
                { 690, 160 },
                { 540, 70 },
                { 475, 70 },
                { 410, 70 },
                { 360, 35 },
                { 295, 35 },
                { 230, 35 },
                { 130, 140 },
                { 140, 260 },
                { 20, 326 },
                { 290, 186 }
            };
            XPCount = XPBlocksData.GetLength(0);

            EntitiesData = new int[,]
            {
                { 425, 63, 410, 570, 1 }
            };



        }
        #endregion

        #region Уровень 4
        public static void LoadLevel4()
        {
            Reset();
            currentLevel = 4;
            IsLoadCustomLevel = false;
            SpawnPoint = new Point(760, 275);
            LevelEndPoint = new Point(-20, 107);

            PlatformsData = new int[,]
            {
                { 512, 352, 282, 40 },
                { 400, 450, 130, 30 },
                { 203, 460, 80, 40 },
                { 20, 444, 130, 30 },
                { 260, 282, 188, 40 },
                { 88, 214, 157, 40 },
                { 5, 160, 80, 40 },
                { 130, 63, 110, 40 },
                { 317, 150, 40, 40 },
                { 430, 93, 40, 40 },
                { 304, 45, 40, 40 },
                { 546, 100, 114, 30 },
                { 546, 202, 114, 30 },
                { 733, 63, 40, 40 }
            };

            SpikesData = new int[,]
            {
                { 640, 332 },
                { 600, 332 },
                { 444, 430 },
                { 204, 440 },
                { 235, 440 },
                { 266, 440 },
                { 115, 195 },
                { 626, 81 },
                { 381, 262 }
            };

            EntitiesData = new int[,]
            {
                { 576, 470, 532, 790, 3 },
                { 22, 411, 20, 160, -2 },
                { 590, 170, 547, 660, 1 }
            };

            XPBlocksData = new int[,]
            {
                { 550, 465 },
                { 600, 465 },
                { 654, 465 },
                { 619, 302 },
                { 423, 248 },
                { 345, 248 },
                { 295, 248 },
                { 183, 182 },
                { 143, 182 },
                { 14, 134 },
                { 54, 134 },
                { 477, 413 },
                { 474, 344 },
                { 326, 441 },
                { 262, 356 },
                { 212, 356 },
                { 167, 471 },
                { 106, 416 },
                { 66, 416 },
                { 26, 416 },
                { 80, 323 },
                { 150, 356 },
                { 404, 404 },
                { 153, 36 },
                { 213, 36 },
                { 319, 20 },
                { 333, 127 },
                { 444, 66 },
                { 587, 66 },
                { 587, 180 },
                { 744, 40 }
            };
            XPCount = XPBlocksData.GetLength(0) + EntitiesData.GetLength(0);
        }
        #endregion

        #region Пользовательский уровень
        public static void InitCustomLevel()
        {
            IsLoadCustomLevel = true;
            Attempts = 1;
            CustomLevelName = FilesName.DirName;
        }

        public static void LoadCustomLevel()
        {
            Reset();
            currentLevel = 4;
            Files files = new Files();
            files.ToCatalog(FilesName.DirName);

            LevelsLoader loader = new LevelsLoader();

            string[] spPoint = loader.GetSpawnPoint();

            if (spPoint != null)
            {
                SpawnPoint = new Point(int.Parse(spPoint[0]), int.Parse(spPoint[1]));
            }

            string[] endPoint = loader.GetEndPoint();

            if (endPoint != null)
            {
                LevelEndPoint = new Point(int.Parse(endPoint[0]), int.Parse(endPoint[1]));
            }

            string[][] plData = loader.GetPlatforms();
            if (plData != null)
            {
                PlatformsData = new int[plData.Length, 4];
                for (int i = 0; i < plData.Length; i++)
                {
                    PlatformsData[i, 0] = int.Parse(plData[i][0]);
                    PlatformsData[i, 1] = int.Parse(plData[i][1]);
                    PlatformsData[i, 2] = int.Parse(plData[i][2]);
                    PlatformsData[i, 3] = int.Parse(plData[i][3]);
                }
            }

            string[][] spData = loader.GetSpikes();
            if (spData != null)
            {
                SpikesData = new int[spData.Length, 2];
                for (int i = 0; i < spData.Length; i++)
                {
                    SpikesData[i, 0] = int.Parse(spData[i][0]);
                    SpikesData[i, 1] = int.Parse(spData[i][1]);
                }
            }

            string[][] xpData = loader.GetXPBlocks();
            if (xpData != null)
            {
                XPBlocksData = new int[xpData.Length, 2];
                for (int i = 0; i < xpData.Length; i++)
                {
                    XPBlocksData[i, 0] = int.Parse(xpData[i][0]);
                    XPBlocksData[i, 1] = int.Parse(xpData[i][1]);
                }
            }

            string[][] entData = loader.GetEntities();
            if (xpData != null)
            {
                EntitiesData = new int[entData.Length, 5];
                for (int i = 0; i < entData.Length; i++)
                {
                    EntitiesData[i, 0] = int.Parse(entData[i][0]);
                    EntitiesData[i, 1] = int.Parse(entData[i][1]);
                    EntitiesData[i, 2] = int.Parse(entData[i][2]);
                    EntitiesData[i, 3] = int.Parse(entData[i][3]);
                    EntitiesData[i, 4] = int.Parse(entData[i][4]);
                }
            }
            if (XPBlocksData != null && EntitiesData != null)
            {
                XPCount = XPBlocksData.GetLength(0) + EntitiesData.GetLength(0);
            }
            else if (EntitiesData != null)
            {
                XPCount = EntitiesData.GetLength(0);
            }
        }
        #endregion
    }
}
