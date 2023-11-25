namespace Project
{
    partial class Add_Work_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Add_work = new System.Windows.Forms.Button();
            this.Btn_Back = new System.Windows.Forms.Button();
            this.worktitle = new System.Windows.Forms.TextBox();
            this.Location = new System.Windows.Forms.TextBox();
            this.TS_number = new System.Windows.Forms.TextBox();
            this.work_type = new System.Windows.Forms.TextBox();
            this.TS_amount = new System.Windows.Forms.TextBox();
            this.Add_Data_Grid = new System.Windows.Forms.DataGridView();
            this.Btn_show = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Add_Data_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Ravie", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add a New Work";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Work Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TS Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Work Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(428, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "TS Amount";
            // 
            // Btn_Add_work
            // 
            this.Btn_Add_work.BackgroundImage = global::Project.Properties.Resources.add_button_png_hi;
            this.Btn_Add_work.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Add_work.Location = new System.Drawing.Point(452, 335);
            this.Btn_Add_work.Name = "Btn_Add_work";
            this.Btn_Add_work.Size = new System.Drawing.Size(126, 62);
            this.Btn_Add_work.TabIndex = 6;
            this.Btn_Add_work.UseVisualStyleBackColor = true;
            this.Btn_Add_work.Click += new System.EventHandler(this.Btn_Add_work_Click);
            // 
            // Btn_Back
            // 
            this.Btn_Back.BackgroundImage = global::Project.Properties.Resources.Back_PNG_Free_Download5;
            this.Btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Back.Location = new System.Drawing.Point(673, 412);
            this.Btn_Back.Name = "Btn_Back";
            this.Btn_Back.Size = new System.Drawing.Size(124, 62);
            this.Btn_Back.TabIndex = 7;
            this.Btn_Back.UseVisualStyleBackColor = true;
            this.Btn_Back.Click += new System.EventHandler(this.Btn_Back_Click);
            // 
            // worktitle
            // 
            this.worktitle.Location = new System.Drawing.Point(271, 131);
            this.worktitle.Name = "worktitle";
            this.worktitle.Size = new System.Drawing.Size(146, 20);
            this.worktitle.TabIndex = 8;
            // 
            // Location
            // 
            this.Location.Location = new System.Drawing.Point(271, 170);
            this.Location.Name = "Location";
            this.Location.Size = new System.Drawing.Size(146, 20);
            this.Location.TabIndex = 9;
            // 
            // TS_number
            // 
            this.TS_number.Location = new System.Drawing.Point(271, 212);
            this.TS_number.Name = "TS_number";
            this.TS_number.Size = new System.Drawing.Size(146, 20);
            this.TS_number.TabIndex = 10;
            // 
            // work_type
            // 
            this.work_type.Location = new System.Drawing.Point(271, 258);
            this.work_type.Name = "work_type";
            this.work_type.Size = new System.Drawing.Size(146, 20);
            this.work_type.TabIndex = 11;
            // 
            // TS_amount
            // 
            this.TS_amount.Location = new System.Drawing.Point(532, 215);
            this.TS_amount.Name = "TS_amount";
            this.TS_amount.Size = new System.Drawing.Size(146, 20);
            this.TS_amount.TabIndex = 12;
            // 
            // Add_Data_Grid
            // 
            this.Add_Data_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Add_Data_Grid.Location = new System.Drawing.Point(546, 12);
            this.Add_Data_Grid.Name = "Add_Data_Grid";
            this.Add_Data_Grid.Size = new System.Drawing.Size(398, 189);
            this.Add_Data_Grid.TabIndex = 13;
            // 
            // Btn_show
            // 
            this.Btn_show.BackgroundImage = global::Project.Properties.Resources.show_button_png_hi1;
            this.Btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_show.Location = new System.Drawing.Point(599, 335);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(120, 62);
            this.Btn_show.TabIndex = 14;
            this.Btn_show.UseVisualStyleBackColor = true;
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.BackgroundImage = global::Project.Properties.Resources.Update_Button_PNG_Free_Image1;
            this.Btn_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Update.Location = new System.Drawing.Point(532, 412);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(119, 62);
            this.Btn_Update.TabIndex = 15;
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackgroundImage = global::Project.Properties.Resources.Delete_Button_PNG_File1;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.Location = new System.Drawing.Point(735, 335);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(118, 62);
            this.Btn_Delete.TabIndex = 16;
            this.Btn_Delete.UseVisualStyleBackColor = true;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Add_Work_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::Project.Properties.Resources.photo_1544006659_f0b21884ce1d;
            this.ClientSize = new System.Drawing.Size(974, 536);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.Add_Data_Grid);
            this.Controls.Add(this.TS_amount);
            this.Controls.Add(this.work_type);
            this.Controls.Add(this.TS_number);
            this.Controls.Add(this.Location);
            this.Controls.Add(this.worktitle);
            this.Controls.Add(this.Btn_Back);
            this.Controls.Add(this.Btn_Add_work);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Work_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Work";
            ((System.ComponentModel.ISupportInitialize)(this.Add_Data_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Add_work;
        private System.Windows.Forms.Button Btn_Back;
        private System.Windows.Forms.TextBox worktitle;
        private System.Windows.Forms.TextBox Location;
        private System.Windows.Forms.TextBox TS_number;
        private System.Windows.Forms.TextBox work_type;
        private System.Windows.Forms.TextBox TS_amount;
        private System.Windows.Forms.DataGridView Add_Data_Grid;
        private System.Windows.Forms.Button Btn_show;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Delete;
    }
}