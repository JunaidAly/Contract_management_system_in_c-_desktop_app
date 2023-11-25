namespace Project
{
    partial class Show_Data
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_showdata = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(852, 431);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_showdata
            // 
            this.Btn_showdata.BackgroundImage = global::Project.Properties.Resources.show_button_png_hi;
            this.Btn_showdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_showdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_showdata.Location = new System.Drawing.Point(302, 470);
            this.Btn_showdata.Name = "Btn_showdata";
            this.Btn_showdata.Size = new System.Drawing.Size(141, 73);
            this.Btn_showdata.TabIndex = 1;
            this.Btn_showdata.UseVisualStyleBackColor = true;
            this.Btn_showdata.Click += new System.EventHandler(this.Btn_showdata_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.BackgroundImage = global::Project.Properties.Resources.Back_PNG_Free_Download3;
            this.Btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_back.Location = new System.Drawing.Point(554, 470);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(137, 73);
            this.Btn_back.TabIndex = 2;
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Show_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.stuffcontentmgrfiles20a2889156e4cbcb9bda9eed3192dadfcmiscshow_me_the_data;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 566);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_showdata);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_showdata;
        private System.Windows.Forms.Button Btn_back;
    }
}