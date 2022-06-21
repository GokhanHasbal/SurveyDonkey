namespace survey
{
    partial class UserUI
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
            this.test = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.survey_group_combobox = new System.Windows.Forms.ComboBox();
            this.bring_survey_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.survey_type_combobox = new System.Windows.Forms.ComboBox();
            this.start_survey_button = new System.Windows.Forms.Button();
            this.random_survey_button = new System.Windows.Forms.Button();
            this.survey_category_combobox = new System.Windows.Forms.ComboBox();
            this.survey_datagridview = new System.Windows.Forms.DataGridView();
            this.survey_data_label = new System.Windows.Forms.Label();
            this.header_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survey_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.test);
            this.header_panel.Controls.Add(this.username_label);
            this.header_panel.Controls.Add(this.logout_button);
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Location = new System.Drawing.Point(12, 12);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(775, 98);
            this.header_panel.TabIndex = 3;
            // 
            // test
            // 
            this.test.AutoSize = true;
            this.test.Location = new System.Drawing.Point(389, 34);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(38, 15);
            this.test.TabIndex = 6;
            this.test.Text = "label4";
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.username_label.Location = new System.Drawing.Point(22, 51);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(146, 37);
            this.username_label.TabIndex = 5;
            this.username_label.Text = "Username";
            // 
            // logout_button
            // 
            this.logout_button.Location = new System.Drawing.Point(601, 14);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(75, 23);
            this.logout_button.TabIndex = 2;
            this.logout_button.Text = "Logout";
            this.logout_button.UseVisualStyleBackColor = true;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(682, 14);
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
            this.header_label.Location = new System.Drawing.Point(0, 0);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(46, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "UI";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.label3);
            this.container_panel.Controls.Add(this.survey_group_combobox);
            this.container_panel.Controls.Add(this.bring_survey_button);
            this.container_panel.Controls.Add(this.label2);
            this.container_panel.Controls.Add(this.label1);
            this.container_panel.Controls.Add(this.survey_type_combobox);
            this.container_panel.Controls.Add(this.start_survey_button);
            this.container_panel.Controls.Add(this.random_survey_button);
            this.container_panel.Controls.Add(this.survey_category_combobox);
            this.container_panel.Controls.Add(this.survey_datagridview);
            this.container_panel.Controls.Add(this.survey_data_label);
            this.container_panel.Location = new System.Drawing.Point(12, 131);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(775, 307);
            this.container_panel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Name";
            // 
            // survey_group_combobox
            // 
            this.survey_group_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.survey_group_combobox.FormattingEnabled = true;
            this.survey_group_combobox.Location = new System.Drawing.Point(307, 58);
            this.survey_group_combobox.Name = "survey_group_combobox";
            this.survey_group_combobox.Size = new System.Drawing.Size(121, 23);
            this.survey_group_combobox.TabIndex = 12;
            // 
            // bring_survey_button
            // 
            this.bring_survey_button.Location = new System.Drawing.Point(468, 17);
            this.bring_survey_button.Name = "bring_survey_button";
            this.bring_survey_button.Size = new System.Drawing.Size(84, 49);
            this.bring_survey_button.TabIndex = 11;
            this.bring_survey_button.Text = "Bring Surveys";
            this.bring_survey_button.UseVisualStyleBackColor = true;
            this.bring_survey_button.Click += new System.EventHandler(this.bring_survey_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Category";
            // 
            // survey_type_combobox
            // 
            this.survey_type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.survey_type_combobox.FormattingEnabled = true;
            this.survey_type_combobox.Location = new System.Drawing.Point(341, 31);
            this.survey_type_combobox.Name = "survey_type_combobox";
            this.survey_type_combobox.Size = new System.Drawing.Size(121, 23);
            this.survey_type_combobox.TabIndex = 8;
            this.survey_type_combobox.SelectionChangeCommitted += new System.EventHandler(this.survey_type_combobox_SelectionChangeCommitted);
            // 
            // start_survey_button
            // 
            this.start_survey_button.Location = new System.Drawing.Point(558, 17);
            this.start_survey_button.Name = "start_survey_button";
            this.start_survey_button.Size = new System.Drawing.Size(96, 49);
            this.start_survey_button.TabIndex = 7;
            this.start_survey_button.Text = "Start Survey";
            this.start_survey_button.UseVisualStyleBackColor = true;
            this.start_survey_button.Click += new System.EventHandler(this.start_survey_button_Click);
            // 
            // random_survey_button
            // 
            this.random_survey_button.Location = new System.Drawing.Point(660, 17);
            this.random_survey_button.Name = "random_survey_button";
            this.random_survey_button.Size = new System.Drawing.Size(95, 49);
            this.random_survey_button.TabIndex = 6;
            this.random_survey_button.Text = "I\'m feeling lucky";
            this.random_survey_button.UseVisualStyleBackColor = true;
            this.random_survey_button.Click += new System.EventHandler(this.random_survey_button_Click);
            // 
            // survey_category_combobox
            // 
            this.survey_category_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.survey_category_combobox.FormattingEnabled = true;
            this.survey_category_combobox.Location = new System.Drawing.Point(214, 31);
            this.survey_category_combobox.Name = "survey_category_combobox";
            this.survey_category_combobox.Size = new System.Drawing.Size(121, 23);
            this.survey_category_combobox.TabIndex = 5;
            this.survey_category_combobox.SelectionChangeCommitted += new System.EventHandler(this.survey_category_combobox_SelectionChangeCommitted);
            // 
            // survey_datagridview
            // 
            this.survey_datagridview.AllowUserToAddRows = false;
            this.survey_datagridview.AllowUserToDeleteRows = false;
            this.survey_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.survey_datagridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.survey_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.survey_datagridview.Location = new System.Drawing.Point(10, 87);
            this.survey_datagridview.Name = "survey_datagridview";
            this.survey_datagridview.ReadOnly = true;
            this.survey_datagridview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.survey_datagridview.RowTemplate.Height = 25;
            this.survey_datagridview.Size = new System.Drawing.Size(747, 202);
            this.survey_datagridview.TabIndex = 2;
            // 
            // survey_data_label
            // 
            this.survey_data_label.AutoSize = true;
            this.survey_data_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.survey_data_label.Location = new System.Drawing.Point(3, 10);
            this.survey_data_label.Name = "survey_data_label";
            this.survey_data_label.Size = new System.Drawing.Size(191, 37);
            this.survey_data_label.TabIndex = 1;
            this.survey_data_label.Text = "Survey Picker";
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserUI";
            this.Text = "UserUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UserUI_FormClosed);
            this.Load += new System.EventHandler(this.UserUI_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survey_datagridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.DataGridView survey_datagridview;
        private System.Windows.Forms.Label survey_data_label;
        private System.Windows.Forms.ComboBox survey_category_combobox;
        private System.Windows.Forms.Button start_survey_button;
        private System.Windows.Forms.Button random_survey_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.ComboBox survey_type_combobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bring_survey_button;
        private System.Windows.Forms.ComboBox survey_group_combobox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label test;
    }
}