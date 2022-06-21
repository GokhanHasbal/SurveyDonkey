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
using System.IO;


namespace survey
{
    public partial class SurveyTime : Form
    {
        public string questionimage = "";
        public string imagesFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("Images")[0].FullName;

        public SurveyTime()
        {
            InitializeComponent();
        }
        private void SurveyTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void finish_survey_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Survey Finished.", "Survey Completion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            this.Hide();
            UserUI userUI = new UserUI();
            userUI.Show();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void upload_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picture_picturebox.Image = new Bitmap(opnfd.FileName);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            questionimage = string.Empty;

            SaveFileDialog opnfd = new SaveFileDialog();
            opnfd.Filter = "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picture_picturebox.Image.Save(opnfd.FileName);
                questionimage = opnfd.FileName;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Login.db.Open();
            string query = "insert into VisualMatching (Question, AnswerA, AnswerB, AnswerC, AnswerD) values ('" + Path.GetFileName(questionimage) + "', '" + 1 + "',  '" + 2 + "',  '" + 3 + "',  '" + 4 + "')";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            sqlCommand.ExecuteNonQuery();
            Login.db.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Login.db.Open();

            string query = "select * from VisualMatching ";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture2_picturebox.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();


        }
    }
}
