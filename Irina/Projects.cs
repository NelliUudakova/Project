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
    public partial class Projects : Form
    {
        public Projects()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.balkiaDataSet);

        }

        private void Projects_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "balkiaDataSet.Project". При необходимости она может быть перемещена или удалена.
            this.projectTableAdapter.Fill(this.balkiaDataSet.Project);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectBindingSource.AddNew();
            projectTableAdapter.Update(balkiaDataSet);
        }
    }
}
