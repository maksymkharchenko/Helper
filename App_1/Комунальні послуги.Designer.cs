namespace App_1
{
    partial class Комунальні_послуги
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
            System.Windows.Forms.Label назва_послугиLabel;
            System.Windows.Forms.Label цінаLabel;
            System.Windows.Forms.Label сплатити_доLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Комунальні_послуги));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.database1DataSet = new App_1.Database1DataSet();
            this.listOfServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listOfServicesTableAdapter = new App_1.Database1DataSetTableAdapters.ListOfServicesTableAdapter();
            this.tableAdapterManager = new App_1.Database1DataSetTableAdapters.TableAdapterManager();
            this.listOfServicesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.назва_послугиTextBox = new System.Windows.Forms.TextBox();
            this.цінаTextBox = new System.Windows.Forms.TextBox();
            this.сплатити_доDateTimePicker = new System.Windows.Forms.DateTimePicker();
            назва_послугиLabel = new System.Windows.Forms.Label();
            цінаLabel = new System.Windows.Forms.Label();
            сплатити_доLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServicesBindingNavigator)).BeginInit();
            this.listOfServicesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // назва_послугиLabel
            // 
            назва_послугиLabel.AutoSize = true;
            назва_послугиLabel.Location = new System.Drawing.Point(9, 38);
            назва_послугиLabel.Name = "назва_послугиLabel";
            назва_послугиLabel.Size = new System.Drawing.Size(85, 13);
            назва_послугиLabel.TabIndex = 13;
            назва_послугиLabel.Text = "Назва послуги:";
            // 
            // цінаLabel
            // 
            цінаLabel.AutoSize = true;
            цінаLabel.Location = new System.Drawing.Point(9, 64);
            цінаLabel.Name = "цінаLabel";
            цінаLabel.Size = new System.Drawing.Size(32, 13);
            цінаLabel.TabIndex = 15;
            цінаLabel.Text = "Ціна:";
            // 
            // сплатити_доLabel
            // 
            сплатити_доLabel.AutoSize = true;
            сплатити_доLabel.Location = new System.Drawing.Point(9, 91);
            сплатити_доLabel.Name = "сплатити_доLabel";
            сплатити_доLabel.Size = new System.Drawing.Size(72, 13);
            сплатити_доLabel.TabIndex = 17;
            сплатити_доLabel.Text = "Сплатити до:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Оплатити";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 142);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Меню";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listOfServicesBindingSource
            // 
            this.listOfServicesBindingSource.DataMember = "ListOfServices";
            this.listOfServicesBindingSource.DataSource = this.database1DataSet;
            // 
            // listOfServicesTableAdapter
            // 
            this.listOfServicesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ListOfServicesTableAdapter = this.listOfServicesTableAdapter;
            this.tableAdapterManager.UpdateOrder = App_1.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // listOfServicesBindingNavigator
            // 
            this.listOfServicesBindingNavigator.AddNewItem = null;
            this.listOfServicesBindingNavigator.BindingSource = this.listOfServicesBindingSource;
            this.listOfServicesBindingNavigator.CountItem = null;
            this.listOfServicesBindingNavigator.DeleteItem = null;
            this.listOfServicesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorMoveNextItem});
            this.listOfServicesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.listOfServicesBindingNavigator.MoveFirstItem = null;
            this.listOfServicesBindingNavigator.MoveLastItem = null;
            this.listOfServicesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.listOfServicesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.listOfServicesBindingNavigator.Name = "listOfServicesBindingNavigator";
            this.listOfServicesBindingNavigator.PositionItem = null;
            this.listOfServicesBindingNavigator.Size = new System.Drawing.Size(359, 25);
            this.listOfServicesBindingNavigator.TabIndex = 13;
            this.listOfServicesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // назва_послугиTextBox
            // 
            this.назва_послугиTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfServicesBindingSource, "Назва послуги", true));
            this.назва_послугиTextBox.Enabled = false;
            this.назва_послугиTextBox.Location = new System.Drawing.Point(100, 35);
            this.назва_послугиTextBox.Name = "назва_послугиTextBox";
            this.назва_послугиTextBox.ReadOnly = true;
            this.назва_послугиTextBox.Size = new System.Drawing.Size(200, 20);
            this.назва_послугиTextBox.TabIndex = 14;
            // 
            // цінаTextBox
            // 
            this.цінаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listOfServicesBindingSource, "Ціна", true));
            this.цінаTextBox.Enabled = false;
            this.цінаTextBox.Location = new System.Drawing.Point(100, 61);
            this.цінаTextBox.Name = "цінаTextBox";
            this.цінаTextBox.ReadOnly = true;
            this.цінаTextBox.Size = new System.Drawing.Size(200, 20);
            this.цінаTextBox.TabIndex = 16;
            // 
            // сплатити_доDateTimePicker
            // 
            this.сплатити_доDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listOfServicesBindingSource, "Сплатити до", true));
            this.сплатити_доDateTimePicker.Enabled = false;
            this.сплатити_доDateTimePicker.Location = new System.Drawing.Point(100, 87);
            this.сплатити_доDateTimePicker.Name = "сплатити_доDateTimePicker";
            this.сплатити_доDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.сплатити_доDateTimePicker.TabIndex = 18;
            // 
            // Комунальні_послуги
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(359, 193);
            this.Controls.Add(назва_послугиLabel);
            this.Controls.Add(this.назва_послугиTextBox);
            this.Controls.Add(цінаLabel);
            this.Controls.Add(this.цінаTextBox);
            this.Controls.Add(сплатити_доLabel);
            this.Controls.Add(this.сплатити_доDateTimePicker);
            this.Controls.Add(this.listOfServicesBindingNavigator);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Комунальні_послуги";
            this.Text = "Комунальні послуги";
            this.Load += new System.EventHandler(this.Комунальні_послуги_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listOfServicesBindingNavigator)).EndInit();
            this.listOfServicesBindingNavigator.ResumeLayout(false);
            this.listOfServicesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource listOfServicesBindingSource;
        private Database1DataSetTableAdapters.ListOfServicesTableAdapter listOfServicesTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator listOfServicesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.TextBox назва_послугиTextBox;
        private System.Windows.Forms.TextBox цінаTextBox;
        private System.Windows.Forms.DateTimePicker сплатити_доDateTimePicker;
    }
}