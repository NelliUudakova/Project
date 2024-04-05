using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Irina
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            LoginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Budgets budgets = new Budgets();
            budgets.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           Projects projects = new Projects();
           projects.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProjectsTeams1 projectsTeams1 = new ProjectsTeams1();
            projectsTeams1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 project1 = new Form1();
            project1.Show();
        }
    }
}
