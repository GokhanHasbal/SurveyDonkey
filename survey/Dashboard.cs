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
    public partial class Dashboard : Form
    {
        public string user = "";

        public Dashboard()
        {
            InitializeComponent();
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void create_survey_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateaSurvey survey = new CreateaSurvey();
            survey.Show();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            boss_label.Text = "Boss, " + user + " Welcome";
            Login.db.Close();
            FillType();
            type_combobox.SelectedIndex = -1;
        }
        public void FillAoMQ()
        {
            string query = "select UserInfo.Namee as [Survey Taker], MultipleChoice.Question as Question, Answers.Answer as [Given Answser], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join MultipleChoice on Answers.QuestionId= MultipleChoice.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        }
        public void FillAoMS()
        {
            string query = "select UserInfo.Namee as [Survey Taker], MultipleSelect.Question as Question, Answers.Answer as [Given Answser], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join MultipleSelect on Answers.QMSId= MultipleSelect.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        }
        public void FillAoM()
        {
            string query = "select UserInfo.Namee as [Survey Taker], Matching.Question as Question, Answers.Answer as [Given Answser], Answers.Answer2 as [Given Answser 2], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join Matching on Answers.QMId= Matching.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        }
        public void FillAoSA()
        {
            string query = "select UserInfo.Namee as [Survey Taker], ShortAnswer.Question as Question, Answers.Answer as [Given Answser], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join ShortAnswer on Answers.QSAId= ShortAnswer.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        }   
        public void FillAoFB()
        {
            string query = "select UserInfo.Namee as [Survey Taker], FillBlank.QuestionFirstPart as Question, Answers.Answer as [Given Answser], FillBlank.QuestionSecondPart as [Question Continue], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join FillBlank on Answers.QFBId= FillBlank.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        } 
        public void FillAoVM()
        {
            string query = "select UserInfo.Namee as [Survey Taker], VisualMatching.Question as Picture, Answers.Answer as [Given Answser], [Type].[Type] as [Survey Type], Category.CategoryName as [Category Name], Groups.[Group] from Answers inner join VisualMatching on Answers.QVMId= VisualMatching.Id inner join UserInfo on Answers.UserId=UserInfo.Id inner join [Type] on Answers.TypeId=[Type].[Id] inner join Category on Answers.CategoryId=Category.Id inner join Groups on Answers.GroupId=Groups.Id";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
        }
        public void FillType()
        {
            Login.db.Open();
            DataTable tablo = new DataTable("Type");
            string query = "select * from Type";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            tablo.Load(sqlDataReader);
            type_combobox.DataSource = tablo;
            type_combobox.DisplayMember = "Type";
            type_combobox.ValueMember = "Id";
            Login.db.Close();
        }
        public DataTable FillData(string query)
        {
            Login.db.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, Login.db);
            sqlDataAdapter.Fill(tablo);
            Login.db.Close();
            return tablo;
        }
        private void type_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(type_combobox.SelectedValue);
            if (type==1)
            {
                survey_datagridview.DataSource = null;
                FillAoMQ();
            }
            else if (type ==2)
            {
                survey_datagridview.DataSource = null;

                FillAoMS();
            }
            else if  (type==3)
            {
                survey_datagridview.DataSource = null;

                FillAoSA();
            }
            else if (type == 4)
            {
                survey_datagridview.DataSource = null;

                FillAoFB();
            }
            else if (type == 5)
            {
                survey_datagridview.DataSource = null;

                FillAoM();
            }
            else if (type == 6)
            {
                survey_datagridview.DataSource = null;

                FillAoVM();
            }
            //survey_datagridview.Columns[1].Width = 500;
            survey_datagridview.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
    }
}
