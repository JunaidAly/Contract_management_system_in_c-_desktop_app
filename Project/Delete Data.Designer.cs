namespace Project
{
    partial class Delete_Data
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
            this.Con_id = new System.Windows.Forms.TextBox();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.DaleteDataGridView = new System.Windows.Forms.DataGridView();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DaleteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contractor Code (Pk)";
            // 
            // Con_id
            // 
            this.Con_id.Location = new System.Drawing.Point(560, 111);
            this.Con_id.Multiline = true;
            this.Con_id.Name = "Con_id";
            this.Con_id.Size = new System.Drawing.Size(202, 27);
            this.Con_id.TabIndex = 1;
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Delete.BackgroundImage = global::Project.Properties.Resources.Delete_Button_PNG_File;
            this.Btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Delete.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Delete.Location = new System.Drawing.Point(286, 404);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(157, 69);
            this.Btn_Delete.TabIndex = 2;
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // DaleteDataGridView
            // 
            this.DaleteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DaleteDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.DaleteDataGridView.Location = new System.Drawing.Point(286, 166);
            this.DaleteDataGridView.Name = "DaleteDataGridView";
            this.DaleteDataGridView.Size = new System.Drawing.Size(476, 208);
            this.DaleteDataGridView.TabIndex = 3;
            // 
            // Btn_back
            // 
            this.Btn_back.BackgroundImage = global::Project.Properties.Resources.Back_PNG_Free_Download;
            this.Btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_back.Location = new System.Drawing.Point(597, 406);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(165, 69);
            this.Btn_back.TabIndex = 4;
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_show
            // 
            this.Btn_show.BackgroundImage = global::Project.Properties.Resources.show_button_png_hi;
            this.Btn_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_show.Location = new System.Drawing.Point(449, 406);
            this.Btn_show.Name = "Btn_show";
            this.Btn_show.Size = new System.Drawing.Size(142, 67);
            this.Btn_show.TabIndex = 5;
            this.Btn_show.UseVisualStyleBackColor = true;
            this.Btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // Delete_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Permanently_Delete_Confidential_Data;
            this.ClientSize = new System.Drawing.Size(975, 512);
            this.Controls.Add(this.Btn_show);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.DaleteDataGridView);
            this.Controls.Add(this.Btn_Delete);
            this.Controls.Add(this.Con_id);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Data";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete_Data";
            ((System.ComponentModel.ISupportInitialize)(this.DaleteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Con_id;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.DataGridView DaleteDataGridView;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_show;
    }
}