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
    public partial class SurveyEdit : Form
    {
        public static int groupid, categoryid, typeid, questionid;
        public string question1, question2, answerA, answerB, answerC, answerD, answerE, answerF;

        private void done_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateaSurvey survey = new CreateaSurvey();
            survey.Show();
        }

        public SurveyEdit()
        {
            InitializeComponent();
        }

        private void bring_question_button_Click(object sender, EventArgs e)
        {
            WriteQ();
        }

        public void WriteQ()
        {
            questionid = Convert.ToInt32(survey_question_combobox.SelectedValue);

            if (typeid == 1)
            {
                q2_rtb.Visible = false;
                q2_label.Visible = false;
                e_label.Visible = false;
                e_tb.Visible = false;
                f_label.Visible = false;
                f_tb.Visible = false;

                Login.db.Open();
                //DataTable tablo = new DataTable("MultipleChoice");
                string query = "select * from MultipleChoice where CategoryId=" + categoryid + " and GroupId=" + groupid + " and Id="+questionid+"";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                //tablo.Load(sqlDataReader);
                //survey_question_combobox.DisplayMember = "Question";
                //survey_question_combobox.ValueMember = "Id";
                //survey_question_combobox.DataSource = tablo;
                if (sqlDataReader.Read())
                {
                    q1_rtb.Text = sqlDataReader["Question"].ToString();
                    a_tb.Text = sqlDataReader["AnswerA"].ToString();
                    b_tb.Text = sqlDataReader["AnswerB"].ToString();
                    c_tb.Text = sqlDataReader["AnswerC"].ToString();
                    d_tb.Text = sqlDataReader["AnswerD"].ToString();

                }
                Login.db.Close();

            }
            else if (typeid == 2)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("MultipleSelect");
                string query = "select * from MultipleSelect where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 3)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("ShortAnswer");
                string query = "select * from ShortAnswer where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 4)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("FillBlank");
                string query = "select * from FillBlank where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 5)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("Matching");
                string query = "select * from Matching where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 6)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("VisualMatching");
                string query = "select * from VisualMatching where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_question_button_Click(object sender, EventArgs e)
        {
            Assign();

            if (typeid == 1)
            {
                Login.db.Open();
                string query = "update MultipleChoice set Question='"+question1+"', AnswerA='"+answerA+"', AnswerB='"+answerB+"', AnswerC='"+answerC+"', AnswerD='"+answerD+ "' where CategoryId=" + categoryid + " and  GroupId=" + groupid + " and Id=" + questionid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Edit Completed");
                Login.db.Close();
            }
           survey_question_combobox.DataSource=null;
            BringQuestion();

        }
        public void Assign()
        {
            question1= q1_rtb.Text;
            question2= q2_rtb.Text;
            answerA= a_tb.Text;
            answerB= b_tb.Text;
            answerC= c_tb.Text;
            answerD= d_tb.Text;
            answerE = e_tb.Text;
            answerF = f_tb.Text;
        }
        private void SurveyEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SurveyEdit_Load(object sender, EventArgs e)
        {
            //FillCategory();
            //FillType();
            type_label.Text = "Type Id: " +typeid.ToString();
            category_label.Text = "Category Id: " + categoryid.ToString();
            group_label.Text = "Group Id: " + groupid.ToString();
            BringQuestion();

        }
        public void BringQuestion()
        {
            if (typeid == 1)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("MultipleChoice");
                string query = "select * from MultipleChoice where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();

            }
            else if (typeid == 2)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("MultipleSelect");
                string query = "select * from MultipleSelect where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 3)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("ShortAnswer");
                string query = "select * from ShortAnswer where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 4)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("FillBlank");
                string query = "select * from FillBlank where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 5)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("Matching");
                string query = "select * from Matching where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
            else if (typeid == 6)
            {
                survey_question_combobox.Items.Clear();
                Login.db.Open();
                DataTable tablo = new DataTable("VisualMatching");
                string query = "select * from VisualMatching where CategoryId=" + categoryid + " and  GroupId=" + groupid + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_question_combobox.DisplayMember = "Question";
                survey_question_combobox.ValueMember = "Id";
                survey_question_combobox.DataSource = tablo;
                Login.db.Close();
            }
        }
        //public void FillCategory()
        //{
        //survey_question_combobox.Items.Clear();
        //Login.db.Open();
        //DataTable tablo = new DataTable("Category");
        //string query = "select * from Category";
        //SqlCommand sqlCommand = new SqlCommand(query, Login.db);
        //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //tablo.Load(sqlDataReader);
        //survey_question_combobox.DataSource = tablo;
        //survey_question_combobox.DisplayMember = "CategoryName";
        //survey_question_combobox.ValueMember = "Id";
        //Login.db.Close();
        //}
        //public void FillType()
        //{
        //    survey_type_combobox.Items.Clear();
        //    Login.db.Open();
        //    DataTable tablo = new DataTable("Type");
        //    string query = "select * from Type";
        //    SqlCommand sqlCommand = new SqlCommand(query, Login.db);
        //    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        //    tablo.Load(sqlDataReader);
        //    survey_type_combobox.DataSource = tablo;
        //    survey_type_combobox.DisplayMember = "Type";
        //    survey_type_combobox.ValueMember = "Id";
        //    Login.db.Close();
        //}
    }
}
