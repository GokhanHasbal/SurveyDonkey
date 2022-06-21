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
    public partial class CreateaSurvey : Form
    {
        public CreateaSurvey()
        {
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void CreateaSurvey_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void single_select_multiple_choice_button_MouseHover(object sender, EventArgs e)
        {
            single_select_multiple_choice_button.Size = new Size(138, 83);
            single_select_multiple_choice_button.BackColor = SystemColors.ControlDark;
        }

        private void single_select_multiple_choice_button_MouseLeave(object sender, EventArgs e)
        {
            single_select_multiple_choice_button.Size = new Size(108, 63);
            single_select_multiple_choice_button.BackColor = SystemColors.Control;


        }

        private void single_select_multiple_choice_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultipleChoice singleMultipleChoice  = new MultipleChoice();
            singleMultipleChoice.Show();
        }

        private void multi_select_multiple_choice_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            MultipleSelect multipleSelect = new MultipleSelect();
            multipleSelect.Show();
        }

        private void short_answer_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShortAnswer shortAnswer = new ShortAnswer();
            shortAnswer.Show();
        }

        private void fill_in_the_blank_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            FillintheBlank fillintheBlank = new FillintheBlank();
            fillintheBlank.Show();
        }

        private void matching_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Matching matching = new Matching();
            matching.Show();
        }

        private void visual_matching_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            VisualMatching visualMatching = new VisualMatching();
            visualMatching.Show();
        }

        private void CreateaSurvey_Load(object sender, EventArgs e)
        {

        }
    }
}
