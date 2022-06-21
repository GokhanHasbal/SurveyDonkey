namespace survey
{
    partial class CreateaSurvey
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
            this.back_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.multi_select_multiple_choice_button = new System.Windows.Forms.Button();
            this.visual_matching_button = new System.Windows.Forms.Button();
            this.fill_in_the_blank_button = new System.Windows.Forms.Button();
            this.matching_button = new System.Windows.Forms.Button();
            this.short_answer_button = new System.Windows.Forms.Button();
            this.single_select_multiple_choice_button = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.back_button);
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Location = new System.Drawing.Point(13, 12);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(775, 95);
            this.header_panel.TabIndex = 2;
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(585, 3);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(75, 23);
            this.back_button.TabIndex = 2;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(683, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.header_label.Location = new System.Drawing.Point(22, 14);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(218, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Create a Survey";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.multi_select_multiple_choice_button);
            this.container_panel.Controls.Add(this.visual_matching_button);
            this.container_panel.Controls.Add(this.fill_in_the_blank_button);
            this.container_panel.Controls.Add(this.matching_button);
            this.container_panel.Controls.Add(this.short_answer_button);
            this.container_panel.Controls.Add(this.single_select_multiple_choice_button);
            this.container_panel.Location = new System.Drawing.Point(13, 140);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(775, 192);
            this.container_panel.TabIndex = 3;
            // 
            // multi_select_multiple_choice_button
            // 
            this.multi_select_multiple_choice_button.BackColor = System.Drawing.SystemColors.Control;
            this.multi_select_multiple_choice_button.Location = new System.Drawing.Point(130, 107);
            this.multi_select_multiple_choice_button.Name = "multi_select_multiple_choice_button";
            this.multi_select_multiple_choice_button.Size = new System.Drawing.Size(108, 63);
            this.multi_select_multiple_choice_button.TabIndex = 7;
            this.multi_select_multiple_choice_button.Text = "\r\nMultiple-Response";
            this.multi_select_multiple_choice_button.UseVisualStyleBackColor = false;
            this.multi_select_multiple_choice_button.Click += new System.EventHandler(this.multi_select_multiple_choice_button_Click);
            // 
            // visual_matching_button
            // 
            this.visual_matching_button.BackColor = System.Drawing.SystemColors.Control;
            this.visual_matching_button.Location = new System.Drawing.Point(562, 107);
            this.visual_matching_button.Name = "visual_matching_button";
            this.visual_matching_button.Size = new System.Drawing.Size(108, 63);
            this.visual_matching_button.TabIndex = 6;
            this.visual_matching_button.Text = "Visual-Matching";
            this.visual_matching_button.UseVisualStyleBackColor = false;
            this.visual_matching_button.Click += new System.EventHandler(this.visual_matching_button_Click);
            // 
            // fill_in_the_blank_button
            // 
            this.fill_in_the_blank_button.BackColor = System.Drawing.SystemColors.Control;
            this.fill_in_the_blank_button.Location = new System.Drawing.Point(346, 107);
            this.fill_in_the_blank_button.Name = "fill_in_the_blank_button";
            this.fill_in_the_blank_button.Size = new System.Drawing.Size(108, 63);
            this.fill_in_the_blank_button.TabIndex = 5;
            this.fill_in_the_blank_button.Text = "Fill-in-the-Blank";
            this.fill_in_the_blank_button.UseVisualStyleBackColor = false;
            this.fill_in_the_blank_button.Click += new System.EventHandler(this.fill_in_the_blank_button_Click);
            // 
            // matching_button
            // 
            this.matching_button.BackColor = System.Drawing.SystemColors.Control;
            this.matching_button.Location = new System.Drawing.Point(454, 23);
            this.matching_button.Name = "matching_button";
            this.matching_button.Size = new System.Drawing.Size(108, 63);
            this.matching_button.TabIndex = 4;
            this.matching_button.Text = "Matching";
            this.matching_button.UseVisualStyleBackColor = false;
            this.matching_button.Click += new System.EventHandler(this.matching_button_Click);
            // 
            // short_answer_button
            // 
            this.short_answer_button.BackColor = System.Drawing.SystemColors.Control;
            this.short_answer_button.Location = new System.Drawing.Point(238, 23);
            this.short_answer_button.Name = "short_answer_button";
            this.short_answer_button.Size = new System.Drawing.Size(108, 63);
            this.short_answer_button.TabIndex = 4;
            this.short_answer_button.Text = "Short-Answer";
            this.short_answer_button.UseVisualStyleBackColor = false;
            this.short_answer_button.Click += new System.EventHandler(this.short_answer_button_Click);
            // 
            // single_select_multiple_choice_button
            // 
            this.single_select_multiple_choice_button.BackColor = System.Drawing.SystemColors.Control;
            this.single_select_multiple_choice_button.Location = new System.Drawing.Point(22, 23);
            this.single_select_multiple_choice_button.Name = "single_select_multiple_choice_button";
            this.single_select_multiple_choice_button.Size = new System.Drawing.Size(108, 63);
            this.single_select_multiple_choice_button.TabIndex = 0;
            this.single_select_multiple_choice_button.Text = "Multiple-Choice";
            this.single_select_multiple_choice_button.UseVisualStyleBackColor = false;
            this.single_select_multiple_choice_button.Click += new System.EventHandler(this.single_select_multiple_choice_button_Click);
            this.single_select_multiple_choice_button.MouseLeave += new System.EventHandler(this.single_select_multiple_choice_button_MouseLeave);
            this.single_select_multiple_choice_button.MouseHover += new System.EventHandler(this.single_select_multiple_choice_button_MouseHover);
            // 
            // CreateaSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateaSurvey";
            this.Text = "CreateaSurvey";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateaSurvey_FormClosed);
            this.Load += new System.EventHandler(this.CreateaSurvey_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.Button single_select_multiple_choice_button;
        private System.Windows.Forms.Button short_answer_button;
        private System.Windows.Forms.Button matching_button;
        private System.Windows.Forms.Button visual_matching_button;
        private System.Windows.Forms.Button fill_in_the_blank_button;
        private System.Windows.Forms.Button multi_select_multiple_choice_button;
    }
}