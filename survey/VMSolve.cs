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
    
    public partial class VMSolve : Form
    {
        public int category = 0;
        public int type = 6;
        public int g_id = 0;
        public string g_name = "";
        public static int userid = 0;
        public string answer1, answer2, answer3, answer4, answer5;
        public List<string> questions = new List<string>();
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public List<string> questionid = new List<string>();
        public List<string> answers = new List<string>();
        public List<string> answersA = new List<string>();
        public List<string> answersB = new List<string>();
        public List<string> answersC = new List<string>();
        public List<string> answersD = new List<string>();
        public string questionimage = "";
        public string imagesFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.GetDirectories("Images")[0].FullName;

        public VMSolve()
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

        private void VMSolve_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

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
        public void FillQuestion()
        {
            Login.db.Open();

            string query = "select * from VisualMatching where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " ";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {


                questions.Add(sqlDataReader["Question"].ToString());
                //pictureBoxes.Add((PictureBox)Controls.Find)[0]) = Image.FromFile(imagesFolder + "\\" + sqlDataReader["Question"].ToString());


                answersA.Add(sqlDataReader["AnswerA"].ToString());
                answersB.Add(sqlDataReader["AnswerB"].ToString());
                answersC.Add(sqlDataReader["AnswerC"].ToString());
                answersD.Add(sqlDataReader["AnswerD"].ToString());
                questionid.Add(sqlDataReader["Id"].ToString());

            }

            Login.db.Close();



            picture_picturebox1.Image = Image.FromFile(imagesFolder + "\\" + questions[0]);
            answer1_A_label.Text = answersA[0];
            answer1_B_label.Text = answersB[0];
            answer1_C_label.Text = answersC[0];
            answer1_D_label.Text = answersD[0];
            question1_id.Text = questionid[0];

            //picture_picturebox2.Text = questions[1];
            picture_picturebox2.Image = Image.FromFile(imagesFolder + "\\" + questions[1]);
            answer2_A_label.Text = answersA[1];
            answer2_B_label.Text = answersB[1];
            answer2_C_label.Text = answersC[1];
            answer2_D_label.Text = answersD[1];
            question2_id.Text = questionid[1];


            //picture_picturebox3.Text = questions[2];
            picture_picturebox3.Image = Image.FromFile(imagesFolder + "\\" + questions[2]);
            answer3_A_label.Text = answersA[2];
            answer3_B_label.Text = answersB[2];
            answer3_C_label.Text = answersC[2];
            answer3_D_label.Text = answersD[2];
            question3_id.Text = questionid[2];

            //picture_picturebox4.Text = questions[3];
            picture_picturebox4.Image = Image.FromFile(imagesFolder + "\\" + questions[3]);
            answer4_A_label.Text = answersA[3];
            answer4_B_label.Text = answersB[3];
            answer4_C_label.Text = answersC[3];
            answer4_D_label.Text = answersD[3];
            question4_id.Text = questionid[3];

            //picture_picturebox5.Text = questions[4];
            picture_picturebox5.Image = Image.FromFile(imagesFolder + "\\" + questions[4]);
            answer5_A_label.Text = answersA[4];
            answer5_B_label.Text = answersB[4];
            answer5_C_label.Text = answersC[4];
            answer5_D_label.Text = answersD[4];
            question5_id.Text = questionid[4];

        }

        public void GetPic1()
        {
            Login.db.Open();

            string query = "select * from VisualMatching  where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " order by Id offset 0 rows fetch next 1 rows only";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture_picturebox1.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();
        }
        public void GetPic2()
        {
            Login.db.Open();

            string query = "select * from VisualMatching  where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " order by Id offset 1 rows fetch next 1 rows only";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture_picturebox2.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();
        }
        public void GetPic3()
        {
            Login.db.Open();

            string query = "select * from VisualMatching  where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " order by Id offset 2 rows fetch next 1 rows only";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture_picturebox3.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();
        }
        public void GetPic4()
        {
            Login.db.Open();

            string query = "select * from VisualMatching  where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " order by Id offset 3 rows fetch next 1 rows only";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture_picturebox4.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();
        }
        public void GetPic5()
        {
            Login.db.Open();

            string query = "select * from VisualMatching  where TypeId=6 and CategoryId=" + category + " and GroupId=" + g_id + " order by Id offset 4 rows fetch next 1 rows only";
            SqlCommand cmd = new SqlCommand(query, Login.db);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                picture_picturebox5.Image = Image.FromFile(imagesFolder + "\\" + reader["Question"].ToString());

            }
            Login.db.Close();
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
                string query = "insert into Answers (QVMId, UserId, Answer, TypeId, CategoryId, GroupId) values (" + questionid[i] + ", " + userid + ",'" + answers[i] + "', " + 6 + ", " + category + ", " + g_id + ")";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                sqlCommand.ExecuteNonQuery();
                Login.db.Close();
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

        private void VMSolve_Load(object sender, EventArgs e)
        {
            FillQuestion();
            test.Text = g_id.ToString();
            test2.Text = userid.ToString();
            CapperField();
            //GetPic1();
            //GetPic2();
            //GetPic3();
            //GetPic4();
            //GetPic5();
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
                answer4 = answer3_B_label.Text;
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
