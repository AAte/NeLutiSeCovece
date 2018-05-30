namespace NeLutiSeCovece
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerKocka = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRoll = new System.Windows.Forms.Label();
            this.buttonKocka = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerKocka
            // 
            this.timerKocka.Interval = 120;
            this.timerKocka.Tick += new System.EventHandler(this.timerKocka_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.labelRoll);
            this.panel1.Controls.Add(this.buttonKocka);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1179, 740);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.BackColor = System.Drawing.Color.Transparent;
            this.labelRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRoll.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelRoll.Location = new System.Drawing.Point(922, 272);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.button1.Location = new System.Drawing.Point(231, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(20, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 741);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 780);
            this.MinimumSize = new System.Drawing.Size(1180, 780);
            this.Name = "Form1";
            this.Text = "Mapa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timerKocka;
        private System.Windows.Forms.Button buttonKocka;
        private System.Windows.Forms.Label labelRoll;
    }
}

