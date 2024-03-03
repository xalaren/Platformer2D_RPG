using Platformer_2D_RPG.Editor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Platformer_2D_RPG
{
    public partial class RecordsWindow : Form
    {
        public RecordsWindow()
        {
            InitializeComponent();
            LoadResults();
        }

        private void LoadResults()
        {
            Files files = new Files();
            recordsListBox.Items.Clear();
            files.ToCatalog(@"\");

            List<string> items = files.LoadItems(FilesName.ScoresFile);

            for (int i = 0; i < items.Count; i++)
            {
                recordsListBox.Items.Add(i + 1 + ".    " + items[i]);
            }
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Files files = new Files();
            recordsListBox.Items.Clear();
            files.ToCatalog(@"\");

            files.DeleteFile(FilesName.ScoresFile);
        }
    }
}
