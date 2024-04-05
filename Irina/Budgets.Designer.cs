namespace Irina
{
    partial class Budgets
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
            System.Windows.Forms.Label budgetIDLabel;
            System.Windows.Forms.Label totalBudgetLabel;
            System.Windows.Forms.Label spentBudgetLabel;
            System.Windows.Forms.Label remainingBudgetLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Budgets));
            this.balkiaDataSet = new Irina.BalkiaDataSet();
            this.budgetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgetsTableAdapter = new Irina.BalkiaDataSetTableAdapters.BudgetsTableAdapter();
            this.tableAdapterManager = new Irina.BalkiaDataSetTableAdapters.TableAdapterManager();
            this.budgetsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.budgetsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.budgetsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.budgetIDTextBox = new System.Windows.Forms.TextBox();
            this.totalBudgetTextBox = new System.Windows.Forms.TextBox();
            this.spentBudgetTextBox = new System.Windows.Forms.TextBox();
            this.remainingBudgetTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            budgetIDLabel = new System.Windows.Forms.Label();
            totalBudgetLabel = new System.Windows.Forms.Label();
            spentBudgetLabel = new System.Windows.Forms.Label();
            remainingBudgetLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingNavigator)).BeginInit();
            this.budgetsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // budgetIDLabel
            // 
            budgetIDLabel.AutoSize = true;
            budgetIDLabel.Location = new System.Drawing.Point(65, 273);
            budgetIDLabel.Name = "budgetIDLabel";
            budgetIDLabel.Size = new System.Drawing.Size(70, 13);
            budgetIDLabel.TabIndex = 2;
            budgetIDLabel.Text = "ID Бюджета:";
            // 
            // totalBudgetLabel
            // 
            totalBudgetLabel.AutoSize = true;
            totalBudgetLabel.Location = new System.Drawing.Point(65, 299);
            totalBudgetLabel.Name = "totalBudgetLabel";
            totalBudgetLabel.Size = new System.Drawing.Size(87, 13);
            totalBudgetLabel.TabIndex = 4;
            totalBudgetLabel.Text = "Общий бюджет:";
            // 
            // spentBudgetLabel
            // 
            spentBudgetLabel.AutoSize = true;
            spentBudgetLabel.Location = new System.Drawing.Point(65, 325);
            spentBudgetLabel.Name = "spentBudgetLabel";
            spentBudgetLabel.Size = new System.Drawing.Size(120, 13);
            spentBudgetLabel.TabIndex = 6;
            spentBudgetLabel.Text = "Потраченный бюджет:";
            // 
            // remainingBudgetLabel
            // 
            remainingBudgetLabel.AutoSize = true;
            remainingBudgetLabel.Location = new System.Drawing.Point(65, 351);
            remainingBudgetLabel.Name = "remainingBudgetLabel";
            remainingBudgetLabel.Size = new System.Drawing.Size(115, 13);
            remainingBudgetLabel.TabIndex = 8;
            remainingBudgetLabel.Text = "Оставшийся бюджет:";
            // 
            // balkiaDataSet
            // 
            this.balkiaDataSet.DataSetName = "BalkiaDataSet";
            this.balkiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // budgetsBindingSource
            // 
            this.budgetsBindingSource.DataMember = "Budgets";
            this.budgetsBindingSource.DataSource = this.balkiaDataSet;
            // 
            // budgetsTableAdapter
            // 
            this.budgetsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BudgetsTableAdapter = this.budgetsTableAdapter;
            this.tableAdapterManager.ParticipantsTableAdapter = null;
            this.tableAdapterManager.ProjectsTeamsTableAdapter = null;
            this.tableAdapterManager.ProjectTableAdapter = null;
            this.tableAdapterManager.TimeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Irina.BalkiaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // budgetsBindingNavigator
            // 
            this.budgetsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.budgetsBindingNavigator.BindingSource = this.budgetsBindingSource;
            this.budgetsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.budgetsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.budgetsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.budgetsBindingNavigatorSaveItem});
            this.budgetsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.budgetsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.budgetsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.budgetsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.budgetsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.budgetsBindingNavigator.Name = "budgetsBindingNavigator";
            this.budgetsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.budgetsBindingNavigator.Size = new System.Drawing.Size(451, 25);
            this.budgetsBindingNavigator.TabIndex = 0;
            this.budgetsBindingNavigator.Text = "bindingNavigator1";
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
            // budgetsBindingNavigatorSaveItem
            // 
            this.budgetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.budgetsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("budgetsBindingNavigatorSaveItem.Image")));
            this.budgetsBindingNavigatorSaveItem.Name = "budgetsBindingNavigatorSaveItem";
            this.budgetsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.budgetsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.budgetsBindingNavigatorSaveItem.Click += new System.EventHandler(this.budgetsBindingNavigatorSaveItem_Click);
            // 
            // budgetsDataGridView
            // 
            this.budgetsDataGridView.AutoGenerateColumns = false;
            this.budgetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.budgetsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.budgetsDataGridView.DataSource = this.budgetsBindingSource;
            this.budgetsDataGridView.Location = new System.Drawing.Point(0, 28);
            this.budgetsDataGridView.Name = "budgetsDataGridView";
            this.budgetsDataGridView.Size = new System.Drawing.Size(447, 220);
            this.budgetsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BudgetID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BudgetID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TotalBudget";
            this.dataGridViewTextBoxColumn2.HeaderText = "TotalBudget";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SpentBudget";
            this.dataGridViewTextBoxColumn3.HeaderText = "SpentBudget";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "RemainingBudget";
            this.dataGridViewTextBoxColumn4.HeaderText = "RemainingBudget";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // budgetIDTextBox
            // 
            this.budgetIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetsBindingSource, "BudgetID", true));
            this.budgetIDTextBox.Location = new System.Drawing.Point(189, 270);
            this.budgetIDTextBox.Name = "budgetIDTextBox";
            this.budgetIDTextBox.Size = new System.Drawing.Size(177, 20);
            this.budgetIDTextBox.TabIndex = 3;
            // 
            // totalBudgetTextBox
            // 
            this.totalBudgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetsBindingSource, "TotalBudget", true));
            this.totalBudgetTextBox.Location = new System.Drawing.Point(189, 296);
            this.totalBudgetTextBox.Name = "totalBudgetTextBox";
            this.totalBudgetTextBox.Size = new System.Drawing.Size(177, 20);
            this.totalBudgetTextBox.TabIndex = 5;
            // 
            // spentBudgetTextBox
            // 
            this.spentBudgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetsBindingSource, "SpentBudget", true));
            this.spentBudgetTextBox.Location = new System.Drawing.Point(189, 322);
            this.spentBudgetTextBox.Name = "spentBudgetTextBox";
            this.spentBudgetTextBox.Size = new System.Drawing.Size(177, 20);
            this.spentBudgetTextBox.TabIndex = 7;
            // 
            // remainingBudgetTextBox
            // 
            this.remainingBudgetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.budgetsBindingSource, "RemainingBudget", true));
            this.remainingBudgetTextBox.Location = new System.Drawing.Point(189, 348);
            this.remainingBudgetTextBox.Name = "remainingBudgetTextBox";
            this.remainingBudgetTextBox.Size = new System.Drawing.Size(177, 20);
            this.remainingBudgetTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(216, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Budgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(451, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(budgetIDLabel);
            this.Controls.Add(this.budgetIDTextBox);
            this.Controls.Add(totalBudgetLabel);
            this.Controls.Add(this.totalBudgetTextBox);
            this.Controls.Add(spentBudgetLabel);
            this.Controls.Add(this.spentBudgetTextBox);
            this.Controls.Add(remainingBudgetLabel);
            this.Controls.Add(this.remainingBudgetTextBox);
            this.Controls.Add(this.budgetsDataGridView);
            this.Controls.Add(this.budgetsBindingNavigator);
            this.Name = "Budgets";
            this.Text = "Budgets";
            this.Load += new System.EventHandler(this.Budgets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.balkiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsBindingNavigator)).EndInit();
            this.budgetsBindingNavigator.ResumeLayout(false);
            this.budgetsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.budgetsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BalkiaDataSet balkiaDataSet;
        private System.Windows.Forms.BindingSource budgetsBindingSource;
        private BalkiaDataSetTableAdapters.BudgetsTableAdapter budgetsTableAdapter;
        private BalkiaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator budgetsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton budgetsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView budgetsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox budgetIDTextBox;
        private System.Windows.Forms.TextBox totalBudgetTextBox;
        private System.Windows.Forms.TextBox spentBudgetTextBox;
        private System.Windows.Forms.TextBox remainingBudgetTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}