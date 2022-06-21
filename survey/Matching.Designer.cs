namespace survey
{
    partial class Matching
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
            this.survey_length_label = new System.Windows.Forms.Label();
            this.survey_length_nupd = new System.Windows.Forms.NumericUpDown();
            this.survey_name_label = new System.Windows.Forms.Label();
            this.survey_category_combobox = new System.Windows.Forms.ComboBox();
            this.survey_name_save_button = new System.Windows.Forms.Button();
            this.survey_name_textbox = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.question_label = new System.Windows.Forms.Label();
            this.question_richtexbox = new System.Windows.Forms.RichTextBox();
            this.choiceD_textbox = new System.Windows.Forms.TextBox();
            this.choiceD_label = new System.Windows.Forms.Label();
            this.choiceC_textbox = new System.Windows.Forms.TextBox();
            this.choiceC_label = new System.Windows.Forms.Label();
            this.choiceB_textbox = new System.Windows.Forms.TextBox();
            this.choiceB_label = new System.Windows.Forms.Label();
            this.choiceA_textbox = new System.Windows.Forms.TextBox();
            this.answerD_textbox = new System.Windows.Forms.TextBox();
            this.answerC_textbox = new System.Windows.Forms.TextBox();
            this.answerB_textbox = new System.Windows.Forms.TextBox();
            this.answerA_textbox = new System.Windows.Forms.TextBox();
            this.answerD_label = new System.Windows.Forms.Label();
            this.answerC_label = new System.Windows.Forms.Label();
            this.answerB_label = new System.Windows.Forms.Label();
            this.answerA_label = new System.Windows.Forms.Label();
            this.choiceA_label = new System.Windows.Forms.Label();
            this.footer_panel = new System.Windows.Forms.Panel();
            this.question_count_label = new System.Windows.Forms.Label();
            this.save_question_button = new System.Windows.Forms.Button();
            this.save_survey_buıtton = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survey_length_nupd)).BeginInit();
            this.container_panel.SuspendLayout();
            this.footer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.survey_length_label);
            this.header_panel.Controls.Add(this.survey_length_nupd);
            this.header_panel.Controls.Add(this.survey_name_label);
            this.header_panel.Controls.Add(this.survey_category_combobox);
            this.header_panel.Controls.Add(this.survey_name_save_button);
            this.header_panel.Controls.Add(this.survey_name_textbox);
            this.header_panel.Controls.Add(this.back_button);
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Location = new System.Drawing.Point(12, 12);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(775, 95);
            this.header_panel.TabIndex = 4;
            // 
            // survey_length_label
            // 
            this.survey_length_label.AutoSize = true;
            this.survey_length_label.Location = new System.Drawing.Point(34, 61);
            this.survey_length_label.Name = "survey_length_label";
            this.survey_length_label.Size = new System.Drawing.Size(82, 15);
            this.survey_length_label.TabIndex = 28;
            this.survey_length_label.Text = "Survey Length";
            // 
            // survey_length_nupd
            // 
            this.survey_length_nupd.Location = new System.Drawing.Point(126, 57);
            this.survey_length_nupd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.survey_length_nupd.Name = "survey_length_nupd";
            this.survey_length_nupd.Size = new System.Drawing.Size(120, 23);
            this.survey_length_nupd.TabIndex = 6;
            this.survey_length_nupd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // survey_name_label
            // 
            this.survey_name_label.AutoSize = true;
            this.survey_name_label.Location = new System.Drawing.Point(430, 36);
            this.survey_name_label.Name = "survey_name_label";
            this.survey_name_label.Size = new System.Drawing.Size(77, 15);
            this.survey_name_label.TabIndex = 25;
            this.survey_name_label.Text = "Survey Name";
            // 
            // survey_category_combobox
            // 
            this.survey_category_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.survey_category_combobox.FormattingEnabled = true;
            this.survey_category_combobox.Location = new System.Drawing.Point(268, 57);
            this.survey_category_combobox.Name = "survey_category_combobox";
            this.survey_category_combobox.Size = new System.Drawing.Size(132, 23);
            this.survey_category_combobox.TabIndex = 4;
            // 
            // survey_name_save_button
            // 
            this.survey_name_save_button.Location = new System.Drawing.Point(616, 57);
            this.survey_name_save_button.Name = "survey_name_save_button";
            this.survey_name_save_button.Size = new System.Drawing.Size(75, 23);
            this.survey_name_save_button.TabIndex = 5;
            this.survey_name_save_button.Text = "Save";
            this.survey_name_save_button.UseVisualStyleBackColor = true;
            this.survey_name_save_button.Click += new System.EventHandler(this.survey_name_save_button_Click);
            // 
            // survey_name_textbox
            // 
            this.survey_name_textbox.Location = new System.Drawing.Point(429, 57);
            this.survey_name_textbox.Name = "survey_name_textbox";
            this.survey_name_textbox.Size = new System.Drawing.Size(170, 23);
            this.survey_name_textbox.TabIndex = 3;
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
            this.header_label.Size = new System.Drawing.Size(234, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Matching Survey";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.question_label);
            this.container_panel.Controls.Add(this.question_richtexbox);
            this.container_panel.Controls.Add(this.choiceD_textbox);
            this.container_panel.Controls.Add(this.choiceD_label);
            this.container_panel.Controls.Add(this.choiceC_textbox);
            this.container_panel.Controls.Add(this.choiceC_label);
            this.container_panel.Controls.Add(this.choiceB_textbox);
            this.container_panel.Controls.Add(this.choiceB_label);
            this.container_panel.Controls.Add(this.choiceA_textbox);
            this.container_panel.Controls.Add(this.answerD_textbox);
            this.container_panel.Controls.Add(this.answerC_textbox);
            this.container_panel.Controls.Add(this.answerB_textbox);
            this.container_panel.Controls.Add(this.answerA_textbox);
            this.container_panel.Controls.Add(this.answerD_label);
            this.container_panel.Controls.Add(this.answerC_label);
            this.container_panel.Controls.Add(this.answerB_label);
            this.container_panel.Controls.Add(this.answerA_label);
            this.container_panel.Controls.Add(this.choiceA_label);
            this.container_panel.Location = new System.Drawing.Point(12, 113);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(775, 261);
            this.container_panel.TabIndex = 5;
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Location = new System.Drawing.Point(85, 113);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(55, 15);
            this.question_label.TabIndex = 18;
            this.question_label.Text = "Question";
            // 
            // question_richtexbox
            // 
            this.question_richtexbox.Location = new System.Drawing.Point(157, 110);
            this.question_richtexbox.Name = "question_richtexbox";
            this.question_richtexbox.Size = new System.Drawing.Size(537, 46);
            this.question_richtexbox.TabIndex = 7;
            this.question_richtexbox.Text = "";
            // 
            // choiceD_textbox
            // 
            this.choiceD_textbox.Location = new System.Drawing.Point(529, 64);
            this.choiceD_textbox.Name = "choiceD_textbox";
            this.choiceD_textbox.Size = new System.Drawing.Size(165, 23);
            this.choiceD_textbox.TabIndex = 11;
            // 
            // choiceD_label
            // 
            this.choiceD_label.AutoSize = true;
            this.choiceD_label.Location = new System.Drawing.Point(457, 64);
            this.choiceD_label.Name = "choiceD_label";
            this.choiceD_label.Size = new System.Drawing.Size(55, 15);
            this.choiceD_label.TabIndex = 15;
            this.choiceD_label.Text = "Choice D";
            // 
            // choiceC_textbox
            // 
            this.choiceC_textbox.Location = new System.Drawing.Point(162, 64);
            this.choiceC_textbox.Name = "choiceC_textbox";
            this.choiceC_textbox.Size = new System.Drawing.Size(165, 23);
            this.choiceC_textbox.TabIndex = 10;
            // 
            // choiceC_label
            // 
            this.choiceC_label.AutoSize = true;
            this.choiceC_label.Location = new System.Drawing.Point(90, 64);
            this.choiceC_label.Name = "choiceC_label";
            this.choiceC_label.Size = new System.Drawing.Size(55, 15);
            this.choiceC_label.TabIndex = 13;
            this.choiceC_label.Text = "Choice C";
            // 
            // choiceB_textbox
            // 
            this.choiceB_textbox.Location = new System.Drawing.Point(529, 26);
            this.choiceB_textbox.Name = "choiceB_textbox";
            this.choiceB_textbox.Size = new System.Drawing.Size(165, 23);
            this.choiceB_textbox.TabIndex = 9;
            // 
            // choiceB_label
            // 
            this.choiceB_label.AutoSize = true;
            this.choiceB_label.Location = new System.Drawing.Point(457, 26);
            this.choiceB_label.Name = "choiceB_label";
            this.choiceB_label.Size = new System.Drawing.Size(54, 15);
            this.choiceB_label.TabIndex = 11;
            this.choiceB_label.Text = "Choice B";
            // 
            // choiceA_textbox
            // 
            this.choiceA_textbox.Location = new System.Drawing.Point(162, 26);
            this.choiceA_textbox.Name = "choiceA_textbox";
            this.choiceA_textbox.Size = new System.Drawing.Size(165, 23);
            this.choiceA_textbox.TabIndex = 8;
            // 
            // answerD_textbox
            // 
            this.answerD_textbox.Location = new System.Drawing.Point(526, 216);
            this.answerD_textbox.Name = "answerD_textbox";
            this.answerD_textbox.Size = new System.Drawing.Size(165, 23);
            this.answerD_textbox.TabIndex = 15;
            // 
            // answerC_textbox
            // 
            this.answerC_textbox.Location = new System.Drawing.Point(157, 216);
            this.answerC_textbox.Name = "answerC_textbox";
            this.answerC_textbox.Size = new System.Drawing.Size(165, 23);
            this.answerC_textbox.TabIndex = 14;
            // 
            // answerB_textbox
            // 
            this.answerB_textbox.Location = new System.Drawing.Point(526, 176);
            this.answerB_textbox.Name = "answerB_textbox";
            this.answerB_textbox.Size = new System.Drawing.Size(165, 23);
            this.answerB_textbox.TabIndex = 13;
            // 
            // answerA_textbox
            // 
            this.answerA_textbox.Location = new System.Drawing.Point(157, 176);
            this.answerA_textbox.Name = "answerA_textbox";
            this.answerA_textbox.Size = new System.Drawing.Size(165, 23);
            this.answerA_textbox.TabIndex = 12;
            // 
            // answerD_label
            // 
            this.answerD_label.AutoSize = true;
            this.answerD_label.Location = new System.Drawing.Point(464, 216);
            this.answerD_label.Name = "answerD_label";
            this.answerD_label.Size = new System.Drawing.Size(57, 15);
            this.answerD_label.TabIndex = 5;
            this.answerD_label.Text = "Answer D";
            // 
            // answerC_label
            // 
            this.answerC_label.AutoSize = true;
            this.answerC_label.Location = new System.Drawing.Point(94, 216);
            this.answerC_label.Name = "answerC_label";
            this.answerC_label.Size = new System.Drawing.Size(57, 15);
            this.answerC_label.TabIndex = 4;
            this.answerC_label.Text = "Answer C";
            // 
            // answerB_label
            // 
            this.answerB_label.AutoSize = true;
            this.answerB_label.Location = new System.Drawing.Point(465, 176);
            this.answerB_label.Name = "answerB_label";
            this.answerB_label.Size = new System.Drawing.Size(56, 15);
            this.answerB_label.TabIndex = 3;
            this.answerB_label.Text = "Answer B";
            // 
            // answerA_label
            // 
            this.answerA_label.AutoSize = true;
            this.answerA_label.Location = new System.Drawing.Point(94, 176);
            this.answerA_label.Name = "answerA_label";
            this.answerA_label.Size = new System.Drawing.Size(57, 15);
            this.answerA_label.TabIndex = 2;
            this.answerA_label.Text = "Answer A";
            // 
            // choiceA_label
            // 
            this.choiceA_label.AutoSize = true;
            this.choiceA_label.Location = new System.Drawing.Point(90, 26);
            this.choiceA_label.Name = "choiceA_label";
            this.choiceA_label.Size = new System.Drawing.Size(55, 15);
            this.choiceA_label.TabIndex = 1;
            this.choiceA_label.Text = "Choice A";
            // 
            // footer_panel
            // 
            this.footer_panel.Controls.Add(this.question_count_label);
            this.footer_panel.Controls.Add(this.save_question_button);
            this.footer_panel.Controls.Add(this.save_survey_buıtton);
            this.footer_panel.Location = new System.Drawing.Point(13, 380);
            this.footer_panel.Name = "footer_panel";
            this.footer_panel.Size = new System.Drawing.Size(775, 68);
            this.footer_panel.TabIndex = 12;
            // 
            // question_count_label
            // 
            this.question_count_label.AutoSize = true;
            this.question_count_label.Location = new System.Drawing.Point(3, 29);
            this.question_count_label.Name = "question_count_label";
            this.question_count_label.Size = new System.Drawing.Size(120, 15);
            this.question_count_label.TabIndex = 5;
            this.question_count_label.Text = "0 / 5 Questions Saved";
            // 
            // save_question_button
            // 
            this.save_question_button.Location = new System.Drawing.Point(528, 17);
            this.save_question_button.Name = "save_question_button";
            this.save_question_button.Size = new System.Drawing.Size(197, 38);
            this.save_question_button.TabIndex = 16;
            this.save_question_button.Text = "Save Question";
            this.save_question_button.UseVisualStyleBackColor = true;
            this.save_question_button.Click += new System.EventHandler(this.save_question_button_Click);
            // 
            // save_survey_buıtton
            // 
            this.save_survey_buıtton.Location = new System.Drawing.Point(528, 17);
            this.save_survey_buıtton.Name = "save_survey_buıtton";
            this.save_survey_buıtton.Size = new System.Drawing.Size(197, 38);
            this.save_survey_buıtton.TabIndex = 7;
            this.save_survey_buıtton.Text = "Save Survey";
            this.save_survey_buıtton.UseVisualStyleBackColor = true;
            this.save_survey_buıtton.Click += new System.EventHandler(this.save_survey_buıtton_Click);
            // 
            // Matching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.footer_panel);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Matching";
            this.Text = "Matching";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Matching_FormClosed);
            this.Load += new System.EventHandler(this.Matching_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survey_length_nupd)).EndInit();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.footer_panel.ResumeLayout(false);
            this.footer_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.TextBox answerD_textbox;
        private System.Windows.Forms.TextBox answerC_textbox;
        private System.Windows.Forms.TextBox answerB_textbox;
        private System.Windows.Forms.TextBox answerA_textbox;
        private System.Windows.Forms.Label answerD_label;
        private System.Windows.Forms.Label answerC_label;
        private System.Windows.Forms.Label answerB_label;
        private System.Windows.Forms.Label answerA_label;
        private System.Windows.Forms.Label choiceA_label;
        private System.Windows.Forms.Label survey_length_label;
        private System.Windows.Forms.NumericUpDown survey_length_nupd;
        private System.Windows.Forms.Label survey_name_label;
        private System.Windows.Forms.ComboBox survey_category_combobox;
        private System.Windows.Forms.Button survey_name_save_button;
        private System.Windows.Forms.TextBox survey_name_textbox;
        private System.Windows.Forms.Panel footer_panel;
        private System.Windows.Forms.Label question_count_label;
        private System.Windows.Forms.Button save_question_button;
        private System.Windows.Forms.Button save_survey_buıtton;
        private System.Windows.Forms.TextBox choiceD_textbox;
        private System.Windows.Forms.Label choiceD_label;
        private System.Windows.Forms.TextBox choiceC_textbox;
        private System.Windows.Forms.Label choiceC_label;
        private System.Windows.Forms.TextBox choiceB_textbox;
        private System.Windows.Forms.Label choiceB_label;
        private System.Windows.Forms.TextBox choiceA_textbox;
        private System.Windows.Forms.Label question_label;
        private System.Windows.Forms.RichTextBox question_richtexbox;
    }
}