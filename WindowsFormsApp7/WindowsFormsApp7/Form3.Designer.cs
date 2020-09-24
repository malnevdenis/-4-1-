namespace WindowsFormsApp7
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.гПУDataSet = new WindowsFormsApp7.ГПУDataSet();
            this.информация_о_сотрудникеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информация_о_сотрудникеTableAdapter = new WindowsFormsApp7.ГПУDataSetTableAdapters.Информация_о_сотрудникеTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.ГПУDataSetTableAdapters.TableAdapterManager();
            this.сотрудникиTableAdapter = new WindowsFormsApp7.ГПУDataSetTableAdapters.СотрудникиTableAdapter();
            this.информация_о_сотрудникеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.информация_о_сотрудникеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.информация_о_сотрудникеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.сотрудникиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.гПУDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеBindingNavigator)).BeginInit();
            this.информация_о_сотрудникеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // гПУDataSet
            // 
            this.гПУDataSet.DataSetName = "ГПУDataSet";
            this.гПУDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информация_о_сотрудникеBindingSource
            // 
            this.информация_о_сотрудникеBindingSource.DataMember = "Информация_о_сотруднике";
            this.информация_о_сотрудникеBindingSource.DataSource = this.гПУDataSet;
            // 
            // информация_о_сотрудникеTableAdapter
            // 
            this.информация_о_сотрудникеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp7.ГПУDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БольничныйTableAdapter = null;
            this.tableAdapterManager.Дата_трудоустройстваTableAdapter = null;
            this.tableAdapterManager.Информация_о_сотрудникеTableAdapter = this.информация_о_сотрудникеTableAdapter;
            this.tableAdapterManager.ОкладTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ОтпускTableAdapter = null;
            this.tableAdapterManager.ОтпускныеTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = this.сотрудникиTableAdapter;
            // 
            // сотрудникиTableAdapter
            // 
            this.сотрудникиTableAdapter.ClearBeforeFill = true;
            // 
            // информация_о_сотрудникеBindingNavigator
            // 
            this.информация_о_сотрудникеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.информация_о_сотрудникеBindingNavigator.BindingSource = this.информация_о_сотрудникеBindingSource;
            this.информация_о_сотрудникеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.информация_о_сотрудникеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.информация_о_сотрудникеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.информация_о_сотрудникеBindingNavigatorSaveItem});
            this.информация_о_сотрудникеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.информация_о_сотрудникеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.информация_о_сотрудникеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.информация_о_сотрудникеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.информация_о_сотрудникеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.информация_о_сотрудникеBindingNavigator.Name = "информация_о_сотрудникеBindingNavigator";
            this.информация_о_сотрудникеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.информация_о_сотрудникеBindingNavigator.Size = new System.Drawing.Size(752, 25);
            this.информация_о_сотрудникеBindingNavigator.TabIndex = 0;
            this.информация_о_сотрудникеBindingNavigator.Text = "bindingNavigator1";
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
            // информация_о_сотрудникеBindingNavigatorSaveItem
            // 
            this.информация_о_сотрудникеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.информация_о_сотрудникеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("информация_о_сотрудникеBindingNavigatorSaveItem.Image")));
            this.информация_о_сотрудникеBindingNavigatorSaveItem.Name = "информация_о_сотрудникеBindingNavigatorSaveItem";
            this.информация_о_сотрудникеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.информация_о_сотрудникеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.информация_о_сотрудникеBindingNavigatorSaveItem.Click += new System.EventHandler(this.информация_о_сотрудникеBindingNavigatorSaveItem_Click);
            // 
            // информация_о_сотрудникеDataGridView
            // 
            this.информация_о_сотрудникеDataGridView.AutoGenerateColumns = false;
            this.информация_о_сотрудникеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.информация_о_сотрудникеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.информация_о_сотрудникеDataGridView.DataSource = this.информация_о_сотрудникеBindingSource;
            this.информация_о_сотрудникеDataGridView.Location = new System.Drawing.Point(0, 28);
            this.информация_о_сотрудникеDataGridView.Name = "информация_о_сотрудникеDataGridView";
            this.информация_о_сотрудникеDataGridView.Size = new System.Drawing.Size(747, 220);
            this.информация_о_сотрудникеDataGridView.TabIndex = 1;
            this.информация_о_сотрудникеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.информация_о_сотрудникеDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_информации";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_информации";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "пол";
            this.dataGridViewTextBoxColumn2.HeaderText = "пол";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "семейное_положение";
            this.dataGridViewTextBoxColumn3.HeaderText = "семейное_положение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "количество_детей";
            this.dataGridViewTextBoxColumn4.HeaderText = "количество_детей";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "возраст";
            this.dataGridViewTextBoxColumn5.HeaderText = "возраст";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "телефон";
            this.dataGridViewTextBoxColumn6.HeaderText = "телефон";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "код_сотрудника";
            this.dataGridViewTextBoxColumn7.DataSource = this.сотрудникиBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "ФИО";
            this.dataGridViewTextBoxColumn7.HeaderText = "код_сотрудника";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "код_сотрудника";
            // 
            // сотрудникиBindingSource
            // 
            this.сотрудникиBindingSource.DataMember = "Сотрудники";
            this.сотрудникиBindingSource.DataSource = this.гПУDataSet;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 264);
            this.Controls.Add(this.информация_о_сотрудникеDataGridView);
            this.Controls.Add(this.информация_о_сотрудникеBindingNavigator);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.гПУDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеBindingNavigator)).EndInit();
            this.информация_о_сотрудникеBindingNavigator.ResumeLayout(false);
            this.информация_о_сотрудникеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информация_о_сотрудникеDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сотрудникиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГПУDataSet гПУDataSet;
        private System.Windows.Forms.BindingSource информация_о_сотрудникеBindingSource;
        private ГПУDataSetTableAdapters.Информация_о_сотрудникеTableAdapter информация_о_сотрудникеTableAdapter;
        private ГПУDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator информация_о_сотрудникеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton информация_о_сотрудникеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView информация_о_сотрудникеDataGridView;
        private ГПУDataSetTableAdapters.СотрудникиTableAdapter сотрудникиTableAdapter;
        private System.Windows.Forms.BindingSource сотрудникиBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}