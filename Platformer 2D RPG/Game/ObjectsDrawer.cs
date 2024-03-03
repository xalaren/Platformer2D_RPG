using System.Drawing;

namespace Platformer_2D_RPG.Game
{
    class ObjectsDrawer
    {
        private Pen expBarPen = new Pen(Color.FromArgb(208, 230, 255), 2);
        private Pen dashLinePen = new Pen(Color.FromArgb(150, 255, 255, 255), 3);
        private Brush hpBarBrush1 = new SolidBrush(Color.FromArgb(27, 0, 0));
        private Brush hpBarBrush2 = new SolidBrush(Color.FromArgb(255, 63, 63));
        private Brush hpBarBrush3 = new SolidBrush(Color.FromArgb(255, 223, 223));
        private SolidBrush xpBrush = new SolidBrush(Color.FromArgb(25, 154, 92));
        private SolidBrush whiteBrush = new SolidBrush(Color.White);
        private SolidBrush cyanBrush = new SolidBrush(Color.FromArgb(0, 107, 226));
        private Font pix14 = new Font("Segoe UI Semibold", 14);
        private Font pix12 = new Font("Segoe UI Semibold", 12);
        private Font pix8 = new Font("Segoe UI Semibold", 8);

        public void DrawFrame(Graphics g, Color color, Frame frame)
        {
            g.DrawRectangle(new Pen(color, 8), frame.X, frame.Y, frame.Width, frame.Height);
            g.FillRectangle(new SolidBrush(Color.FromArgb(22, 25, 30)), frame.Width + 3, frame.Y, 160, frame.Height);  //Заливание боковой панели
            g.DrawRectangle(new Pen(Color.Black, 3.5f), frame.Width + 1, frame.Y + 3.2f, 160.5f, frame.Height - 4.5f);  //Линия разделения рамки и панели 
        }

        public void DrawLevelEndBlock(Graphics g, Color color, LevelEndBlock levelEndBlock)
        {
            g.FillRectangle(new SolidBrush(color), levelEndBlock.X, levelEndBlock.Y, levelEndBlock.Width, levelEndBlock.Height);
            g.DrawImage(levelEndBlock.BlockTexture, levelEndBlock.X + 30, levelEndBlock.Y + 5, 27, 27);
        }

        public void DrawLevelEndBlock(Graphics g, LevelEndBlock levelEndBlock)
        {
            g.DrawImage(levelEndBlock.BlockTexture, levelEndBlock.X + 30, levelEndBlock.Y + 5, 27, 27);
        }

        public void DrawPlayer(Graphics g, Player player)
        {
            g.DrawImage(player.PlayerSprite, player.X - 9, player.Y - 10, player.Width + 12, player.Height + 10);

            if (player.IsDashing)
            {
                if (player.Direction > 0)
                {
                    g.DrawLine(dashLinePen, player.X - 35, player.Y + 5, player.X - 10, player.Y + 5);
                    g.DrawLine(dashLinePen, player.X - 25, player.Y + 15, player.X - 10, player.Y + 15);
                    g.DrawLine(dashLinePen, player.X - 20, player.Y + 25, player.X - 10, player.Y + 25);
                }
                else
                {
                    g.DrawLine(dashLinePen, player.X + player.Width + 35, player.Y + 5, player.X + player.Width + 10, player.Y + 5);
                    g.DrawLine(dashLinePen, player.X + player.Width + 25, player.Y + 15, player.X + player.Width + 10, player.Y + 15);
                    g.DrawLine(dashLinePen, player.X + player.Width + 20, player.Y + 25, player.X + player.Width + 10, player.Y + 25);
                }
            }
        }

        public void DrawGround(Graphics g, Ground ground)
        {
            g.DrawImage(ground.GroundSprite, ground.X, ground.Y, ground.Width, ground.Height);
        }

        public void DrawPlatform(Graphics g, Platform platform)
        {
            g.DrawImage(platform.Texture, platform.X, platform.Y, new Rectangle(0, 0, platform.Width, platform.Height), GraphicsUnit.Pixel);
            g.DrawRectangle(new Pen(Color.FromArgb(7, 10, 14), 3), platform.X, platform.Y, platform.Width, platform.Height);
            g.DrawLine(new Pen(Color.FromArgb(50, 89, 112, 149), 3), platform.X + 3, platform.Y + 3, platform.X + platform.Width - 3, platform.Y + 3);
        }

        public void DrawSpike(Graphics g, Spike spike)
        {
            g.DrawImage(spike.Texture, spike.X, spike.Y, spike.Width, spike.Height);
        }

        public void DrawEntity(Graphics g, Entity entity)
        {
            g.DrawImage(entity.EntitySprite, entity.X, entity.Y, entity.Width, entity.Height);
        }

        public void DrawEntityHealthBar(Graphics g, Entity entity)
        {
            if (Level.CurrentLevel == 4)
            {
                g.FillRectangle(hpBarBrush3, entity.X + 6, entity.Y - 24, 12 * entity.LivesAmount + 8, 10);
                g.FillRectangle(hpBarBrush1, entity.X + 8, entity.Y - 22, 12 * entity.LivesAmount + 4, 6);
                g.FillRectangle(hpBarBrush2, entity.X + 10, entity.Y - 20, 12 * entity.LivesAmount, 2);
            }
        }

        public void DrawFireball(Graphics g, Fireball fireball)
        {
            g.DrawImage(fireball.BlockTexture, fireball.X, fireball.Y, fireball.Width, fireball.Height);
        }

        public void DrawXPBlock(Graphics g, XPBlock xpBlock)
        {
            g.DrawImage(xpBlock.BlockTexture, xpBlock.X, xpBlock.Y, xpBlock.Width, xpBlock.Height);
        }

        public void DrawExpBar(Graphics g, Player player, int x, int y)
        {
            g.DrawString("XP:", pix14, whiteBrush, x, y - 34);  //XP Label
            g.DrawString($"{ player.ExpCount } / { Level.XPCount }", pix12, whiteBrush, x, y + 27); //expCount Label
            g.DrawString($"Level: { player.ExpLevel,-1 }", pix12, whiteBrush, x + 80, y + 27);  //expLevel Label

            g.DrawRectangle(expBarPen, x, y, 140, 20);

            float delta = 0;
            if (Level.XPCount != 0)
            {
                delta = 140 / Level.XPCount;
            }

            for (int i = 1; i <= player.ExpCount; i++)
            {
                g.FillRectangle(xpBrush, x + 3, y + 3, delta * i, 14);
            }
        }

        public void DrawGUI(Graphics g, Player player, GUI gui, int x, int y)
        {
            g.DrawString("HP:", pix14, whiteBrush, x, y - 30);

            for (byte i = 0; i < player.LivesAmount; i++)
            {
                g.DrawImage(gui.LivesSprite, x + i * 30, y, 22, 22);
            }

            if (player.CanDoubleJump)
            {
                g.DrawImage(gui.DoubleJumpBonusSprite, x + 5, y + 165, 48, 48);
                g.DrawString(" -  Double\r\n Jump\r\n", pix12, whiteBrush, x + 53, y + 165);
                g.DrawString("   (Press Space x2)", pix8, cyanBrush, x + 43, y + 205);
            }

            if (player.CanDash)
            {
                g.DrawImage(gui.DashBonusSprite, x + 5, y + 245, 48, 48);
                g.DrawString(" -  Dash", pix12, whiteBrush, x + 53, y + 245);
                g.DrawString("   (Press X)", pix8, cyanBrush, x + 53, y + 270);
            }

            if (player.CanShoot)
            {
                g.DrawImage(gui.FireCharmBonusSprite, x + 5, y + 315, 48, 48);
                g.DrawString(" -  Fire\r\n Charm", pix12, whiteBrush, x + 53, y + 315);
                g.DrawString("   (Press Z)", pix8, cyanBrush, x + 53, y + 360);
            }

            g.DrawString("Time: ", pix14, whiteBrush, new Point(x + 5, y + 400));
            g.DrawString($"{gui.TimeGUI.Minutes:00}:{gui.TimeGUI.Seconds:00}", pix14, whiteBrush, new Point(x + 5, y + 430));

            g.DrawString($"Attempt: {Level.Attempts}", pix14, whiteBrush, new Point(x + 5, y + 480));
        }

        public void DrawEntityBorderLines(Graphics g, Entity entity)
        {
            g.DrawLine(new Pen(Color.FromArgb(0, 155, 78), 1), entity.MoveStart, 0, entity.MoveStart, 600);
            g.DrawLine(new Pen(Color.FromArgb(0, 155, 78), 1), entity.MoveEnd, 0, entity.MoveEnd, 600);
        }

        public void DrawSpawnPoint(Graphics g, Point coords)
        {
            g.FillRectangle(whiteBrush, coords.X, coords.Y, 10, 10);
        }
    }
}
