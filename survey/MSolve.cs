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
    public partial class MSolve : Form
    {
        public int category = 0;
        public int type = 5;
        public int g_id = 0;
        public string g_name = "";
        public static int userid = 0;
        public string answer1, answer2, answer3, answer4, answer5, choice1, choice2, choice3, choice4, choice5;
        public List<string> questions = new List<string>();
        public List<string> questionid = new List<string>();
        public List<string> answers = new List<string>();
        public List<string> choices = new List<string>();
        public List<string> answersA = new List<string>();
        public List<string> answersB = new List<string>();
        public List<string> answersC = new List<string>();
        public List<string> answersD = new List<string>();
        public List<string> choicesA = new List<string>();
        public List<string> choicesB = new List<string>();
        public List<string> choicesC = new List<string>();
        public List<string> choicesD = new List<string>();

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

        public void GetAnswer1()
        {

            if (q1_rb_1.Checked)
            {
                answer1 = answer1_A_label.Text;
            }
            else if (q1_rb_2.Checked)
            {
                answer1 = answer1_B_label.Text;
            }
            else if (q1_rb_3.Checked)
            {
                answer1 = answer1_C_label.Text;
            }
            else if (q1_rb_4.Checked)
            {
                answer1 = answer1_D_label.Text;
            }
            else
            {
                answer1 = "No answer";
            }
            if (c1_rb_1.Checked)
            {
                choice1 = choice1_A_label.Text;
            }
            else if (c1_rb_2.Checked)
            {
                choice1 = choice1_B_label.Text;
            }
            else if (c1_rb_3.Checked)
            {
                choice1 = choice1_C_label.Text;
            }
            else if (c1_rb_4.Checked)
            {
                choice1 = choice1_D_label.Text;
            }
            else
            {
                choice1 = "No answer";
            }

        }
        public void GetAnswer2()
        {

            if (q2_rb_1.Checked)
            {
                answer2 = answer2_A_label.Text;
            }
            else if (q2_rb_2.Checked)
            {
                answer2 = answer2_B_label.Text;
            }
            else if (q2_rb_3.Checked)
            {
                answer2 = answer2_C_label.Text;
            }
            else if (q2_rb_4.Checked)
            {
                answer2 = answer2_D_label.Text;
            }
            else
            {
                answer2 = "No answer";
            }
            if (c2_rb_1.Checked)
            {
                choice2 = choice2_A_label.Text;
            }
            else if (c2_rb_2.Checked)
            {
                choice2 = choice2_B_label.Text;
            }
            else if (c2_rb_3.Checked)
            {
                choice2 = choice2_C_label.Text;
            }
            else if (c2_rb_4.Checked)
            {
                choice2 = choice2_D_label.Text;
            }
            else
            {
                choice2 = "No answer";
            }

        }
        public void GetAnswer3()
        {

            if (q3_rb_1.Checked)
            {
                answer3 = answer3_A_label.Text;
            }
            else if (q3_rb_2.Checked)
            {
                answer3 = answer3_B_label.Text;
            }
            else if (q3_rb_3.Checked)
            {
                answer3 = answer3_C_label.Text;
            }
            else if (q3_rb_4.Checked)
            {
                answer3 = answer3_D_label.Text;
            }
            else
            {
                answer3 = "No answer";
            }
            if (c3_rb_1.Checked)
            {
                choice3 = choice3_A_label.Text;
            }
            else if (c3_rb_2.Checked)
            {
                choice3 = choice3_B_label.Text;
            }
            else if (c3_rb_3.Checked)
            {
                choice3 = choice3_C_label.Text;
            }
            else if (c3_rb_4.Checked)
            {
                choice3 = choice3_D_label.Text;
            }
            else
            {
                choice3 = "No answer";
            }

        }
        public void GetAnswer4()
        {

            if (q4_rb_1.Checked)
            {
                answer4 = answer4_A_label.Text;
            }
            else if (q4_rb_2.Checked)
            {
                answer4 = answer4_B_label.Text;
            }
            else if (q4_rb_3.Checked)
            {
                answer4 = answer4_C_label.Text;
            }
            else if (q4_rb_4.Checked)
            {
                answer4 = answer4_D_label.Text;
            }
            else
            {
                answer4 = "No answer";
            }
            if (c4_rb_1.Checked)
            {
                choice4 = choice4_A_label.Text;
            }
            else if (c4_rb_2.Checked)
            {
                choice4 = choice4_B_label.Text;
            }
            else if (c4_rb_3.Checked)
            {
                choice4= choice4_C_label.Text;
            }
            else if (c4_rb_4.Checked)
            {
                choice4 = choice4_D_label.Text;
            }
            else
            {
                choice4 = "No answer";
            }

        }
        public void GetAnswer5()
        {

            if (q5_rb_1.Checked)
            {
                answer5 = answer5_A_label.Text;
            }
            else if (q5_rb_2.Checked)
            {
                answer5 = answer5_B_label.Text;
            }
            else if (q5_rb_3.Checked)
            {
                answer5 = answer5_C_label.Text;
            }
            else if (q5_rb_4.Checked)
            {
                answer5 = answer5_D_label.Text;
            }
            else
            {
                answer5 = "No answer";
            }
            if (c5_rb_1.Checked)
            {
                choice5 = choice5_A_label.Text;
            }
            else if (c5_rb_2.Checked)
            {
                choice5 = choice5_B_label.Text;
            }
            else if (c5_rb_3.Checked)
            {
                choice5 = choice5_C_label.Text;
            }
            else if (c5_rb_4.Checked)
            {
                choice5 = choice5_D_label.Text;
            }
            else
            {
                choice5 = "No answer";
            }

        }
        private void MSolve_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserUI userUI = new UserUI();
            userUI.Show();
        }

        private void MSolve_Load(object sender, EventArgs e)
        {
            FillQuestion();
            test.Text = g_id.ToString();
            test2.Text = userid.ToString();
            CapperField();
        }

        public void FillQuestion()
        {
            Login.db.Open();

            string query = "select * from Matching where TypeId=5 and CategoryId=" + category + " and GroupId=" + g_id + " ";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
          

                questions.Add(sqlDataReader["Question"].ToString());
                answersA.Add(sqlDataReader["AnswerA"].ToString());
                choicesA.Add(sqlDataReader["ChoiceA"].ToString());
                answersB.Add(sqlDataReader["AnswerB"].ToString());
                choicesB.Add(sqlDataReader["ChoiceB"].ToString());
                answersC.Add(sqlDataReader["AnswerC"].ToString());
                choicesC.Add(sqlDataReader["ChoiceC"].ToString());
                answersD.Add(sqlDataReader["AnswerD"].ToString());
                choicesD.Add(sqlDataReader["ChoiceD"].ToString());

                questionid.Add(sqlDataReader["Id"].ToString());
            }

            Login.db.Close();


            question_richtextbox_1.Text = questions[0];
            answer1_A_label.Text = answersA[0];
            answer1_B_label.Text = answersB[0];
            answer1_C_label.Text = answersC[0];
            answer1_D_label.Text = answersD[0];
            choice1_A_label.Text = choicesA[0];
            choice1_B_label.Text = choicesB[0];
            choice1_C_label.Text = choicesC[0];
            choice1_D_label.Text = choicesD[0];
            question1_id.Text = questionid[0];

            question_richtextbox_2.Text = questions[1];
            answer2_A_label.Text = answersA[1];
            answer2_B_label.Text = answersB[1];
            answer2_C_label.Text = answersC[1];
            answer2_D_label.Text = answersD[1];
            choice2_A_label.Text = choicesA[1];
            choice2_B_label.Text = choicesB[1];
            choice2_C_label.Text = choicesC[1];
            choice2_D_label.Text = choicesD[1];
            question2_id.Text = questionid[1];


            question_richtextbox_3.Text = questions[2];
            answer3_A_label.Text = answersA[2];
            answer3_B_label.Text = answersB[2];
            answer3_C_label.Text = answersC[2];
            answer3_D_label.Text = answersD[2];
            choice3_A_label.Text = choicesA[2];
            choice3_B_label.Text = choicesB[2];
            choice3_C_label.Text = choicesC[2];
            choice3_D_label.Text = choicesD[2];
            question3_id.Text = questionid[2];

            question_richtextbox_4.Text = questions[3];
            answer4_A_label.Text = answersA[3];
            answer4_B_label.Text = answersB[3];
            answer4_C_label.Text = answersC[3];
            answer4_D_label.Text = answersD[3];
            choice4_A_label.Text = choicesA[3];
            choice4_B_label.Text = choicesB[3];
            choice4_C_label.Text = choicesC[3];
            choice4_D_label.Text = choicesD[3];
            question4_id.Text = questionid[3];

            question_richtextbox_5.Text = questions[4];
            answer5_A_label.Text = answersA[4];
            answer5_B_label.Text = answersB[4];
            answer5_C_label.Text = answersC[4];
            answer5_D_label.Text = answersD[4];
            choice5_A_label.Text = choicesA[4];
            choice5_B_label.Text = choicesB[4];
            choice5_C_label.Text = choicesC[4];
            choice5_D_label.Text = choicesD[4];
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

            choices.Add(choice1);
            choices.Add(choice2);
            choices.Add(choice3);
            choices.Add(choice4);
            choices.Add(choice5);

            for (int i = 0; i < 5; i++)
            {
                Login.db.Open();
                string query = "insert into Answers (QMId, UserId, Answer, Answer2, TypeId, CategoryId, GroupId) values (" + questionid[i] + ", " + userid + ",'" + answers[i] + "','" + choices[i] + "', " + 5 + ", " + category + ", " + g_id + ")";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                sqlCommand.ExecuteNonQuery();
                Login.db.Close();
            }

        }

        public MSolve()
        {
            InitializeComponent();
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

    }
}
