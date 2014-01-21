namespace LINQ_test
{
    partial class TimezoneRedactor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ButtonChangePrices = new System.Windows.Forms.Button();
            this.datagridViewPriceList = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboBoxTimeZOne = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddNewTimezoneButton = new System.Windows.Forms.Button();
            this.textBoxTimeZoneName = new System.Windows.Forms.TextBox();
            this.start_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.end_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DeleteRecordButtton = new System.Windows.Forms.Button();
            this.timeZones_datagridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPriceList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeZones_datagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DeleteRecordButtton);
            this.splitContainer1.Panel2.Controls.Add(this.timeZones_datagridView);
            this.splitContainer1.Size = new System.Drawing.Size(653, 461);
            this.splitContainer1.SplitterDistance = 213;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ButtonChangePrices);
            this.groupBox2.Controls.Add(this.datagridViewPriceList);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboBoxTimeZOne);
            this.groupBox2.Location = new System.Drawing.Point(315, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 198);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Playstations price";
            // 
            // ButtonChangePrices
            // 
            this.ButtonChangePrices.Location = new System.Drawing.Point(227, 14);
            this.ButtonChangePrices.Name = "ButtonChangePrices";
            this.ButtonChangePrices.Size = new System.Drawing.Size(93, 34);
            this.ButtonChangePrices.TabIndex = 7;
            this.ButtonChangePrices.Text = "Change timezone prices";
            this.ButtonChangePrices.UseVisualStyleBackColor = true;
            this.ButtonChangePrices.Click += new System.EventHandler(this.ButtonChangePrices_Click);
            // 
            // datagridViewPriceList
            // 
            this.datagridViewPriceList.AllowUserToAddRows = false;
            this.datagridViewPriceList.AllowUserToDeleteRows = false;
            this.datagridViewPriceList.AllowUserToResizeColumns = false;
            this.datagridViewPriceList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.NullValue = "0";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPriceList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridViewPriceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridViewPriceList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.datagridViewPriceList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.datagridViewPriceList.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridViewPriceList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridViewPriceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridViewPriceList.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridViewPriceList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridViewPriceList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridViewPriceList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datagridViewPriceList.Location = new System.Drawing.Point(3, 59);
            this.datagridViewPriceList.Name = "datagridViewPriceList";
            this.datagridViewPriceList.RowHeadersVisible = false;
            this.datagridViewPriceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridViewPriceList.Size = new System.Drawing.Size(320, 136);
            this.datagridViewPriceList.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TimeZone name";
            // 
            // ComboBoxTimeZOne
            // 
            this.ComboBoxTimeZOne.FormattingEnabled = true;
            this.ComboBoxTimeZOne.Location = new System.Drawing.Point(91, 21);
            this.ComboBoxTimeZOne.Name = "ComboBoxTimeZOne";
            this.ComboBoxTimeZOne.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxTimeZOne.TabIndex = 5;
            this.ComboBoxTimeZOne.SelectedIndexChanged += new System.EventHandler(this.playstationsComboBox_SelectedIndexChanged);
            this.ComboBoxTimeZOne.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddNewTimezoneButton);
            this.groupBox1.Controls.Add(this.textBoxTimeZoneName);
            this.groupBox1.Controls.Add(this.start_datetimepicker);
            this.groupBox1.Controls.Add(this.end_dateTimePicker);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 195);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timezone Create";
            // 
            // AddNewTimezoneButton
            // 
            this.AddNewTimezoneButton.Location = new System.Drawing.Point(109, 142);
            this.AddNewTimezoneButton.Name = "AddNewTimezoneButton";
            this.AddNewTimezoneButton.Size = new System.Drawing.Size(75, 23);
            this.AddNewTimezoneButton.TabIndex = 4;
            this.AddNewTimezoneButton.Text = "Add";
            this.AddNewTimezoneButton.UseVisualStyleBackColor = true;
            this.AddNewTimezoneButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxTimeZoneName
            // 
            this.textBoxTimeZoneName.Location = new System.Drawing.Point(151, 22);
            this.textBoxTimeZoneName.Name = "textBoxTimeZoneName";
            this.textBoxTimeZoneName.Size = new System.Drawing.Size(119, 20);
            this.textBoxTimeZoneName.TabIndex = 1;
            // 
            // start_datetimepicker
            // 
            this.start_datetimepicker.CustomFormat = "HH:00";
            this.start_datetimepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_datetimepicker.Location = new System.Drawing.Point(151, 53);
            this.start_datetimepicker.Name = "start_datetimepicker";
            this.start_datetimepicker.ShowUpDown = true;
            this.start_datetimepicker.Size = new System.Drawing.Size(68, 20);
            this.start_datetimepicker.TabIndex = 2;
            // 
            // end_dateTimePicker
            // 
            this.end_dateTimePicker.CustomFormat = "HH:00";
            this.end_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_dateTimePicker.Location = new System.Drawing.Point(151, 89);
            this.end_dateTimePicker.Name = "end_dateTimePicker";
            this.end_dateTimePicker.ShowUpDown = true;
            this.end_dateTimePicker.Size = new System.Drawing.Size(68, 20);
            this.end_dateTimePicker.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "TimeZone end time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "TimeZone start time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TimeZone start time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TimeZone name";
            // 
            // DeleteRecordButtton
            // 
            this.DeleteRecordButtton.Location = new System.Drawing.Point(22, 18);
            this.DeleteRecordButtton.Name = "DeleteRecordButtton";
            this.DeleteRecordButtton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRecordButtton.TabIndex = 8;
            this.DeleteRecordButtton.Text = "Delete";
            this.DeleteRecordButtton.UseVisualStyleBackColor = true;
            this.DeleteRecordButtton.Click += new System.EventHandler(this.button2_Click);
            // 
            // timeZones_datagridView
            // 
            this.timeZones_datagridView.AllowUserToAddRows = false;
            this.timeZones_datagridView.AllowUserToDeleteRows = false;
            this.timeZones_datagridView.AllowUserToResizeColumns = false;
            this.timeZones_datagridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.timeZones_datagridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.timeZones_datagridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.timeZones_datagridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.timeZones_datagridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.timeZones_datagridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.timeZones_datagridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.timeZones_datagridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.timeZones_datagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.timeZones_datagridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.timeZones_datagridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.timeZones_datagridView.Location = new System.Drawing.Point(0, 56);
            this.timeZones_datagridView.Name = "timeZones_datagridView";
            this.timeZones_datagridView.RowHeadersVisible = false;
            this.timeZones_datagridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeZones_datagridView.Size = new System.Drawing.Size(653, 188);
            this.timeZones_datagridView.TabIndex = 7;
            // 
            // TimezoneRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 461);
            this.Controls.Add(this.splitContainer1);
            this.Name = "TimezoneRedactor";
            this.Text = "TimezoneRedactor";
            this.Load += new System.EventHandler(this.TimezoneRedactor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridViewPriceList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeZones_datagridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView timeZones_datagridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button AddNewTimezoneButton;
        private System.Windows.Forms.TextBox textBoxTimeZoneName;
        private System.Windows.Forms.DateTimePicker start_datetimepicker;
        private System.Windows.Forms.DateTimePicker end_dateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView datagridViewPriceList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxTimeZOne;
        private System.Windows.Forms.Button DeleteRecordButtton;
        private System.Windows.Forms.Button ButtonChangePrices;
    }
}