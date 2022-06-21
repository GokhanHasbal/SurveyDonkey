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
    public partial class MSSolve : Form
    {
        public int category = 0;
        public int type = 2;
        public int g_id = 0;
        public string g_name = "";
        public static int userid = 0;
        public string answer1, answer2, answer3, answer4, answer5;
        public List<string> questions = new List<string>();
        public List<string> answersA = new List<string>();
        public List<string> answersB = new List<string>();
        public List<string> answersC = new List<string>();
        public List<string> answersD = new List<string>();
        public List<string> answersE = new List<string>();
        public List<string> answersF = new List<string>();
        public List<string> questionid = new List<string>();
        public List<string> answers = new List<string>();
        private void MSSolve_Load(object sender, EventArgs e)
        {
            FillQuestion();
            test.Text = g_id.ToString();
            test2.Text = userid.ToString();
            CapperField();
        }

        public MSSolve()
        {
            InitializeComponent();
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
        private void MSSolve_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
        }
        public void GetAnswer5()
        {

            if (q_5_cbox1.Checked)
            {
                answer5 += q_5_cbox1.Text +"-";
            }
           if (q_5_cbox2.Checked)
            {
                answer5 += q_5_cbox2.Text + "-";
            }
            if (q_5_cbox3.Checked)
            {
                answer5 += q_5_cbox3.Text + "-";
            }
            if (q_5_cbox4.Checked)
            {
                answer5 += q_5_cbox4.Text + "-";
            }
            if (q_5_cbox5.Checked)
            {
                answer5 += q_5_cbox5.Text + "-";
            }
            if (q_5_cbox6.Checked)
            {
                answer5 += q_5_cbox6.Text + "-";
            }

            if (q_5_cbox1.Checked==false && q_5_cbox2.Checked == false && q_5_cbox3.Checked == false && q_5_cbox4.Checked == false && q_5_cbox5.Checked == false)
            {
                answer5 = "No answer";
            }
        }
        public void FillQuestion()
        {
            Login.db.Open();

            string query = "select * from MultipleSelect where TypeId=2 and CategoryId=" + category + " and GroupId=" + g_id + " ";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                questions.Add(sqlDataReader["Question"].ToString());
                answersA.Add(sqlDataReader["AnswerA"].ToString());
                answersB.Add(sqlDataReader["AnswerB"].ToString());
                answersC.Add(sqlDataReader["AnswerC"].ToString());
                answersD.Add(sqlDataReader["AnswerD"].ToString());
                answersE.Add(sqlDataReader["AnswerE"].ToString());
                answersF.Add(sqlDataReader["AnswerF"].ToString());
                questionid.Add(sqlDataReader["Id"].ToString());
            }

            Login.db.Close();

            question_richtextbox_1.Text = questions[0];
            answer1_A_label.Text = answersA[0];
            answer1_B_label.Text = answersB[0];
            answer1_C_label.Text = answersC[0];
            answer1_D_label.Text = answersD[0];
            answer1_E_label.Text = answersE[0];
            answer1_F_label.Text = answersF[0];
            question1_id.Text = questionid[0];

            question_richtextbox_2.Text = questions[1];
            answer2_A_label.Text = answersA[1];
            answer2_B_label.Text = answersB[1];
            answer2_C_label.Text = answersC[1];
            answer2_D_label.Text = answersD[1];
            answer2_E_label.Text = answersE[1];
            answer2_F_label.Text = answersF[1];
            question2_id.Text = questionid[1];


            question_richtextbox_3.Text = questions[2];
            answer3_A_label.Text = answersA[2];
            answer1_A_label.Text = answersB[2];
            answer3_C_label.Text = answersC[2];
            answer3_D_label.Text = answersD[2];
            answer3_E_label.Text = answersE[2];
            answer3_F_label.Text = answersF[2];
            question3_id.Text = questionid[2];

            question_richtextbox_4.Text = questions[3];
            answer4_A_label.Text = answersA[3];
            answer4_B_label.Text = answersB[3];
            answer4_C_label.Text = answersC[3];
            answer4_D_label.Text = answersD[3];
            answer4_E_label.Text = answersE[3];
            answer4_F_label.Text = answersF[3];
            question4_id.Text = questionid[3];

            question_richtextbox_5.Text = questions[4];
            q_5_cbox1.Text= answersA[4];
            q_5_cbox2.Text= answersB[4];
            q_5_cbox3.Text= answersC[4];
            q_5_cbox4.Text= answersD[4];
            q_5_cbox5.Text= answersE[4];
            q_5_cbox6.Text= answersF[4];

            //answer5_A_label.Text = answersA[4];
            //answer5_B_label.Text = answersB[4];
            //answer5_C_label.Text = answersC[4];
            //answer5_D_label.Text = answersD[4];
            //answer5_E_label.Text = answersE[4];
            //answer5_F_label.Text = answersF[4];
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
                string query = "insert into Answers (QMSId, UserId, Answer, TypeId, CategoryId, GroupId) values (" + questionid[i] + ", " + userid + ",'" + answers[i] + "', " + 2 + ", " + category + ", " + g_id + ")";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                sqlCommand.ExecuteNonQuery();
                Login.db.Close();
            }

        }

    }
}
