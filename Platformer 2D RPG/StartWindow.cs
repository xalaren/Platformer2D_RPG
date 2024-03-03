using Platformer_2D_RPG.Game;
using System;
using System.Windows.Forms;

namespace Platformer_2D_RPG
{
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Level.InitInternalLevel();
            ActivateGameForm();
            this.Visible = false;
        }

        private void editorButton_Click(object sender, EventArgs e)
        {
            ActivateEditorMenuForm();
            this.Visible = false;
        }

        private void ActivateGameForm()
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.FormClosed += GameWindow_FormClosed;
            gameWindow.Show();
        }

        private void ActivateEditorMenuForm()
        {
            EditorMenu editorMenu = new EditorMenu();
            editorMenu.FormClosed += EditorMenu_FormClosed;
            editorMenu.Show();
        }

        private void ActivateRecordsForm()
        {
            RecordsWindow recordsWindow = new RecordsWindow();
            recordsWindow.FormClosed += RecordsWindow_FormClosed;
            recordsWindow.Show();
        }

        private void RecordsWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void EditorMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void scoresButton_Click(object sender, EventArgs e)
        {
            ActivateRecordsForm();
            this.Visible = false;
        }
    }
}
