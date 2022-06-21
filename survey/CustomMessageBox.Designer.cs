namespace survey
{
    partial class CustomMessageBox
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
            this.button1 = new System.Windows.Forms.Button();
            this.save_question_button = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.header_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.button1);
            this.header_panel.Controls.Add(this.save_question_button);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Location = new System.Drawing.Point(12, 12);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(224, 202);
            this.header_panel.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // save_question_button
            // 
            this.save_question_button.Location = new System.Drawing.Point(14, 98);
            this.save_question_button.Name = "save_question_button";
            this.save_question_button.Size = new System.Drawing.Size(197, 38);
            this.save_question_button.TabIndex = 7;
            this.save_question_button.Text = "Continue";
            this.save_question_button.UseVisualStyleBackColor = true;
            this.save_question_button.Click += new System.EventHandler(this.save_question_button_Click);
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.header_label.Location = new System.Drawing.Point(14, 13);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(189, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Survey Saved";
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 224);
            this.Controls.Add(this.header_panel);
            this.Name = "CustomMessageBox";
            this.Text = "CustomMessageBox";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomMessageBox_FormClosed);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button save_question_button;
    }
}