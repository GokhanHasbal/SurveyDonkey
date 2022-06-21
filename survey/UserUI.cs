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
    public partial class UserUI : Form
    {
        public string user = "";
        public static int grpid = 0;
        public static int userid = 0;
        public List<string> group = new List<string>();
        public List<string> category = new List<string>();


        MCSolve mCSolve = new MCSolve();
        MSSolve mMSSolve = new MSSolve();
        SASolve sSASolve = new SASolve();
        FitBSolve fitBSolve = new FitBSolve();
        MSolve MSolve = new MSolve();
        VMSolve VMSolve = new VMSolve();

        public UserUI()
        {
            InitializeComponent();
        }
        private void UserUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void CapperField()
        {
            test.Visible = false;
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
        private void start_survey_button_Click(object sender, EventArgs e)
        {
            //SurveySettings.CategoryId = Convert.ToInt32(survey_category_combobox.SelectedValue);
            //SurveySettings.GroupId = Convert.ToInt32(survey_group_combobox.SelectedValue);
            //SurveySettings.TypeId = Convert.ToInt32(survey_type_combobox.SelectedValue);

            mCSolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            mCSolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);

            mMSSolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            mMSSolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);

            sSASolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            sSASolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);

            fitBSolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            fitBSolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);

            MSolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            MSolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);

            VMSolve.category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            VMSolve.g_id = Convert.ToInt32(survey_group_combobox.SelectedValue);


            this.Hide();
            if (survey_type_combobox.SelectedValue.ToString() == "1")
            {
                mCSolve.Show();
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "2")
            {
                mMSSolve.Show();
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "3")
            {
                sSASolve.Show();
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "4")
            {
                fitBSolve.Show();
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "5")
            {
                MSolve.Show();
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "6")
            {
                VMSolve.Show();
            }

        }
        private void random_survey_button_Click(object sender, EventArgs e)
        {
            

            Random random = new Random();
            int number1 = random.Next(1, 6);

            this.Hide();

            if (number1 == 1)
            {
                Login.db.Open();
                string query = "select distinct GroupId from MultipleChoice";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                mCSolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from MultipleChoice where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                mCSolve.category = number5;
                mCSolve.Show();
            }
            else if (number1 == 2)
            {
                Login.db.Open();
                string query = "select distinct GroupId from MultipleSelect";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                mMSSolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from MultipleSelect where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                mMSSolve.category = number5;
                mMSSolve.Show();
            }
            else if (number1 == 3)
            {
                Login.db.Open();
                string query = "select distinct GroupId from ShortAnswer";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                sSASolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from ShortAnswer where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                sSASolve.category = number5;
                sSASolve.Show();
            }
            else if (number1 == 4)
            {
                Login.db.Open();
                string query = "select distinct GroupId from FillBlank";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                fitBSolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from FillBlank where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                fitBSolve.category = number5;
                fitBSolve.Show();
            }
            else if (number1 == 5)
            {
                Login.db.Open();
                string query = "select distinct GroupId from Matching";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                MSolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from Matching where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                MSolve.category = number5;
                MSolve.Show();
            }
            else if (number1 == 6)
            {
                Login.db.Open();
                string query = "select distinct GroupId from VisualMatching";
                SqlCommand cmd = new SqlCommand(query, Login.db);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    group.Add(reader["GroupId"].ToString());
                }
                Login.db.Close();


                int number2 = group.Count;
                int number3 = random.Next(1, number2);
                int number4 = Convert.ToInt32(group[number3 - 1]);
                VMSolve.g_id = number4;

                Login.db.Open();
                string query2 = "select distinct CategoryId from VisualMatching where GroupId='" + number4 + "' ";
                SqlCommand cmd2 = new SqlCommand(query2, Login.db);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    category.Add(reader2["CategoryId"].ToString());
                }
                Login.db.Close();
                int number5 = Convert.ToInt32(category[0]);
                VMSolve.category = number5;
                VMSolve.Show();
            }


        }
        public void FillCategory()
        {
            //survey_category_combobox.Items.Clear();
            Login.db.Open();
            DataTable tablo = new DataTable("Category");
            string query = "select * from Category";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            tablo.Load(sqlDataReader);
            survey_category_combobox.DisplayMember = "CategoryName";
            survey_category_combobox.ValueMember = "Id";
            survey_category_combobox.DataSource = tablo;
            Login.db.Close();

        }
        public void FillType()
        {
            //survey_type_combobox.Items.Clear();
            Login.db.Open();
            DataTable tablo = new DataTable("Type");
            string query = "select * from Type";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            tablo.Load(sqlDataReader);
            survey_type_combobox.DataSource = tablo;
            survey_type_combobox.DisplayMember = "Type";
            survey_type_combobox.ValueMember = "Id";
            Login.db.Close();

        }
        public void FillGroup()
        {

            int category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            int type = Convert.ToInt32(survey_type_combobox.SelectedValue);

            Login.db.Open();
            DataTable tablo = new DataTable("Groups");
            string query = "select * from Groups";
            SqlCommand sqlCommand = new SqlCommand(query, Login.db);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            tablo.Load(sqlDataReader);
            survey_group_combobox.DataSource = tablo;
            survey_group_combobox.DisplayMember = "Group";
            survey_group_combobox.ValueMember = "Id";
            Login.db.Close();
            survey_group_combobox.SelectedIndex = -1;

        }
        public void FillGroup2()
        {
            int category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            int type = Convert.ToInt32(survey_type_combobox.SelectedValue);

            Login.db.Open();

            if (survey_type_combobox.SelectedValue.ToString() == "1")
            {
                DataTable tablo = new DataTable("MultipleChoice");
                string query = "select distinct Groups.[Group] from MultipleChoice inner join Groups on MultipleChoice.GroupId=Groups.Id where CategoryId="+category+"";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_group_combobox.DataSource=tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";


            }
            else if (survey_type_combobox.SelectedValue.ToString() == "2")
            {
                DataTable tablo = new DataTable("MultipleSelect");
                string query = "select distinct Groups.[Group] from MultipleSelect inner join Groups on MultipleSelect.GroupId=Groups.Id where CategoryId=" + category + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_group_combobox.DataSource = tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "3")
            {
                DataTable tablo = new DataTable("ShortAnswer");
                string query = "select distinct Groups.[Group] from ShortAnswer inner join Groups on ShortAnswer.GroupId=Groups.Id where CategoryId=" + category + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_group_combobox.DataSource = tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "4")
            {
                DataTable tablo = new DataTable("FillBlank");
                string query = "select distinct Groups.[Group] from FillBlank inner join Groups on FillBlank.GroupId=Groups.Id where CategoryId=" + category + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader); 
                survey_group_combobox.DataSource = tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "5")
            {
                DataTable tablo = new DataTable("Matching");
                string query = "select distinct Groups.[Group] from Matching inner join Groups on Matching.GroupId=Groups.Id where CategoryId=" + category + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_group_combobox.DataSource = tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "6")
            {
                DataTable tablo = new DataTable("VisualMatching");
                string query = "select distinct Groups.[Group] from VisualMatching inner join Groups on VisualMatching.GroupId=Groups.Id where CategoryId=" + category + "";
                SqlCommand sqlCommand = new SqlCommand(query, Login.db);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                tablo.Load(sqlDataReader);
                survey_group_combobox.DataSource = tablo;
                survey_group_combobox.DisplayMember = "Id";
                survey_group_combobox.ValueMember = "Group";
            }
            Login.db.Close();


        }
        private void bring_survey_button_Click(object sender, EventArgs e)
        {
            int category = Convert.ToInt32(survey_category_combobox.SelectedValue);
            int type = Convert.ToInt32(survey_type_combobox.SelectedValue);
            string query = "";

            if (survey_type_combobox.SelectedValue.ToString() == "1")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from MultipleChoice inner join Groups on (MultipleChoice.GroupId=Groups.Id) where MultipleChoice.CategoryId=" + category + " and MultipleChoice.TypeId=" + type + "";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "2")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from MultipleSelect inner join Groups on (MultipleSelect.GroupId=Groups.Id) where MultipleSelect.CategoryId=" + category + " and MultipleSelect.TypeId=" + type + "";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "3")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from ShortAnswer inner join Groups on (ShortAnswer.GroupId=Groups.Id) where ShortAnswer.CategoryId=" + category + " and ShortAnswer.TypeId=" + type + "";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "4")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from FillBlank inner join Groups on (FillBlank.GroupId=Groups.Id) where FillBlank.CategoryId=" + category + " and FillBlank.TypeId=" + type + "";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "5")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from Matching inner join Groups on (Matching.GroupId=Groups.Id) where Matching.CategoryId=" + category + " and Matching.TypeId=" + type + "";
            }
            else if (survey_type_combobox.SelectedValue.ToString() == "6")
            {
                query = "select distinct Groups.[Group] as [Survey Name] from VisualMatching inner join Groups on (VisualMatching.GroupId=Groups.Id) where VisualMatching.CategoryId=" + category + " and VisualMatching.TypeId=" + type + "";
            }
            //string group = group_combobox.Text;
            //string query = "select MultipleChoice.Question from MultipleChoice where MultipleChoice.CategoryId=" + category + " and MultipleChoice.TypeId=" + type + " and MultipleChoice.GroupId=" + grpid + "";
            //string query = "select MultipleChoice.Question from MultipleChoice where MultipleChoice.Gname='" + group + "'";
            FillData(query);
            survey_datagridview.DataSource = FillData(query);
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
        private void UserUI_Load(object sender, EventArgs e)
        {
            Login.db.Close();
            username_label.Text = "Welcome, " + user + "!";
            FillCategory();
            FillType();
            //survey_category_combobox.SelectedIndex = -1;
            //survey_type_combobox.SelectedIndex = -1;
            test.Text = userid.ToString();
            CapperField();
        }
        private void survey_category_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (survey_category_combobox.SelectedIndex != -1 && survey_type_combobox.SelectedIndex != -1)
            {
            }
                FillGroup();
        }
        private void survey_type_combobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (survey_category_combobox.SelectedIndex != -1 && survey_type_combobox.SelectedIndex != -1)
            {
            }
                FillGroup();
        }

      
    }
}
