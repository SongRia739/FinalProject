namespace FinalProject
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
            this.sceneImage = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.NBox = new System.Windows.Forms.PictureBox();
            this.MBox = new System.Windows.Forms.PictureBox();
            this.NLabel = new System.Windows.Forms.Label();
            this.MLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneImage
            // 
            this.sceneImage.BackColor = System.Drawing.SystemColors.ControlText;
            this.sceneImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sceneImage.Location = new System.Drawing.Point(-4, 1);
            this.sceneImage.Name = "sceneImage";
            this.sceneImage.Size = new System.Drawing.Size(1190, 369);
            this.sceneImage.TabIndex = 0;
            this.sceneImage.TabStop = false;
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.Color.PaleVioletRed;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel.Location = new System.Drawing.Point(-4, 366);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(1205, 130);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Welcome to [Game name], ready for your adventure?\r\n\r\nPress the Space bar to conti" +
    "nue";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // NBox
            // 
            this.NBox.BackColor = System.Drawing.Color.Indigo;
            this.NBox.Location = new System.Drawing.Point(12, 499);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(100, 50);
            this.NBox.TabIndex = 2;
            this.NBox.TabStop = false;
            // 
            // MBox
            // 
            this.MBox.BackColor = System.Drawing.Color.DarkViolet;
            this.MBox.Location = new System.Drawing.Point(625, 499);
            this.MBox.Name = "MBox";
            this.MBox.Size = new System.Drawing.Size(100, 50);
            this.MBox.TabIndex = 3;
            this.MBox.TabStop = false;
            // 
            // NLabel
            // 
            this.NLabel.Location = new System.Drawing.Point(129, 499);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(432, 50);
            this.NLabel.TabIndex = 4;
            this.NLabel.Text = "N Key";
            this.NLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MLabel
            // 
            this.MLabel.BackColor = System.Drawing.Color.Transparent;
            this.MLabel.Location = new System.Drawing.Point(740, 502);
            this.MLabel.Name = "MLabel";
            this.MLabel.Size = new System.Drawing.Size(432, 50);
            this.MLabel.TabIndex = 5;
            this.MLabel.Text = "M Key";
            this.MLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(29, 26);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(250, 43);
            this.scoreLabel.TabIndex = 6;
            this.scoreLabel.Text = "Score: 3000";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.MBox);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.sceneImage);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.sceneImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sceneImage;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox NBox;
        private System.Windows.Forms.PictureBox MBox;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label MLabel;
        private System.Windows.Forms.Label scoreLabel;
    }
}

