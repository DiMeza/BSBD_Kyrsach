namespace Приложение_для_БД_ЭлектронныйМагазин
{
    partial class FormInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.электронныйМагазинDataSet = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSet();
            this.информацияЗаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.информацияЗаказаTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ИнформацияЗаказаTableAdapter();
            this.tableAdapterManager = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager();
            this.информацияЗаказаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.информацияЗаказаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.информацияЗаказаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingNavigator)).BeginInit();
            this.информацияЗаказаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // электронныйМагазинDataSet
            // 
            this.электронныйМагазинDataSet.DataSetName = "ЭлектронныйМагазинDataSet";
            this.электронныйМагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // информацияЗаказаBindingSource
            // 
            this.информацияЗаказаBindingSource.DataMember = "ИнформацияЗаказа";
            this.информацияЗаказаBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // информацияЗаказаTableAdapter
            // 
            this.информацияЗаказаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнформацияЗаказаTableAdapter = this.информацияЗаказаTableAdapter;
            this.tableAdapterManager.ОтзывTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // информацияЗаказаBindingNavigator
            // 
            this.информацияЗаказаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.информацияЗаказаBindingNavigator.BindingSource = this.информацияЗаказаBindingSource;
            this.информацияЗаказаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.информацияЗаказаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.информацияЗаказаBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.информацияЗаказаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.информацияЗаказаBindingNavigatorSaveItem});
            this.информацияЗаказаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.информацияЗаказаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.информацияЗаказаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.информацияЗаказаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.информацияЗаказаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.информацияЗаказаBindingNavigator.Name = "информацияЗаказаBindingNavigator";
            this.информацияЗаказаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.информацияЗаказаBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.информацияЗаказаBindingNavigator.TabIndex = 0;
            this.информацияЗаказаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 33);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 33);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // информацияЗаказаBindingNavigatorSaveItem
            // 
            this.информацияЗаказаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.информацияЗаказаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("информацияЗаказаBindingNavigatorSaveItem.Image")));
            this.информацияЗаказаBindingNavigatorSaveItem.Name = "информацияЗаказаBindingNavigatorSaveItem";
            this.информацияЗаказаBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.информацияЗаказаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.информацияЗаказаBindingNavigatorSaveItem.Click += new System.EventHandler(this.информацияЗаказаBindingNavigatorSaveItem_Click);
            // 
            // информацияЗаказаDataGridView
            // 
            this.информацияЗаказаDataGridView.AutoGenerateColumns = false;
            this.информацияЗаказаDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.информацияЗаказаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.информацияЗаказаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.информацияЗаказаDataGridView.DataSource = this.информацияЗаказаBindingSource;
            this.информацияЗаказаDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.информацияЗаказаDataGridView.Location = new System.Drawing.Point(0, 38);
            this.информацияЗаказаDataGridView.Name = "информацияЗаказаDataGridView";
            this.информацияЗаказаDataGridView.RowHeadersWidth = 62;
            this.информацияЗаказаDataGridView.RowTemplate.Height = 28;
            this.информацияЗаказаDataGridView.Size = new System.Drawing.Size(800, 412);
            this.информацияЗаказаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_заказа";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_заказа";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_товара";
            this.dataGridViewTextBoxColumn2.HeaderText = "ID_товара";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Количество товара";
            this.dataGridViewTextBoxColumn3.HeaderText = "Количество товара";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.информацияЗаказаDataGridView);
            this.Controls.Add(this.информацияЗаказаBindingNavigator);
            this.Name = "FormInfo";
            this.Text = "Информация заказа";
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingNavigator)).EndInit();
            this.информацияЗаказаBindingNavigator.ResumeLayout(false);
            this.информацияЗаказаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЭлектронныйМагазинDataSet электронныйМагазинDataSet;
        private System.Windows.Forms.BindingSource информацияЗаказаBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ИнформацияЗаказаTableAdapter информацияЗаказаTableAdapter;
        private ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator информацияЗаказаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton информацияЗаказаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView информацияЗаказаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}