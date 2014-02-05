namespace LINQ_test
{
    partial class DiscountRedactor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button1 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewDiscountsTable = new System.Windows.Forms.DataGridView();
            this.buttonStopEarlier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscountsTable)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.buttonStopEarlier);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1222, 507);
            this.splitContainer1.SplitterDistance = 236;
            this.splitContainer1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1222, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridViewDiscountsTable);
            this.splitContainer2.Size = new System.Drawing.Size(1222, 267);
            this.splitContainer2.SplitterDistance = 1075;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridViewDiscountsTable
            // 
            this.dataGridViewDiscountsTable.AllowUserToAddRows = false;
            this.dataGridViewDiscountsTable.AllowUserToDeleteRows = false;
            this.dataGridViewDiscountsTable.AllowUserToResizeColumns = false;
            this.dataGridViewDiscountsTable.AllowUserToResizeRows = false;
            this.dataGridViewDiscountsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDiscountsTable.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewDiscountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDiscountsTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDiscountsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDiscountsTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDiscountsTable.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewDiscountsTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDiscountsTable.MultiSelect = false;
            this.dataGridViewDiscountsTable.Name = "dataGridViewDiscountsTable";
            this.dataGridViewDiscountsTable.ReadOnly = true;
            this.dataGridViewDiscountsTable.RowHeadersVisible = false;
            this.dataGridViewDiscountsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewDiscountsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDiscountsTable.Size = new System.Drawing.Size(1075, 267);
            this.dataGridViewDiscountsTable.TabIndex = 8;
            // 
            // buttonStopEarlier
            // 
            this.buttonStopEarlier.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStopEarlier.Location = new System.Drawing.Point(0, 68);
            this.buttonStopEarlier.Name = "buttonStopEarlier";
            this.buttonStopEarlier.Size = new System.Drawing.Size(1222, 67);
            this.buttonStopEarlier.TabIndex = 10;
            this.buttonStopEarlier.Text = "Stop Earlier";
            this.buttonStopEarlier.UseVisualStyleBackColor = true;
            // 
            // DiscountRedactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 507);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DiscountRedactor";
            this.Text = "DiscountRedactor";
            this.Load += new System.EventHandler(this.DiscountRedactor_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscountsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridViewDiscountsTable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonStopEarlier;
    }
}