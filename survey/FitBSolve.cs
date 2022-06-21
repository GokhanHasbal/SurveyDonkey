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
    public partial class FitBSolve : Form
    {
        public int category = 0;
        public int type = 3;
        public int g_id = 0;
        public string g_name = "";
        public static int userid = 0;
        public string answer1, answer2, answer3, answer4, answer5;
        public List<string> questions = new List<string>();
        public List<string> questions2 = new List<string>();
        public List<string> questionid = new List<string>();
        public List<string> answers = new List<string>();


        private void FitBSolve_Load(object sender, EventArgs e)
        {
            FillQuestion();
            test.Text = g_id.ToString();
            test2.Text = userid.ToString();
            CapperField();
        }

        private void finish_survey_button_Click(object sender, EventArgs e)
        {
            DialogResult save = new DialogResult();
            save = MessageBox.Show("All your answered will be saved, please check if your answers are final. Do you wanna continue?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (save == DialogResult.Yes)
            {
                SaveAnswers();
                MessageBox.Show("Your answer saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                UserUI userUI = new UserUI();
                userUI.Show();
            }
        }

        private void FitBSolve_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        public void GetAnswer1()
        {
            answer1 = answer_textbox_1.Text;
        }
         public void GetAnswer2()
        {
            answer2 = answer_textbox_2.Text;
        }
         public void GetAnswer3()
        {
            answer3 = answer_textbox_3.Text;
        }
         public void GetAnswer4()
        {
            answer4 = answer_textbox_4.Text;
        }
         public void GetAnswer5()
        {
            answer5 = answer_textbox_5.Text;
        }
        public void CapperField()
        {
            question1_id.Visible = false;
            question2_id.Visible = false;
            question3_id.Visible = false;
            question4_id.Visible = false;
            question5_id.Visible = false;
            test.Visible = false;
            test2.Visible = false;

        }
        public FitBSolve()
        {
            InitializeComponent();
        }
        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUI userUI = new UserUI();
            userUI.Show();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        public void FillQuestion()
        {
            Login.db.Open();

            string query = "select * from FillBlank where TypeId=4 and CategoryId=" + category + " and GroupId=" + g_id + " ";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                questions.Add(sqlDataReader["QuestionFirstPart"].ToString());
                questions2.Add(sqlDataReader["QuestionSecondPart"].ToString());
                questionid.Add(sqlDataReader["Id"].ToString());
            }

            Login.db.Close();

            question_richtextbox_1.Text = questions[0];
            question_richtextbox_11.Text = questions2[0];
            question1_id.Text = questionid[0];

            question_richtextbox_2.Text = questions[1];
            question_richtextbox_22.Text = questions2[1];
            question2_id.Text = questionid[1];

            question_richtextbox_3.Text = questions[2];
            question_richtextbox_33.Text = questions2[2];
            question3_id.Text = questionid[2];

            question_richtextbox_4.Text = questions[3];
            question_richtextbox_44.Text = questions2[3];
            question4_id.Text = questionid[3];

            question_richtextbox_5.Text = questions[4];
            question_richtextbox_55.Text = questions2[4];
            question5_id.Text = questionid[4];
        }

        public void SaveAnswers()
        {
            GetAnswer1();
            GetAnswer2();
            GetAnswer3();
            GetAnswer4();
            GetAnswer5();

            answers.Add(answer1);
            answers.Add(answer2);
            answers.Add(answer3);
            answers.Add(answer4);
            answers.Add(answer5);

            for (int i = 0; i < 5; i++)
            {
                Login.db.Open();
                string query = "insert into Answers (QFBId, UserId, Answer, TypeId, CategoryId, GroupId) values (" + questionid[i] + ", " + userid + ",'" + answers[i] + "', " + 4 + ", " + category + ", " + g_id + ")";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                sqlCommand.ExecuteNonQuery();
                Login.db.Close();
            }

        }
    }
}
