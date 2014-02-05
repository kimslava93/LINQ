namespace LINQ_test
{
    partial class AddNewDiscountForm
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
            this.comboBoxAuditory = new System.Windows.Forms.ComboBox();
            this.labelAuditory = new System.Windows.Forms.Label();
            this.groupBoxRequirments = new System.Windows.Forms.GroupBox();
            this.checkBoxRequiredHours = new System.Windows.Forms.CheckBox();
            this.checkBoxRequiredItem = new System.Windows.Forms.CheckBox();
            this.numericUpDownRequiredPaidMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRequiredPaidHours = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRequiredNumberOfItem = new System.Windows.Forms.NumericUpDown();
            this.labelRequiredPaidTime = new System.Windows.Forms.Label();
            this.labelRequiredItem = new System.Windows.Forms.Label();
            this.comboBoxRequiredItem = new System.Windows.Forms.ComboBox();
            this.labelRequiredNumber = new System.Windows.Forms.Label();
            this.groupBoxPercentage = new System.Windows.Forms.GroupBox();
            this.numericUpDownDiscountSize = new System.Windows.Forms.NumericUpDown();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAddDiscount = new System.Windows.Forms.Button();
            this.checkedListBoxTimeZones = new System.Windows.Forms.CheckedListBox();
            this.labelTimeZones = new System.Windows.Forms.Label();
            this.buttonAddPlaystations = new System.Windows.Forms.Button();
            this.textBoxPlaystations = new System.Windows.Forms.TextBox();
            this.labelDiscountPLaystations = new System.Windows.Forms.Label();
            this.textBoxDiscountName = new System.Windows.Forms.TextBox();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelDiscountName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBonusType = new System.Windows.Forms.RadioButton();
            this.radioButtonPercentage = new System.Windows.Forms.RadioButton();
            this.groupBoxBonus = new System.Windows.Forms.GroupBox();
            this.checkBoxPriceDiscount = new System.Windows.Forms.CheckBox();
            this.numericUpDownPriceDiscount = new System.Windows.Forms.NumericUpDown();
            this.labelPriceDiscount = new System.Windows.Forms.Label();
            this.checkBoxBonusHours = new System.Windows.Forms.CheckBox();
            this.checkBoxBonusItem = new System.Windows.Forms.CheckBox();
            this.comboBoxBonusItem = new System.Windows.Forms.ComboBox();
            this.numericUpDownBonusMinutes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNumberOfBonusItem = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBonusHours = new System.Windows.Forms.NumericUpDown();
            this.labelNumberOfBonusItem = new System.Windows.Forms.Label();
            this.labelBonusItem = new System.Windows.Forms.Label();
            this.labelBonusTime = new System.Windows.Forms.Label();
            this.groupBoxRequirments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredPaidMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredPaidHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredNumberOfItem)).BeginInit();
            this.groupBoxPercentage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBoxBonus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonusMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfBonusItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonusHours)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxAuditory
            // 
            this.comboBoxAuditory.FormattingEnabled = true;
            this.comboBoxAuditory.Items.AddRange(new object[] {
            "With discout cards only",
            "Usual clients",
            "Both with and without discount cards"});
            this.comboBoxAuditory.Location = new System.Drawing.Point(110, 192);
            this.comboBoxAuditory.Name = "comboBoxAuditory";
            this.comboBoxAuditory.Size = new System.Drawing.Size(230, 21);
            this.comboBoxAuditory.TabIndex = 45;
            // 
            // labelAuditory
            // 
            this.labelAuditory.AutoSize = true;
            this.labelAuditory.Location = new System.Drawing.Point(29, 195);
            this.labelAuditory.Name = "labelAuditory";
            this.labelAuditory.Size = new System.Drawing.Size(45, 13);
            this.labelAuditory.TabIndex = 44;
            this.labelAuditory.Text = "Auditory";
            // 
            // groupBoxRequirments
            // 
            this.groupBoxRequirments.Controls.Add(this.checkBoxRequiredHours);
            this.groupBoxRequirments.Controls.Add(this.checkBoxRequiredItem);
            this.groupBoxRequirments.Controls.Add(this.numericUpDownRequiredPaidMinutes);
            this.groupBoxRequirments.Controls.Add(this.numericUpDownRequiredPaidHours);
            this.groupBoxRequirments.Controls.Add(this.numericUpDownRequiredNumberOfItem);
            this.groupBoxRequirments.Controls.Add(this.labelRequiredPaidTime);
            this.groupBoxRequirments.Controls.Add(this.labelRequiredItem);
            this.groupBoxRequirments.Controls.Add(this.comboBoxRequiredItem);
            this.groupBoxRequirments.Controls.Add(this.labelRequiredNumber);
            this.groupBoxRequirments.Enabled = false;
            this.groupBoxRequirments.Location = new System.Drawing.Point(496, 128);
            this.groupBoxRequirments.Name = "groupBoxRequirments";
            this.groupBoxRequirments.Size = new System.Drawing.Size(272, 170);
            this.groupBoxRequirments.TabIndex = 42;
            this.groupBoxRequirments.TabStop = false;
            this.groupBoxRequirments.Text = "Requirments";
            this.groupBoxRequirments.Visible = false;
            this.groupBoxRequirments.Enter += new System.EventHandler(this.groupBoxRequirments_Enter);
            // 
            // checkBoxRequiredHours
            // 
            this.checkBoxRequiredHours.AutoSize = true;
            this.checkBoxRequiredHours.Checked = true;
            this.checkBoxRequiredHours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxRequiredHours.Location = new System.Drawing.Point(8, 19);
            this.checkBoxRequiredHours.Name = "checkBoxRequiredHours";
            this.checkBoxRequiredHours.Size = new System.Drawing.Size(98, 17);
            this.checkBoxRequiredHours.TabIndex = 48;
            this.checkBoxRequiredHours.Text = "Required hours";
            this.checkBoxRequiredHours.UseVisualStyleBackColor = true;
            this.checkBoxRequiredHours.CheckedChanged += new System.EventHandler(this.checkBoxRequiredHours_CheckedChanged);
            // 
            // checkBoxRequiredItem
            // 
            this.checkBoxRequiredItem.AutoSize = true;
            this.checkBoxRequiredItem.Location = new System.Drawing.Point(8, 41);
            this.checkBoxRequiredItem.Name = "checkBoxRequiredItem";
            this.checkBoxRequiredItem.Size = new System.Drawing.Size(91, 17);
            this.checkBoxRequiredItem.TabIndex = 48;
            this.checkBoxRequiredItem.Text = "Required item";
            this.checkBoxRequiredItem.UseVisualStyleBackColor = true;
            this.checkBoxRequiredItem.CheckedChanged += new System.EventHandler(this.checkBoxRequiredItem_CheckedChanged);
            // 
            // numericUpDownRequiredPaidMinutes
            // 
            this.numericUpDownRequiredPaidMinutes.Location = new System.Drawing.Point(193, 71);
            this.numericUpDownRequiredPaidMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownRequiredPaidMinutes.Name = "numericUpDownRequiredPaidMinutes";
            this.numericUpDownRequiredPaidMinutes.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownRequiredPaidMinutes.TabIndex = 4;
            // 
            // numericUpDownRequiredPaidHours
            // 
            this.numericUpDownRequiredPaidHours.Location = new System.Drawing.Point(121, 71);
            this.numericUpDownRequiredPaidHours.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numericUpDownRequiredPaidHours.Name = "numericUpDownRequiredPaidHours";
            this.numericUpDownRequiredPaidHours.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownRequiredPaidHours.TabIndex = 4;
            // 
            // numericUpDownRequiredNumberOfItem
            // 
            this.numericUpDownRequiredNumberOfItem.Location = new System.Drawing.Point(121, 126);
            this.numericUpDownRequiredNumberOfItem.Name = "numericUpDownRequiredNumberOfItem";
            this.numericUpDownRequiredNumberOfItem.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownRequiredNumberOfItem.TabIndex = 4;
            this.numericUpDownRequiredNumberOfItem.Visible = false;
            // 
            // labelRequiredPaidTime
            // 
            this.labelRequiredPaidTime.AutoSize = true;
            this.labelRequiredPaidTime.Location = new System.Drawing.Point(6, 73);
            this.labelRequiredPaidTime.Name = "labelRequiredPaidTime";
            this.labelRequiredPaidTime.Size = new System.Drawing.Size(94, 13);
            this.labelRequiredPaidTime.TabIndex = 2;
            this.labelRequiredPaidTime.Text = "Paid time (HH:mm)";
            // 
            // labelRequiredItem
            // 
            this.labelRequiredItem.AutoSize = true;
            this.labelRequiredItem.Location = new System.Drawing.Point(6, 100);
            this.labelRequiredItem.Name = "labelRequiredItem";
            this.labelRequiredItem.Size = new System.Drawing.Size(72, 13);
            this.labelRequiredItem.TabIndex = 1;
            this.labelRequiredItem.Text = "Required item";
            this.labelRequiredItem.Visible = false;
            // 
            // comboBoxRequiredItem
            // 
            this.comboBoxRequiredItem.FormattingEnabled = true;
            this.comboBoxRequiredItem.Items.AddRange(new object[] {
            "None ",
            "Coca-Cola 1lt",
            "Hookah ICE"});
            this.comboBoxRequiredItem.Location = new System.Drawing.Point(121, 97);
            this.comboBoxRequiredItem.MaxDropDownItems = 10;
            this.comboBoxRequiredItem.Name = "comboBoxRequiredItem";
            this.comboBoxRequiredItem.Size = new System.Drawing.Size(141, 21);
            this.comboBoxRequiredItem.TabIndex = 3;
            this.comboBoxRequiredItem.Visible = false;
            // 
            // labelRequiredNumber
            // 
            this.labelRequiredNumber.AutoSize = true;
            this.labelRequiredNumber.Location = new System.Drawing.Point(6, 128);
            this.labelRequiredNumber.Name = "labelRequiredNumber";
            this.labelRequiredNumber.Size = new System.Drawing.Size(88, 13);
            this.labelRequiredNumber.TabIndex = 2;
            this.labelRequiredNumber.Text = "Required number";
            this.labelRequiredNumber.Visible = false;
            // 
            // groupBoxPercentage
            // 
            this.groupBoxPercentage.Controls.Add(this.numericUpDownDiscountSize);
            this.groupBoxPercentage.Controls.Add(this.labelDiscount);
            this.groupBoxPercentage.Location = new System.Drawing.Point(496, 50);
            this.groupBoxPercentage.Name = "groupBoxPercentage";
            this.groupBoxPercentage.Size = new System.Drawing.Size(272, 72);
            this.groupBoxPercentage.TabIndex = 41;
            this.groupBoxPercentage.TabStop = false;
            this.groupBoxPercentage.Text = "Percentage";
            this.groupBoxPercentage.Visible = false;
            // 
            // numericUpDownDiscountSize
            // 
            this.numericUpDownDiscountSize.Location = new System.Drawing.Point(135, 29);
            this.numericUpDownDiscountSize.Name = "numericUpDownDiscountSize";
            this.numericUpDownDiscountSize.Size = new System.Drawing.Size(78, 20);
            this.numericUpDownDiscountSize.TabIndex = 18;
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Location = new System.Drawing.Point(61, 32);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(70, 13);
            this.labelDiscount.TabIndex = 19;
            this.labelDiscount.Text = "Discount size";
            // 
            // dateTimePickerEndTime
            // 
            this.dateTimePickerEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(275, 116);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(65, 20);
            this.dateTimePickerEndTime.TabIndex = 38;
            this.dateTimePickerEndTime.Value = new System.DateTime(2014, 1, 24, 0, 0, 0, 0);
            // 
            // dateTimePickerStartTime
            // 
            this.dateTimePickerStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(275, 82);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(65, 20);
            this.dateTimePickerStartTime.TabIndex = 37;
            this.dateTimePickerStartTime.Value = new System.DateTime(2014, 1, 24, 0, 0, 0, 0);
            // 
            // buttonAddDiscount
            // 
            this.buttonAddDiscount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAddDiscount.Location = new System.Drawing.Point(192, 455);
            this.buttonAddDiscount.Name = "buttonAddDiscount";
            this.buttonAddDiscount.Size = new System.Drawing.Size(165, 34);
            this.buttonAddDiscount.TabIndex = 34;
            this.buttonAddDiscount.Text = "Add Discount";
            this.buttonAddDiscount.UseVisualStyleBackColor = true;
            this.buttonAddDiscount.Click += new System.EventHandler(this.buttonAddDiscount_Click);
            // 
            // checkedListBoxTimeZones
            // 
            this.checkedListBoxTimeZones.CheckOnClick = true;
            this.checkedListBoxTimeZones.FormattingEnabled = true;
            this.checkedListBoxTimeZones.Location = new System.Drawing.Point(110, 236);
            this.checkedListBoxTimeZones.Name = "checkedListBoxTimeZones";
            this.checkedListBoxTimeZones.Size = new System.Drawing.Size(165, 49);
            this.checkedListBoxTimeZones.TabIndex = 33;
            // 
            // labelTimeZones
            // 
            this.labelTimeZones.AutoSize = true;
            this.labelTimeZones.Location = new System.Drawing.Point(26, 229);
            this.labelTimeZones.Name = "labelTimeZones";
            this.labelTimeZones.Size = new System.Drawing.Size(63, 13);
            this.labelTimeZones.TabIndex = 36;
            this.labelTimeZones.Text = "Time Zones";
            // 
            // buttonAddPlaystations
            // 
            this.buttonAddPlaystations.Location = new System.Drawing.Point(275, 150);
            this.buttonAddPlaystations.Name = "buttonAddPlaystations";
            this.buttonAddPlaystations.Size = new System.Drawing.Size(65, 25);
            this.buttonAddPlaystations.TabIndex = 32;
            this.buttonAddPlaystations.Text = "Change";
            this.buttonAddPlaystations.UseVisualStyleBackColor = true;
            this.buttonAddPlaystations.Click += new System.EventHandler(this.buttonAddPlaystations_Click);
            // 
            // textBoxPlaystations
            // 
            this.textBoxPlaystations.BackColor = System.Drawing.Color.White;
            this.textBoxPlaystations.Location = new System.Drawing.Point(110, 153);
            this.textBoxPlaystations.Name = "textBoxPlaystations";
            this.textBoxPlaystations.ReadOnly = true;
            this.textBoxPlaystations.Size = new System.Drawing.Size(159, 20);
            this.textBoxPlaystations.TabIndex = 31;
            // 
            // labelDiscountPLaystations
            // 
            this.labelDiscountPLaystations.AutoSize = true;
            this.labelDiscountPLaystations.Location = new System.Drawing.Point(26, 156);
            this.labelDiscountPLaystations.Name = "labelDiscountPLaystations";
            this.labelDiscountPLaystations.Size = new System.Drawing.Size(63, 13);
            this.labelDiscountPLaystations.TabIndex = 35;
            this.labelDiscountPLaystations.Text = "Playstations";
            // 
            // textBoxDiscountName
            // 
            this.textBoxDiscountName.Location = new System.Drawing.Point(110, 50);
            this.textBoxDiscountName.Name = "textBoxDiscountName";
            this.textBoxDiscountName.Size = new System.Drawing.Size(230, 20);
            this.textBoxDiscountName.TabIndex = 26;
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(110, 116);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerEndDate.TabIndex = 30;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.CustomFormat = "";
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(110, 82);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerStartDate.TabIndex = 29;
            this.dateTimePickerStartDate.Value = new System.DateTime(2014, 1, 24, 13, 27, 31, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(26, 122);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(50, 13);
            this.labelEndDate.TabIndex = 25;
            this.labelEndDate.Text = "End date";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(26, 88);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(53, 13);
            this.labelStartDate.TabIndex = 28;
            this.labelStartDate.Text = "Start date";
            // 
            // labelDiscountName
            // 
            this.labelDiscountName.AutoSize = true;
            this.labelDiscountName.Location = new System.Drawing.Point(26, 53);
            this.labelDiscountName.Name = "labelDiscountName";
            this.labelDiscountName.Size = new System.Drawing.Size(78, 13);
            this.labelDiscountName.TabIndex = 27;
            this.labelDiscountName.Text = "Discount name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonBonusType);
            this.groupBox1.Controls.Add(this.radioButtonPercentage);
            this.groupBox1.Location = new System.Drawing.Point(363, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 80);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of bonus";
            // 
            // radioButtonBonusType
            // 
            this.radioButtonBonusType.AutoSize = true;
            this.radioButtonBonusType.Location = new System.Drawing.Point(17, 53);
            this.radioButtonBonusType.Name = "radioButtonBonusType";
            this.radioButtonBonusType.Size = new System.Drawing.Size(55, 17);
            this.radioButtonBonusType.TabIndex = 44;
            this.radioButtonBonusType.Text = "Bonus";
            this.radioButtonBonusType.UseVisualStyleBackColor = true;
            this.radioButtonBonusType.CheckedChanged += new System.EventHandler(this.radioButtonBonusType_CheckedChanged);
            // 
            // radioButtonPercentage
            // 
            this.radioButtonPercentage.AutoSize = true;
            this.radioButtonPercentage.Location = new System.Drawing.Point(17, 30);
            this.radioButtonPercentage.Name = "radioButtonPercentage";
            this.radioButtonPercentage.Size = new System.Drawing.Size(80, 17);
            this.radioButtonPercentage.TabIndex = 45;
            this.radioButtonPercentage.Text = "Percentage";
            this.radioButtonPercentage.UseVisualStyleBackColor = true;
            this.radioButtonPercentage.CheckedChanged += new System.EventHandler(this.radioButtonPercentage_CheckedChanged);
            // 
            // groupBoxBonus
            // 
            this.groupBoxBonus.Controls.Add(this.checkBoxPriceDiscount);
            this.groupBoxBonus.Controls.Add(this.numericUpDownPriceDiscount);
            this.groupBoxBonus.Controls.Add(this.labelPriceDiscount);
            this.groupBoxBonus.Controls.Add(this.checkBoxBonusHours);
            this.groupBoxBonus.Controls.Add(this.checkBoxBonusItem);
            this.groupBoxBonus.Controls.Add(this.comboBoxBonusItem);
            this.groupBoxBonus.Controls.Add(this.numericUpDownBonusMinutes);
            this.groupBoxBonus.Controls.Add(this.numericUpDownNumberOfBonusItem);
            this.groupBoxBonus.Controls.Add(this.numericUpDownBonusHours);
            this.groupBoxBonus.Controls.Add(this.labelNumberOfBonusItem);
            this.groupBoxBonus.Controls.Add(this.labelBonusItem);
            this.groupBoxBonus.Controls.Add(this.labelBonusTime);
            this.groupBoxBonus.Location = new System.Drawing.Point(496, 304);
            this.groupBoxBonus.Name = "groupBoxBonus";
            this.groupBoxBonus.Size = new System.Drawing.Size(272, 185);
            this.groupBoxBonus.TabIndex = 47;
            this.groupBoxBonus.TabStop = false;
            this.groupBoxBonus.Text = "Bonus";
            this.groupBoxBonus.Visible = false;
            this.groupBoxBonus.Enter += new System.EventHandler(this.groupBoxBonus_Enter);
            // 
            // checkBoxPriceDiscount
            // 
            this.checkBoxPriceDiscount.AutoSize = true;
            this.checkBoxPriceDiscount.Location = new System.Drawing.Point(121, 19);
            this.checkBoxPriceDiscount.Name = "checkBoxPriceDiscount";
            this.checkBoxPriceDiscount.Size = new System.Drawing.Size(93, 17);
            this.checkBoxPriceDiscount.TabIndex = 61;
            this.checkBoxPriceDiscount.Text = "Price discount";
            this.checkBoxPriceDiscount.UseVisualStyleBackColor = true;
            this.checkBoxPriceDiscount.CheckedChanged += new System.EventHandler(this.checkBoxPriceDiscount_CheckedChanged);
            // 
            // numericUpDownPriceDiscount
            // 
            this.numericUpDownPriceDiscount.DecimalPlaces = 2;
            this.numericUpDownPriceDiscount.Location = new System.Drawing.Point(121, 150);
            this.numericUpDownPriceDiscount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownPriceDiscount.Name = "numericUpDownPriceDiscount";
            this.numericUpDownPriceDiscount.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownPriceDiscount.TabIndex = 60;
            this.numericUpDownPriceDiscount.Visible = false;
            // 
            // labelPriceDiscount
            // 
            this.labelPriceDiscount.AutoSize = true;
            this.labelPriceDiscount.Location = new System.Drawing.Point(7, 152);
            this.labelPriceDiscount.Name = "labelPriceDiscount";
            this.labelPriceDiscount.Size = new System.Drawing.Size(74, 13);
            this.labelPriceDiscount.TabIndex = 59;
            this.labelPriceDiscount.Text = "Price discount";
            this.labelPriceDiscount.Visible = false;
            // 
            // checkBoxBonusHours
            // 
            this.checkBoxBonusHours.AutoSize = true;
            this.checkBoxBonusHours.Checked = true;
            this.checkBoxBonusHours.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBonusHours.Location = new System.Drawing.Point(9, 19);
            this.checkBoxBonusHours.Name = "checkBoxBonusHours";
            this.checkBoxBonusHours.Size = new System.Drawing.Size(85, 17);
            this.checkBoxBonusHours.TabIndex = 58;
            this.checkBoxBonusHours.Text = "Bonus hours";
            this.checkBoxBonusHours.UseVisualStyleBackColor = true;
            this.checkBoxBonusHours.CheckedChanged += new System.EventHandler(this.checkBoxBonusHours_CheckedChanged);
            // 
            // checkBoxBonusItem
            // 
            this.checkBoxBonusItem.AutoSize = true;
            this.checkBoxBonusItem.Location = new System.Drawing.Point(9, 41);
            this.checkBoxBonusItem.Name = "checkBoxBonusItem";
            this.checkBoxBonusItem.Size = new System.Drawing.Size(78, 17);
            this.checkBoxBonusItem.TabIndex = 57;
            this.checkBoxBonusItem.Text = "Bonus item";
            this.checkBoxBonusItem.UseVisualStyleBackColor = true;
            this.checkBoxBonusItem.CheckedChanged += new System.EventHandler(this.checkBoxBonusItem_CheckedChanged);
            // 
            // comboBoxBonusItem
            // 
            this.comboBoxBonusItem.FormattingEnabled = true;
            this.comboBoxBonusItem.Items.AddRange(new object[] {
            "None",
            "Coca-Cola 1lt",
            "Hookah ICE"});
            this.comboBoxBonusItem.Location = new System.Drawing.Point(121, 97);
            this.comboBoxBonusItem.Name = "comboBoxBonusItem";
            this.comboBoxBonusItem.Size = new System.Drawing.Size(141, 21);
            this.comboBoxBonusItem.TabIndex = 56;
            this.comboBoxBonusItem.Visible = false;
            // 
            // numericUpDownBonusMinutes
            // 
            this.numericUpDownBonusMinutes.Location = new System.Drawing.Point(193, 70);
            this.numericUpDownBonusMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDownBonusMinutes.Name = "numericUpDownBonusMinutes";
            this.numericUpDownBonusMinutes.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownBonusMinutes.TabIndex = 55;
            // 
            // numericUpDownNumberOfBonusItem
            // 
            this.numericUpDownNumberOfBonusItem.Location = new System.Drawing.Point(121, 124);
            this.numericUpDownNumberOfBonusItem.Name = "numericUpDownNumberOfBonusItem";
            this.numericUpDownNumberOfBonusItem.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownNumberOfBonusItem.TabIndex = 54;
            this.numericUpDownNumberOfBonusItem.Visible = false;
            // 
            // numericUpDownBonusHours
            // 
            this.numericUpDownBonusHours.Location = new System.Drawing.Point(121, 70);
            this.numericUpDownBonusHours.Name = "numericUpDownBonusHours";
            this.numericUpDownBonusHours.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownBonusHours.TabIndex = 54;
            // 
            // labelNumberOfBonusItem
            // 
            this.labelNumberOfBonusItem.AutoSize = true;
            this.labelNumberOfBonusItem.Location = new System.Drawing.Point(5, 126);
            this.labelNumberOfBonusItem.Name = "labelNumberOfBonusItem";
            this.labelNumberOfBonusItem.Size = new System.Drawing.Size(111, 13);
            this.labelNumberOfBonusItem.TabIndex = 52;
            this.labelNumberOfBonusItem.Text = "Number of bonus Item";
            this.labelNumberOfBonusItem.Visible = false;
            // 
            // labelBonusItem
            // 
            this.labelBonusItem.AutoSize = true;
            this.labelBonusItem.Location = new System.Drawing.Point(5, 100);
            this.labelBonusItem.Name = "labelBonusItem";
            this.labelBonusItem.Size = new System.Drawing.Size(59, 13);
            this.labelBonusItem.TabIndex = 52;
            this.labelBonusItem.Text = "Bonus item";
            this.labelBonusItem.Visible = false;
            // 
            // labelBonusTime
            // 
            this.labelBonusTime.AutoSize = true;
            this.labelBonusTime.Location = new System.Drawing.Point(5, 72);
            this.labelBonusTime.Name = "labelBonusTime";
            this.labelBonusTime.Size = new System.Drawing.Size(103, 13);
            this.labelBonusTime.TabIndex = 53;
            this.labelBonusTime.Text = "Bonus time (HH:mm)";
            // 
            // AddNewDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 501);
            this.Controls.Add(this.groupBoxBonus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxAuditory);
            this.Controls.Add(this.labelAuditory);
            this.Controls.Add(this.groupBoxRequirments);
            this.Controls.Add(this.groupBoxPercentage);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.buttonAddDiscount);
            this.Controls.Add(this.checkedListBoxTimeZones);
            this.Controls.Add(this.labelTimeZones);
            this.Controls.Add(this.buttonAddPlaystations);
            this.Controls.Add(this.textBoxPlaystations);
            this.Controls.Add(this.labelDiscountPLaystations);
            this.Controls.Add(this.textBoxDiscountName);
            this.Controls.Add(this.dateTimePickerEndDate);
            this.Controls.Add(this.dateTimePickerStartDate);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelDiscountName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewDiscountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewDiscountForm";
            this.Load += new System.EventHandler(this.AddNewDiscountForm_Load);
            this.groupBoxRequirments.ResumeLayout(false);
            this.groupBoxRequirments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredPaidMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredPaidHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRequiredNumberOfItem)).EndInit();
            this.groupBoxPercentage.ResumeLayout(false);
            this.groupBoxPercentage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscountSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxBonus.ResumeLayout(false);
            this.groupBoxBonus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPriceDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonusMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumberOfBonusItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBonusHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAuditory;
        private System.Windows.Forms.Label labelAuditory;
        private System.Windows.Forms.GroupBox groupBoxRequirments;
        private System.Windows.Forms.NumericUpDown numericUpDownRequiredNumberOfItem;
        private System.Windows.Forms.ComboBox comboBoxRequiredItem;
        private System.Windows.Forms.Label labelRequiredNumber;
        private System.Windows.Forms.Label labelRequiredItem;
        private System.Windows.Forms.GroupBox groupBoxPercentage;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscountSize;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.Button buttonAddDiscount;
        private System.Windows.Forms.CheckedListBox checkedListBoxTimeZones;
        private System.Windows.Forms.Label labelTimeZones;
        private System.Windows.Forms.Button buttonAddPlaystations;
        private System.Windows.Forms.TextBox textBoxPlaystations;
        private System.Windows.Forms.Label labelDiscountPLaystations;
        private System.Windows.Forms.TextBox textBoxDiscountName;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelDiscountName;
        private System.Windows.Forms.CheckBox checkBoxRequiredHours;
        private System.Windows.Forms.CheckBox checkBoxRequiredItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonBonusType;
        private System.Windows.Forms.RadioButton radioButtonPercentage;
        private System.Windows.Forms.GroupBox groupBoxBonus;
        private System.Windows.Forms.ComboBox comboBoxBonusItem;
        private System.Windows.Forms.NumericUpDown numericUpDownBonusMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownBonusHours;
        private System.Windows.Forms.Label labelBonusItem;
        private System.Windows.Forms.Label labelBonusTime;
        private System.Windows.Forms.NumericUpDown numericUpDownRequiredPaidMinutes;
        private System.Windows.Forms.NumericUpDown numericUpDownRequiredPaidHours;
        private System.Windows.Forms.Label labelRequiredPaidTime;
        private System.Windows.Forms.CheckBox checkBoxBonusHours;
        private System.Windows.Forms.CheckBox checkBoxBonusItem;
        private System.Windows.Forms.NumericUpDown numericUpDownNumberOfBonusItem;
        private System.Windows.Forms.Label labelNumberOfBonusItem;
        private System.Windows.Forms.NumericUpDown numericUpDownPriceDiscount;
        private System.Windows.Forms.Label labelPriceDiscount;
        private System.Windows.Forms.CheckBox checkBoxPriceDiscount;
    }
}