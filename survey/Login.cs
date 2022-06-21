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
    public partial class Login : Form
    {
        public static SqlConnection db = new SqlConnection("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Survey;Integrated Security=True");

       // public static SqlConnection db = new SqlConnection("Data Source=DESKTOP-73JQEIH\\SQLEXPRESS;Initial Catalog=Survey;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

         

        public int durum=0;
        public int countdown=0;
        UserUI userUI = new UserUI();
        Dashboard Dashboard = new Dashboard();


        public Login()
        {
            InitializeComponent();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void register_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Login_Shown(object sender, EventArgs e)
        {
            username_textbox.Focus();
        }
        private void admin_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
        private void user_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUI userUI = new UserUI();
            userUI.Show();
        }
        private void troll_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Troll troll = new Troll();
            troll.Show();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void login_button_Click(object sender, EventArgs e)
        {
            string username = username_textbox.Text;
            string password = password_textbox.Text;
            if (username !="" && password!="")
            {
                db.Open();
                string query = "select * from UserInfo where Username='"+username+"' and Password='"+password+"' ";
                SqlCommand cmd = new SqlCommand(query, db);
                SqlDataReader reader = cmd.ExecuteReader(); 
                if (reader.Read())
                {
                    durum = 0;
                    timer1.Start();
                    if (Convert.ToInt32(reader["AuthId"]) == 1)
                    {
                        durum = 1;
                        Dashboard.user = reader["Namee"].ToString();

                    }
                    else if(Convert.ToInt32(reader["AuthId"]) == 2)
                    {
                        durum = 2;
                        userUI.user = reader["Namee"].ToString() + " " +reader["Surname"].ToString();
                        UserUI.userid = Convert.ToInt32(reader["Id"]);
                        MCSolve.userid = Convert.ToInt32(reader["Id"]);
                        MSSolve.userid = Convert.ToInt32(reader["Id"]);
                        SASolve.userid = Convert.ToInt32(reader["Id"]);
                        FitBSolve.userid = Convert.ToInt32(reader["Id"]);  
                        MCSolve.userid = Convert.ToInt32(reader["Id"]);
                        MSolve.userid = Convert.ToInt32(reader["Id"]);
                        VMSolve.userid = Convert.ToInt32(reader["Id"]);

                    }
                    MessageBox.Show("Login succesfull.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Information you entered does not match our records. Please try again.", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    username_textbox.Clear();
                    password_textbox.Clear();
                }
                db.Close();
            }
            else
            {
                MessageBox.Show("Missing information. Please try again.", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                username_textbox.Clear();
                password_textbox.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            countdown++;
            if (countdown==2)
            {
                timer1.Stop();
                this.Hide();
                if (durum == 1)
                {
                    Dashboard.Show();
                }
                else if (durum == 2)
                {
                    userUI.Show();
                }
            }
        }

        private void test_Click(object sender, EventArgs e)
        {
            DateTimePicker dtp = new DateTimePicker();
            //string theDate = dtp.Value.ToString("yyyy-MM-dd");
            string theDate = dtp.Value.ToString("dd-MM-yyyy");
            MessageBox.Show(theDate);


        }
    }
}
