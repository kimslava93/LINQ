namespace LINQ_test
{
    partial class AddDiscountCardToSession
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
            this.comboBoxDiscountCard = new System.Windows.Forms.ComboBox();
            this.labelDsicountId = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.clients_money_left_textBox = new System.Windows.Forms.TextBox();
            this.client_name_textBox = new System.Windows.Forms.TextBox();
            this.labelMoneyLeft = new System.Windows.Forms.Label();
            this.labelClientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDiscountCard
            // 
            this.comboBoxDiscountCard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDiscountCard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDiscountCard.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxDiscountCard.FormattingEnabled = true;
            this.comboBoxDiscountCard.Location = new System.Drawing.Point(165, 22);
            this.comboBoxDiscountCard.Name = "comboBoxDiscountCard";
            this.comboBoxDiscountCard.Size = new System.Drawing.Size(121, 25);
            this.comboBoxDiscountCard.TabIndex = 1;
            this.comboBoxDiscountCard.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiscountCard_SelectedIndexChanged);
            this.comboBoxDiscountCard.TextChanged += new System.EventHandler(this.comboBoxDiscountCard_TextChanged);
            // 
            // labelDsicountId
            // 
            this.labelDsicountId.AutoSize = true;
            this.labelDsicountId.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDsicountId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDsicountId.Location = new System.Drawing.Point(12, 25);
            this.labelDsicountId.Name = "labelDsicountId";
            this.labelDsicountId.Size = new System.Drawing.Size(143, 17);
            this.labelDsicountId.TabIndex = 1;
            this.labelDsicountId.Text = "Discount card";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(269, 139);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 28);
            this.buttonSubmit.TabIndex = 2;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(11, 139);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 28);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // clients_money_left_textBox
            // 
            this.clients_money_left_textBox.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clients_money_left_textBox.Location = new System.Drawing.Point(165, 92);
            this.clients_money_left_textBox.Name = "clients_money_left_textBox";
            this.clients_money_left_textBox.ReadOnly = true;
            this.clients_money_left_textBox.Size = new System.Drawing.Size(179, 25);
            this.clients_money_left_textBox.TabIndex = 8;
            // 
            // client_name_textBox
            // 
            this.client_name_textBox.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.client_name_textBox.Location = new System.Drawing.Point(165, 58);
            this.client_name_textBox.Name = "client_name_textBox";
            this.client_name_textBox.ReadOnly = true;
            this.client_name_textBox.Size = new System.Drawing.Size(179, 25);
            this.client_name_textBox.TabIndex = 7;
            // 
            // labelMoneyLeft
            // 
            this.labelMoneyLeft.AutoSize = true;
            this.labelMoneyLeft.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMoneyLeft.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelMoneyLeft.Location = new System.Drawing.Point(12, 92);
            this.labelMoneyLeft.Name = "labelMoneyLeft";
            this.labelMoneyLeft.Size = new System.Drawing.Size(106, 17);
            this.labelMoneyLeft.TabIndex = 6;
            this.labelMoneyLeft.Text = "Money left";
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClientName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelClientName.Location = new System.Drawing.Point(11, 61);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(122, 17);
            this.labelClientName.TabIndex = 5;
            this.labelClientName.Text = "Client name";
            // 
            // AddDiscountCardToSession
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(356, 175);
            this.ControlBox = false;
            this.Controls.Add(this.clients_money_left_textBox);
            this.Controls.Add(this.client_name_textBox);
            this.Controls.Add(this.labelMoneyLeft);
            this.Controls.Add(this.labelClientName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelDsicountId);
            this.Controls.Add(this.comboBoxDiscountCard);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDiscountCardToSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddDiscountCardToSession_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDiscountCard;
        private System.Windows.Forms.Label labelDsicountId;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox clients_money_left_textBox;
        private System.Windows.Forms.TextBox client_name_textBox;
        private System.Windows.Forms.Label labelMoneyLeft;
        private System.Windows.Forms.Label labelClientName;
    }
}