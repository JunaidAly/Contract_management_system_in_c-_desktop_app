namespace Project
{
    partial class Splash_screen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Splash_progressBar = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.splash_timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources._211;
            this.pictureBox1.Location = new System.Drawing.Point(429, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(278, 282);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Contract Management System";
            // 
            // Splash_progressBar
            // 
            this.Splash_progressBar.BackColor = System.Drawing.Color.Green;
            this.Splash_progressBar.ForeColor = System.Drawing.Color.Green;
            this.Splash_progressBar.Location = new System.Drawing.Point(327, 368);
            this.Splash_progressBar.Name = "Splash_progressBar";
            this.Splash_progressBar.Size = new System.Drawing.Size(338, 34);
            this.Splash_progressBar.TabIndex = 3;
            this.Splash_progressBar.Click += new System.EventHandler(this.Splash_progressBar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(425, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "LOading....";
            // 
            // Splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.download1;
            this.ClientSize = new System.Drawing.Size(975, 592);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Splash_progressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash_screen";
            this.Load += new System.EventHandler(this.Splash_screen_Load);
            this.Shown += new System.EventHandler(this.Splash_screen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar Splash_progressBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer splash_timer;
    }
}