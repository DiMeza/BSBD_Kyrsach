namespace Приложение_для_БД_ЭлектронныйМагазин
{
    partial class FormPolzovatel
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
            System.Windows.Forms.Label iD_покупателяLabel;
            System.Windows.Forms.Label фамилияLabel;
            System.Windows.Forms.Label имяLabel;
            System.Windows.Forms.Label отчествоLabel;
            System.Windows.Forms.Label номер_телефонаLabel;
            System.Windows.Forms.Label адресLabel;
            System.Windows.Forms.Label номер_картыLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPolzovatel));
            this.электронныйМагазинDataSet = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSet();
            this.покупательBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.покупательTableAdapter = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.ПокупательTableAdapter();
            this.tableAdapterManager = new Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager();
            this.покупательBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.покупательBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_покупателяTextBox = new System.Windows.Forms.TextBox();
            this.фамилияTextBox = new System.Windows.Forms.TextBox();
            this.имяTextBox = new System.Windows.Forms.TextBox();
            this.отчествоTextBox = new System.Windows.Forms.TextBox();
            this.номер_телефонаTextBox = new System.Windows.Forms.TextBox();
            this.адресTextBox = new System.Windows.Forms.TextBox();
            this.номер_картыTextBox = new System.Windows.Forms.TextBox();
            iD_покупателяLabel = new System.Windows.Forms.Label();
            фамилияLabel = new System.Windows.Forms.Label();
            имяLabel = new System.Windows.Forms.Label();
            отчествоLabel = new System.Windows.Forms.Label();
            номер_телефонаLabel = new System.Windows.Forms.Label();
            адресLabel = new System.Windows.Forms.Label();
            номер_картыLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingNavigator)).BeginInit();
            this.покупательBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // iD_покупателяLabel
            // 
            iD_покупателяLabel.AutoSize = true;
            iD_покупателяLabel.Location = new System.Drawing.Point(21, 47);
            iD_покупателяLabel.Name = "iD_покупателяLabel";
            iD_покупателяLabel.Size = new System.Drawing.Size(122, 20);
            iD_покупателяLabel.TabIndex = 1;
            iD_покупателяLabel.Text = "ID покупателя:";
            // 
            // фамилияLabel
            // 
            фамилияLabel.AutoSize = true;
            фамилияLabel.Location = new System.Drawing.Point(21, 79);
            фамилияLabel.Name = "фамилияLabel";
            фамилияLabel.Size = new System.Drawing.Size(85, 20);
            фамилияLabel.TabIndex = 3;
            фамилияLabel.Text = "Фамилия:";
            // 
            // имяLabel
            // 
            имяLabel.AutoSize = true;
            имяLabel.Location = new System.Drawing.Point(21, 111);
            имяLabel.Name = "имяLabel";
            имяLabel.Size = new System.Drawing.Size(44, 20);
            имяLabel.TabIndex = 5;
            имяLabel.Text = "Имя:";
            // 
            // отчествоLabel
            // 
            отчествоLabel.AutoSize = true;
            отчествоLabel.Location = new System.Drawing.Point(21, 143);
            отчествоLabel.Name = "отчествоLabel";
            отчествоLabel.Size = new System.Drawing.Size(87, 20);
            отчествоLabel.TabIndex = 7;
            отчествоLabel.Text = "Отчество:";
            // 
            // номер_телефонаLabel
            // 
            номер_телефонаLabel.AutoSize = true;
            номер_телефонаLabel.Location = new System.Drawing.Point(21, 175);
            номер_телефонаLabel.Name = "номер_телефонаLabel";
            номер_телефонаLabel.Size = new System.Drawing.Size(146, 20);
            номер_телефонаLabel.TabIndex = 9;
            номер_телефонаLabel.Text = "Номер телефона:";
            // 
            // адресLabel
            // 
            адресLabel.AutoSize = true;
            адресLabel.Location = new System.Drawing.Point(21, 207);
            адресLabel.Name = "адресLabel";
            адресLabel.Size = new System.Drawing.Size(61, 20);
            адресLabel.TabIndex = 11;
            адресLabel.Text = "Адрес:";
            // 
            // номер_картыLabel
            // 
            номер_картыLabel.AutoSize = true;
            номер_картыLabel.Location = new System.Drawing.Point(21, 239);
            номер_картыLabel.Name = "номер_картыLabel";
            номер_картыLabel.Size = new System.Drawing.Size(113, 20);
            номер_картыLabel.TabIndex = 13;
            номер_картыLabel.Text = "Номер карты:";
            // 
            // электронныйМагазинDataSet
            // 
            this.электронныйМагазинDataSet.DataSetName = "ЭлектронныйМагазинDataSet";
            this.электронныйМагазинDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Приложение_для_БД_ЭлектронныйМагазин.ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = null;
            this.tableAdapterManager.ИнформацияЗаказаTableAdapter = null;
            this.tableAdapterManager.ОтзывTableAdapter = null;
            this.tableAdapterManager.ПокупательTableAdapter = this.покупательTableAdapter;
            this.tableAdapterManager.ТоварTableAdapter = null;
            // 
            // покупательBindingNavigator
            // 
            this.покупательBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.покупательBindingNavigator.BindingSource = this.покупательBindingSource;
            this.покупательBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.покупательBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.покупательBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.покупательBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.покупательBindingNavigatorSaveItem});
            this.покупательBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.покупательBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.покупательBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.покупательBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.покупательBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.покупательBindingNavigator.Name = "покупательBindingNavigator";
            this.покупательBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.покупательBindingNavigator.Size = new System.Drawing.Size(800, 38);
            this.покупательBindingNavigator.TabIndex = 0;
            this.покупательBindingNavigator.Text = "bindingNavigator1";
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
            // покупательBindingNavigatorSaveItem
            // 
            this.покупательBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.покупательBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("покупательBindingNavigatorSaveItem.Image")));
            this.покупательBindingNavigatorSaveItem.Name = "покупательBindingNavigatorSaveItem";
            this.покупательBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 33);
            this.покупательBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.покупательBindingNavigatorSaveItem.Click += new System.EventHandler(this.покупательBindingNavigatorSaveItem_Click);
            // 
            // iD_покупателяTextBox
            // 
            this.iD_покупателяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "ID_покупателя", true));
            this.iD_покупателяTextBox.Location = new System.Drawing.Point(173, 44);
            this.iD_покупателяTextBox.Name = "iD_покупателяTextBox";
            this.iD_покупателяTextBox.Size = new System.Drawing.Size(600, 26);
            this.iD_покупателяTextBox.TabIndex = 2;
            // 
            // фамилияTextBox
            // 
            this.фамилияTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Фамилия", true));
            this.фамилияTextBox.Location = new System.Drawing.Point(173, 76);
            this.фамилияTextBox.Name = "фамилияTextBox";
            this.фамилияTextBox.Size = new System.Drawing.Size(600, 26);
            this.фамилияTextBox.TabIndex = 4;
            // 
            // имяTextBox
            // 
            this.имяTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Имя", true));
            this.имяTextBox.Location = new System.Drawing.Point(173, 108);
            this.имяTextBox.Name = "имяTextBox";
            this.имяTextBox.Size = new System.Drawing.Size(600, 26);
            this.имяTextBox.TabIndex = 6;
            // 
            // отчествоTextBox
            // 
            this.отчествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Отчество", true));
            this.отчествоTextBox.Location = new System.Drawing.Point(173, 140);
            this.отчествоTextBox.Name = "отчествоTextBox";
            this.отчествоTextBox.Size = new System.Drawing.Size(600, 26);
            this.отчествоTextBox.TabIndex = 8;
            // 
            // номер_телефонаTextBox
            // 
            this.номер_телефонаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Номер телефона", true));
            this.номер_телефонаTextBox.Location = new System.Drawing.Point(173, 172);
            this.номер_телефонаTextBox.Name = "номер_телефонаTextBox";
            this.номер_телефонаTextBox.Size = new System.Drawing.Size(600, 26);
            this.номер_телефонаTextBox.TabIndex = 10;
            // 
            // адресTextBox
            // 
            this.адресTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Адрес", true));
            this.адресTextBox.Location = new System.Drawing.Point(173, 204);
            this.адресTextBox.Name = "адресTextBox";
            this.адресTextBox.Size = new System.Drawing.Size(600, 26);
            this.адресTextBox.TabIndex = 12;
            // 
            // номер_картыTextBox
            // 
            this.номер_картыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.покупательBindingSource, "Номер карты", true));
            this.номер_картыTextBox.Location = new System.Drawing.Point(173, 236);
            this.номер_картыTextBox.Name = "номер_картыTextBox";
            this.номер_картыTextBox.Size = new System.Drawing.Size(600, 26);
            this.номер_картыTextBox.TabIndex = 14;
            // 
            // FormPolzovatel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(iD_покупателяLabel);
            this.Controls.Add(this.iD_покупателяTextBox);
            this.Controls.Add(фамилияLabel);
            this.Controls.Add(this.фамилияTextBox);
            this.Controls.Add(имяLabel);
            this.Controls.Add(this.имяTextBox);
            this.Controls.Add(отчествоLabel);
            this.Controls.Add(this.отчествоTextBox);
            this.Controls.Add(номер_телефонаLabel);
            this.Controls.Add(this.номер_телефонаTextBox);
            this.Controls.Add(адресLabel);
            this.Controls.Add(this.адресTextBox);
            this.Controls.Add(номер_картыLabel);
            this.Controls.Add(this.номер_картыTextBox);
            this.Controls.Add(this.покупательBindingNavigator);
            this.Name = "FormPolzovatel";
            this.Text = "Пользователи";
            this.Load += new System.EventHandler(this.FormPolzovatel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.электронныйМагазинDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.покупательBindingNavigator)).EndInit();
            this.покупательBindingNavigator.ResumeLayout(false);
            this.покупательBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ЭлектронныйМагазинDataSet электронныйМагазинDataSet;
        private System.Windows.Forms.BindingSource покупательBindingSource;
        private ЭлектронныйМагазинDataSetTableAdapters.ПокупательTableAdapter покупательTableAdapter;
        private ЭлектронныйМагазинDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator покупательBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton покупательBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_покупателяTextBox;
        private System.Windows.Forms.TextBox фамилияTextBox;
        private System.Windows.Forms.TextBox имяTextBox;
        private System.Windows.Forms.TextBox отчествоTextBox;
        private System.Windows.Forms.TextBox номер_телефонаTextBox;
        private System.Windows.Forms.TextBox адресTextBox;
        private System.Windows.Forms.TextBox номер_картыTextBox;
    }
}