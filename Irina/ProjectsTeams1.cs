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
    public partial class ProjectsTeams1 : Form
    {
        public ProjectsTeams1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void projectsTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.balkiaDataSet);

        }

        private void ProjectsTeams1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "balkiaDataSet.ProjectsTeams". При необходимости она может быть перемещена или удалена.
            this.projectsTeamsTableAdapter.Fill(this.balkiaDataSet.ProjectsTeams);

        }

        private void projectsTeamsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void teamMembersLabel_Click(object sender, EventArgs e)
        {

        }

        private void teamNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void teamIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectsTeamsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectsTeamsBindingSource.AddNew();
            projectsTeamsTableAdapter.Update(balkiaDataSet);
        }
    }
}
