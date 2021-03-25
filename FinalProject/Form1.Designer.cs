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
            this.sceneBox = new System.Windows.Forms.PictureBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NLabel = new System.Windows.Forms.Label();
            this.MLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneBox
            // 
            this.sceneBox.BackColor = System.Drawing.SystemColors.ControlText;
            this.sceneBox.Location = new System.Drawing.Point(-4, 1);
            this.sceneBox.Name = "sceneBox";
            this.sceneBox.Size = new System.Drawing.Size(1190, 369);
            this.sceneBox.TabIndex = 0;
            this.sceneBox.TabStop = false;
            // 
            // textLabel
            // 
            this.textLabel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textLabel.Font = new System.Drawing.Font("Windsor Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Indigo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkViolet;
            this.pictureBox2.Location = new System.Drawing.Point(625, 499);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.MLabel);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.sceneBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.sceneBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox sceneBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label NLabel;
        private System.Windows.Forms.Label MLabel;
    }
}

