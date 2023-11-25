namespace Project
{
    partial class Sign_Up
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Full_Name_txtbox = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.passtxtbox = new System.Windows.Forms.TextBox();
            this.conpasstxt = new System.Windows.Forms.TextBox();
            this.Btn_create = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.sign_up_logo;
            this.pictureBox1.Location = new System.Drawing.Point(462, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(302, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(302, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(302, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(302, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Confirm Password";
            // 
            // Full_Name_txtbox
            // 
            this.Full_Name_txtbox.Location = new System.Drawing.Point(462, 218);
            this.Full_Name_txtbox.Name = "Full_Name_txtbox";
            this.Full_Name_txtbox.Size = new System.Drawing.Size(159, 20);
            this.Full_Name_txtbox.TabIndex = 6;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(462, 252);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(159, 20);
            this.username.TabIndex = 8;
            // 
            // passtxtbox
            // 
            this.passtxtbox.Location = new System.Drawing.Point(462, 283);
            this.passtxtbox.Name = "passtxtbox";
            this.passtxtbox.Size = new System.Drawing.Size(159, 20);
            this.passtxtbox.TabIndex = 9;
            this.passtxtbox.UseSystemPasswordChar = true;
            // 
            // conpasstxt
            // 
            this.conpasstxt.Location = new System.Drawing.Point(462, 318);
            this.conpasstxt.Name = "conpasstxt";
            this.conpasstxt.Size = new System.Drawing.Size(159, 20);
            this.conpasstxt.TabIndex = 10;
            this.conpasstxt.UseSystemPasswordChar = true;
            // 
            // Btn_create
            // 
            this.Btn_create.BackColor = System.Drawing.Color.Transparent;
            this.Btn_create.BackgroundImage = global::Project.Properties.Resources.createaccount_button_png_hi;
            this.Btn_create.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_create.Location = new System.Drawing.Point(306, 392);
            this.Btn_create.Name = "Btn_create";
            this.Btn_create.Size = new System.Drawing.Size(176, 82);
            this.Btn_create.TabIndex = 11;
            this.Btn_create.UseVisualStyleBackColor = false;
            this.Btn_create.Click += new System.EventHandler(this.Btn_create_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.BackColor = System.Drawing.Color.Transparent;
            this.Btn_back.BackgroundImage = global::Project.Properties.Resources.Back_PNG_Free_Download4;
            this.Btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(506, 392);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(167, 82);
            this.Btn_back.TabIndex = 12;
            this.Btn_back.UseVisualStyleBackColor = false;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Sign_Up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.sign_up_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(940, 566);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_create);
            this.Controls.Add(this.conpasstxt);
            this.Controls.Add(this.passtxtbox);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Full_Name_txtbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sign_Up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign_Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Full_Name_txtbox;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox passtxtbox;
        private System.Windows.Forms.TextBox conpasstxt;
        private System.Windows.Forms.Button Btn_create;
        private System.Windows.Forms.Button Btn_back;
    }
}