﻿namespace Irina
{
    partial class ProjectsTeams1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label teamIDLabel;
            System.Windows.Forms.Label teamNameLabel;
            System.Windows.Forms.Label teamMembersLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsTeams1));
            this.balkiaDataSet = new Irina.BalkiaDataSet();
            this.projectsTeamsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTeamsTableAdapter = new Irina.BalkiaDataSetTableAdapters.ProjectsTeamsTableAdapter();
            this.tableAdapterManager = new Irina.BalkiaDataSetTableAdapters.TableAdapterManager();
            this.projectsTeamsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.projectsTeamsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.projectsTeamsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamIDTextBox = new System.Windows.Forms.TextBox();
            this.teamNameTextBox = new System.Windows.Forms.TextBox();
            this.teamMembersTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            teamIDLabel = new System.Windows.Forms.Label();
            teamNameLabel = new System.Windows.Forms.Label();
            teamMembersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsBindingNavigator)).BeginInit();
            this.projectsTeamsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // teamIDLabel
            // 
            teamIDLabel.AutoSize = true;
            teamIDLabel.Location = new System.Drawing.Point(35, 283);
            teamIDLabel.Name = "teamIDLabel";
            teamIDLabel.Size = new System.Drawing.Size(61, 13);
            teamIDLabel.TabIndex = 2;
            teamIDLabel.Text = "ID Группы:";
            teamIDLabel.Click += new System.EventHandler(this.teamIDLabel_Click);
            // 
            // teamNameLabel
            // 
            teamNameLabel.AutoSize = true;
            teamNameLabel.Location = new System.Drawing.Point(35, 309);
            teamNameLabel.Name = "teamNameLabel";
            teamNameLabel.Size = new System.Drawing.Size(71, 13);
            teamNameLabel.TabIndex = 4;
            teamNameLabel.Text = "Имя группы:";
            teamNameLabel.Click += new System.EventHandler(this.teamNameLabel_Click);
            // 
            // teamMembersLabel
            // 
            teamMembersLabel.AutoSize = true;
            teamMembersLabel.Location = new System.Drawing.Point(35, 335);
            teamMembersLabel.Name = "teamMembersLabel";
            teamMembersLabel.Size = new System.Drawing.Size(93, 13);
            teamMembersLabel.TabIndex = 6;
            teamMembersLabel.Text = "Члены команды:";
            teamMembersLabel.Click += new System.EventHandler(this.teamMembersLabel_Click);
            // 
            // balkiaDataSet
            // 
            this.balkiaDataSet.DataSetName = "BalkiaDataSet";
            this.balkiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsTeamsBindingSource
            // 
            this.projectsTeamsBindingSource.DataMember = "ProjectsTeams";
            this.projectsTeamsBindingSource.DataSource = this.balkiaDataSet;
            // 
            // projectsTeamsTableAdapter
            // 
            this.projectsTeamsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetsTableAdapter = null;
            this.tableAdapterManager.ParticipantsTableAdapter = null;
            this.tableAdapterManager.ProjectsTeamsTableAdapter = this.projectsTeamsTableAdapter;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.TimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Irina.BalkiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // projectsTeamsBindingNavigator
            // 
            this.projectsTeamsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.projectsTeamsBindingNavigator.BindingSource = this.projectsTeamsBindingSource;
            this.projectsTeamsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.projectsTeamsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.projectsTeamsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.projectsTeamsBindingNavigatorSaveItem});
            this.projectsTeamsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.projectsTeamsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.projectsTeamsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.projectsTeamsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.projectsTeamsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.projectsTeamsBindingNavigator.Name = "projectsTeamsBindingNavigator";
            this.projectsTeamsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.projectsTeamsBindingNavigator.Size = new System.Drawing.Size(346, 25);
            this.projectsTeamsBindingNavigator.TabIndex = 0;
            this.projectsTeamsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // projectsTeamsBindingNavigatorSaveItem
            // 
            this.projectsTeamsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.projectsTeamsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("projectsTeamsBindingNavigatorSaveItem.Image")));
            this.projectsTeamsBindingNavigatorSaveItem.Name = "projectsTeamsBindingNavigatorSaveItem";
            this.projectsTeamsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.projectsTeamsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.projectsTeamsBindingNavigatorSaveItem.Click += new System.EventHandler(this.projectsTeamsBindingNavigatorSaveItem_Click);
            // 
            // projectsTeamsDataGridView
            // 
            this.projectsTeamsDataGridView.AutoGenerateColumns = false;
            this.projectsTeamsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectsTeamsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.projectsTeamsDataGridView.DataSource = this.projectsTeamsBindingSource;
            this.projectsTeamsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.projectsTeamsDataGridView.Name = "projectsTeamsDataGridView";
            this.projectsTeamsDataGridView.Size = new System.Drawing.Size(344, 220);
            this.projectsTeamsDataGridView.TabIndex = 1;
            this.projectsTeamsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectsTeamsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "TeamID";
            this.dataGridViewTextBoxColumn1.HeaderText = "TeamID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TeamName";
            this.dataGridViewTextBoxColumn2.HeaderText = "TeamName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TeamMembers";
            this.dataGridViewTextBoxColumn3.HeaderText = "TeamMembers";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // teamIDTextBox
            // 
            this.teamIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTeamsBindingSource, "TeamID", true));
            this.teamIDTextBox.Location = new System.Drawing.Point(139, 280);
            this.teamIDTextBox.Name = "teamIDTextBox";
            this.teamIDTextBox.Size = new System.Drawing.Size(167, 20);
            this.teamIDTextBox.TabIndex = 3;
            // 
            // teamNameTextBox
            // 
            this.teamNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTeamsBindingSource, "TeamName", true));
            this.teamNameTextBox.Location = new System.Drawing.Point(139, 306);
            this.teamNameTextBox.Name = "teamNameTextBox";
            this.teamNameTextBox.Size = new System.Drawing.Size(167, 20);
            this.teamNameTextBox.TabIndex = 5;
            // 
            // teamMembersTextBox
            // 
            this.teamMembersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.projectsTeamsBindingSource, "TeamMembers", true));
            this.teamMembersTextBox.Location = new System.Drawing.Point(139, 332);
            this.teamMembersTextBox.Name = "teamMembersTextBox";
            this.teamMembersTextBox.Size = new System.Drawing.Size(167, 20);
            this.teamMembersTextBox.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 26);
            this.button2.TabIndex = 21;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 20;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ProjectsTeams1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(346, 430);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(teamIDLabel);
            this.Controls.Add(this.teamIDTextBox);
            this.Controls.Add(teamNameLabel);
            this.Controls.Add(this.teamNameTextBox);
            this.Controls.Add(teamMembersLabel);
            this.Controls.Add(this.teamMembersTextBox);
            this.Controls.Add(this.projectsTeamsDataGridView);
            this.Controls.Add(this.projectsTeamsBindingNavigator);
            this.Name = "ProjectsTeams1";
            this.Text = "ProjectsTeams1";
            this.Load += new System.EventHandler(this.ProjectsTeams1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsBindingNavigator)).EndInit();
            this.projectsTeamsBindingNavigator.ResumeLayout(false);
            this.projectsTeamsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectsTeamsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BalkiaDataSet balkiaDataSet;
        private System.Windows.Forms.BindingSource projectsTeamsBindingSource;
        private BalkiaDataSetTableAdapters.ProjectsTeamsTableAdapter projectsTeamsTableAdapter;
        private BalkiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator projectsTeamsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton projectsTeamsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView projectsTeamsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox teamIDTextBox;
        private System.Windows.Forms.TextBox teamNameTextBox;
        private System.Windows.Forms.TextBox teamMembersTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}