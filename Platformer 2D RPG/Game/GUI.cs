using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class GUI
    {
        public Time TimeGUI { get; private set; }
        public Image LivesSprite { get; set; }
        public Image DoubleJumpBonusSprite { get; set; }
        public Image DashBonusSprite { get; set; }
        public Image FireCharmBonusSprite { get; set; }

        public GUI(Time time)
        {
            LivesSprite = new Bitmap(TexturesResourceFile.heart_1);
            DoubleJumpBonusSprite = new Bitmap(TexturesResourceFile.doubleJump_bonus_1);
            DashBonusSprite = new Bitmap(TexturesResourceFile.dash_bonus_1);
            FireCharmBonusSprite = new Bitmap(TexturesResourceFile.fireCharmBonus_1);
            TimeGUI = time;
        }
    }
}
