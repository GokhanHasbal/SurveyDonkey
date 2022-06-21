namespace survey
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.header_panel = new System.Windows.Forms.Panel();
            this.header_label = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.admin_button = new System.Windows.Forms.Button();
            this.user_button = new System.Windows.Forms.Button();
            this.register_button = new System.Windows.Forms.Button();
            this.register_label = new System.Windows.Forms.Label();
            this.container_panel = new System.Windows.Forms.Panel();
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.troll_button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.test = new System.Windows.Forms.Button();
            this.header_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.container_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header_panel
            // 
            this.header_panel.Controls.Add(this.header_label);
            this.header_panel.Controls.Add(this.pictureBox2);
            this.header_panel.Controls.Add(this.exit_button);
            this.header_panel.Controls.Add(this.pictureBox1);
            this.header_panel.Location = new System.Drawing.Point(13, 22);
            this.header_panel.Name = "header_panel";
            this.header_panel.Size = new System.Drawing.Size(775, 95);
            this.header_panel.TabIndex = 0;
            // 
            // header_label
            // 
            this.header_label.AutoSize = true;
            this.header_label.BackColor = System.Drawing.SystemColors.Control;
            this.header_label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.header_label.Location = new System.Drawing.Point(160, 18);
            this.header_label.Name = "header_label";
            this.header_label.Size = new System.Drawing.Size(210, 37);
            this.header_label.TabIndex = 0;
            this.header_label.Text = "Survey Donkey";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::survey.Properties.Resources.eeyore1;
            this.pictureBox2.Location = new System.Drawing.Point(3, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(217, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::survey.Properties.Resources.eeyore2;
            this.pictureBox1.Location = new System.Drawing.Point(306, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(29, 56);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.PlaceholderText = "Username";
            this.username_textbox.Size = new System.Drawing.Size(188, 23);
            this.username_textbox.TabIndex = 1;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(29, 126);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.PlaceholderText = "Password";
            this.password_textbox.Size = new System.Drawing.Size(186, 23);
            this.password_textbox.TabIndex = 2;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(29, 165);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(185, 23);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(279, 415);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(75, 23);
            this.admin_button.TabIndex = 4;
            this.admin_button.Text = "admin";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(375, 415);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(75, 23);
            this.user_button.TabIndex = 5;
            this.user_button.Text = "user";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(29, 235);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(185, 23);
            this.register_button.TabIndex = 6;
            this.register_button.Text = "Register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // register_label
            // 
            this.register_label.AutoSize = true;
            this.register_label.Location = new System.Drawing.Point(29, 204);
            this.register_label.Name = "register_label";
            this.register_label.Size = new System.Drawing.Size(131, 15);
            this.register_label.TabIndex = 7;
            this.register_label.Text = "Don\'t have an account?";
            // 
            // container_panel
            // 
            this.container_panel.Controls.Add(this.username_label);
            this.container_panel.Controls.Add(this.password_label);
            this.container_panel.Controls.Add(this.login_button);
            this.container_panel.Controls.Add(this.register_label);
            this.container_panel.Controls.Add(this.username_textbox);
            this.container_panel.Controls.Add(this.register_button);
            this.container_panel.Controls.Add(this.password_textbox);
            this.container_panel.Location = new System.Drawing.Point(13, 135);
            this.container_panel.Name = "container_panel";
            this.container_panel.Size = new System.Drawing.Size(249, 303);
            this.container_panel.TabIndex = 8;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(29, 25);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(60, 15);
            this.username_label.TabIndex = 9;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(29, 95);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(57, 15);
            this.password_label.TabIndex = 8;
            this.password_label.Text = "Password";
            // 
            // troll_button
            // 
            this.troll_button.Location = new System.Drawing.Point(471, 415);
            this.troll_button.Name = "troll_button";
            this.troll_button.Size = new System.Drawing.Size(75, 23);
            this.troll_button.TabIndex = 9;
            this.troll_button.Text = "troll";
            this.troll_button.UseVisualStyleBackColor = true;
            this.troll_button.Click += new System.EventHandler(this.troll_button_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(495, 215);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 10;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.troll_button);
            this.Controls.Add(this.container_panel);
            this.Controls.Add(this.header_panel);
            this.Controls.Add(this.user_button);
            this.Controls.Add(this.admin_button);
            this.Name = "Login";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            this.header_panel.ResumeLayout(false);
            this.header_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.container_panel.ResumeLayout(false);
            this.container_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel header_panel;
        private System.Windows.Forms.Label header_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button user_button;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label register_label;
        private System.Windows.Forms.Panel container_panel;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button troll_button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button test;
    }
}
