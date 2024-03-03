namespace Platformer_2D_RPG.Editor
{
    /// <summary>
    /// Класс для хранения названий файлов
    /// </summary>
    static class FilesName
    {
        public static string DirName { get; set; }
        public static string LevelsFile { get; } = "levelsInfo";
        public static string PointsFile { get; } = "pointsInfo";
        public static string PlatformFile { get; } = "platformsInfo";
        public static string SpikeFile { get; } = "spikesInfo";
        public static string XPBlockFile { get; } = "xpBlockInfo";
        public static string EntityFile { get; } = "entityInfo";
        public static string ScoresFile { get; } = "results";
    }
}
