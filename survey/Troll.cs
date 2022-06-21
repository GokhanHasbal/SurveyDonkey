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
    public partial class Troll : Form
    {
        int i = 0;
        int j = 0;
        public Troll()
        {
            InitializeComponent();
        }
        private void Troll_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Troll_Load(object sender, EventArgs e)
        {
            click_button.Visible = false;
            win_label.Visible = false;
            loose_label.Visible = false;
            richTextBox1.ReadOnly = true;
        }
        private void click_button_Click(object sender, EventArgs e)
        {
            j++;
            win_label.Text = "Win = " + j;
            if (j >= 20)
            {
                MessageBox.Show("You won!");
                ResetGame();
            }
        }
        public void ResetGame()
        {
            loose_label.Text = "Loose ";
            win_label.Text = "Win ";
            i = 0;
            j = 0;
            click_button.Location = new Point(350, 175);
        }
        private void click_button_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(0, 700);
            int number2 = random.Next(0, 350);
            click_button.Location = new Point(number1, number2);
            i++;
            loose_label.Text = "Loose = " + i;
            if (i >= 20)
            {
                MessageBox.Show("You lost!");
                ResetGame();
            }
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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(0, 1700);
            int number2 = random.Next(0, 860);
            low_button.Location = new Point(number1, number2);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(0, 1700);
            int number2 = random.Next(0, 860);
            med_button.Location = new Point(number1, number2);
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int number1 = random.Next(0, 1700);
            int number2 = random.Next(0, 860);
            medi_button.Location = new Point(number1, number2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çok teşekkürler");
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.BackColor = Color.ForestGreen;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = SystemColors.Control;

        }
    }
}
