namespace Irina
{
    partial class Form1
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
            System.Windows.Forms.Label participantsIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label startDateLabel;
            System.Windows.Forms.Label monthlyRentLabel;
            System.Windows.Forms.Label legalEntityLabel;
            System.Windows.Forms.Label individualEntrepreneurLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.balkiaDataSet = new Irina.BalkiaDataSet();
            this.participantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.participantsTableAdapter = new Irina.BalkiaDataSetTableAdapters.ParticipantsTableAdapter();
            this.tableAdapterManager = new Irina.BalkiaDataSetTableAdapters.TableAdapterManager();
            this.participantsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.participantsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.participantsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.participantsIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.monthlyRentTextBox = new System.Windows.Forms.TextBox();
            this.legalEntityCheckBox = new System.Windows.Forms.CheckBox();
            this.individualEntrepreneurCheckBox = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            participantsIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            startDateLabel = new System.Windows.Forms.Label();
            monthlyRentLabel = new System.Windows.Forms.Label();
            legalEntityLabel = new System.Windows.Forms.Label();
            individualEntrepreneurLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingNavigator)).BeginInit();
            this.participantsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // participantsIDLabel
            // 
            participantsIDLabel.AutoSize = true;
            participantsIDLabel.Location = new System.Drawing.Point(56, 277);
            participantsIDLabel.Name = "participantsIDLabel";
            participantsIDLabel.Size = new System.Drawing.Size(78, 13);
            participantsIDLabel.TabIndex = 2;
            participantsIDLabel.Text = "ID Участника:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(56, 303);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(32, 13);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Имя:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(56, 329);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "Email:";
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new System.Drawing.Point(56, 356);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new System.Drawing.Size(74, 13);
            startDateLabel.TabIndex = 8;
            startDateLabel.Text = "Дата начала:";
            // 
            // monthlyRentLabel
            // 
            monthlyRentLabel.AutoSize = true;
            monthlyRentLabel.Location = new System.Drawing.Point(56, 381);
            monthlyRentLabel.Name = "monthlyRentLabel";
            monthlyRentLabel.Size = new System.Drawing.Size(101, 13);
            monthlyRentLabel.TabIndex = 10;
            monthlyRentLabel.Text = "Размер зарплаты:";
            // 
            // legalEntityLabel
            // 
            legalEntityLabel.AutoSize = true;
            legalEntityLabel.Location = new System.Drawing.Point(56, 409);
            legalEntityLabel.Name = "legalEntityLabel";
            legalEntityLabel.Size = new System.Drawing.Size(105, 13);
            legalEntityLabel.TabIndex = 12;
            legalEntityLabel.Text = "Юридическое лицо:";
            // 
            // individualEntrepreneurLabel
            // 
            individualEntrepreneurLabel.AutoSize = true;
            individualEntrepreneurLabel.Location = new System.Drawing.Point(56, 439);
            individualEntrepreneurLabel.Name = "individualEntrepreneurLabel";
            individualEntrepreneurLabel.Size = new System.Drawing.Size(191, 13);
            individualEntrepreneurLabel.TabIndex = 14;
            individualEntrepreneurLabel.Text = "Индивидуальный предприниматель:";
            // 
            // balkiaDataSet
            // 
            this.balkiaDataSet.DataSetName = "BalkiaDataSet";
            this.balkiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // participantsBindingSource
            // 
            this.participantsBindingSource.DataMember = "Participants";
            this.participantsBindingSource.DataSource = this.balkiaDataSet;
            // 
            // participantsTableAdapter
            // 
            this.participantsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetsTableAdapter = null;
            this.tableAdapterManager.ParticipantsTableAdapter = this.participantsTableAdapter;
            this.tableAdapterManager.ProjectsTeamsTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.TimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Irina.BalkiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // participantsBindingNavigator
            // 
            this.participantsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.participantsBindingNavigator.BindingSource = this.participantsBindingSource;
            this.participantsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.participantsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.participantsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.participantsBindingNavigatorSaveItem});
            this.participantsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.participantsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.participantsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.participantsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.participantsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.participantsBindingNavigator.Name = "participantsBindingNavigator";
            this.participantsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.participantsBindingNavigator.Size = new System.Drawing.Size(750, 25);
            this.participantsBindingNavigator.TabIndex = 0;
            this.participantsBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // participantsBindingNavigatorSaveItem
            // 
            this.participantsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.participantsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("participantsBindingNavigatorSaveItem.Image")));
            this.participantsBindingNavigatorSaveItem.Name = "participantsBindingNavigatorSaveItem";
            this.participantsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.participantsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.participantsBindingNavigatorSaveItem.Click += new System.EventHandler(this.participantsBindingNavigatorSaveItem_Click);
            // 
            // participantsDataGridView
            // 
            this.participantsDataGridView.AutoGenerateColumns = false;
            this.participantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.participantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2});
            this.participantsDataGridView.DataSource = this.participantsBindingSource;
            this.participantsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.participantsDataGridView.Name = "participantsDataGridView";
            this.participantsDataGridView.Size = new System.Drawing.Size(746, 220);
            this.participantsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ParticipantsID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ParticipantsID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn3.HeaderText = "Email";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "StartDate";
            this.dataGridViewTextBoxColumn4.HeaderText = "StartDate";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "MonthlyRent";
            this.dataGridViewTextBoxColumn5.HeaderText = "MonthlyRent";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "LegalEntity";
            this.dataGridViewCheckBoxColumn1.HeaderText = "LegalEntity";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "IndividualEntrepreneur";
            this.dataGridViewCheckBoxColumn2.HeaderText = "IndividualEntrepreneur";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // participantsIDTextBox
            // 
            this.participantsIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "ParticipantsID", true));
            this.participantsIDTextBox.Location = new System.Drawing.Point(250, 274);
            this.participantsIDTextBox.Name = "participantsIDTextBox";
            this.participantsIDTextBox.Size = new System.Drawing.Size(406, 20);
            this.participantsIDTextBox.TabIndex = 3;
            this.participantsIDTextBox.TextChanged += new System.EventHandler(this.participantsIDTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(250, 300);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(406, 20);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(250, 326);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(406, 20);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.participantsBindingSource, "StartDate", true));
            this.startDateDateTimePicker.Location = new System.Drawing.Point(250, 352);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(406, 20);
            this.startDateDateTimePicker.TabIndex = 9;
            this.startDateDateTimePicker.ValueChanged += new System.EventHandler(this.startDateDateTimePicker_ValueChanged);
            // 
            // monthlyRentTextBox
            // 
            this.monthlyRentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.participantsBindingSource, "MonthlyRent", true));
            this.monthlyRentTextBox.Location = new System.Drawing.Point(250, 378);
            this.monthlyRentTextBox.Name = "monthlyRentTextBox";
            this.monthlyRentTextBox.Size = new System.Drawing.Size(406, 20);
            this.monthlyRentTextBox.TabIndex = 11;
            this.monthlyRentTextBox.TextChanged += new System.EventHandler(this.monthlyRentTextBox_TextChanged);
            // 
            // legalEntityCheckBox
            // 
            this.legalEntityCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.participantsBindingSource, "LegalEntity", true));
            this.legalEntityCheckBox.Location = new System.Drawing.Point(250, 404);
            this.legalEntityCheckBox.Name = "legalEntityCheckBox";
            this.legalEntityCheckBox.Size = new System.Drawing.Size(406, 24);
            this.legalEntityCheckBox.TabIndex = 13;
            this.legalEntityCheckBox.UseVisualStyleBackColor = true;
            this.legalEntityCheckBox.CheckedChanged += new System.EventHandler(this.legalEntityCheckBox_CheckedChanged);
            // 
            // individualEntrepreneurCheckBox
            // 
            this.individualEntrepreneurCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.participantsBindingSource, "IndividualEntrepreneur", true));
            this.individualEntrepreneurCheckBox.Location = new System.Drawing.Point(250, 434);
            this.individualEntrepreneurCheckBox.Name = "individualEntrepreneurCheckBox";
            this.individualEntrepreneurCheckBox.Size = new System.Drawing.Size(406, 24);
            this.individualEntrepreneurCheckBox.TabIndex = 15;
            this.individualEntrepreneurCheckBox.UseVisualStyleBackColor = true;
            this.individualEntrepreneurCheckBox.CheckedChanged += new System.EventHandler(this.individualEntrepreneurCheckBox_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(750, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(participantsIDLabel);
            this.Controls.Add(this.participantsIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(startDateLabel);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(monthlyRentLabel);
            this.Controls.Add(this.monthlyRentTextBox);
            this.Controls.Add(legalEntityLabel);
            this.Controls.Add(this.legalEntityCheckBox);
            this.Controls.Add(individualEntrepreneurLabel);
            this.Controls.Add(this.individualEntrepreneurCheckBox);
            this.Controls.Add(this.participantsDataGridView);
            this.Controls.Add(this.participantsBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.participantsBindingNavigator)).EndInit();
            this.participantsBindingNavigator.ResumeLayout(false);
            this.participantsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.participantsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BalkiaDataSet balkiaDataSet;
        private System.Windows.Forms.BindingSource participantsBindingSource;
        private BalkiaDataSetTableAdapters.ParticipantsTableAdapter participantsTableAdapter;
        private BalkiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator participantsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton participantsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView participantsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.TextBox participantsIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.TextBox monthlyRentTextBox;
        private System.Windows.Forms.CheckBox legalEntityCheckBox;
        private System.Windows.Forms.CheckBox individualEntrepreneurCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}