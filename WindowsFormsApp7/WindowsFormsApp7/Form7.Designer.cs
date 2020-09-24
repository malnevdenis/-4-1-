namespace WindowsFormsApp7
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.гПУDataSet = new WindowsFormsApp7.ГПУDataSet();
            this.отпускныеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отпускныеTableAdapter = new WindowsFormsApp7.ГПУDataSetTableAdapters.ОтпускныеTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp7.ГПУDataSetTableAdapters.TableAdapterManager();
            this.отпускныеBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.отпускныеBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.отпускныеDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.гПУDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеBindingNavigator)).BeginInit();
            this.отпускныеBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // гПУDataSet
            // 
            this.гПУDataSet.DataSetName = "ГПУDataSet";
            this.гПУDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отпускныеBindingSource
            // 
            this.отпускныеBindingSource.DataMember = "Отпускные";
            this.отпускныеBindingSource.DataSource = this.гПУDataSet;
            // 
            // отпускныеTableAdapter
            // 
            this.отпускныеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp7.ГПУDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.БольничныйTableAdapter = null;
            this.tableAdapterManager.Дата_трудоустройстваTableAdapter = null;
            this.tableAdapterManager.Информация_о_сотрудникеTableAdapter = null;
            this.tableAdapterManager.ОкладTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.ОтпускTableAdapter = null;
            this.tableAdapterManager.ОтпускныеTableAdapter = this.отпускныеTableAdapter;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // отпускныеBindingNavigator
            // 
            this.отпускныеBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отпускныеBindingNavigator.BindingSource = this.отпускныеBindingSource;
            this.отпускныеBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отпускныеBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отпускныеBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отпускныеBindingNavigatorSaveItem});
            this.отпускныеBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отпускныеBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отпускныеBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отпускныеBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отпускныеBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отпускныеBindingNavigator.Name = "отпускныеBindingNavigator";
            this.отпускныеBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отпускныеBindingNavigator.Size = new System.Drawing.Size(363, 25);
            this.отпускныеBindingNavigator.TabIndex = 0;
            this.отпускныеBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // отпускныеBindingNavigatorSaveItem
            // 
            this.отпускныеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отпускныеBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отпускныеBindingNavigatorSaveItem.Image")));
            this.отпускныеBindingNavigatorSaveItem.Name = "отпускныеBindingNavigatorSaveItem";
            this.отпускныеBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.отпускныеBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.отпускныеBindingNavigatorSaveItem.Click += new System.EventHandler(this.отпускныеBindingNavigatorSaveItem_Click);
            // 
            // отпускныеDataGridView
            // 
            this.отпускныеDataGridView.AutoGenerateColumns = false;
            this.отпускныеDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.отпускныеDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.отпускныеDataGridView.DataSource = this.отпускныеBindingSource;
            this.отпускныеDataGridView.Location = new System.Drawing.Point(12, 28);
            this.отпускныеDataGridView.Name = "отпускныеDataGridView";
            this.отпускныеDataGridView.Size = new System.Drawing.Size(346, 220);
            this.отпускныеDataGridView.TabIndex = 1;
            this.отпускныеDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.отпускныеDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_отпускных";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код_отпускных";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "отпускные_сумма";
            this.dataGridViewTextBoxColumn2.HeaderText = "отпускные_сумма";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "код_отпуска";
            this.dataGridViewTextBoxColumn3.HeaderText = "код_отпуска";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 259);
            this.Controls.Add(this.отпускныеDataGridView);
            this.Controls.Add(this.отпускныеBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.гПУDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеBindingNavigator)).EndInit();
            this.отпускныеBindingNavigator.ResumeLayout(false);
            this.отпускныеBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.отпускныеDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ГПУDataSet гПУDataSet;
        private System.Windows.Forms.BindingSource отпускныеBindingSource;
        private ГПУDataSetTableAdapters.ОтпускныеTableAdapter отпускныеTableAdapter;
        private ГПУDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отпускныеBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отпускныеBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView отпускныеDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}