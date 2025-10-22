namespace Susl_Jump
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelMainMenu = new System.Windows.Forms.Panel();
            this.buttonShop = new System.Windows.Forms.Button();
            this.buttonLeaders = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.pictureBoxBackground = new System.Windows.Forms.PictureBox();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelShieldKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelShootKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRightKey = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelLeftKey = new System.Windows.Forms.Label();
            this.panelLeaderboard = new System.Windows.Forms.Panel();
            this.buttonBack1 = new System.Windows.Forms.Button();
            this.textBoxLeaders = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panelMove = new System.Windows.Forms.Panel();
            this.panelShop = new System.Windows.Forms.Panel();
            this.labelShopInfo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonShieldBuy = new System.Windows.Forms.Button();
            this.buttonBack2 = new System.Windows.Forms.Button();
            this.panelMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).BeginInit();
            this.panelSettings.SuspendLayout();
            this.panelLeaderboard.SuspendLayout();
            this.panelShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMainMenu
            // 
            this.panelMainMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMainMenu.BackColor = System.Drawing.Color.Black;
            this.panelMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMainMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMainMenu.Controls.Add(this.buttonShop);
            this.panelMainMenu.Controls.Add(this.buttonLeaders);
            this.panelMainMenu.Controls.Add(this.buttonSettings);
            this.panelMainMenu.Controls.Add(this.buttonPlay);
            this.panelMainMenu.Location = new System.Drawing.Point(12, 50);
            this.panelMainMenu.MinimumSize = new System.Drawing.Size(400, 250);
            this.panelMainMenu.Name = "panelMainMenu";
            this.panelMainMenu.Size = new System.Drawing.Size(400, 250);
            this.panelMainMenu.TabIndex = 0;
            // 
            // buttonShop
            // 
            this.buttonShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonShop.BackColor = System.Drawing.Color.Black;
            this.buttonShop.BackgroundImage = global::Susl_Jump.Properties.Resources.dungeonBackground;
            this.buttonShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShop.CausesValidation = false;
            this.buttonShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShop.ForeColor = System.Drawing.Color.White;
            this.buttonShop.Location = new System.Drawing.Point(132, 81);
            this.buttonShop.Name = "buttonShop";
            this.buttonShop.Size = new System.Drawing.Size(210, 60);
            this.buttonShop.TabIndex = 0;
            this.buttonShop.TabStop = false;
            this.buttonShop.Text = "Shop";
            this.buttonShop.UseVisualStyleBackColor = false;
            this.buttonShop.Click += new System.EventHandler(this.buttonShop_Click);
            // 
            // buttonLeaders
            // 
            this.buttonLeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeaders.BackColor = System.Drawing.Color.Black;
            this.buttonLeaders.BackgroundImage = global::Susl_Jump.Properties.Resources.dungeonBackground;
            this.buttonLeaders.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLeaders.CausesValidation = false;
            this.buttonLeaders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLeaders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeaders.ForeColor = System.Drawing.Color.White;
            this.buttonLeaders.Location = new System.Drawing.Point(33, 147);
            this.buttonLeaders.Name = "buttonLeaders";
            this.buttonLeaders.Size = new System.Drawing.Size(210, 60);
            this.buttonLeaders.TabIndex = 0;
            this.buttonLeaders.TabStop = false;
            this.buttonLeaders.Text = "Leaderboard";
            this.buttonLeaders.UseVisualStyleBackColor = false;
            this.buttonLeaders.Click += new System.EventHandler(this.buttonLeaders_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.BackColor = System.Drawing.Color.Black;
            this.buttonSettings.BackgroundImage = global::Susl_Jump.Properties.Resources.settings;
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.CausesValidation = false;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Location = new System.Drawing.Point(365, 3);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(30, 30);
            this.buttonSettings.TabIndex = 0;
            this.buttonSettings.TabStop = false;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPlay.BackColor = System.Drawing.Color.Black;
            this.buttonPlay.BackgroundImage = global::Susl_Jump.Properties.Resources.dungeonBackground;
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPlay.CausesValidation = false;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPlay.ForeColor = System.Drawing.Color.White;
            this.buttonPlay.Location = new System.Drawing.Point(20, 15);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(210, 60);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.TabStop = false;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = false;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // pictureBoxBackground
            // 
            this.pictureBoxBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxBackground.Enabled = false;
            this.pictureBoxBackground.Image = global::Susl_Jump.Properties.Resources.dungeonBackground;
            this.pictureBoxBackground.Location = new System.Drawing.Point(24, 679);
            this.pictureBoxBackground.Name = "pictureBoxBackground";
            this.pictureBoxBackground.Size = new System.Drawing.Size(500, 700);
            this.pictureBoxBackground.TabIndex = 2;
            this.pictureBoxBackground.TabStop = false;
            // 
            // panelSettings
            // 
            this.panelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSettings.BackColor = System.Drawing.Color.Black;
            this.panelSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSettings.Controls.Add(this.buttonBack);
            this.panelSettings.Controls.Add(this.label4);
            this.panelSettings.Controls.Add(this.labelShieldKey);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.labelShootKey);
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.labelRightKey);
            this.panelSettings.Controls.Add(this.label1);
            this.panelSettings.Controls.Add(this.labelLeftKey);
            this.panelSettings.Location = new System.Drawing.Point(450, 150);
            this.panelSettings.MinimumSize = new System.Drawing.Size(400, 250);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(400, 250);
            this.panelSettings.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack.BackColor = System.Drawing.Color.Black;
            this.buttonBack.CausesValidation = false;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(3, 220);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(80, 25);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.TabStop = false;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.CausesValidation = false;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(206, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shield : ";
            // 
            // labelShieldKey
            // 
            this.labelShieldKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShieldKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShieldKey.CausesValidation = false;
            this.labelShieldKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShieldKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelShieldKey.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShieldKey.ForeColor = System.Drawing.Color.White;
            this.labelShieldKey.Location = new System.Drawing.Point(231, 160);
            this.labelShieldKey.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.labelShieldKey.Name = "labelShieldKey";
            this.labelShieldKey.Size = new System.Drawing.Size(120, 50);
            this.labelShieldKey.TabIndex = 4;
            this.labelShieldKey.Text = "X";
            this.labelShieldKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShieldKey.Click += new System.EventHandler(this.labelsKey_Click);
            this.labelShieldKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelsKey_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.CausesValidation = false;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Shoot :";
            // 
            // labelShootKey
            // 
            this.labelShootKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelShootKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelShootKey.CausesValidation = false;
            this.labelShootKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelShootKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelShootKey.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShootKey.ForeColor = System.Drawing.Color.White;
            this.labelShootKey.Location = new System.Drawing.Point(231, 70);
            this.labelShootKey.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.labelShootKey.Name = "labelShootKey";
            this.labelShootKey.Size = new System.Drawing.Size(120, 50);
            this.labelShootKey.TabIndex = 2;
            this.labelShootKey.Text = "Space";
            this.labelShootKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShootKey.Click += new System.EventHandler(this.labelsKey_Click);
            this.labelShootKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelsKey_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.CausesValidation = false;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Right : ";
            // 
            // labelRightKey
            // 
            this.labelRightKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRightKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRightKey.CausesValidation = false;
            this.labelRightKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelRightKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelRightKey.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRightKey.ForeColor = System.Drawing.Color.White;
            this.labelRightKey.Location = new System.Drawing.Point(55, 160);
            this.labelRightKey.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.labelRightKey.Name = "labelRightKey";
            this.labelRightKey.Size = new System.Drawing.Size(120, 50);
            this.labelRightKey.TabIndex = 0;
            this.labelRightKey.Text = "Right";
            this.labelRightKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRightKey.Click += new System.EventHandler(this.labelsKey_Click);
            this.labelRightKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelsKey_PreviewKeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.CausesValidation = false;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Left : ";
            // 
            // labelLeftKey
            // 
            this.labelLeftKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLeftKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelLeftKey.CausesValidation = false;
            this.labelLeftKey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLeftKey.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelLeftKey.Font = new System.Drawing.Font("Lucida Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLeftKey.ForeColor = System.Drawing.Color.White;
            this.labelLeftKey.Location = new System.Drawing.Point(55, 70);
            this.labelLeftKey.Margin = new System.Windows.Forms.Padding(30, 40, 35, 35);
            this.labelLeftKey.Name = "labelLeftKey";
            this.labelLeftKey.Size = new System.Drawing.Size(120, 50);
            this.labelLeftKey.TabIndex = 0;
            this.labelLeftKey.Text = "Left";
            this.labelLeftKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLeftKey.Click += new System.EventHandler(this.labelsKey_Click);
            this.labelLeftKey.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.labelsKey_PreviewKeyDown);
            // 
            // panelLeaderboard
            // 
            this.panelLeaderboard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLeaderboard.BackColor = System.Drawing.Color.Black;
            this.panelLeaderboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeaderboard.Controls.Add(this.buttonBack1);
            this.panelLeaderboard.Controls.Add(this.textBoxLeaders);
            this.panelLeaderboard.Location = new System.Drawing.Point(450, 406);
            this.panelLeaderboard.MinimumSize = new System.Drawing.Size(400, 250);
            this.panelLeaderboard.Name = "panelLeaderboard";
            this.panelLeaderboard.Size = new System.Drawing.Size(400, 250);
            this.panelLeaderboard.TabIndex = 0;
            // 
            // buttonBack1
            // 
            this.buttonBack1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack1.BackColor = System.Drawing.Color.Black;
            this.buttonBack1.CausesValidation = false;
            this.buttonBack1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack1.FlatAppearance.BorderSize = 0;
            this.buttonBack1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack1.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack1.ForeColor = System.Drawing.Color.White;
            this.buttonBack1.Location = new System.Drawing.Point(3, 220);
            this.buttonBack1.Name = "buttonBack1";
            this.buttonBack1.Size = new System.Drawing.Size(392, 25);
            this.buttonBack1.TabIndex = 1;
            this.buttonBack1.TabStop = false;
            this.buttonBack1.Text = "Back";
            this.buttonBack1.UseVisualStyleBackColor = false;
            this.buttonBack1.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // textBoxLeaders
            // 
            this.textBoxLeaders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLeaders.BackColor = System.Drawing.Color.Black;
            this.textBoxLeaders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLeaders.CausesValidation = false;
            this.textBoxLeaders.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxLeaders.ForeColor = System.Drawing.Color.White;
            this.textBoxLeaders.Location = new System.Drawing.Point(3, 3);
            this.textBoxLeaders.MaxLength = 0;
            this.textBoxLeaders.Multiline = true;
            this.textBoxLeaders.Name = "textBoxLeaders";
            this.textBoxLeaders.ReadOnly = true;
            this.textBoxLeaders.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLeaders.Size = new System.Drawing.Size(392, 211);
            this.textBoxLeaders.TabIndex = 0;
            this.textBoxLeaders.TabStop = false;
            this.textBoxLeaders.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Black;
            this.buttonExit.BackgroundImage = global::Susl_Jump.Properties.Resources.exitBtn;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.CausesValidation = false;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(458, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(30, 30);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.TabStop = false;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelMove
            // 
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(500, 20);
            this.panelMove.TabIndex = 0;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // panelShop
            // 
            this.panelShop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShop.BackColor = System.Drawing.Color.Black;
            this.panelShop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShop.Controls.Add(this.labelShopInfo);
            this.panelShop.Controls.Add(this.label6);
            this.panelShop.Controls.Add(this.label5);
            this.panelShop.Controls.Add(this.buttonShieldBuy);
            this.panelShop.Controls.Add(this.buttonBack2);
            this.panelShop.Location = new System.Drawing.Point(12, 336);
            this.panelShop.MinimumSize = new System.Drawing.Size(400, 250);
            this.panelShop.Name = "panelShop";
            this.panelShop.Size = new System.Drawing.Size(400, 250);
            this.panelShop.TabIndex = 0;
            // 
            // labelShopInfo
            // 
            this.labelShopInfo.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelShopInfo.ForeColor = System.Drawing.Color.White;
            this.labelShopInfo.Location = new System.Drawing.Point(91, 84);
            this.labelShopInfo.Margin = new System.Windows.Forms.Padding(15);
            this.labelShopInfo.Name = "labelShopInfo";
            this.labelShopInfo.Size = new System.Drawing.Size(292, 149);
            this.labelShopInfo.TabIndex = 5;
            this.labelShopInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(264, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 15, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = ">> 2💰";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Margin = new System.Windows.Forms.Padding(60, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Shield <<";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonShieldBuy
            // 
            this.buttonShieldBuy.BackColor = System.Drawing.Color.Black;
            this.buttonShieldBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShieldBuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShieldBuy.ForeColor = System.Drawing.Color.White;
            this.buttonShieldBuy.Location = new System.Drawing.Point(173, 34);
            this.buttonShieldBuy.Name = "buttonShieldBuy";
            this.buttonShieldBuy.Size = new System.Drawing.Size(85, 32);
            this.buttonShieldBuy.TabIndex = 0;
            this.buttonShieldBuy.TabStop = false;
            this.buttonShieldBuy.Text = "buy";
            this.buttonShieldBuy.UseVisualStyleBackColor = false;
            this.buttonShieldBuy.Click += new System.EventHandler(this.buttonShieldBuy_Click);
            // 
            // buttonBack2
            // 
            this.buttonBack2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBack2.BackColor = System.Drawing.Color.Black;
            this.buttonBack2.CausesValidation = false;
            this.buttonBack2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack2.FlatAppearance.BorderSize = 0;
            this.buttonBack2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonBack2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonBack2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack2.Font = new System.Drawing.Font("Lucida Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBack2.ForeColor = System.Drawing.Color.White;
            this.buttonBack2.Location = new System.Drawing.Point(3, 220);
            this.buttonBack2.Name = "buttonBack2";
            this.buttonBack2.Size = new System.Drawing.Size(80, 25);
            this.buttonBack2.TabIndex = 1;
            this.buttonBack2.TabStop = false;
            this.buttonBack2.Text = "Back";
            this.buttonBack2.UseVisualStyleBackColor = false;
            this.buttonBack2.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 700);
            this.Controls.Add(this.panelShop);
            this.Controls.Add(this.panelMove);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.panelLeaderboard);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.pictureBoxBackground);
            this.Controls.Add(this.panelMainMenu);
            this.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.panelMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBackground)).EndInit();
            this.panelSettings.ResumeLayout(false);
            this.panelLeaderboard.ResumeLayout(false);
            this.panelLeaderboard.PerformLayout();
            this.panelShop.ResumeLayout(false);
            this.panelShop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMainMenu;
        private PictureBox pictureBoxBackground;
        private Button buttonLeaders;
        private Button buttonSettings;
        private Button buttonPlay;
        private Panel panelSettings;
        private Label labelLeftKey;
        private Label label2;
        private Label labelRightKey;
        private Label label1;
        private Label label3;
        private Label labelShootKey;
        private Label label4;
        private Label labelShieldKey;
        private Panel panelLeaderboard;
        private TextBox textBoxLeaders;
        private Button buttonExit;
        private Button buttonBack;
        private Button buttonBack1;
        private Panel panelMove;
        private Button buttonShop;
        private Panel panelShop;
        private Button buttonBack2;
        private Label label5;
        private Button buttonShieldBuy;
        private Label label6;
        private Label labelShopInfo;
    }
}