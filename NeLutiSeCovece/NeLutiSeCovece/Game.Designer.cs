namespace NeLutiSeCovece
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.timerKocka = new System.Windows.Forms.Timer(this.components);
            this.panelGame = new System.Windows.Forms.Panel();
            this.btnNextTurn = new System.Windows.Forms.Button();
            this.lbTurn = new System.Windows.Forms.Label();
            this.btnBlue3 = new System.Windows.Forms.Button();
            this.btnBlue2 = new System.Windows.Forms.Button();
            this.btnBlue1 = new System.Windows.Forms.Button();
            this.btnBlue0 = new System.Windows.Forms.Button();
            this.btnGreen3 = new System.Windows.Forms.Button();
            this.btnGreen2 = new System.Windows.Forms.Button();
            this.btnGreen1 = new System.Windows.Forms.Button();
            this.btnGreen0 = new System.Windows.Forms.Button();
            this.btnYellow3 = new System.Windows.Forms.Button();
            this.btnYellow2 = new System.Windows.Forms.Button();
            this.btnYellow1 = new System.Windows.Forms.Button();
            this.btnYellow0 = new System.Windows.Forms.Button();
            this.btnRed3 = new System.Windows.Forms.Button();
            this.btnRed2 = new System.Windows.Forms.Button();
            this.btnRed1 = new System.Windows.Forms.Button();
            this.btnRed0 = new System.Windows.Forms.Button();
            this.labelRoll = new System.Windows.Forms.Label();
            this.buttonKocka = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerKocka
            // 
            this.timerKocka.Interval = 120;
            this.timerKocka.Tick += new System.EventHandler(this.timerKocka_Tick);
            // 
            // panelGame
            // 
            this.panelGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGame.BackgroundImage")));
            this.panelGame.Controls.Add(this.btnNextTurn);
            this.panelGame.Controls.Add(this.lbTurn);
            this.panelGame.Controls.Add(this.btnBlue3);
            this.panelGame.Controls.Add(this.btnBlue2);
            this.panelGame.Controls.Add(this.btnBlue1);
            this.panelGame.Controls.Add(this.btnBlue0);
            this.panelGame.Controls.Add(this.btnGreen3);
            this.panelGame.Controls.Add(this.btnGreen2);
            this.panelGame.Controls.Add(this.btnGreen1);
            this.panelGame.Controls.Add(this.btnGreen0);
            this.panelGame.Controls.Add(this.btnYellow3);
            this.panelGame.Controls.Add(this.btnYellow2);
            this.panelGame.Controls.Add(this.btnYellow1);
            this.panelGame.Controls.Add(this.btnYellow0);
            this.panelGame.Controls.Add(this.btnRed3);
            this.panelGame.Controls.Add(this.btnRed2);
            this.panelGame.Controls.Add(this.btnRed1);
            this.panelGame.Controls.Add(this.btnRed0);
            this.panelGame.Controls.Add(this.labelRoll);
            this.panelGame.Controls.Add(this.buttonKocka);
            this.panelGame.Location = new System.Drawing.Point(-4, -1);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(1169, 744);
            this.panelGame.TabIndex = 0;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // btnNextTurn
            // 
            this.btnNextTurn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNextTurn.Enabled = false;
            this.btnNextTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextTurn.Location = new System.Drawing.Point(914, 349);
            this.btnNextTurn.Name = "btnNextTurn";
            this.btnNextTurn.Size = new System.Drawing.Size(151, 39);
            this.btnNextTurn.TabIndex = 20;
            this.btnNextTurn.Text = "Next Turn";
            this.btnNextTurn.UseVisualStyleBackColor = false;
            this.btnNextTurn.Click += new System.EventHandler(this.btnNextTurn_Click);
            // 
            // lbTurn
            // 
            this.lbTurn.AutoSize = true;
            this.lbTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTurn.Location = new System.Drawing.Point(876, 453);
            this.lbTurn.Name = "lbTurn";
            this.lbTurn.Size = new System.Drawing.Size(212, 46);
            this.lbTurn.TabIndex = 19;
            this.lbTurn.Text = "Player turn";
            // 
            // btnBlue3
            // 
            this.btnBlue3.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlue3.BackgroundImage")));
            this.btnBlue3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlue3.Enabled = false;
            this.btnBlue3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue3.Location = new System.Drawing.Point(154, 257);
            this.btnBlue3.Name = "btnBlue3";
            this.btnBlue3.Size = new System.Drawing.Size(36, 72);
            this.btnBlue3.TabIndex = 18;
            this.btnBlue3.UseVisualStyleBackColor = false;
            this.btnBlue3.Visible = false;
            this.btnBlue3.Click += new System.EventHandler(this.btnBlue3_Click);
            // 
            // btnBlue2
            // 
            this.btnBlue2.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlue2.BackgroundImage")));
            this.btnBlue2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlue2.Enabled = false;
            this.btnBlue2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue2.Location = new System.Drawing.Point(111, 257);
            this.btnBlue2.Name = "btnBlue2";
            this.btnBlue2.Size = new System.Drawing.Size(36, 72);
            this.btnBlue2.TabIndex = 17;
            this.btnBlue2.UseVisualStyleBackColor = false;
            this.btnBlue2.Visible = false;
            this.btnBlue2.Click += new System.EventHandler(this.btnBlue2_Click);
            // 
            // btnBlue1
            // 
            this.btnBlue1.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlue1.BackgroundImage")));
            this.btnBlue1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlue1.Enabled = false;
            this.btnBlue1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue1.Location = new System.Drawing.Point(69, 257);
            this.btnBlue1.Name = "btnBlue1";
            this.btnBlue1.Size = new System.Drawing.Size(36, 72);
            this.btnBlue1.TabIndex = 16;
            this.btnBlue1.UseVisualStyleBackColor = false;
            this.btnBlue1.Visible = false;
            this.btnBlue1.Click += new System.EventHandler(this.btnBlue1_Click);
            // 
            // btnBlue0
            // 
            this.btnBlue0.BackColor = System.Drawing.Color.Transparent;
            this.btnBlue0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlue0.BackgroundImage")));
            this.btnBlue0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBlue0.Enabled = false;
            this.btnBlue0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlue0.Location = new System.Drawing.Point(27, 257);
            this.btnBlue0.Name = "btnBlue0";
            this.btnBlue0.Size = new System.Drawing.Size(36, 72);
            this.btnBlue0.TabIndex = 15;
            this.btnBlue0.UseVisualStyleBackColor = false;
            this.btnBlue0.Visible = false;
            this.btnBlue0.Click += new System.EventHandler(this.btnBlue0_Click);
            // 
            // btnGreen3
            // 
            this.btnGreen3.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreen3.BackgroundImage")));
            this.btnGreen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreen3.Enabled = false;
            this.btnGreen3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen3.Location = new System.Drawing.Point(154, 179);
            this.btnGreen3.Name = "btnGreen3";
            this.btnGreen3.Size = new System.Drawing.Size(36, 72);
            this.btnGreen3.TabIndex = 14;
            this.btnGreen3.UseVisualStyleBackColor = false;
            this.btnGreen3.Visible = false;
            this.btnGreen3.Click += new System.EventHandler(this.btnGreen3_Click);
            // 
            // btnGreen2
            // 
            this.btnGreen2.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreen2.BackgroundImage")));
            this.btnGreen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreen2.Enabled = false;
            this.btnGreen2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen2.Location = new System.Drawing.Point(111, 179);
            this.btnGreen2.Name = "btnGreen2";
            this.btnGreen2.Size = new System.Drawing.Size(36, 72);
            this.btnGreen2.TabIndex = 13;
            this.btnGreen2.UseVisualStyleBackColor = false;
            this.btnGreen2.Visible = false;
            this.btnGreen2.Click += new System.EventHandler(this.btnGreen2_Click);
            // 
            // btnGreen1
            // 
            this.btnGreen1.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreen1.BackgroundImage")));
            this.btnGreen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreen1.Enabled = false;
            this.btnGreen1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen1.Location = new System.Drawing.Point(69, 179);
            this.btnGreen1.Name = "btnGreen1";
            this.btnGreen1.Size = new System.Drawing.Size(36, 72);
            this.btnGreen1.TabIndex = 12;
            this.btnGreen1.UseVisualStyleBackColor = false;
            this.btnGreen1.Visible = false;
            this.btnGreen1.Click += new System.EventHandler(this.btnGreen1_Click);
            // 
            // btnGreen0
            // 
            this.btnGreen0.BackColor = System.Drawing.Color.Transparent;
            this.btnGreen0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGreen0.BackgroundImage")));
            this.btnGreen0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGreen0.Enabled = false;
            this.btnGreen0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreen0.Location = new System.Drawing.Point(27, 179);
            this.btnGreen0.Name = "btnGreen0";
            this.btnGreen0.Size = new System.Drawing.Size(36, 72);
            this.btnGreen0.TabIndex = 11;
            this.btnGreen0.UseVisualStyleBackColor = false;
            this.btnGreen0.Visible = false;
            this.btnGreen0.Click += new System.EventHandler(this.btnGreen0_Click);
            // 
            // btnYellow3
            // 
            this.btnYellow3.BackColor = System.Drawing.Color.Transparent;
            this.btnYellow3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYellow3.BackgroundImage")));
            this.btnYellow3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellow3.Enabled = false;
            this.btnYellow3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow3.Location = new System.Drawing.Point(154, 101);
            this.btnYellow3.Name = "btnYellow3";
            this.btnYellow3.Size = new System.Drawing.Size(36, 72);
            this.btnYellow3.TabIndex = 10;
            this.btnYellow3.UseVisualStyleBackColor = false;
            this.btnYellow3.Visible = false;
            this.btnYellow3.Click += new System.EventHandler(this.btnYellow3_Click);
            // 
            // btnYellow2
            // 
            this.btnYellow2.BackColor = System.Drawing.Color.Transparent;
            this.btnYellow2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYellow2.BackgroundImage")));
            this.btnYellow2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellow2.Enabled = false;
            this.btnYellow2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow2.Location = new System.Drawing.Point(111, 101);
            this.btnYellow2.Name = "btnYellow2";
            this.btnYellow2.Size = new System.Drawing.Size(36, 72);
            this.btnYellow2.TabIndex = 9;
            this.btnYellow2.UseVisualStyleBackColor = false;
            this.btnYellow2.Visible = false;
            this.btnYellow2.Click += new System.EventHandler(this.btnYellow2_Click);
            // 
            // btnYellow1
            // 
            this.btnYellow1.BackColor = System.Drawing.Color.Transparent;
            this.btnYellow1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYellow1.BackgroundImage")));
            this.btnYellow1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellow1.Enabled = false;
            this.btnYellow1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow1.Location = new System.Drawing.Point(69, 101);
            this.btnYellow1.Name = "btnYellow1";
            this.btnYellow1.Size = new System.Drawing.Size(36, 72);
            this.btnYellow1.TabIndex = 8;
            this.btnYellow1.UseVisualStyleBackColor = false;
            this.btnYellow1.Visible = false;
            this.btnYellow1.Click += new System.EventHandler(this.btnYellow1_Click);
            // 
            // btnYellow0
            // 
            this.btnYellow0.BackColor = System.Drawing.Color.Transparent;
            this.btnYellow0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnYellow0.BackgroundImage")));
            this.btnYellow0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYellow0.Enabled = false;
            this.btnYellow0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnYellow0.Location = new System.Drawing.Point(27, 101);
            this.btnYellow0.Name = "btnYellow0";
            this.btnYellow0.Size = new System.Drawing.Size(36, 72);
            this.btnYellow0.TabIndex = 7;
            this.btnYellow0.UseVisualStyleBackColor = false;
            this.btnYellow0.Visible = false;
            this.btnYellow0.Click += new System.EventHandler(this.btnYellow0_Click);
            // 
            // btnRed3
            // 
            this.btnRed3.BackColor = System.Drawing.Color.Transparent;
            this.btnRed3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRed3.BackgroundImage")));
            this.btnRed3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRed3.Enabled = false;
            this.btnRed3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRed3.Location = new System.Drawing.Point(154, 23);
            this.btnRed3.Name = "btnRed3";
            this.btnRed3.Size = new System.Drawing.Size(36, 72);
            this.btnRed3.TabIndex = 6;
            this.btnRed3.UseVisualStyleBackColor = false;
            this.btnRed3.Visible = false;
            this.btnRed3.Click += new System.EventHandler(this.btnRed3_Click);
            // 
            // btnRed2
            // 
            this.btnRed2.BackColor = System.Drawing.Color.Transparent;
            this.btnRed2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRed2.BackgroundImage")));
            this.btnRed2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRed2.Enabled = false;
            this.btnRed2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRed2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRed2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed2.Location = new System.Drawing.Point(111, 23);
            this.btnRed2.Name = "btnRed2";
            this.btnRed2.Size = new System.Drawing.Size(36, 72);
            this.btnRed2.TabIndex = 5;
            this.btnRed2.UseVisualStyleBackColor = false;
            this.btnRed2.Visible = false;
            this.btnRed2.Click += new System.EventHandler(this.btnRed2_Click);
            // 
            // btnRed1
            // 
            this.btnRed1.BackColor = System.Drawing.Color.Transparent;
            this.btnRed1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRed1.BackgroundImage")));
            this.btnRed1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRed1.Enabled = false;
            this.btnRed1.FlatAppearance.BorderSize = 0;
            this.btnRed1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRed1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRed1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed1.Location = new System.Drawing.Point(69, 23);
            this.btnRed1.Name = "btnRed1";
            this.btnRed1.Size = new System.Drawing.Size(36, 72);
            this.btnRed1.TabIndex = 4;
            this.btnRed1.UseVisualStyleBackColor = false;
            this.btnRed1.Visible = false;
            this.btnRed1.Click += new System.EventHandler(this.btnRed1_Click);
            // 
            // btnRed0
            // 
            this.btnRed0.BackColor = System.Drawing.Color.Transparent;
            this.btnRed0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRed0.BackgroundImage")));
            this.btnRed0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRed0.Enabled = false;
            this.btnRed0.FlatAppearance.BorderSize = 0;
            this.btnRed0.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRed0.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRed0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed0.Location = new System.Drawing.Point(27, 23);
            this.btnRed0.Margin = new System.Windows.Forms.Padding(0);
            this.btnRed0.Name = "btnRed0";
            this.btnRed0.Size = new System.Drawing.Size(36, 72);
            this.btnRed0.TabIndex = 3;
            this.btnRed0.UseVisualStyleBackColor = false;
            this.btnRed0.Visible = false;
            this.btnRed0.Click += new System.EventHandler(this.btnRed0_Click);
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.BackColor = System.Drawing.Color.Transparent;
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRoll.Location = new System.Drawing.Point(920, 268);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(134, 26);
            this.labelRoll.TabIndex = 2;
            this.labelRoll.Text = "Click to Roll!";
            // 
            // buttonKocka
            // 
            this.buttonKocka.BackColor = System.Drawing.Color.Transparent;
            this.buttonKocka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonKocka.BackgroundImage")));
            this.buttonKocka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonKocka.Location = new System.Drawing.Point(884, 68);
            this.buttonKocka.Name = "buttonKocka";
            this.buttonKocka.Size = new System.Drawing.Size(204, 187);
            this.buttonKocka.TabIndex = 1;
            this.buttonKocka.UseVisualStyleBackColor = false;
            this.buttonKocka.Click += new System.EventHandler(this.buttonKocka_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 741);
            this.Controls.Add(this.panelGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 780);
            this.MinimumSize = new System.Drawing.Size(1180, 780);
            this.Name = "Game";
            this.Text = "Mapa";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerKocka;
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Button btnBlue3;
        private System.Windows.Forms.Button btnBlue2;
        private System.Windows.Forms.Button btnBlue1;
        private System.Windows.Forms.Button btnBlue0;
        private System.Windows.Forms.Button btnGreen3;
        private System.Windows.Forms.Button btnGreen2;
        private System.Windows.Forms.Button btnGreen1;
        private System.Windows.Forms.Button btnGreen0;
        private System.Windows.Forms.Button btnYellow3;
        private System.Windows.Forms.Button btnYellow2;
        private System.Windows.Forms.Button btnYellow1;
        private System.Windows.Forms.Button btnYellow0;
        private System.Windows.Forms.Button btnRed3;
        private System.Windows.Forms.Button btnRed2;
        private System.Windows.Forms.Button btnRed1;
        private System.Windows.Forms.Button btnRed0;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Button buttonKocka;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Button btnNextTurn;
    }
}

