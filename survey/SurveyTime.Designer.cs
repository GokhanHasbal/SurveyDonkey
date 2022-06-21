namespace survey
{
    partial class SurveyTime
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
            this.header_panel = new System.Windows.Forms.Panel();
            this.exit_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.header_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picture2_picturebox = new System.Windows.Forms.PictureBox();
            this.upload_button = new System.Windows.Forms.Button();
            this.picture_picturebox = new System.Windows.Forms.PictureBox();
            this.survey_data_label = new System.Windows.Forms.Label();
            this.finish_survey_button = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.username_label);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Location = new System.Drawing.Point(12, 12);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(775, 75);
            this.header_panel.TabIndex = 4;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(675, 14);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_label.Location = new System.Drawing.Point(240, 14);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(146, 37);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.header_label.Location = new System.Drawing.Point(22, 14);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(200, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Survey Name?";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.button3);
            this.container_panel.Controls.Add(this.button2);
            this.container_panel.Controls.Add(this.button1);
            this.container_panel.Controls.Add(this.picture2_picturebox);
            this.container_panel.Controls.Add(this.upload_button);
            this.container_panel.Controls.Add(this.picture_picturebox);
            this.container_panel.Controls.Add(this.survey_data_label);
            this.container_panel.Location = new System.Drawing.Point(13, 124);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(775, 270);
            this.container_panel.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "getir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "yallah sql\'e";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture2_picturebox
            // 
            this.picture2_picturebox.Location = new System.Drawing.Point(502, 56);
            this.picture2_picturebox.Name = "picture2_picturebox";
            this.picture2_picturebox.Size = new System.Drawing.Size(189, 143);
            this.picture2_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture2_picturebox.TabIndex = 14;
            this.picture2_picturebox.TabStop = false;
            // 
            // upload_button
            // 
            this.upload_button.Location = new System.Drawing.Point(43, 176);
            this.upload_button.Name = "upload_button";
            this.upload_button.Size = new System.Drawing.Size(75, 23);
            this.upload_button.TabIndex = 13;
            this.upload_button.Text = "Upload";
            this.upload_button.UseVisualStyleBackColor = true;
            this.upload_button.Click += new System.EventHandler(this.upload_button_Click);
            // 
            // picture_picturebox
            // 
            this.picture_picturebox.Location = new System.Drawing.Point(170, 56);
            this.picture_picturebox.Name = "picture_picturebox";
            this.picture_picturebox.Size = new System.Drawing.Size(189, 143);
            this.picture_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_picturebox.TabIndex = 12;
            this.picture_picturebox.TabStop = false;
            // 
            // survey_data_label
            // 
            this.survey_data_label.AutoSize = true;
            this.survey_data_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.survey_data_label.Location = new System.Drawing.Point(3, 10);
            this.survey_data_label.Name = "survey_data_label";
            this.survey_data_label.Size = new System.Drawing.Size(231, 37);
            this.survey_data_label.TabIndex = 1;
            this.survey_data_label.Text = "Category Name?";
            // 
            // finish_survey_button
            // 
            this.finish_survey_button.Location = new System.Drawing.Point(590, 400);
            this.finish_survey_button.Name = "finish_survey_button";
            this.finish_survey_button.Size = new System.Drawing.Size(197, 38);
            this.finish_survey_button.TabIndex = 8;
            this.finish_survey_button.Text = "Finish Survey";
            this.finish_survey_button.UseVisualStyleBackColor = true;
            this.finish_survey_button.Click += new System.EventHandler(this.finish_survey_button_Click);
            // 
            // SurveyTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.finish_survey_button);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SurveyTime";
            this.Text = "SurveyTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SurveyTime_FormClosed);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture2_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.Label survey_data_label;
        private System.Windows.Forms.Button finish_survey_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button upload_button;
        private System.Windows.Forms.PictureBox picture_picturebox;
        private System.Windows.Forms.PictureBox picture2_picturebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}