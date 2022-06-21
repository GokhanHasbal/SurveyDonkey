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
    public partial class Matching : Form
    {
        int i = 0;
        public Matching()
        {
            InitializeComponent();
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
        private void Matching_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Matching_Load(object sender, EventArgs e)
        {
            save_survey_buıtton.Visible = false;
            FillCategory();
            survey_category_combobox.SelectedValue = -1;
            container_panel.Visible = false;
            footer_panel.Visible = false;
        }
        public void ResetQuestion()
        {
            question_richtexbox.Text = "";
            answerA_textbox.Text = "";
            answerB_textbox.Text = "";
            answerC_textbox.Text = "";
            answerD_textbox.Text = "";
            choiceA_textbox.Text = "";
            choiceB_textbox.Text = "";
            choiceC_textbox.Text = "";
            choiceD_textbox.Text = "";
            question_richtexbox.Focus();
        }
        private void save_survey_buıtton_Click(object sender, EventArgs e)
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
        public void MQSave()
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
            string question = question_richtexbox.Text;
            string choiceA = choiceA_textbox.Text;
            string choiceB = choiceB_textbox.Text;
            string choiceC = choiceC_textbox.Text;
            string choiceD = choiceD_textbox.Text;
            string answerA = answerA_textbox.Text;
            string answerB = answerB_textbox.Text;
            string answerC = answerC_textbox.Text;
            string answerD = answerD_textbox.Text;
            int category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            int type = 5;
            Login.db.Close();
            Login.db.Open();
            string query = "insert into Matching (Question, AnswerA, AnswerB, AnswerC, AnswerD, CategoryId, TypeId, GroupId, ChoiceA, ChoiceB, ChoiceC, ChoiceD) values ('" + question + "', '" + answerA + "', '" + answerB + "', '" + answerC + "', '" + answerD + "', " + category + ", " + type + ", " + grp + ", '" + choiceA + "', '" + choiceB + "', '" + choiceC + "', '" + choiceD + "')";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            if (question!="" && choiceA != "" && choiceB != "" && choiceC != "" && choiceD != "" && answerA != "" && answerB != "" && answerC != "" && answerD != "" && survey_category_combobox.SelectedIndex != -1)
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
            string question = question_richtexbox.Text;
            string choiceA = choiceA_textbox.Text;
            string choiceB = choiceB_textbox.Text;
            string choiceC = choiceC_textbox.Text;
            string choiceD = choiceD_textbox.Text;
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
            question_richtexbox.Focus();
        }
        private void save_question_button_Click(object sender, EventArgs e)
        {
            MQSave();
            if (i >= 5)
            {
                save_survey_buıtton.Visible = true;
                survey_category_combobox.Visible = true;
                save_question_button.Visible = false;
            }
            question_count_label.Text = i.ToString() + " /5 Questions Saved";
        }
    }
}
