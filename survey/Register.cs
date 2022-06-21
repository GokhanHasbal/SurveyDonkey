using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace survey
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            other_radiobutton.Checked = true;
            noanswer_radiobutton.Checked=true;
            driving_licence_combobox.SelectedIndex = 0;
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            RegisterUser();
        }

        public void RegisterUser()
        {
            string name= name_textbox.Text;
            string surname = surname_textbox.Text;
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            string password2 = confirm_password_textbox.Text;
            int age = Convert.ToInt32(age_numupdown.Value);
            string gender = "";
            string marital = "";
            string driving = driving_licence_combobox.Text;
            string city = city_textbox.Text;
            int auth = 2;

            if (male_radiobutton.Checked)
            {
                 gender = "Male";
            }
            else if (female_radiobutton.Checked)
            {
                 gender = "Female";
            }
            else if (other_radiobutton.Checked)
            {
                 gender = "Other";
            }

            if (single_radiobutton.Checked)
            {
                marital = "Single";
            }
            else if (married_radiobutton.Checked)
            {
                marital = "Married";
            }
            else if (divorcee_radiobutton.Checked)
            {
                marital = "Divorced";
            }
            else if (widowed_radiobutton.Checked)
            {
                marital = "Widowed";
            }
            else if (noanswer_radiobutton.Checked)
            {
                marital = "No Answer";
            }

            Login.db.Open();
            string query = "insert into UserInfo (Namee, Surname, Username, Password, Age, Gender, Marital, Driving, City, AuthId) values ('" + name+"', '"+surname+"', '"+username+ "', '"+password+"', "+age+ ",'"+gender+ "', '"+marital+ "', '"+driving+ "', '"+city+"', "+auth+")";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);

            if (name!="" && surname !="" && username != "" && password != "" && age != 0 && city != "")
            {
                if(password==password2)
                {
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("You have been successfully registered.", "Registration Succesfull!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
               
                else
                {
                    MessageBox.Show("Passwords doesn't match. Please type again.", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    password_textbox.Clear();
                    confirm_password_textbox.Clear();
                    password_textbox.Focus();

                }
            }
            else
            {
                MessageBox.Show("Missing information. Please try again.", "Registration Unsuccesfull!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            Login.db.Close();
        }

        private void Register_Shown(object sender, EventArgs e)
        {
            username_textbox.Focus();
        }
    }
}
