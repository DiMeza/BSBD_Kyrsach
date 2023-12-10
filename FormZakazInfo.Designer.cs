namespace Приложение_для_БД_ЭлектронныйМагазин
{
    partial class FormZakazInfo
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
            System.Windows.Forms.Label iD_заказаLabel;
            System.Windows.Forms.Label адрес_пункта_выдачиLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label iD_покупателяLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormZakazInfo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.электронныйМагазинDataSet = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager();
            this.информацияЗаказаTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ИнформацияЗаказаTableAdapter();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_заказаTextBox = new System.Windows.Forms.TextBox();
            this.адрес_пункта_выдачиTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iD_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.groupBoxZakazInfo = new System.Windows.Forms.GroupBox();
            this.ZakazInfobindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.информацияЗаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.информацияЗаказаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPokypatel = new System.Windows.Forms.Button();
            this.покупательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупательTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ПокупательTableAdapter();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ТоварTableAdapter();
            iD_заказаLabel = new System.Windows.Forms.Label();
            адрес_пункта_выдачиLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            iD_покупателяLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            this.groupBoxZakazInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZakazInfobindingNavigator)).BeginInit();
            this.ZakazInfobindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_заказаLabel
            // 
            iD_заказаLabel.AutoSize = true;
            iD_заказаLabel.Location = new System.Drawing.Point(12, 47);
            iD_заказаLabel.Name = "iD_заказаLabel";
            iD_заказаLabel.Size = new System.Drawing.Size(85, 20);
            iD_заказаLabel.TabIndex = 1;
            iD_заказаLabel.Text = "ID заказа:";
            // 
            // адрес_пункта_выдачиLabel
            // 
            адрес_пункта_выдачиLabel.AutoSize = true;
            адрес_пункта_выдачиLabel.Location = new System.Drawing.Point(12, 76);
            адрес_пункта_выдачиLabel.Name = "адрес_пункта_выдачиLabel";
            адрес_пункта_выдачиLabel.Size = new System.Drawing.Size(178, 20);
            адрес_пункта_выдачиLabel.TabIndex = 3;
            адрес_пункта_выдачиLabel.Text = "Адрес пункта выдачи:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(12, 109);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 5;
            датаLabel.Text = "Дата:";
            // 
            // iD_покупателяLabel
            // 
            iD_покупателяLabel.AutoSize = true;
            iD_покупателяLabel.Location = new System.Drawing.Point(12, 140);
            iD_покупателяLabel.Name = "iD_покупателяLabel";
            iD_покупателяLabel.Size = new System.Drawing.Size(122, 20);
            iD_покупателяLabel.TabIndex = 7;
            iD_покупателяLabel.Text = "ID покупателя:";
            // 
            // электронныйМагазинDataSet
            // 
            this.электронныйМагазинDataSet.DataSetName = "ЭлектронныйМагазинDataSet";
            this.электронныйМагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.ИнформацияЗаказаTableAdapter = this.информацияЗаказаTableAdapter;
            this.tableAdapterManager.ОтзывTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // информацияЗаказаTableAdapter
            // 
            this.информацияЗаказаTableAdapter.ClearBeforeFill = true;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.BindingSource = this.заказBindingSource;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(1150, 33);
            this.заказBindingNavigator.TabIndex = 0;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
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
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // iD_заказаTextBox
            // 
            this.iD_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ID_заказа", true));
            this.iD_заказаTextBox.Location = new System.Drawing.Point(196, 44);
            this.iD_заказаTextBox.Name = "iD_заказаTextBox";
            this.iD_заказаTextBox.Size = new System.Drawing.Size(200, 26);
            this.iD_заказаTextBox.TabIndex = 2;
            // 
            // адрес_пункта_выдачиTextBox
            // 
            this.адрес_пункта_выдачиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Адрес пункта выдачи", true));
            this.адрес_пункта_выдачиTextBox.Location = new System.Drawing.Point(196, 76);
            this.адрес_пункта_выдачиTextBox.Name = "адрес_пункта_выдачиTextBox";
            this.адрес_пункта_выдачиTextBox.Size = new System.Drawing.Size(200, 26);
            this.адрес_пункта_выдачиTextBox.TabIndex = 4;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.заказBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(196, 105);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.датаDateTimePicker.TabIndex = 6;
            // 
            // iD_покупателяTextBox
            // 
            this.iD_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "ID_покупателя", true));
            this.iD_покупателяTextBox.Location = new System.Drawing.Point(196, 137);
            this.iD_покупателяTextBox.Name = "iD_покупателяTextBox";
            this.iD_покупателяTextBox.Size = new System.Drawing.Size(200, 26);
            this.iD_покупателяTextBox.TabIndex = 8;
            // 
            // groupBoxZakazInfo
            // 
            this.groupBoxZakazInfo.Controls.Add(this.ZakazInfobindingNavigator);
            this.groupBoxZakazInfo.Controls.Add(this.информацияЗаказаDataGridView);
            this.groupBoxZakazInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxZakazInfo.Location = new System.Drawing.Point(0, 208);
            this.groupBoxZakazInfo.Name = "groupBoxZakazInfo";
            this.groupBoxZakazInfo.Size = new System.Drawing.Size(1150, 786);
            this.groupBoxZakazInfo.TabIndex = 9;
            this.groupBoxZakazInfo.TabStop = false;
            this.groupBoxZakazInfo.Text = "Информация заказа";
            // 
            // ZakazInfobindingNavigator
            // 
            this.ZakazInfobindingNavigator.AddNewItem = this.toolStripButton1;
            this.ZakazInfobindingNavigator.BindingSource = this.информацияЗаказаBindingSource;
            this.ZakazInfobindingNavigator.CountItem = this.toolStripLabel1;
            this.ZakazInfobindingNavigator.DeleteItem = this.toolStripButton2;
            this.ZakazInfobindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ZakazInfobindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.ZakazInfobindingNavigator.Location = new System.Drawing.Point(3, 22);
            this.ZakazInfobindingNavigator.MoveFirstItem = this.toolStripButton3;
            this.ZakazInfobindingNavigator.MoveLastItem = this.toolStripButton6;
            this.ZakazInfobindingNavigator.MoveNextItem = this.toolStripButton5;
            this.ZakazInfobindingNavigator.MovePreviousItem = this.toolStripButton4;
            this.ZakazInfobindingNavigator.Name = "ZakazInfobindingNavigator";
            this.ZakazInfobindingNavigator.PositionItem = this.toolStripTextBox1;
            this.ZakazInfobindingNavigator.Size = new System.Drawing.Size(1144, 33);
            this.ZakazInfobindingNavigator.TabIndex = 1;
            this.ZakazInfobindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton1.Text = "Добавить";
            // 
            // информацияЗаказаBindingSource
            // 
            this.информацияЗаказаBindingSource.DataMember = "FK_ИнформацияЗаказа_Заказ";
            this.информацияЗаказаBindingSource.DataSource = this.заказBindingSource;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 28);
            this.toolStripLabel1.Text = "для {0}";
            this.toolStripLabel1.ToolTipText = "Общее число элементов";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton2.Text = "Удалить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton3.Text = "Переместить в начало";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton4.Text = "Переместить назад";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Положение";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 31);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Текущее положение";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton5.Text = "Переместить вперед";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton6.Text = "Переместить в конец";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(34, 28);
            this.toolStripButton7.Text = "Сохранить данные";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.информацияЗаказаDataGridView.DataSource = this.информацияЗаказаBindingSource;
            this.информацияЗаказаDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.информацияЗаказаDataGridView.Location = new System.Drawing.Point(3, 63);
            this.информацияЗаказаDataGridView.Name = "информацияЗаказаDataGridView";
            this.информацияЗаказаDataGridView.RowHeadersWidth = 62;
            this.информацияЗаказаDataGridView.RowTemplate.Height = 28;
            this.информацияЗаказаDataGridView.Size = new System.Drawing.Size(1144, 720);
            this.информацияЗаказаDataGridView.TabIndex = 0;
            this.информацияЗаказаDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.инфоЗаказDataGridView_CellContentClick);
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "О товаре";
            this.dataGridViewTextBoxColumn3.HeaderText = "О товаре";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количество товара";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количество товара";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Стоимость";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Итоговая стоимость";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Итоговая стоимость";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // buttonPokypatel
            // 
            this.buttonPokypatel.Location = new System.Drawing.Point(441, 137);
            this.buttonPokypatel.Name = "buttonPokypatel";
            this.buttonPokypatel.Size = new System.Drawing.Size(117, 40);
            this.buttonPokypatel.TabIndex = 10;
            this.buttonPokypatel.Text = "Покупатель";
            this.buttonPokypatel.UseVisualStyleBackColor = true;
            this.buttonPokypatel.Click += new System.EventHandler(this.buttonPokypatel_Click);
            // 
            // покупательBindingSource
            // 
            this.покупательBindingSource.DataMember = "Покупатель";
            this.покупательBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // покупательTableAdapter
            // 
            this.покупательTableAdapter.ClearBeforeFill = true;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // FormZakazInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 994);
            this.Controls.Add(this.buttonPokypatel);
            this.Controls.Add(this.groupBoxZakazInfo);
            this.Controls.Add(iD_заказаLabel);
            this.Controls.Add(this.iD_заказаTextBox);
            this.Controls.Add(адрес_пункта_выдачиLabel);
            this.Controls.Add(this.адрес_пункта_выдачиTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(iD_покупателяLabel);
            this.Controls.Add(this.iD_покупателяTextBox);
            this.Controls.Add(this.заказBindingNavigator);
            this.Name = "FormZakazInfo";
            this.Text = "Информация заказов";
            this.Load += new System.EventHandler(this.FormZakazInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            this.groupBoxZakazInfo.ResumeLayout(false);
            this.groupBoxZakazInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZakazInfobindingNavigator)).EndInit();
            this.ZakazInfobindingNavigator.ResumeLayout(false);
            this.ZakazInfobindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.информацияЗаказаDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЭлектронныйМагазинDataSet электронныйМагазинDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_заказаTextBox;
        private System.Windows.Forms.TextBox адрес_пункта_выдачиTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox iD_покупателяTextBox;
        private System.Windows.Forms.GroupBox groupBoxZakazInfo;
        private ЭлектронныйМагазинDataSetTableAdapters.ИнформацияЗаказаTableAdapter информацияЗаказаTableAdapter;
        private System.Windows.Forms.BindingSource информацияЗаказаBindingSource;
        private System.Windows.Forms.DataGridView информацияЗаказаDataGridView;
        private System.Windows.Forms.BindingNavigator ZakazInfobindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.Button buttonPokypatel;
        private System.Windows.Forms.BindingSource покупательBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ПокупательTableAdapter покупательTableAdapter;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}