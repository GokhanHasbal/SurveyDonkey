namespace survey
{
    partial class Register
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
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.username_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.surname_label = new System.Windows.Forms.Label();
            this.surname_textbox = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.confirm_password_label = new System.Windows.Forms.Label();
            this.confirm_password_textbox = new System.Windows.Forms.TextBox();
            this.age_label = new System.Windows.Forms.Label();
            this.age_numupdown = new System.Windows.Forms.NumericUpDown();
            this.gender_groupbox = new System.Windows.Forms.GroupBox();
            this.other_radiobutton = new System.Windows.Forms.RadioButton();
            this.female_radiobutton = new System.Windows.Forms.RadioButton();
            this.male_radiobutton = new System.Windows.Forms.RadioButton();
            this.marital_groupbox = new System.Windows.Forms.GroupBox();
            this.noanswer_radiobutton = new System.Windows.Forms.RadioButton();
            this.widowed_radiobutton = new System.Windows.Forms.RadioButton();
            this.divorcee_radiobutton = new System.Windows.Forms.RadioButton();
            this.married_radiobutton = new System.Windows.Forms.RadioButton();
            this.single_radiobutton = new System.Windows.Forms.RadioButton();
            this.driving_licence_textbox = new System.Windows.Forms.Label();
            this.driving_licence_combobox = new System.Windows.Forms.ComboBox();
            this.register_button = new System.Windows.Forms.Button();
            this.city_label = new System.Windows.Forms.Label();
            this.city_textbox = new System.Windows.Forms.TextBox();
            this.container_panel = new System.Windows.Forms.Panel();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age_numupdown)).BeginInit();
            this.gender_groupbox.SuspendLayout();
            this.marital_groupbox.SuspendLayout();
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
            this.header_panel.TabIndex = 1;
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
            this.header_label.Size = new System.Drawing.Size(123, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Register";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(22, 57);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.PlaceholderText = "Username";
            this.username_textbox.Size = new System.Drawing.Size(100, 23);
            this.username_textbox.TabIndex = 2;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(23, 34);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(60, 15);
            this.username_label.TabIndex = 3;
            this.username_label.Text = "Username";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(23, 108);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(39, 15);
            this.name_label.TabIndex = 5;
            this.name_label.Text = "Name";
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(22, 131);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.PlaceholderText = "Name";
            this.name_textbox.Size = new System.Drawing.Size(100, 23);
            this.name_textbox.TabIndex = 4;
            // 
            // surname_label
            // 
            this.surname_label.AutoSize = true;
            this.surname_label.Location = new System.Drawing.Point(23, 186);
            this.surname_label.Name = "surname_label";
            this.surname_label.Size = new System.Drawing.Size(54, 15);
            this.surname_label.TabIndex = 7;
            this.surname_label.Text = "Surname";
            // 
            // surname_textbox
            // 
            this.surname_textbox.Location = new System.Drawing.Point(22, 209);
            this.surname_textbox.Name = "surname_textbox";
            this.surname_textbox.PlaceholderText = "Surname";
            this.surname_textbox.Size = new System.Drawing.Size(100, 23);
            this.surname_textbox.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(154, 34);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 15);
            this.password_label.TabIndex = 9;
            this.password_label.Text = "Password";
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(153, 57);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.PlaceholderText = "Password";
            this.password_textbox.Size = new System.Drawing.Size(100, 23);
            this.password_textbox.TabIndex = 8;
            // 
            // confirm_password_label
            // 
            this.confirm_password_label.AutoSize = true;
            this.confirm_password_label.Location = new System.Drawing.Point(153, 108);
            this.confirm_password_label.Name = "confirm_password_label";
            this.confirm_password_label.Size = new System.Drawing.Size(104, 15);
            this.confirm_password_label.TabIndex = 11;
            this.confirm_password_label.Text = "Confirm Password";
            // 
            // confirm_password_textbox
            // 
            this.confirm_password_textbox.Location = new System.Drawing.Point(152, 131);
            this.confirm_password_textbox.Name = "confirm_password_textbox";
            this.confirm_password_textbox.PasswordChar = '*';
            this.confirm_password_textbox.PlaceholderText = "Password";
            this.confirm_password_textbox.Size = new System.Drawing.Size(100, 23);
            this.confirm_password_textbox.TabIndex = 10;
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Location = new System.Drawing.Point(159, 186);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(28, 15);
            this.age_label.TabIndex = 12;
            this.age_label.Text = "Age";
            // 
            // age_numupdown
            // 
            this.age_numupdown.Location = new System.Drawing.Point(159, 209);
            this.age_numupdown.Name = "age_numupdown";
            this.age_numupdown.Size = new System.Drawing.Size(65, 23);
            this.age_numupdown.TabIndex = 13;
            // 
            // gender_groupbox
            // 
            this.gender_groupbox.Controls.Add(this.other_radiobutton);
            this.gender_groupbox.Controls.Add(this.female_radiobutton);
            this.gender_groupbox.Controls.Add(this.male_radiobutton);
            this.gender_groupbox.Location = new System.Drawing.Point(294, 34);
            this.gender_groupbox.Name = "gender_groupbox";
            this.gender_groupbox.Size = new System.Drawing.Size(72, 116);
            this.gender_groupbox.TabIndex = 14;
            this.gender_groupbox.TabStop = false;
            this.gender_groupbox.Text = "Gender";
            // 
            // other_radiobutton
            // 
            this.other_radiobutton.AutoSize = true;
            this.other_radiobutton.Location = new System.Drawing.Point(6, 73);
            this.other_radiobutton.Name = "other_radiobutton";
            this.other_radiobutton.Size = new System.Drawing.Size(55, 19);
            this.other_radiobutton.TabIndex = 17;
            this.other_radiobutton.TabStop = true;
            this.other_radiobutton.Text = "Other";
            this.other_radiobutton.UseVisualStyleBackColor = true;
            // 
            // female_radiobutton
            // 
            this.female_radiobutton.AutoSize = true;
            this.female_radiobutton.Location = new System.Drawing.Point(6, 50);
            this.female_radiobutton.Name = "female_radiobutton";
            this.female_radiobutton.Size = new System.Drawing.Size(63, 19);
            this.female_radiobutton.TabIndex = 16;
            this.female_radiobutton.TabStop = true;
            this.female_radiobutton.Text = "Female";
            this.female_radiobutton.UseVisualStyleBackColor = true;
            // 
            // male_radiobutton
            // 
            this.male_radiobutton.AutoSize = true;
            this.male_radiobutton.Location = new System.Drawing.Point(6, 27);
            this.male_radiobutton.Name = "male_radiobutton";
            this.male_radiobutton.Size = new System.Drawing.Size(51, 19);
            this.male_radiobutton.TabIndex = 15;
            this.male_radiobutton.TabStop = true;
            this.male_radiobutton.Text = "Male";
            this.male_radiobutton.UseVisualStyleBackColor = true;
            // 
            // marital_groupbox
            // 
            this.marital_groupbox.Controls.Add(this.noanswer_radiobutton);
            this.marital_groupbox.Controls.Add(this.widowed_radiobutton);
            this.marital_groupbox.Controls.Add(this.divorcee_radiobutton);
            this.marital_groupbox.Controls.Add(this.married_radiobutton);
            this.marital_groupbox.Controls.Add(this.single_radiobutton);
            this.marital_groupbox.Location = new System.Drawing.Point(391, 34);
            this.marital_groupbox.Name = "marital_groupbox";
            this.marital_groupbox.Size = new System.Drawing.Size(104, 154);
            this.marital_groupbox.TabIndex = 15;
            this.marital_groupbox.TabStop = false;
            this.marital_groupbox.Text = "Marital Status";
            // 
            // noanswer_radiobutton
            // 
            this.noanswer_radiobutton.AutoSize = true;
            this.noanswer_radiobutton.Location = new System.Drawing.Point(6, 119);
            this.noanswer_radiobutton.Name = "noanswer_radiobutton";
            this.noanswer_radiobutton.Size = new System.Drawing.Size(47, 19);
            this.noanswer_radiobutton.TabIndex = 19;
            this.noanswer_radiobutton.TabStop = true;
            this.noanswer_radiobutton.Text = "N/A";
            this.noanswer_radiobutton.UseVisualStyleBackColor = true;
            // 
            // widowed_radiobutton
            // 
            this.widowed_radiobutton.AutoSize = true;
            this.widowed_radiobutton.Location = new System.Drawing.Point(6, 96);
            this.widowed_radiobutton.Name = "widowed_radiobutton";
            this.widowed_radiobutton.Size = new System.Drawing.Size(75, 19);
            this.widowed_radiobutton.TabIndex = 18;
            this.widowed_radiobutton.TabStop = true;
            this.widowed_radiobutton.Text = "Widowed";
            this.widowed_radiobutton.UseVisualStyleBackColor = true;
            // 
            // divorcee_radiobutton
            // 
            this.divorcee_radiobutton.AutoSize = true;
            this.divorcee_radiobutton.Location = new System.Drawing.Point(6, 73);
            this.divorcee_radiobutton.Name = "divorcee_radiobutton";
            this.divorcee_radiobutton.Size = new System.Drawing.Size(71, 19);
            this.divorcee_radiobutton.TabIndex = 17;
            this.divorcee_radiobutton.TabStop = true;
            this.divorcee_radiobutton.Text = "Divorcee";
            this.divorcee_radiobutton.UseVisualStyleBackColor = true;
            // 
            // married_radiobutton
            // 
            this.married_radiobutton.AutoSize = true;
            this.married_radiobutton.Location = new System.Drawing.Point(6, 50);
            this.married_radiobutton.Name = "married_radiobutton";
            this.married_radiobutton.Size = new System.Drawing.Size(66, 19);
            this.married_radiobutton.TabIndex = 16;
            this.married_radiobutton.TabStop = true;
            this.married_radiobutton.Text = "Married";
            this.married_radiobutton.UseVisualStyleBackColor = true;
            // 
            // single_radiobutton
            // 
            this.single_radiobutton.AutoSize = true;
            this.single_radiobutton.Location = new System.Drawing.Point(6, 27);
            this.single_radiobutton.Name = "single_radiobutton";
            this.single_radiobutton.Size = new System.Drawing.Size(57, 19);
            this.single_radiobutton.TabIndex = 15;
            this.single_radiobutton.TabStop = true;
            this.single_radiobutton.Text = "Single";
            this.single_radiobutton.UseVisualStyleBackColor = true;
            // 
            // driving_licence_textbox
            // 
            this.driving_licence_textbox.AutoSize = true;
            this.driving_licence_textbox.Location = new System.Drawing.Point(262, 195);
            this.driving_licence_textbox.Name = "driving_licence_textbox";
            this.driving_licence_textbox.Size = new System.Drawing.Size(88, 15);
            this.driving_licence_textbox.TabIndex = 16;
            this.driving_licence_textbox.Text = "Driving Licence";
            // 
            // driving_licence_combobox
            // 
            this.driving_licence_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.driving_licence_combobox.FormattingEnabled = true;
            this.driving_licence_combobox.Items.AddRange(new object[] {
            "None",
            "M",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G"});
            this.driving_licence_combobox.Location = new System.Drawing.Point(263, 218);
            this.driving_licence_combobox.Name = "driving_licence_combobox";
            this.driving_licence_combobox.Size = new System.Drawing.Size(121, 23);
            this.driving_licence_combobox.TabIndex = 17;
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(664, 218);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 20;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // city_label
            // 
            this.city_label.AutoSize = true;
            this.city_label.Location = new System.Drawing.Point(428, 195);
            this.city_label.Name = "city_label";
            this.city_label.Size = new System.Drawing.Size(28, 15);
            this.city_label.TabIndex = 18;
            this.city_label.Text = "City";
            // 
            // city_textbox
            // 
            this.city_textbox.Location = new System.Drawing.Point(427, 218);
            this.city_textbox.Name = "city_textbox";
            this.city_textbox.PlaceholderText = "City";
            this.city_textbox.Size = new System.Drawing.Size(100, 23);
            this.city_textbox.TabIndex = 19;
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.username_label);
            this.container_panel.Controls.Add(this.city_label);
            this.container_panel.Controls.Add(this.username_textbox);
            this.container_panel.Controls.Add(this.city_textbox);
            this.container_panel.Controls.Add(this.name_textbox);
            this.container_panel.Controls.Add(this.register_button);
            this.container_panel.Controls.Add(this.name_label);
            this.container_panel.Controls.Add(this.driving_licence_combobox);
            this.container_panel.Controls.Add(this.surname_textbox);
            this.container_panel.Controls.Add(this.driving_licence_textbox);
            this.container_panel.Controls.Add(this.surname_label);
            this.container_panel.Controls.Add(this.marital_groupbox);
            this.container_panel.Controls.Add(this.password_textbox);
            this.container_panel.Controls.Add(this.gender_groupbox);
            this.container_panel.Controls.Add(this.password_label);
            this.container_panel.Controls.Add(this.age_numupdown);
            this.container_panel.Controls.Add(this.confirm_password_textbox);
            this.container_panel.Controls.Add(this.age_label);
            this.container_panel.Controls.Add(this.confirm_password_label);
            this.container_panel.Location = new System.Drawing.Point(12, 160);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(776, 263);
            this.container_panel.TabIndex = 21;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.Load += new System.EventHandler(this.Register_Load);
            this.Shown += new System.EventHandler(this.Register_Shown);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.age_numupdown)).EndInit();
            this.gender_groupbox.ResumeLayout(false);
            this.gender_groupbox.PerformLayout();
            this.marital_groupbox.ResumeLayout(false);
            this.marital_groupbox.PerformLayout();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label surname_label;
        private System.Windows.Forms.TextBox surname_textbox;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label confirm_password_label;
        private System.Windows.Forms.TextBox confirm_password_textbox;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.NumericUpDown age_numupdown;
        private System.Windows.Forms.GroupBox gender_groupbox;
        private System.Windows.Forms.RadioButton other_radiobutton;
        private System.Windows.Forms.RadioButton female_radiobutton;
        private System.Windows.Forms.RadioButton male_radiobutton;
        private System.Windows.Forms.GroupBox marital_groupbox;
        private System.Windows.Forms.RadioButton widowed_radiobutton;
        private System.Windows.Forms.RadioButton divorcee_radiobutton;
        private System.Windows.Forms.RadioButton married_radiobutton;
        private System.Windows.Forms.RadioButton single_radiobutton;
        private System.Windows.Forms.RadioButton noanswer_radiobutton;
        private System.Windows.Forms.Label driving_licence_textbox;
        private System.Windows.Forms.ComboBox driving_licence_combobox;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label city_label;
        private System.Windows.Forms.TextBox city_textbox;
        private System.Windows.Forms.Panel container_panel;
    }
}