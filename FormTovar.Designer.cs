namespace Приложение_для_БД_ЭлектронныйМагазин
{
    partial class FormTovar
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
            System.Windows.Forms.Label iD_товараLabel;
            System.Windows.Forms.Label названиеLabel;
            System.Windows.Forms.Label поставщикLabel;
            System.Windows.Forms.Label стоимостьLabel;
            System.Windows.Forms.Label тип_товараLabel;
            System.Windows.Forms.Label адрес_складаLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTovar));
            this.товарBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.электронныйМагазинDataSet = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSet();
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
            this.товарBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_товараTextBox = new System.Windows.Forms.TextBox();
            this.названиеTextBox = new System.Windows.Forms.TextBox();
            this.поставщикTextBox = new System.Windows.Forms.TextBox();
            this.стоимостьTextBox = new System.Windows.Forms.TextBox();
            this.тип_товараComboBox = new System.Windows.Forms.ComboBox();
            this.адрес_складаTextBox = new System.Windows.Forms.TextBox();
            this.товарTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ТоварTableAdapter();
            this.tableAdapterManager = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager();
            iD_товараLabel = new System.Windows.Forms.Label();
            названиеLabel = new System.Windows.Forms.Label();
            поставщикLabel = new System.Windows.Forms.Label();
            стоимостьLabel = new System.Windows.Forms.Label();
            тип_товараLabel = new System.Windows.Forms.Label();
            адрес_складаLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).BeginInit();
            this.товарBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_товараLabel
            // 
            iD_товараLabel.AutoSize = true;
            iD_товараLabel.Location = new System.Drawing.Point(12, 52);
            iD_товараLabel.Name = "iD_товараLabel";
            iD_товараLabel.Size = new System.Drawing.Size(88, 20);
            iD_товараLabel.TabIndex = 1;
            iD_товараLabel.Text = "ID товара:";
            // 
            // названиеLabel
            // 
            названиеLabel.AutoSize = true;
            названиеLabel.Location = new System.Drawing.Point(12, 84);
            названиеLabel.Name = "названиеLabel";
            названиеLabel.Size = new System.Drawing.Size(87, 20);
            названиеLabel.TabIndex = 3;
            названиеLabel.Text = "Название:";
            // 
            // поставщикLabel
            // 
            поставщикLabel.AutoSize = true;
            поставщикLabel.Location = new System.Drawing.Point(12, 116);
            поставщикLabel.Name = "поставщикLabel";
            поставщикLabel.Size = new System.Drawing.Size(99, 20);
            поставщикLabel.TabIndex = 5;
            поставщикLabel.Text = "Поставщик:";
            // 
            // стоимостьLabel
            // 
            стоимостьLabel.AutoSize = true;
            стоимостьLabel.Location = new System.Drawing.Point(12, 148);
            стоимостьLabel.Name = "стоимостьLabel";
            стоимостьLabel.Size = new System.Drawing.Size(97, 20);
            стоимостьLabel.TabIndex = 7;
            стоимостьLabel.Text = "Стоимость:";
            // 
            // тип_товараLabel
            // 
            тип_товараLabel.AutoSize = true;
            тип_товараLabel.Location = new System.Drawing.Point(12, 180);
            тип_товараLabel.Name = "тип_товараLabel";
            тип_товараLabel.Size = new System.Drawing.Size(98, 20);
            тип_товараLabel.TabIndex = 9;
            тип_товараLabel.Text = "Тип товара:";
            // 
            // адрес_складаLabel
            // 
            адрес_складаLabel.AutoSize = true;
            адрес_складаLabel.Location = new System.Drawing.Point(12, 214);
            адрес_складаLabel.Name = "адрес_складаLabel";
            адрес_складаLabel.Size = new System.Drawing.Size(120, 20);
            адрес_складаLabel.TabIndex = 11;
            адрес_складаLabel.Text = "Адрес склада:";
            // 
            // товарBindingNavigator
            // 
            this.товарBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.товарBindingNavigator.BindingSource = this.товарBindingSource;
            this.товарBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.товарBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.товарBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.товарBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.товарBindingNavigatorSaveItem});
            this.товарBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.товарBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.товарBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.товарBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.товарBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.товарBindingNavigator.Name = "товарBindingNavigator";
            this.товарBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.товарBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.товарBindingNavigator.TabIndex = 0;
            this.товарBindingNavigator.Text = "bindingNavigator1";
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
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // электронныйМагазинDataSet
            // 
            this.электронныйМагазинDataSet.DataSetName = "ЭлектронныйМагазинDataSet";
            this.электронныйМагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // товарBindingNavigatorSaveItem
            // 
            this.товарBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.товарBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("товарBindingNavigatorSaveItem.Image")));
            this.товарBindingNavigatorSaveItem.Name = "товарBindingNavigatorSaveItem";
            this.товарBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.товарBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.товарBindingNavigatorSaveItem.Click += new System.EventHandler(this.товарBindingNavigatorSaveItem_Click);
            // 
            // iD_товараTextBox
            // 
            this.iD_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "ID_товара", true));
            this.iD_товараTextBox.Location = new System.Drawing.Point(138, 49);
            this.iD_товараTextBox.Name = "iD_товараTextBox";
            this.iD_товараTextBox.Size = new System.Drawing.Size(633, 26);
            this.iD_товараTextBox.TabIndex = 2;
            // 
            // названиеTextBox
            // 
            this.названиеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Название", true));
            this.названиеTextBox.Location = new System.Drawing.Point(138, 81);
            this.названиеTextBox.Name = "названиеTextBox";
            this.названиеTextBox.Size = new System.Drawing.Size(633, 26);
            this.названиеTextBox.TabIndex = 4;
            // 
            // поставщикTextBox
            // 
            this.поставщикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Поставщик", true));
            this.поставщикTextBox.Location = new System.Drawing.Point(138, 113);
            this.поставщикTextBox.Name = "поставщикTextBox";
            this.поставщикTextBox.Size = new System.Drawing.Size(633, 26);
            this.поставщикTextBox.TabIndex = 6;
            // 
            // стоимостьTextBox
            // 
            this.стоимостьTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Стоимость", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.стоимостьTextBox.Location = new System.Drawing.Point(138, 145);
            this.стоимостьTextBox.Name = "стоимостьTextBox";
            this.стоимостьTextBox.Size = new System.Drawing.Size(633, 26);
            this.стоимостьTextBox.TabIndex = 8;
            // 
            // тип_товараComboBox
            // 
            this.тип_товараComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Тип товара", true));
            this.тип_товараComboBox.FormattingEnabled = true;
            this.тип_товараComboBox.Items.AddRange(new object[] {
            "Стандарт",
            "Хрупкое",
            "Крупнобаритный"});
            this.тип_товараComboBox.Location = new System.Drawing.Point(138, 177);
            this.тип_товараComboBox.Name = "тип_товараComboBox";
            this.тип_товараComboBox.Size = new System.Drawing.Size(633, 28);
            this.тип_товараComboBox.TabIndex = 10;
            // 
            // адрес_складаTextBox
            // 
            this.адрес_складаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.товарBindingSource, "Адрес склада", true));
            this.адрес_складаTextBox.Location = new System.Drawing.Point(138, 211);
            this.адрес_складаTextBox.Name = "адрес_складаTextBox";
            this.адрес_складаTextBox.Size = new System.Drawing.Size(633, 26);
            this.адрес_складаTextBox.TabIndex = 12;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнформацияЗаказаTableAdapter = null;
            this.tableAdapterManager.ОтзывTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = this.товарTableAdapter;
            // 
            // FormTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_товараLabel);
            this.Controls.Add(this.iD_товараTextBox);
            this.Controls.Add(названиеLabel);
            this.Controls.Add(this.названиеTextBox);
            this.Controls.Add(поставщикLabel);
            this.Controls.Add(this.поставщикTextBox);
            this.Controls.Add(стоимостьLabel);
            this.Controls.Add(this.стоимостьTextBox);
            this.Controls.Add(тип_товараLabel);
            this.Controls.Add(this.тип_товараComboBox);
            this.Controls.Add(адрес_складаLabel);
            this.Controls.Add(this.адрес_складаTextBox);
            this.Controls.Add(this.товарBindingNavigator);
            this.Name = "FormTovar";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.FormTovar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingNavigator)).EndInit();
            this.товарBindingNavigator.ResumeLayout(false);
            this.товарBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЭлектронныйМагазинDataSet электронныйМагазинDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator товарBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton товарBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_товараTextBox;
        private System.Windows.Forms.TextBox названиеTextBox;
        private System.Windows.Forms.TextBox поставщикTextBox;
        private System.Windows.Forms.TextBox стоимостьTextBox;
        private System.Windows.Forms.ComboBox тип_товараComboBox;
        private System.Windows.Forms.TextBox адрес_складаTextBox;
    }
}