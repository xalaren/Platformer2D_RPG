using Platformer_2D_RPG.Editor;
using Platformer_2D_RPG.Game;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Platformer_2D_RPG
{
    public partial class GameEditor : Form
    {
        EditorCore editorCore;
        ObjectsDrawer objectsDrawer;

        private int index;
        Point coords;
        Size size;
        (int x1, int x2) borders;
        int speed;

        enum GameObjects
        {
            Spawnpoint,
            Endpoint,
            Platform,
            Spike,
            XPBlock,
            Entity
        }

        public GameEditor()
        {
            InitializeComponent();

            editorCore = new EditorCore();
            objectsDrawer = new ObjectsDrawer();

            platformCheck.CheckedChanged += RadioButtonsCheckedChanged;
            spikeCheck.CheckedChanged += RadioButtonsCheckedChanged;
            xpBlockCheck.CheckedChanged += RadioButtonsCheckedChanged;
            entityCheck.CheckedChanged += RadioButtonsCheckedChanged;

            FillComboBox();
            timer1.Start();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            editorCore.DrawObjects(g, objectsDrawer);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            coords = GetPoint();
            if (platformCheck.Checked)
            {
                if (CheckZeroBoxes(GameObjects.Platform))
                {
                    size = GetSize();
                    editorCore.AddPlatform(coords.X, coords.Y, size.Width, size.Height);
                    FillComboBox();
                    ResetBoxes();
                }
                else
                {
                    MessageBox.Show("Fill boxes!", "Unavailable");
                }
            }
            else if (spikeCheck.Checked)
            {
                if (CheckZeroBoxes(GameObjects.Spike))
                {
                    editorCore.AddSpike(coords.X, coords.Y);
                    FillComboBox();
                    ResetBoxes();
                }
                else
                {
                    MessageBox.Show("Fill boxes!", "Unavailable");
                }
            }
            else if (xpBlockCheck.Checked)
            {
                if (CheckZeroBoxes(GameObjects.XPBlock))
                {
                    editorCore.AddXPBlock(coords.X, coords.Y);
                    FillComboBox();
                    ResetBoxes();
                }
                else
                {
                    MessageBox.Show("Fill boxes!", "Unavailable");
                }
            }
            else if (entityCheck.Checked)
            {
                if (CheckZeroBoxes(GameObjects.Entity))
                {
                    borders = GetBorderPoints();
                    speed = GetSpeedValue();
                    editorCore.AddEntity(coords.X, coords.Y, borders.x1, borders.x2, speed);
                    FillComboBox();
                    ResetBoxes();
                }
                else
                {
                    MessageBox.Show("Fill boxes!", "Unavailable");
                }
            }
        }

        private Point GetPoint()
        {
            return new Point((int)pointXBox.Value, (int)pointYBox.Value);
        }

        private (int, int) GetBorderPoints()
        {
            return ((int)entBorderBox1.Value, (int)entBorderBox2.Value);
        }

        private int GetSpeedValue()
        {
            return ((int)speedBox.Value);
        }

        private Size GetSize()
        {
            return new Size((int)widthBox.Value, (int)heightBox.Value);
        }

        private void Update(object sender, EventArgs e)
        {
            workSpaceBox.Invalidate();
        }

        private void ResetBoxes()
        {
            pointXBox.Value = 0;
            pointYBox.Value = 0;
            widthBox.Value = 0;
            heightBox.Value = 0;
            speedBox.Value = 0;
            entBorderBox1.Value = 0;
            entBorderBox2.Value = 0;
        }

        private bool CheckZeroBoxes(GameObjects item)
        {
            bool zeroBox = true;
            switch (item)
            {
                case GameObjects.Platform:
                    zeroBox = pointXBox.Value != 0 && pointYBox.Value != 0 &&
                        widthBox.Value != 0 && heightBox.Value != 0;
                    break;
                case GameObjects.Entity:
                    zeroBox = pointXBox.Value != 0 && pointYBox.Value != 0 &&
                        entBorderBox1.Value != 0 && entBorderBox2.Value != 0 &&
                        speedBox.Value != 0;
                    break;
                default:
                    zeroBox = pointXBox.Value != 0 && pointYBox.Value != 0;
                    break;
            }
            return zeroBox;
        }


        private void FillComboBox()
        {
            ResetBoxes();
            objectsComboBox.Items.Clear();
            if (platformCheck.Checked)
            {
                for (int i = 0; i < editorCore.Platforms.Count; i++)
                {
                    objectsComboBox.Items.Add(i + 1);
                }
            }
            else if (spikeCheck.Checked)
            {
                for (int i = 0; i < editorCore.Spikes.Count; i++)
                {
                    objectsComboBox.Items.Add(i + 1);
                }
            }
            else if (xpBlockCheck.Checked)
            {
                for (int i = 0; i < editorCore.XPBlocks.Count; i++)
                {
                    objectsComboBox.Items.Add(i + 1);
                }
            }
            else if (entityCheck.Checked)
            {
                for (int i = 0; i < editorCore.Entities.Count; i++)
                {
                    objectsComboBox.Items.Add(i + 1);
                }
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (platformCheck.Checked)
            {
                if (editorCore.Platforms.Count > 0)
                {
                    if (index > 0)
                    {
                        editorCore.RemovePlatform(index);
                        FillComboBox();
                    }
                    else
                    {
                        editorCore.RemovePlatform(0);
                        FillComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("No more platforms!", "Unavailable");
                }
            }
            else if (spikeCheck.Checked)
            {
                if (editorCore.Spikes.Count > 0)
                {
                    if (index > 0)
                    {
                        editorCore.RemoveSpike(index);
                        FillComboBox();
                    }
                    else
                    {
                        editorCore.RemoveSpike(0);
                        FillComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("No more spikes!", "Unavailable");
                }
            }
            else if (xpBlockCheck.Checked)
            {
                if (editorCore.XPBlocks.Count > 0)
                {
                    if (index > 0)
                    {
                        editorCore.RemoveXPBlock(index);
                        FillComboBox();
                    }
                    else
                    {
                        editorCore.RemoveXPBlock(0);
                        FillComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("No more XP blocks!", "Unavailable");
                }
            }
            else if (entityCheck.Checked)
            {
                if (editorCore.Entities.Count > 0)
                {
                    if (index > 0)
                    {
                        editorCore.RemoveEntity(index);
                        FillComboBox();
                    }
                    else
                    {
                        editorCore.RemoveEntity(0);
                        FillComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("No more entities!", "Unavailable");
                }
            }
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            coords = GetPoint();
            if (platformCheck.Checked)
            {
                if (objectsComboBox.SelectedIndex >= 0)
                {
                    index = objectsComboBox.SelectedIndex;
                    if (CheckZeroBoxes(GameObjects.Platform))
                    {
                        size = GetSize();
                        editorCore.EditPlatform(index, coords.X, coords.Y, size.Width, size.Height);
                    }
                }
                else
                {
                    MessageBox.Show("Select platform from list", "Unavailable");
                }
            }
            else if (spikeCheck.Checked)
            {
                if (objectsComboBox.SelectedIndex >= 0)
                {
                    index = objectsComboBox.SelectedIndex;
                    if (CheckZeroBoxes(GameObjects.Spike))
                    {
                        editorCore.EditSpike(index, coords.X, coords.Y);
                    }
                }
                else
                {
                    MessageBox.Show("Select spike from list", "Unavailable");
                }
            }
            else if (xpBlockCheck.Checked)
            {
                if (objectsComboBox.SelectedIndex >= 0)
                {
                    index = objectsComboBox.SelectedIndex;
                    if (CheckZeroBoxes(GameObjects.XPBlock))
                    {
                        editorCore.EditXPBlock(index, coords.X, coords.Y);
                    }
                }
                else
                {
                    MessageBox.Show("Select XP block from list", "Unavailable");
                }
            }
            else if (entityCheck.Checked)
            {
                if (objectsComboBox.SelectedIndex >= 0)
                {
                    index = objectsComboBox.SelectedIndex;
                    if (CheckZeroBoxes(GameObjects.Entity))
                    {
                        borders = GetBorderPoints();
                        speed = GetSpeedValue();
                        editorCore.EditEntity(index, coords.X, coords.Y, borders.x1, borders.x2, speed); ;
                    }
                }
                else
                {
                    MessageBox.Show("Select entity from list", "Unavailable");
                }
            }
        }

        private void objectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = objectsComboBox.SelectedIndex;
            if (platformCheck.Checked)
            {
                pointXBox.Value = editorCore.Platforms[index].X;
                pointYBox.Value = editorCore.Platforms[index].Y;
                widthBox.Value = editorCore.Platforms[index].Width;
                heightBox.Value = editorCore.Platforms[index].Height;
            }
            else if (spikeCheck.Checked)
            {
                pointXBox.Value = editorCore.Spikes[index].X;
                pointYBox.Value = editorCore.Spikes[index].Y;
            }
            else if (xpBlockCheck.Checked)
            {
                pointXBox.Value = editorCore.XPBlocks[index].X;
                pointYBox.Value = editorCore.XPBlocks[index].Y;
            }
            else if (entityCheck.Checked)
            {
                pointXBox.Value = editorCore.Entities[index].X;
                pointYBox.Value = editorCore.Entities[index].Y;
                entBorderBox1.Value = editorCore.Entities[index].MoveStart;
                entBorderBox2.Value = editorCore.Entities[index].MoveEnd;
                speedBox.Value = editorCore.Entities[index].Speed;
            }
        }

        private void spawnPointButton_Click(object sender, EventArgs e)
        {
            coords = GetPoint();
            editorCore.SetSpawnPoint(coords.X, coords.Y);
        }

        private void setEndPointBlock_Click(object sender, EventArgs e)
        {
            coords = GetPoint();
            editorCore.SetEndBlock(coords.X, coords.Y);
        }

        private void RadioButtonsCheckedChanged(object sender, EventArgs e)
        {
            FillComboBox();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ResetBoxes();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            editorCore.SaveFile();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
