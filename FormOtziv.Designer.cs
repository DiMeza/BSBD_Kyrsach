namespace Приложение_для_БД_ЭлектронныйМагазин
{
    partial class FormOtziv
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
            System.Windows.Forms.Label ___отзываLabel;
            System.Windows.Forms.Label датаLabel;
            System.Windows.Forms.Label описаниеLabel;
            System.Windows.Forms.Label оценкаLabel;
            System.Windows.Forms.Label iD_покупателяLabel;
            System.Windows.Forms.Label iD_товараLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOtziv));
            this.электронныйМагазинDataSet = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSet();
            this.отзывBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.отзывTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ОтзывTableAdapter();
            this.tableAdapterManager = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager();
            this.отзывBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.отзывBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.___отзываTextBox = new System.Windows.Forms.TextBox();
            this.датаDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.описаниеTextBox = new System.Windows.Forms.TextBox();
            this.оценкаTextBox = new System.Windows.Forms.TextBox();
            this.iD_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.iD_товараTextBox = new System.Windows.Forms.TextBox();
            ___отзываLabel = new System.Windows.Forms.Label();
            датаLabel = new System.Windows.Forms.Label();
            описаниеLabel = new System.Windows.Forms.Label();
            оценкаLabel = new System.Windows.Forms.Label();
            iD_покупателяLabel = new System.Windows.Forms.Label();
            iD_товараLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывBindingNavigator)).BeginInit();
            this.отзывBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ___отзываLabel
            // 
            ___отзываLabel.AutoSize = true;
            ___отзываLabel.Location = new System.Drawing.Point(12, 55);
            ___отзываLabel.Name = "___отзываLabel";
            ___отзываLabel.Size = new System.Drawing.Size(87, 20);
            ___отзываLabel.TabIndex = 1;
            ___отзываLabel.Text = "№ отзыва:";
            // 
            // датаLabel
            // 
            датаLabel.AutoSize = true;
            датаLabel.Location = new System.Drawing.Point(12, 88);
            датаLabel.Name = "датаLabel";
            датаLabel.Size = new System.Drawing.Size(52, 20);
            датаLabel.TabIndex = 3;
            датаLabel.Text = "Дата:";
            // 
            // описаниеLabel
            // 
            описаниеLabel.AutoSize = true;
            описаниеLabel.Location = new System.Drawing.Point(12, 119);
            описаниеLabel.Name = "описаниеLabel";
            описаниеLabel.Size = new System.Drawing.Size(87, 20);
            описаниеLabel.TabIndex = 5;
            описаниеLabel.Text = "Описание:";
            // 
            // оценкаLabel
            // 
            оценкаLabel.AutoSize = true;
            оценкаLabel.Location = new System.Drawing.Point(12, 328);
            оценкаLabel.Name = "оценкаLabel";
            оценкаLabel.Size = new System.Drawing.Size(69, 20);
            оценкаLabel.TabIndex = 7;
            оценкаLabel.Text = "Оценка:";
            // 
            // iD_покупателяLabel
            // 
            iD_покупателяLabel.AutoSize = true;
            iD_покупателяLabel.Location = new System.Drawing.Point(12, 360);
            iD_покупателяLabel.Name = "iD_покупателяLabel";
            iD_покупателяLabel.Size = new System.Drawing.Size(122, 20);
            iD_покупателяLabel.TabIndex = 9;
            iD_покупателяLabel.Text = "ID покупателя:";
            // 
            // iD_товараLabel
            // 
            iD_товараLabel.AutoSize = true;
            iD_товараLabel.Location = new System.Drawing.Point(12, 392);
            iD_товараLabel.Name = "iD_товараLabel";
            iD_товараLabel.Size = new System.Drawing.Size(88, 20);
            iD_товараLabel.TabIndex = 11;
            iD_товараLabel.Text = "ID товара:";
            // 
            // электронныйМагазинDataSet
            // 
            this.электронныйМагазинDataSet.DataSetName = "ЭлектронныйМагазинDataSet";
            this.электронныйМагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // отзывBindingSource
            // 
            this.отзывBindingSource.DataMember = "Отзыв";
            this.отзывBindingSource.DataSource = this.электронныйМагазинDataSet;
            // 
            // отзывTableAdapter
            // 
            this.отзывTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнформацияЗаказаTableAdapter = null;
            this.tableAdapterManager.ОтзывTableAdapter = this.отзывTableAdapter;
            this.tableAdapterManager.ПокупательTableAdapter = null;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // отзывBindingNavigator
            // 
            this.отзывBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.отзывBindingNavigator.BindingSource = this.отзывBindingSource;
            this.отзывBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.отзывBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.отзывBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.отзывBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.отзывBindingNavigatorSaveItem});
            this.отзывBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.отзывBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.отзывBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.отзывBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.отзывBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.отзывBindingNavigator.Name = "отзывBindingNavigator";
            this.отзывBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.отзывBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.отзывBindingNavigator.TabIndex = 0;
            this.отзывBindingNavigator.Text = "bindingNavigator1";
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
            // отзывBindingNavigatorSaveItem
            // 
            this.отзывBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.отзывBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("отзывBindingNavigatorSaveItem.Image")));
            this.отзывBindingNavigatorSaveItem.Name = "отзывBindingNavigatorSaveItem";
            this.отзывBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.отзывBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.отзывBindingNavigatorSaveItem.Click += new System.EventHandler(this.отзывBindingNavigatorSaveItem_Click_1);
            // 
            // ___отзываTextBox
            // 
            this.___отзываTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отзывBindingSource, "№_отзыва", true));
            this.___отзываTextBox.Location = new System.Drawing.Point(140, 52);
            this.___отзываTextBox.Name = "___отзываTextBox";
            this.___отзываTextBox.Size = new System.Drawing.Size(631, 26);
            this.___отзываTextBox.TabIndex = 2;
            // 
            // датаDateTimePicker
            // 
            this.датаDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.отзывBindingSource, "Дата", true));
            this.датаDateTimePicker.Location = new System.Drawing.Point(140, 84);
            this.датаDateTimePicker.Name = "датаDateTimePicker";
            this.датаDateTimePicker.Size = new System.Drawing.Size(631, 26);
            this.датаDateTimePicker.TabIndex = 4;
            // 
            // описаниеTextBox
            // 
            this.описаниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отзывBindingSource, "Описание", true));
            this.описаниеTextBox.Location = new System.Drawing.Point(140, 116);
            this.описаниеTextBox.Multiline = true;
            this.описаниеTextBox.Name = "описаниеTextBox";
            this.описаниеTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.описаниеTextBox.Size = new System.Drawing.Size(631, 203);
            this.описаниеTextBox.TabIndex = 6;
            // 
            // оценкаTextBox
            // 
            this.оценкаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отзывBindingSource, "Оценка", true));
            this.оценкаTextBox.Location = new System.Drawing.Point(140, 325);
            this.оценкаTextBox.Name = "оценкаTextBox";
            this.оценкаTextBox.Size = new System.Drawing.Size(631, 26);
            this.оценкаTextBox.TabIndex = 8;
            // 
            // iD_покупателяTextBox
            // 
            this.iD_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отзывBindingSource, "ID_покупателя", true));
            this.iD_покупателяTextBox.Location = new System.Drawing.Point(140, 357);
            this.iD_покупателяTextBox.Name = "iD_покупателяTextBox";
            this.iD_покупателяTextBox.Size = new System.Drawing.Size(631, 26);
            this.iD_покупателяTextBox.TabIndex = 10;
            // 
            // iD_товараTextBox
            // 
            this.iD_товараTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.отзывBindingSource, "ID_товара", true));
            this.iD_товараTextBox.Location = new System.Drawing.Point(140, 389);
            this.iD_товараTextBox.Name = "iD_товараTextBox";
            this.iD_товараTextBox.Size = new System.Drawing.Size(631, 26);
            this.iD_товараTextBox.TabIndex = 12;
            // 
            // FormOtziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(___отзываLabel);
            this.Controls.Add(this.___отзываTextBox);
            this.Controls.Add(датаLabel);
            this.Controls.Add(this.датаDateTimePicker);
            this.Controls.Add(описаниеLabel);
            this.Controls.Add(this.описаниеTextBox);
            this.Controls.Add(оценкаLabel);
            this.Controls.Add(this.оценкаTextBox);
            this.Controls.Add(iD_покупателяLabel);
            this.Controls.Add(this.iD_покупателяTextBox);
            this.Controls.Add(iD_товараLabel);
            this.Controls.Add(this.iD_товараTextBox);
            this.Controls.Add(this.отзывBindingNavigator);
            this.Name = "FormOtziv";
            this.Text = "Отзывы";
            this.Load += new System.EventHandler(this.FormOtziv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.отзывBindingNavigator)).EndInit();
            this.отзывBindingNavigator.ResumeLayout(false);
            this.отзывBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЭлектронныйМагазинDataSet электронныйМагазинDataSet;
        private System.Windows.Forms.BindingSource отзывBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ОтзывTableAdapter отзывTableAdapter;
        private ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator отзывBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton отзывBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ___отзываTextBox;
        private System.Windows.Forms.DateTimePicker датаDateTimePicker;
        private System.Windows.Forms.TextBox описаниеTextBox;
        private System.Windows.Forms.TextBox оценкаTextBox;
        private System.Windows.Forms.TextBox iD_покупателяTextBox;
        private System.Windows.Forms.TextBox iD_товараTextBox;
    }
}