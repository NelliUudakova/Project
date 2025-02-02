﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void participantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.participantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.balkiaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "balkiaDataSet.Participants". При необходимости она может быть перемещена или удалена.
            this.participantsTableAdapter.Fill(this.balkiaDataSet.Participants);

        }

        private void participantsIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthlyRentTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void legalEntityCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void individualEntrepreneurCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            participantsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            participantsBindingSource.AddNew();
            participantsTableAdapter.Update(balkiaDataSet);
        }
    }
}
