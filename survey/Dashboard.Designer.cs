namespace survey
{
    partial class Dashboard
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
            this.boss_label = new System.Windows.Forms.Label();
            this.logout_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.header_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.survey_data_label = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.survey_datagridview = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.create_survey_button = new System.Windows.Forms.Button();
            this.filler_panel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.header_panel.SuspendLayout();
            this.container_panel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.survey_datagridview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.filler_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.boss_label);
            this.header_panel.Controls.Add(this.logout_button);
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_panel.Location = new System.Drawing.Point(0, 0);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(1620, 83);
            this.header_panel.TabIndex = 2;
            // 
            // boss_label
            // 
            this.boss_label.AutoSize = true;
            this.boss_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.boss_label.Location = new System.Drawing.Point(211, 14);
            this.boss_label.Name = "boss_label";
            this.boss_label.Size = new System.Drawing.Size(75, 37);
            this.boss_label.TabIndex = 5;
            this.boss_label.Text = "Boss";
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
            this.header_label.Location = new System.Drawing.Point(22, 14);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(157, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Dashboard";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.label1);
            this.container_panel.Controls.Add(this.type_combobox);
            this.container_panel.Controls.Add(this.survey_data_label);
            this.container_panel.Controls.Add(this.tabControl1);
            this.container_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.container_panel.Location = new System.Drawing.Point(0, 201);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(1620, 719);
            this.container_panel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(276, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Type";
            // 
            // type_combobox
            // 
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Location = new System.Drawing.Point(276, 28);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(121, 23);
            this.type_combobox.TabIndex = 4;
            this.type_combobox.SelectionChangeCommitted += new System.EventHandler(this.type_combobox_SelectionChangeCommitted);
            // 
            // survey_data_label
            // 
            this.survey_data_label.AutoSize = true;
            this.survey_data_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.survey_data_label.Location = new System.Drawing.Point(3, 10);
            this.survey_data_label.Name = "survey_data_label";
            this.survey_data_label.Size = new System.Drawing.Size(173, 37);
            this.survey_data_label.TabIndex = 1;
            this.survey_data_label.Text = "Survey Data";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1602, 666);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.survey_datagridview);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1594, 638);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Answered Questions";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // survey_datagridview
            // 
            this.survey_datagridview.AllowUserToAddRows = false;
            this.survey_datagridview.AllowUserToDeleteRows = false;
            this.survey_datagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.survey_datagridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.survey_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.survey_datagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.survey_datagridview.Location = new System.Drawing.Point(3, 3);
            this.survey_datagridview.Name = "survey_datagridview";
            this.survey_datagridview.ReadOnly = true;
            this.survey_datagridview.RowHeadersWidth = 60;
            this.survey_datagridview.RowTemplate.Height = 25;
            this.survey_datagridview.Size = new System.Drawing.Size(1588, 632);
            this.survey_datagridview.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1594, 638);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Progress";
            // 
            // create_survey_button
            // 
            this.create_survey_button.Location = new System.Drawing.Point(270, 29);
            this.create_survey_button.Name = "create_survey_button";
            this.create_survey_button.Size = new System.Drawing.Size(139, 49);
            this.create_survey_button.TabIndex = 4;
            this.create_survey_button.Text = "Create a New Survey";
            this.create_survey_button.UseVisualStyleBackColor = true;
            this.create_survey_button.Click += new System.EventHandler(this.create_survey_button_Click);
            // 
            // filler_panel
            // 
            this.filler_panel.Controls.Add(this.create_survey_button);
            this.filler_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filler_panel.Location = new System.Drawing.Point(0, 83);
            this.filler_panel.Name = "filler_panel";
            this.filler_panel.Size = new System.Drawing.Size(1620, 100);
            this.filler_panel.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(353, 21);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(430, 82);
            this.progressBar1.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1620, 920);
            this.Controls.Add(this.filler_panel);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.survey_datagridview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.filler_panel.ResumeLayout(false);
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
        private System.Windows.Forms.Button create_survey_button;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label boss_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.Panel filler_panel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}