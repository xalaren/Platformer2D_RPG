using Platformer_2D_RPG.Editor;
using Platformer_2D_RPG.Game;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_2D_RPG
{
    public partial class GameWindow : Form
    {
        PictureBox renderBox;
        GameCore gameCore;
        ObjectsDrawer drawer;
        GUI gui;

        Frame mainFrame;
        Player player;
        Ground ground;
        Time time = new Time();


        Timer mainTimer;
        Timer reloadTimer;
        Label gameInfoText;
        Label timeText;
        Label attemptText;
        Button restartButton;
        Button exitButton;

        public GameWindow()
        {
            InitializeComponent();

            mainTimer = new Timer
            {
                Interval = 10
            };

            reloadTimer = new Timer
            {
                Interval = 100
            };

            renderBox = new PictureBox
            {
                Location = new Point(0, 0),
                Size = new Size(this.Width, this.Height),
                BackColor = Color.Transparent,
            };
            Controls.Add(renderBox);

            Level.LevelChanged += OnLevelChanged;  //Обработчик события при изменении уровня
            mainTimer.Tick += new EventHandler(Update);
            reloadTimer.Tick += new EventHandler(ReloadTimerHandler);
            renderBox.Paint += new PaintEventHandler(Render);

            Init();
            renderBox.Refresh();
        }

        public void Init()
        {
            InitControls();

            Level.IsGameOver = false;
            Level.IsGameEnd = false;

            LevelInit();

            if (!Level.IsLoadCustomLevel)
            {
                this.Text = $"Level { Level.CurrentLevel }";
            }
            else
            {
                this.Text = $"Level { Level.CustomLevelName }";
            }

            gameCore = new GameCore();
            drawer = new ObjectsDrawer();
            mainFrame = gameCore.frame;
            ground = gameCore.ground;
            player = gameCore.player;
            gui = new GUI(time);

            gameCore.ActivateLevelBonus(Level.CurrentLevel);
            mainTimer.Start();
        }

        private void InitControls()
        {
            gameInfoText = new Label
            {
                Location = new Point(this.Width / 2 - 150, this.Height / 2 - 100),
                Size = new Size(700, 100),
                ForeColor = Color.White,
                BackColor = this.BackColor,
                Font = new Font("Segoe UI Semibold", 35),
                Text = "Game Over"
            };

            timeText = new Label
            {
                Location = new Point(this.Width - 250, this.Height - 150),
                Size = new Size(300, 50),
                ForeColor = Color.White,
                BackColor = this.BackColor,
                Font = new Font("Segoe UI Semibold", 16),
                Text = Level.TimeResult
            };

            attemptText = new Label
            {
                Location = new Point(this.Width - 250, this.Height - 100),
                Size = new Size(300, 50),
                ForeColor = Color.White,
                BackColor = this.BackColor,
                Font = new Font("Segoe UI Semibold", 16),
                Text = $"Attempts: {Level.Attempts}",
                Visible = false
            };

            restartButton = new Button
            {
                Location = new Point(this.Width / 2 - 130, gameInfoText.Bottom + 30),
                Size = new Size(70, 70),
                BackColor = Color.FromArgb(39, 45, 58),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 18),
                FlatStyle = FlatStyle.Flat,
                Image = TexturesResourceFile.playIcon
            };

            exitButton = new Button
            {
                Location = new Point(restartButton.Right + 100, gameInfoText.Bottom + 30),
                Size = new Size(70, 70),
                BackColor = Color.FromArgb(39, 45, 58),
                ForeColor = Color.White,
                Font = new Font("Segoe UI Semibold", 14),
                FlatStyle = FlatStyle.Flat,
                Image = TexturesResourceFile.menuIcon
            };

            exitButton.FlatAppearance.BorderSize = 0;
            restartButton.FlatAppearance.BorderSize = 0;

            restartButton.Click += new EventHandler(RestartButton_Click);
            exitButton.Click += new EventHandler(ExitButton_Click);

        }

        private void Render(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            if (!Level.IsGameOver && !Level.IsGameEnd)
            {
                drawer.DrawGround(graphics, ground);
                drawer.DrawFrame(graphics, Color.FromArgb(50, 50, 50), mainFrame);
                drawer.DrawExpBar(graphics, player, 810, 120);
                if (gameCore.LevelCompare() || Level.XPCount == 0)
                {
                    drawer.DrawLevelEndBlock(graphics, gameCore.levelEndBlock);
                }
                drawer.DrawGUI(graphics, player, gui, 805, 35);
                drawer.DrawPlayer(graphics, player);

                gameCore.platformController.Draw(graphics, drawer);
                gameCore.spikeController.Draw(graphics, drawer);
                gameCore.xpBlockController.Draw(graphics, drawer);
                gameCore.entityController.Draw(graphics, drawer);
                gameCore.fireballController.Draw(graphics, drawer);
            }
            else
            {
                graphics.Clear(this.BackColor);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (!Level.IsGameOver && !Level.IsGameEnd)
            {
                gameCore.LinkGameCore();
                SetTime();
            }
            else
            {
                OnGameEnd();
            }

            renderBox.Refresh();
        }

        private void SetTime()
        {
            if (time.Milliseconds <= 60)
            {
                time.Milliseconds++;
            }
            else if (time.Seconds <= 60)
            {
                time.Milliseconds = 0;
                time.Seconds++;
            }
            else if (time.Minutes <= 60)
            {
                time.Seconds = 0;
                time.Minutes++;
            }
        }

        private void OnGameEnd()
        {
            Level.TimeResult = time.GetTime();
            timeText.Text = Level.TimeResult;
            time.Clear();

            GameInfoMenu();
            mainTimer.Stop();
            SaveResult();
        }

        private void SaveResult()
        {
            if (Level.IsGameEnd)
            {
                Files files = new Files();
                files.ToCatalog(@"\");

                string levelType = (Level.IsLoadCustomLevel) ? $"Custom Level: {Level.CustomLevelName}" : "Internal Level";
                files.SaveItemsLine(FilesName.ScoresFile, "Time: " + Level.TimeResult + "\tAttempts: " + Level.Attempts + "    \t" + levelType);
            }
        }
        private void ReloadTimerHandler(object sender, EventArgs e)
        {
            if (gameCore.ReloadTime <= 400)
            {
                gameCore.ReloadTime += reloadTimer.Interval;
            }
            else
            {
                reloadTimer.Stop();
                gameCore.ReloadTime = 0;
            }
        }

        private void GameInfoMenu()
        {
            if (Level.IsGameOver)
            {
                gameInfoText.Text = "Game Over";
                gameInfoText.Location = new Point(this.Width / 2 - 150, this.Height / 2 - 100);
                gameInfoText.Size = new Size(330, 100);
            }
            else
            {
                gameInfoText.Text = "Game Completed";
                gameInfoText.Location = new Point(this.Width / 2 - 210, this.Height / 2 - 100);
                gameInfoText.Size = new Size(500, 100);
                attemptText.Visible = true;
            }

            Controls.Add(gameInfoText);
            Controls.Add(timeText);
            Controls.Add(attemptText);
            Controls.Add(restartButton);
            Controls.Add(exitButton);

            gameInfoText.BringToFront();
            timeText.BringToFront();
            attemptText.BringToFront();
            restartButton.BringToFront();
            exitButton.BringToFront();
        }

        private void RestartGame()
        {
            Controls.Remove(gameInfoText);
            Controls.Remove(timeText);
            Controls.Remove(attemptText);
            Controls.Remove(restartButton);
            Controls.Remove(exitButton);
            Init();
        }

        private void LevelInit()
        {
            if (!Level.IsLoadCustomLevel)
            {
                switch (Level.CurrentLevel)
                {
                    case 1:
                        Level.LoadLevel1();
                        break;
                    case 2:
                        Level.LoadLevel2();
                        break;
                    case 3:
                        Level.LoadLevel3();
                        break;
                    case 4:
                        Level.LoadLevel4();
                        break;
                    default:
                        Level.LoadLevel1();
                        break;
                }
            }
            else
            {
                Level.LoadCustomLevel();
            }
        }

        private void OnLevelChanged()
        {
            RestartGame();
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            mainTimer.Stop();
            this.Close();
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                gameCore.AllowActions(GameCore.Actions.MoveLeft);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                gameCore.AllowActions(GameCore.Actions.MoveRight);
            }
            else if (e.KeyCode == Keys.Space)
            {
                gameCore.AllowActions(GameCore.Actions.Jump);
            }
            else if (e.KeyCode == Keys.X)
            {
                gameCore.AllowActions(GameCore.Actions.Dash);
            }
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                gameCore.DisableActions(GameCore.Actions.MoveLeft);
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                gameCore.DisableActions(GameCore.Actions.MoveRight);
            }
            else if (e.KeyCode == Keys.X)
            {
                gameCore.DisableActions(GameCore.Actions.Dash);
            }
            else if (e.KeyCode == Keys.Z)
            {
                if (!reloadTimer.Enabled)
                {
                    gameCore.DisableActions(GameCore.Actions.Shoot);
                    reloadTimer.Start();
                }
            }
        }
    }
}
