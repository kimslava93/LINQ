namespace LINQ_test
{
    partial class TablesManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelTables = new System.Windows.Forms.Label();
            this.dataGridViewConsolesList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxState = new System.Windows.Forms.ComboBox();
            this.dataGridViewPriceList = new System.Windows.Forms.DataGridView();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.dateTimePickerOrder = new System.Windows.Forms.DateTimePicker();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelCurrentState = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonApplyChanges = new System.Windows.Forms.Button();
            this.buttonCreateNewConsole = new System.Windows.Forms.Button();
            this.buttonDeleteConsole = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolesList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTables
            // 
            this.labelTables.AutoSize = true;
            this.labelTables.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTables.Location = new System.Drawing.Point(58, 86);
            this.labelTables.Name = "labelTables";
            this.labelTables.Size = new System.Drawing.Size(83, 20);
            this.labelTables.TabIndex = 1;
            this.labelTables.Text = "Consoles";
            // 
            // dataGridViewConsolesList
            // 
            this.dataGridViewConsolesList.AllowUserToAddRows = false;
            this.dataGridViewConsolesList.AllowUserToDeleteRows = false;
            this.dataGridViewConsolesList.AllowUserToResizeColumns = false;
            this.dataGridViewConsolesList.AllowUserToResizeRows = false;
            this.dataGridViewConsolesList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewConsolesList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewConsolesList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewConsolesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsolesList.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewConsolesList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewConsolesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewConsolesList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewConsolesList.Location = new System.Drawing.Point(12, 109);
            this.dataGridViewConsolesList.MultiSelect = false;
            this.dataGridViewConsolesList.Name = "dataGridViewConsolesList";
            this.dataGridViewConsolesList.ReadOnly = true;
            this.dataGridViewConsolesList.RowHeadersVisible = false;
            this.dataGridViewConsolesList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewConsolesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewConsolesList.Size = new System.Drawing.Size(191, 296);
            this.dataGridViewConsolesList.TabIndex = 0;
            this.dataGridViewConsolesList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsolesList_CellClick);
            this.dataGridViewConsolesList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewConsolesList_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxState);
            this.groupBox1.Controls.Add(this.dataGridViewPriceList);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.dateTimePickerOrder);
            this.groupBox1.Controls.Add(this.labelOrder);
            this.groupBox1.Controls.Add(this.labelCurrentState);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Location = new System.Drawing.Point(237, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 281);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info about console point";
            // 
            // comboBoxState
            // 
            this.comboBoxState.FormattingEnabled = true;
            this.comboBoxState.Items.AddRange(new object[] {
            "free",
            "busy",
            "unknown"});
            this.comboBoxState.Location = new System.Drawing.Point(94, 51);
            this.comboBoxState.Name = "comboBoxState";
            this.comboBoxState.Size = new System.Drawing.Size(142, 21);
            this.comboBoxState.TabIndex = 3;
            // 
            // dataGridViewPriceList
            // 
            this.dataGridViewPriceList.AllowUserToAddRows = false;
            this.dataGridViewPriceList.AllowUserToDeleteRows = false;
            this.dataGridViewPriceList.AllowUserToResizeColumns = false;
            this.dataGridViewPriceList.AllowUserToResizeRows = false;
            this.dataGridViewPriceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPriceList.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewPriceList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewPriceList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPriceList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewPriceList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPriceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewPriceList.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewPriceList.Location = new System.Drawing.Point(3, 99);
            this.dataGridViewPriceList.MultiSelect = false;
            this.dataGridViewPriceList.Name = "dataGridViewPriceList";
            this.dataGridViewPriceList.ReadOnly = true;
            this.dataGridViewPriceList.RowHeadersVisible = false;
            this.dataGridViewPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPriceList.Size = new System.Drawing.Size(247, 179);
            this.dataGridViewPriceList.TabIndex = 4;
            // 
            // textBoxName
            // 
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Location = new System.Drawing.Point(94, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 13);
            this.textBoxName.TabIndex = 3;
            // 
            // dateTimePickerOrder
            // 
            this.dateTimePickerOrder.Location = new System.Drawing.Point(94, 78);
            this.dateTimePickerOrder.Name = "dateTimePickerOrder";
            this.dateTimePickerOrder.Size = new System.Drawing.Size(142, 20);
            this.dateTimePickerOrder.TabIndex = 2;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(20, 84);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(33, 13);
            this.labelOrder.TabIndex = 1;
            this.labelOrder.Text = "Order";
            // 
            // labelCurrentState
            // 
            this.labelCurrentState.AutoSize = true;
            this.labelCurrentState.Location = new System.Drawing.Point(18, 54);
            this.labelCurrentState.Name = "labelCurrentState";
            this.labelCurrentState.Size = new System.Drawing.Size(70, 13);
            this.labelCurrentState.TabIndex = 0;
            this.labelCurrentState.Text = "Currrent state";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(18, 28);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // buttonApplyChanges
            // 
            this.buttonApplyChanges.Location = new System.Drawing.Point(237, 382);
            this.buttonApplyChanges.Name = "buttonApplyChanges";
            this.buttonApplyChanges.Size = new System.Drawing.Size(253, 23);
            this.buttonApplyChanges.TabIndex = 4;
            this.buttonApplyChanges.Text = "Apply changes";
            this.buttonApplyChanges.UseVisualStyleBackColor = true;
            // 
            // buttonCreateNewConsole
            // 
            this.buttonCreateNewConsole.Location = new System.Drawing.Point(189, 24);
            this.buttonCreateNewConsole.Name = "buttonCreateNewConsole";
            this.buttonCreateNewConsole.Size = new System.Drawing.Size(118, 23);
            this.buttonCreateNewConsole.TabIndex = 5;
            this.buttonCreateNewConsole.Text = "Create New Console";
            this.buttonCreateNewConsole.UseVisualStyleBackColor = true;
            this.buttonCreateNewConsole.Click += new System.EventHandler(this.buttonCreateNewConsole_Click);
            // 
            // buttonDeleteConsole
            // 
            this.buttonDeleteConsole.Location = new System.Drawing.Point(189, 72);
            this.buttonDeleteConsole.Name = "buttonDeleteConsole";
            this.buttonDeleteConsole.Size = new System.Drawing.Size(118, 23);
            this.buttonDeleteConsole.TabIndex = 6;
            this.buttonDeleteConsole.Text = "Delete Console";
            this.buttonDeleteConsole.UseVisualStyleBackColor = true;
            this.buttonDeleteConsole.Click += new System.EventHandler(this.buttonDeleteConsole_Click);
            // 
            // TablesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 438);
            this.Controls.Add(this.buttonDeleteConsole);
            this.Controls.Add(this.buttonCreateNewConsole);
            this.Controls.Add(this.buttonApplyChanges);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTables);
            this.Controls.Add(this.dataGridViewConsolesList);
            this.Name = "TablesManager";
            this.Text = "Tables Manager";
            this.Load += new System.EventHandler(this.TablesManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsolesList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriceList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTables;
        private System.Windows.Forms.DataGridView dataGridViewConsolesList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCurrentState;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrder;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.DataGridView dataGridViewPriceList;
        private System.Windows.Forms.ComboBox comboBoxState;
        private System.Windows.Forms.Button buttonApplyChanges;
        private System.Windows.Forms.Button buttonCreateNewConsole;
        private System.Windows.Forms.Button buttonDeleteConsole;

    }
}