using Platformer_2D_RPG.Editor;
using Platformer_2D_RPG.Game;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Platformer_2D_RPG
{
    public partial class EditorMenu : Form
    {
        Files files;

        public EditorMenu()
        {
            InitializeComponent();
            files = new Files();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            levelsListBox.Items.Clear();
            files.ToCatalog(@"\");

            List<string> items = files.LoadItems(FilesName.LevelsFile);

            for (int i = 0; i < items.Count; i++)
            {
                levelsListBox.Items.Add(items[i]);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(levelNameTextBox.Text))
            {
                levelsListBox.Items.Add(levelNameTextBox.Text);
                FilesName.DirName = levelNameTextBox.Text + "_Level";
                files.ToCatalog(FilesName.DirName);
            }
            levelNameTextBox.Text = "";
            SaveListBox();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (levelsListBox.Items.Count > 0 && levelsListBox.SelectedIndex >= 0)
            {
                files.ToCatalog(FilesName.DirName);
                files.DeleteDirectory(FilesName.DirName);
                levelsListBox.Items.Remove(levelsListBox.SelectedItem);
            }

            SaveListBox();
        }

        private void SaveListBox()
        {
            files.ToCatalog(@"\");
            files.DeleteFile(FilesName.LevelsFile);
            for (int i = 0; i < levelsListBox.Items.Count; i++)
            {
                files.SaveItemsLine(FilesName.LevelsFile, levelsListBox.Items[i].ToString());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            int index = levelsListBox.SelectedIndex;
            if (levelsListBox.SelectedIndex >= 0)
            {
                files.ToCatalog(FilesName.DirName);
                ActivateGameEditor();
                this.Visible = false;
            }

        }

        private void ActivateGameEditor()
        {
            GameEditor gameEditor = new GameEditor();
            gameEditor.Show();
            gameEditor.FormClosed += GameEditor_FormClosed;
        }

        private void ActivateGameForm()
        {
            GameWindow gameWindow = new GameWindow();
            gameWindow.FormClosed += GameWindow_FormClosed;
            gameWindow.Show();
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void GameEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (levelsListBox.SelectedIndex >= 0)
            {
                files.ToCatalog(FilesName.DirName);
                Level.InitCustomLevel();
                ActivateGameForm();
                this.Visible = false;
            }
        }

        private void levelsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (levelsListBox.SelectedIndex >= 0)
            {
                FilesName.DirName = levelsListBox.SelectedItem + "_Level";
            }
        }

        private void levelNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) | (e.KeyChar == (char)Keys.Back) | (e.KeyChar == (char)Keys.Enter))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
