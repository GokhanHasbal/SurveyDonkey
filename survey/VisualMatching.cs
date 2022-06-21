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
    public partial class VisualMatching : Form
    {
        int i = 0;
        public string questionimage = "";
        public string imagesFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("Images")[0].FullName;
        public VisualMatching()
        {
            InitializeComponent();
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
        private void save_button_Click(object sender, EventArgs e)
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
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateaSurvey survey = new CreateaSurvey();
            survey.Show();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void VisualMatching_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void VisualMatching_Load(object sender, EventArgs e)
        {
            save_survey_buıtton.Visible = false;
            FillCategory();
            survey_category_combobox.SelectedValue = -1;
            container_panel.Visible = false;
            footer_panel.Visible = false;
        }
        private void save_question_button_Click(object sender, EventArgs e)
        {
            VMQSave();
            if (i >= 5)
            {
                save_survey_buıtton.Visible = true;
                survey_category_combobox.Visible = true;

                save_question_button.Visible = false;
            }
            question_count_label.Text = i.ToString() + " /5 Questions Saved";
        }
        public void ResetQuestion()
        {
            answerA_textbox.Text = "";
            answerB_textbox.Text = "";
            answerC_textbox.Text = "";
            answerD_textbox.Text = "";
            picture_picturebox.Image = null;
        }
        private void save_survey_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
        }
        public void FillCategory()
        {
            survey_category_combobox.Items.Clear();
            Login.db.Open();
            DataTable tablo = new DataTable("Category");
            string query = "select * from Category";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            tablo.Load(sqlDataReader);
            survey_category_combobox.DataSource = tablo;
            survey_category_combobox.DisplayMember = "CategoryName";
            survey_category_combobox.ValueMember = "Id";
            Login.db.Close();
        }
        public void VMQSave()
        {
            string group = survey_name_textbox.Text;
            int grp = 0;
            Login.db.Open();
            string query2 = "select * from Groups where ([Group])='" + group + "' ";
            SqlCommand cmd = new SqlCommand(query2, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                grp = Convert.ToInt32(reader["Id"]);
            }
            
            string answerA = answerA_textbox.Text;
            string answerB = answerB_textbox.Text;
            string answerC = answerC_textbox.Text;
            string answerD = answerD_textbox.Text;
            int category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            int type = 6;
            Login.db.Close();
            Login.db.Open();
            string query = "insert into VisualMatching (Question, AnswerA, AnswerB, AnswerC, AnswerD, CategoryId, TypeId, GroupId) values ('" + Path.GetFileName(questionimage) + "', '" + answerA + "', '" + answerB + "', '" + answerC + "', '" + answerD + "', " + category + ", " + type + ", " + grp + ")";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            if (answerA != "" && answerB != "" && answerC != "" && answerD != "" && survey_category_combobox.SelectedIndex != -1)
            {
                sqlCommand.ExecuteNonQuery();
                ResetQuestion();
                i++;
            }
            else
            {
                MessageBox.Show("Missing information. Please fill all boxes.", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Login.db.Close();
        }
        public void SaveQuestion()
        {
            string answerA = answerA_textbox.Text;
            string answerB = answerB_textbox.Text;
            string answerC = answerC_textbox.Text;
            string answerD = answerD_textbox.Text;
        }
        public void SaveGroup()
        {
            int length = Convert.ToInt32(survey_length_nupd.Value);
            string group = survey_name_textbox.Text;
            string activity = "True";
            Login.db.Open();
            string query = "insert into Groups ([Group], Length, Activity) values ('" + group + "', " + length + ", '" + activity + "')";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            sqlCommand.ExecuteNonQuery();
            Login.db.Close();
        }
        private void survey_name_save_button_Click(object sender, EventArgs e)
        {
            if (survey_category_combobox.SelectedIndex != -1 && survey_name_textbox.Text != "")
            {
                container_panel.Visible = true;
                footer_panel.Visible = true;
                survey_name_textbox.ReadOnly = true;
                survey_category_combobox.Enabled = false;
                survey_length_nupd.ReadOnly = true;
                survey_length_nupd.Increment = 0;
                SaveGroup();
            }
        }

        private void save_survey_buıtton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomMessageBox customMessageBox = new CustomMessageBox();
            customMessageBox.ShowDialog();
        }
    }
}
