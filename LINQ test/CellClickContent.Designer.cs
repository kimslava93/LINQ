namespace LINQ_test
{
    partial class CellClickContent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxCloseSession = new System.Windows.Forms.PictureBox();
            this.labelCurrentTime = new System.Windows.Forms.Label();
            this.pictureBoxStop = new System.Windows.Forms.PictureBox();
            this.pictureBoxAdd = new System.Windows.Forms.PictureBox();
            this.dataGridViewDaysSession = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseSession)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaysSession)).BeginInit();
            this.SuspendLayout();
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 1000;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // pictureBoxCloseSession
            // 
            this.pictureBoxCloseSession.Image = global::LINQ_test.Properties.Resources.close;
            this.pictureBoxCloseSession.InitialImage = global::LINQ_test.Properties.Resources.close;
            this.pictureBoxCloseSession.Location = new System.Drawing.Point(803, 12);
            this.pictureBoxCloseSession.Name = "pictureBoxCloseSession";
            this.pictureBoxCloseSession.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxCloseSession.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCloseSession.TabIndex = 8;
            this.pictureBoxCloseSession.TabStop = false;
            this.pictureBoxCloseSession.Click += new System.EventHandler(this.pictureBoxCloseSession_MouseClick);
            this.pictureBoxCloseSession.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCloseSession_MouseDown);
            this.pictureBoxCloseSession.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCloseSession_MouseUp);
            // 
            // labelCurrentTime
            // 
            this.labelCurrentTime.AutoSize = true;
            this.labelCurrentTime.Font = new System.Drawing.Font("Perfo", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentTime.Location = new System.Drawing.Point(644, 24);
            this.labelCurrentTime.Name = "labelCurrentTime";
            this.labelCurrentTime.Size = new System.Drawing.Size(75, 34);
            this.labelCurrentTime.TabIndex = 7;
            this.labelCurrentTime.Text = "TIME";
            // 
            // pictureBoxStop
            // 
            this.pictureBoxStop.Image = global::LINQ_test.Properties.Resources.stop;
            this.pictureBoxStop.InitialImage = global::LINQ_test.Properties.Resources.stop;
            this.pictureBoxStop.Location = new System.Drawing.Point(108, 12);
            this.pictureBoxStop.Name = "pictureBoxStop";
            this.pictureBoxStop.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStop.TabIndex = 6;
            this.pictureBoxStop.TabStop = false;
            this.pictureBoxStop.Click += new System.EventHandler(this.pictureBoxStop_Click_1);
            this.pictureBoxStop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxStop_MouseDown_1);
            this.pictureBoxStop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxStop_MouseUp_1);
            // 
            // pictureBoxAdd
            // 
            this.pictureBoxAdd.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxAdd.BackgroundImage = global::LINQ_test.Properties.Resources.add;
            this.pictureBoxAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAdd.Image = global::LINQ_test.Properties.Resources.stop;
            this.pictureBoxAdd.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAdd.Name = "pictureBoxAdd";
            this.pictureBoxAdd.Size = new System.Drawing.Size(66, 66);
            this.pictureBoxAdd.TabIndex = 5;
            this.pictureBoxAdd.TabStop = false;
            this.pictureBoxAdd.Click += new System.EventHandler(this.pictureBoxAdd_Click);
            this.pictureBoxAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAdd_MouseDown);
            this.pictureBoxAdd.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAdd_MouseUp);
            // 
            // dataGridViewDaysSession
            // 
            this.dataGridViewDaysSession.AllowUserToAddRows = false;
            this.dataGridViewDaysSession.AllowUserToDeleteRows = false;
            this.dataGridViewDaysSession.AllowUserToResizeColumns = false;
            this.dataGridViewDaysSession.AllowUserToResizeRows = false;
            this.dataGridViewDaysSession.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDaysSession.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDaysSession.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewDaysSession.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewDaysSession.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDaysSession.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDaysSession.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDaysSession.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewDaysSession.GridColor = System.Drawing.Color.Black;
            this.dataGridViewDaysSession.Location = new System.Drawing.Point(0, 84);
            this.dataGridViewDaysSession.Name = "dataGridViewDaysSession";
            this.dataGridViewDaysSession.RowHeadersVisible = false;
            this.dataGridViewDaysSession.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewDaysSession.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDaysSession.Size = new System.Drawing.Size(881, 372);
            this.dataGridViewDaysSession.TabIndex = 9;
            // 
            // CellClickContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 456);
            this.Controls.Add(this.dataGridViewDaysSession);
            this.Controls.Add(this.pictureBoxCloseSession);
            this.Controls.Add(this.labelCurrentTime);
            this.Controls.Add(this.pictureBoxStop);
            this.Controls.Add(this.pictureBoxAdd);
            this.DoubleBuffered = true;
            this.Name = "CellClickContent";
            this.Text = "CellContentClick";
            this.Load += new System.EventHandler(this.CellClickContent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCloseSession)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDaysSession)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerTick;
        private System.Windows.Forms.PictureBox pictureBoxCloseSession;
        private System.Windows.Forms.Label labelCurrentTime;
        private System.Windows.Forms.PictureBox pictureBoxStop;
        private System.Windows.Forms.PictureBox pictureBoxAdd;
        private System.Windows.Forms.DataGridView dataGridViewDaysSession;
    }
}