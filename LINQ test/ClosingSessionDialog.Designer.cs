namespace LINQ_test
{
    partial class ClosingSessionDialog
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
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonClientGone = new System.Windows.Forms.Button();
            this.buttonProblems = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.richTextBoxComments = new System.Windows.Forms.RichTextBox();
            this.buttonSubmitAndClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Europe_Ext", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(64, 47);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(51, 15);
            this.labelQuestion.TabIndex = 0;
            this.labelQuestion.Text = "label1";
            // 
            // buttonClientGone
            // 
            this.buttonClientGone.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClientGone.Location = new System.Drawing.Point(12, 121);
            this.buttonClientGone.Name = "buttonClientGone";
            this.buttonClientGone.Size = new System.Drawing.Size(134, 43);
            this.buttonClientGone.TabIndex = 1;
            this.buttonClientGone.Text = "Client has gone";
            this.buttonClientGone.UseVisualStyleBackColor = true;
            this.buttonClientGone.Click += new System.EventHandler(this.buttonClientGone_Click);
            // 
            // buttonProblems
            // 
            this.buttonProblems.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProblems.Location = new System.Drawing.Point(134, 183);
            this.buttonProblems.Name = "buttonProblems";
            this.buttonProblems.Size = new System.Drawing.Size(121, 27);
            this.buttonProblems.TabIndex = 1;
            this.buttonProblems.Text = "Problems";
            this.buttonProblems.UseVisualStyleBackColor = true;
            this.buttonProblems.Click += new System.EventHandler(this.buttonProblems_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(245, 121);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(134, 43);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // richTextBoxComments
            // 
            this.richTextBoxComments.Font = new System.Drawing.Font("Europe_Ext", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxComments.Location = new System.Drawing.Point(12, 244);
            this.richTextBoxComments.Name = "richTextBoxComments";
            this.richTextBoxComments.Size = new System.Drawing.Size(367, 111);
            this.richTextBoxComments.TabIndex = 3;
            this.richTextBoxComments.Text = "";
            // 
            // buttonSubmitAndClose
            // 
            this.buttonSubmitAndClose.Font = new System.Drawing.Font("Europe_Ext", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSubmitAndClose.Location = new System.Drawing.Point(91, 361);
            this.buttonSubmitAndClose.Name = "buttonSubmitAndClose";
            this.buttonSubmitAndClose.Size = new System.Drawing.Size(213, 34);
            this.buttonSubmitAndClose.TabIndex = 4;
            this.buttonSubmitAndClose.Text = "Submit and close";
            this.buttonSubmitAndClose.UseVisualStyleBackColor = true;
            this.buttonSubmitAndClose.Click += new System.EventHandler(this.buttonSubmitAndClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Europe_Ext", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Please, describe the problem";
            // 
            // ClosingSessionDialog
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(391, 221);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSubmitAndClose);
            this.Controls.Add(this.richTextBoxComments);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonProblems);
            this.Controls.Add(this.buttonClientGone);
            this.Controls.Add(this.labelQuestion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClosingSessionDialog";
            this.Text = "CLOSING SESSION";
            this.Load += new System.EventHandler(this.ClosingSessionDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonClientGone;
        private System.Windows.Forms.Button buttonProblems;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RichTextBox richTextBoxComments;
        private System.Windows.Forms.Button buttonSubmitAndClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}