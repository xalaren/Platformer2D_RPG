
namespace Platformer_2D_RPG
{
    partial class StartWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameNameLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.playLabel = new System.Windows.Forms.Label();
            this.editorLabel = new System.Windows.Forms.Label();
            this.editorButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.scoresButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.gameNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gameNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameNameLabel.ForeColor = System.Drawing.Color.White;
            this.gameNameLabel.Location = new System.Drawing.Point(12, 22);
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(265, 40);
            this.gameNameLabel.TabIndex = 0;
            this.gameNameLabel.Text = "Platformer 2D RPG";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Minecrafter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Image = global::Platformer_2D_RPG.TexturesResourceFile.playIcon;
            this.playButton.Location = new System.Drawing.Point(10, 113);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(60, 60);
            this.playButton.TabIndex = 1;
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // playLabel
            // 
            this.playLabel.AutoSize = true;
            this.playLabel.BackColor = System.Drawing.Color.Transparent;
            this.playLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.playLabel.Location = new System.Drawing.Point(94, 133);
            this.playLabel.Name = "playLabel";
            this.playLabel.Size = new System.Drawing.Size(48, 25);
            this.playLabel.TabIndex = 2;
            this.playLabel.Text = "Play";
            // 
            // editorLabel
            // 
            this.editorLabel.AutoSize = true;
            this.editorLabel.BackColor = System.Drawing.Color.Transparent;
            this.editorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.editorLabel.Location = new System.Drawing.Point(94, 224);
            this.editorLabel.Name = "editorLabel";
            this.editorLabel.Size = new System.Drawing.Size(63, 25);
            this.editorLabel.TabIndex = 4;
            this.editorLabel.Text = "Editor";
            // 
            // editorButton
            // 
            this.editorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.editorButton.BackgroundImage = global::Platformer_2D_RPG.TexturesResourceFile.editorIcon;
            this.editorButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.editorButton.FlatAppearance.BorderSize = 0;
            this.editorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editorButton.Font = new System.Drawing.Font("Minecrafter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorButton.ForeColor = System.Drawing.Color.White;
            this.editorButton.Location = new System.Drawing.Point(10, 204);
            this.editorButton.Name = "editorButton";
            this.editorButton.Size = new System.Drawing.Size(60, 60);
            this.editorButton.TabIndex = 3;
            this.editorButton.UseVisualStyleBackColor = false;
            this.editorButton.Click += new System.EventHandler(this.editorButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.infoLabel.Location = new System.Drawing.Point(379, 433);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(193, 19);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Created by: Валерий Иманов";
            // 
            // scoresButton
            // 
            this.scoresButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.scoresButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.scoresButton.FlatAppearance.BorderSize = 0;
            this.scoresButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scoresButton.Font = new System.Drawing.Font("Minecrafter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresButton.ForeColor = System.Drawing.Color.White;
            this.scoresButton.Image = global::Platformer_2D_RPG.TexturesResourceFile.scoresIcon;
            this.scoresButton.Location = new System.Drawing.Point(10, 297);
            this.scoresButton.Name = "scoresButton";
            this.scoresButton.Size = new System.Drawing.Size(60, 60);
            this.scoresButton.TabIndex = 6;
            this.scoresButton.UseVisualStyleBackColor = false;
            this.scoresButton.Click += new System.EventHandler(this.scoresButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(94, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scores";
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.BackgroundImage = global::Platformer_2D_RPG.TexturesResourceFile.menu_bg;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoresButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.editorLabel);
            this.Controls.Add(this.editorButton);
            this.Controls.Add(this.playLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.gameNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "StartWindow";
            this.Text = "Platformer 2D RPG";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameNameLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label playLabel;
        private System.Windows.Forms.Label editorLabel;
        private System.Windows.Forms.Button editorButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button scoresButton;
        private System.Windows.Forms.Label label1;
    }
}