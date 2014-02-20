namespace LINQ_test
{
    partial class CreateNewConsolePoint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonCreateNewConsolePoint = new System.Windows.Forms.Button();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTimezones = new System.Windows.Forms.Label();
            this.textBoxNameOfNewConsole = new System.Windows.Forms.TextBox();
            this.labelNewName = new System.Windows.Forms.Label();
            this.buttonCreateConsoleName = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateNewConsolePoint
            // 
            this.buttonCreateNewConsolePoint.Location = new System.Drawing.Point(123, 258);
            this.buttonCreateNewConsolePoint.Name = "buttonCreateNewConsolePoint";
            this.buttonCreateNewConsolePoint.Size = new System.Drawing.Size(118, 23);
            this.buttonCreateNewConsolePoint.TabIndex = 13;
            this.buttonCreateNewConsolePoint.Text = "Create";
            this.buttonCreateNewConsolePoint.UseVisualStyleBackColor = true;
            this.buttonCreateNewConsolePoint.Click += new System.EventHandler(this.buttonCreateNewConsolePoint_Click);
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.DecimalPlaces = 2;
            this.numericUpDownPrice.Location = new System.Drawing.Point(184, 108);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownPrice.TabIndex = 12;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Price for timezone";
            // 
            // labelTimezones
            // 
            this.labelTimezones.AutoSize = true;
            this.labelTimezones.Location = new System.Drawing.Point(25, 89);
            this.labelTimezones.Name = "labelTimezones";
            this.labelTimezones.Size = new System.Drawing.Size(97, 13);
            this.labelTimezones.TabIndex = 10;
            this.labelTimezones.Text = "TimezonesMyClass";
            // 
            // textBoxNameOfNewConsole
            // 
            this.textBoxNameOfNewConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNameOfNewConsole.Location = new System.Drawing.Point(113, 31);
            this.textBoxNameOfNewConsole.Name = "textBoxNameOfNewConsole";
            this.textBoxNameOfNewConsole.Size = new System.Drawing.Size(84, 20);
            this.textBoxNameOfNewConsole.TabIndex = 8;
            // 
            // labelNewName
            // 
            this.labelNewName.AutoSize = true;
            this.labelNewName.Location = new System.Drawing.Point(57, 33);
            this.labelNewName.Name = "labelNewName";
            this.labelNewName.Size = new System.Drawing.Size(35, 13);
            this.labelNewName.TabIndex = 7;
            this.labelNewName.Text = "Name";
            // 
            // buttonCreateConsoleName
            // 
            this.buttonCreateConsoleName.Location = new System.Drawing.Point(214, 29);
            this.buttonCreateConsoleName.Name = "buttonCreateConsoleName";
            this.buttonCreateConsoleName.Size = new System.Drawing.Size(75, 23);
            this.buttonCreateConsoleName.TabIndex = 14;
            this.buttonCreateConsoleName.Text = "Create";
            this.buttonCreateConsoleName.UseVisualStyleBackColor = true;
            this.buttonCreateConsoleName.Click += new System.EventHandler(this.buttonCreateConsoleName_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Wheat;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(28, 108);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(139, 132);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CreateNewConsolePoint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 69);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonCreateConsoleName);
            this.Controls.Add(this.buttonCreateNewConsolePoint);
            this.Controls.Add(this.numericUpDownPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTimezones);
            this.Controls.Add(this.textBoxNameOfNewConsole);
            this.Controls.Add(this.labelNewName);
            this.Name = "CreateNewConsolePoint";
            this.Text = "CreateNewConsolePoint";
            this.Load += new System.EventHandler(this.CreateNewConsolePoint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreateNewConsolePoint;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTimezones;
        private System.Windows.Forms.TextBox textBoxNameOfNewConsole;
        private System.Windows.Forms.Label labelNewName;
        private System.Windows.Forms.Button buttonCreateConsoleName;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}