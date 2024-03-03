
namespace Platformer_2D_RPG
{
    partial class GameEditor
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
            this.components = new System.ComponentModel.Container();
            this.platformCheck = new System.Windows.Forms.RadioButton();
            this.spikeCheck = new System.Windows.Forms.RadioButton();
            this.xpBlockCheck = new System.Windows.Forms.RadioButton();
            this.entityCheck = new System.Windows.Forms.RadioButton();
            this.pointXBox = new System.Windows.Forms.NumericUpDown();
            this.spawnPointButton = new System.Windows.Forms.Button();
            this.setEndPointBlock = new System.Windows.Forms.Button();
            this.pointYBox = new System.Windows.Forms.NumericUpDown();
            this.widthBox = new System.Windows.Forms.NumericUpDown();
            this.heightBox = new System.Windows.Forms.NumericUpDown();
            this.posX_Label = new System.Windows.Forms.Label();
            this.posY_Label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.NumericUpDown();
            this.speedLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.entBorderBox1 = new System.Windows.Forms.NumericUpDown();
            this.border1_Label = new System.Windows.Forms.Label();
            this.entBorderBox2 = new System.Windows.Forms.NumericUpDown();
            this.border2_Label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.workSpaceBox = new System.Windows.Forms.PictureBox();
            this.objectsComboBox = new System.Windows.Forms.ComboBox();
            this.objectsListLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pointXBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entBorderBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entBorderBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSpaceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // platformCheck
            // 
            this.platformCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.platformCheck.AutoSize = true;
            this.platformCheck.FlatAppearance.BorderSize = 0;
            this.platformCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.platformCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.platformCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.platformCheck.ForeColor = System.Drawing.Color.White;
            this.platformCheck.Location = new System.Drawing.Point(806, 234);
            this.platformCheck.Name = "platformCheck";
            this.platformCheck.Size = new System.Drawing.Size(83, 31);
            this.platformCheck.TabIndex = 1;
            this.platformCheck.TabStop = true;
            this.platformCheck.Text = "Platform";
            this.platformCheck.UseVisualStyleBackColor = true;
            // 
            // spikeCheck
            // 
            this.spikeCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.spikeCheck.AutoSize = true;
            this.spikeCheck.FlatAppearance.BorderSize = 0;
            this.spikeCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.spikeCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spikeCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spikeCheck.ForeColor = System.Drawing.Color.White;
            this.spikeCheck.Location = new System.Drawing.Point(806, 269);
            this.spikeCheck.Name = "spikeCheck";
            this.spikeCheck.Size = new System.Drawing.Size(60, 31);
            this.spikeCheck.TabIndex = 2;
            this.spikeCheck.TabStop = true;
            this.spikeCheck.Text = "Spike";
            this.spikeCheck.UseVisualStyleBackColor = true;
            // 
            // xpBlockCheck
            // 
            this.xpBlockCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.xpBlockCheck.AutoSize = true;
            this.xpBlockCheck.FlatAppearance.BorderSize = 0;
            this.xpBlockCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.xpBlockCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xpBlockCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xpBlockCheck.ForeColor = System.Drawing.Color.White;
            this.xpBlockCheck.Location = new System.Drawing.Point(806, 304);
            this.xpBlockCheck.Name = "xpBlockCheck";
            this.xpBlockCheck.Size = new System.Drawing.Size(79, 31);
            this.xpBlockCheck.TabIndex = 3;
            this.xpBlockCheck.TabStop = true;
            this.xpBlockCheck.Text = "XPBlock";
            this.xpBlockCheck.UseVisualStyleBackColor = true;
            // 
            // entityCheck
            // 
            this.entityCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.entityCheck.AutoSize = true;
            this.entityCheck.FlatAppearance.BorderSize = 0;
            this.entityCheck.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.entityCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.entityCheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.entityCheck.ForeColor = System.Drawing.Color.White;
            this.entityCheck.Location = new System.Drawing.Point(806, 339);
            this.entityCheck.Name = "entityCheck";
            this.entityCheck.Size = new System.Drawing.Size(61, 31);
            this.entityCheck.TabIndex = 4;
            this.entityCheck.TabStop = true;
            this.entityCheck.Text = "Entity";
            this.entityCheck.UseVisualStyleBackColor = true;
            // 
            // pointXBox
            // 
            this.pointXBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointXBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointXBox.ForeColor = System.Drawing.Color.Black;
            this.pointXBox.Location = new System.Drawing.Point(806, 39);
            this.pointXBox.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.pointXBox.Name = "pointXBox";
            this.pointXBox.Size = new System.Drawing.Size(60, 33);
            this.pointXBox.TabIndex = 5;
            // 
            // spawnPointButton
            // 
            this.spawnPointButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.spawnPointButton.FlatAppearance.BorderSize = 0;
            this.spawnPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.spawnPointButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spawnPointButton.ForeColor = System.Drawing.Color.White;
            this.spawnPointButton.Location = new System.Drawing.Point(806, 374);
            this.spawnPointButton.Name = "spawnPointButton";
            this.spawnPointButton.Size = new System.Drawing.Size(134, 47);
            this.spawnPointButton.TabIndex = 6;
            this.spawnPointButton.Text = "SetSpawnPoint";
            this.spawnPointButton.UseVisualStyleBackColor = false;
            this.spawnPointButton.Click += new System.EventHandler(this.spawnPointButton_Click);
            // 
            // setEndPointBlock
            // 
            this.setEndPointBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.setEndPointBlock.FlatAppearance.BorderSize = 0;
            this.setEndPointBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setEndPointBlock.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setEndPointBlock.ForeColor = System.Drawing.Color.White;
            this.setEndPointBlock.Location = new System.Drawing.Point(806, 438);
            this.setEndPointBlock.Name = "setEndPointBlock";
            this.setEndPointBlock.Size = new System.Drawing.Size(134, 47);
            this.setEndPointBlock.TabIndex = 7;
            this.setEndPointBlock.Text = "SetEndPoint";
            this.setEndPointBlock.UseVisualStyleBackColor = false;
            this.setEndPointBlock.Click += new System.EventHandler(this.setEndPointBlock_Click);
            // 
            // pointYBox
            // 
            this.pointYBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointYBox.Location = new System.Drawing.Point(890, 39);
            this.pointYBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.pointYBox.Name = "pointYBox";
            this.pointYBox.Size = new System.Drawing.Size(60, 33);
            this.pointYBox.TabIndex = 8;
            // 
            // widthBox
            // 
            this.widthBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthBox.Location = new System.Drawing.Point(806, 112);
            this.widthBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(60, 33);
            this.widthBox.TabIndex = 9;
            // 
            // heightBox
            // 
            this.heightBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightBox.Location = new System.Drawing.Point(890, 112);
            this.heightBox.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.heightBox.Name = "heightBox";
            this.heightBox.Size = new System.Drawing.Size(60, 33);
            this.heightBox.TabIndex = 10;
            // 
            // posX_Label
            // 
            this.posX_Label.AutoSize = true;
            this.posX_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posX_Label.ForeColor = System.Drawing.Color.White;
            this.posX_Label.Location = new System.Drawing.Point(806, 9);
            this.posX_Label.Name = "posX_Label";
            this.posX_Label.Size = new System.Drawing.Size(20, 21);
            this.posX_Label.TabIndex = 11;
            this.posX_Label.Text = "X";
            // 
            // posY_Label
            // 
            this.posY_Label.AutoSize = true;
            this.posY_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.posY_Label.ForeColor = System.Drawing.Color.White;
            this.posY_Label.Location = new System.Drawing.Point(886, 9);
            this.posY_Label.Name = "posY_Label";
            this.posY_Label.Size = new System.Drawing.Size(19, 21);
            this.posY_Label.TabIndex = 12;
            this.posY_Label.Text = "Y";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_label.ForeColor = System.Drawing.Color.White;
            this.width_label.Location = new System.Drawing.Point(806, 81);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(54, 21);
            this.width_label.TabIndex = 13;
            this.width_label.Text = "Width";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_label.ForeColor = System.Drawing.Color.White;
            this.height_label.Location = new System.Drawing.Point(891, 81);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(60, 21);
            this.height_label.TabIndex = 14;
            this.height_label.Text = "Height";
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(987, 243);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 40);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(987, 289);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 40);
            this.removeButton.TabIndex = 16;
            this.removeButton.Text = "-";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speedBox.Location = new System.Drawing.Point(806, 194);
            this.speedBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speedBox.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(60, 33);
            this.speedBox.TabIndex = 17;
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.speedLabel.ForeColor = System.Drawing.Color.White;
            this.speedLabel.Location = new System.Drawing.Point(806, 161);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(57, 21);
            this.speedLabel.TabIndex = 18;
            this.speedLabel.Text = "Speed";
            // 
            // setButton
            // 
            this.setButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.setButton.FlatAppearance.BorderSize = 0;
            this.setButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setButton.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.setButton.ForeColor = System.Drawing.Color.White;
            this.setButton.Location = new System.Drawing.Point(988, 335);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(75, 42);
            this.setButton.TabIndex = 19;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = false;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(806, 502);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(134, 47);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // entBorderBox1
            // 
            this.entBorderBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entBorderBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entBorderBox1.ForeColor = System.Drawing.Color.Black;
            this.entBorderBox1.Location = new System.Drawing.Point(890, 194);
            this.entBorderBox1.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.entBorderBox1.Name = "entBorderBox1";
            this.entBorderBox1.Size = new System.Drawing.Size(60, 33);
            this.entBorderBox1.TabIndex = 21;
            // 
            // border1_Label
            // 
            this.border1_Label.AutoSize = true;
            this.border1_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border1_Label.ForeColor = System.Drawing.Color.White;
            this.border1_Label.Location = new System.Drawing.Point(887, 163);
            this.border1_Label.Name = "border1_Label";
            this.border1_Label.Size = new System.Drawing.Size(90, 21);
            this.border1_Label.TabIndex = 22;
            this.border1_Label.Text = "EntBorder1";
            // 
            // entBorderBox2
            // 
            this.entBorderBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.entBorderBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entBorderBox2.ForeColor = System.Drawing.Color.Black;
            this.entBorderBox2.Location = new System.Drawing.Point(987, 194);
            this.entBorderBox2.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.entBorderBox2.Name = "entBorderBox2";
            this.entBorderBox2.Size = new System.Drawing.Size(60, 33);
            this.entBorderBox2.TabIndex = 23;
            // 
            // border2_Label
            // 
            this.border2_Label.AutoSize = true;
            this.border2_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.border2_Label.ForeColor = System.Drawing.Color.White;
            this.border2_Label.Location = new System.Drawing.Point(984, 163);
            this.border2_Label.Name = "border2_Label";
            this.border2_Label.Size = new System.Drawing.Size(93, 21);
            this.border2_Label.TabIndex = 24;
            this.border2_Label.Text = "EntBorder2";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // workSpaceBox
            // 
            this.workSpaceBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(26)))), ((int)(((byte)(37)))));
            this.workSpaceBox.Location = new System.Drawing.Point(0, 0);
            this.workSpaceBox.Name = "workSpaceBox";
            this.workSpaceBox.Size = new System.Drawing.Size(800, 600);
            this.workSpaceBox.TabIndex = 0;
            this.workSpaceBox.TabStop = false;
            this.workSpaceBox.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            // 
            // objectsComboBox
            // 
            this.objectsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.objectsComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.objectsComboBox.FormattingEnabled = true;
            this.objectsComboBox.Location = new System.Drawing.Point(975, 39);
            this.objectsComboBox.Name = "objectsComboBox";
            this.objectsComboBox.Size = new System.Drawing.Size(87, 33);
            this.objectsComboBox.TabIndex = 25;
            this.objectsComboBox.SelectedIndexChanged += new System.EventHandler(this.objectsComboBox_SelectedIndexChanged);
            // 
            // objectsListLabel
            // 
            this.objectsListLabel.AutoSize = true;
            this.objectsListLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.objectsListLabel.ForeColor = System.Drawing.Color.White;
            this.objectsListLabel.Location = new System.Drawing.Point(972, 11);
            this.objectsListLabel.Name = "objectsListLabel";
            this.objectsListLabel.Size = new System.Drawing.Size(70, 21);
            this.objectsListLabel.TabIndex = 26;
            this.objectsListLabel.Text = "Objects:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.clearButton.FlatAppearance.BorderSize = 0;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.ForeColor = System.Drawing.Color.White;
            this.clearButton.Location = new System.Drawing.Point(987, 107);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 42);
            this.clearButton.TabIndex = 27;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(1022, 502);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 50);
            this.backButton.TabIndex = 28;
            this.backButton.Text = "«";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // GameEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.objectsListLabel);
            this.Controls.Add(this.objectsComboBox);
            this.Controls.Add(this.border2_Label);
            this.Controls.Add(this.entBorderBox2);
            this.Controls.Add(this.border1_Label);
            this.Controls.Add(this.entBorderBox1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedBox);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.posY_Label);
            this.Controls.Add(this.posX_Label);
            this.Controls.Add(this.heightBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.pointYBox);
            this.Controls.Add(this.setEndPointBlock);
            this.Controls.Add(this.spawnPointButton);
            this.Controls.Add(this.pointXBox);
            this.Controls.Add(this.entityCheck);
            this.Controls.Add(this.xpBlockCheck);
            this.Controls.Add(this.spikeCheck);
            this.Controls.Add(this.platformCheck);
            this.Controls.Add(this.workSpaceBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameEditor";
            this.Text = "GameEditor";
            ((System.ComponentModel.ISupportInitialize)(this.pointXBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointYBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entBorderBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entBorderBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workSpaceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox workSpaceBox;
        private System.Windows.Forms.RadioButton platformCheck;
        private System.Windows.Forms.RadioButton spikeCheck;
        private System.Windows.Forms.RadioButton xpBlockCheck;
        private System.Windows.Forms.RadioButton entityCheck;
        private System.Windows.Forms.NumericUpDown pointXBox;
        private System.Windows.Forms.Button spawnPointButton;
        private System.Windows.Forms.Button setEndPointBlock;
        private System.Windows.Forms.NumericUpDown pointYBox;
        private System.Windows.Forms.NumericUpDown widthBox;
        private System.Windows.Forms.NumericUpDown heightBox;
        private System.Windows.Forms.Label posX_Label;
        private System.Windows.Forms.Label posY_Label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.NumericUpDown speedBox;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown entBorderBox1;
        private System.Windows.Forms.Label border1_Label;
        private System.Windows.Forms.NumericUpDown entBorderBox2;
        private System.Windows.Forms.Label border2_Label;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox objectsComboBox;
        private System.Windows.Forms.Label objectsListLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button backButton;
    }
}