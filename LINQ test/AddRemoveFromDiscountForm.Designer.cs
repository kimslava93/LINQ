namespace LINQ_test
{
    partial class AddRemoveFromDiscountForm
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
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.buttonRemoveOne = new System.Windows.Forms.Button();
            this.labelDiscountItems = new System.Windows.Forms.Label();
            this.buttonAddAll = new System.Windows.Forms.Button();
            this.buttonAddOneRecord = new System.Windows.Forms.Button();
            this.listBoxItemsToAdd = new System.Windows.Forms.ListBox();
            this.listBoxSupposeItems = new System.Windows.Forms.ListBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Location = new System.Drawing.Point(132, 159);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(33, 23);
            this.buttonRemoveAll.TabIndex = 19;
            this.buttonRemoveAll.Text = "<<";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // buttonRemoveOne
            // 
            this.buttonRemoveOne.Location = new System.Drawing.Point(132, 64);
            this.buttonRemoveOne.Name = "buttonRemoveOne";
            this.buttonRemoveOne.Size = new System.Drawing.Size(33, 23);
            this.buttonRemoveOne.TabIndex = 20;
            this.buttonRemoveOne.Text = "<";
            this.buttonRemoveOne.UseVisualStyleBackColor = true;
            this.buttonRemoveOne.Click += new System.EventHandler(this.buttonRemoveOne_Click);
            // 
            // labelDiscountItems
            // 
            this.labelDiscountItems.AutoSize = true;
            this.labelDiscountItems.Location = new System.Drawing.Point(129, 9);
            this.labelDiscountItems.Name = "labelDiscountItems";
            this.labelDiscountItems.Size = new System.Drawing.Size(32, 13);
            this.labelDiscountItems.TabIndex = 18;
            this.labelDiscountItems.Text = "Items";
            // 
            // buttonAddAll
            // 
            this.buttonAddAll.Location = new System.Drawing.Point(132, 130);
            this.buttonAddAll.Name = "buttonAddAll";
            this.buttonAddAll.Size = new System.Drawing.Size(33, 23);
            this.buttonAddAll.TabIndex = 17;
            this.buttonAddAll.Text = ">>";
            this.buttonAddAll.UseVisualStyleBackColor = true;
            this.buttonAddAll.Click += new System.EventHandler(this.buttonAddAll_Click);
            // 
            // buttonAddOneRecord
            // 
            this.buttonAddOneRecord.Location = new System.Drawing.Point(132, 35);
            this.buttonAddOneRecord.Name = "buttonAddOneRecord";
            this.buttonAddOneRecord.Size = new System.Drawing.Size(33, 23);
            this.buttonAddOneRecord.TabIndex = 16;
            this.buttonAddOneRecord.Text = ">";
            this.buttonAddOneRecord.UseVisualStyleBackColor = true;
            this.buttonAddOneRecord.Click += new System.EventHandler(this.buttonAddOneRecord_Click);
            // 
            // listBoxItemsToAdd
            // 
            this.listBoxItemsToAdd.FormattingEnabled = true;
            this.listBoxItemsToAdd.Location = new System.Drawing.Point(171, 35);
            this.listBoxItemsToAdd.Name = "listBoxItemsToAdd";
            this.listBoxItemsToAdd.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxItemsToAdd.Size = new System.Drawing.Size(114, 147);
            this.listBoxItemsToAdd.TabIndex = 14;
            // 
            // listBoxSupposeItems
            // 
            this.listBoxSupposeItems.FormattingEnabled = true;
            this.listBoxSupposeItems.Location = new System.Drawing.Point(12, 36);
            this.listBoxSupposeItems.Name = "listBoxSupposeItems";
            this.listBoxSupposeItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSupposeItems.Size = new System.Drawing.Size(114, 147);
            this.listBoxSupposeItems.TabIndex = 15;
            // 
            // buttonApply
            // 
            this.buttonApply.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonApply.Location = new System.Drawing.Point(0, 203);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(297, 30);
            this.buttonApply.TabIndex = 21;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // AddRemoveFromDiscountForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 233);
            this.ControlBox = false;
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonRemoveAll);
            this.Controls.Add(this.buttonRemoveOne);
            this.Controls.Add(this.labelDiscountItems);
            this.Controls.Add(this.buttonAddAll);
            this.Controls.Add(this.buttonAddOneRecord);
            this.Controls.Add(this.listBoxItemsToAdd);
            this.Controls.Add(this.listBoxSupposeItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRemoveFromDiscountForm";
            this.Text = "AddRemoveFromDiscountForm";
            this.Load += new System.EventHandler(this.AddRemoveFromDiscountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Button buttonRemoveOne;
        private System.Windows.Forms.Label labelDiscountItems;
        private System.Windows.Forms.Button buttonAddAll;
        private System.Windows.Forms.Button buttonAddOneRecord;
        private System.Windows.Forms.ListBox listBoxItemsToAdd;
        private System.Windows.Forms.ListBox listBoxSupposeItems;
        private System.Windows.Forms.Button buttonApply;
    }
}