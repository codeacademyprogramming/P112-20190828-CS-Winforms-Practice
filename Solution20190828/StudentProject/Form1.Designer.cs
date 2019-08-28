namespace StudentProject
{
    partial class frmStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.lblSelectedIndex = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbx = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(109, 12);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(224, 26);
            this.txtFirstname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lastname";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(109, 50);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(224, 26);
            this.txtLastname.TabIndex = 2;
            // 
            // lbxStudents
            // 
            this.lbxStudents.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.ItemHeight = 20;
            this.lbxStudents.Location = new System.Drawing.Point(366, 12);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(335, 304);
            this.lbxStudents.TabIndex = 4;
            this.lbxStudents.SelectedIndexChanged += new System.EventHandler(this.LbxStudents_SelectedIndexChanged);
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.DeepPink;
            this.btnSaveStudent.Location = new System.Drawing.Point(209, 281);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(124, 35);
            this.btnSaveStudent.TabIndex = 3;
            this.btnSaveStudent.Text = "Save";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.BtnSaveStudent_Click);
            // 
            // lblSelectedIndex
            // 
            this.lblSelectedIndex.AutoSize = true;
            this.lblSelectedIndex.Location = new System.Drawing.Point(16, 288);
            this.lblSelectedIndex.Name = "lblSelectedIndex";
            this.lblSelectedIndex.Size = new System.Drawing.Size(0, 20);
            this.lblSelectedIndex.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.Yellow;
            this.numericUpDown1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Red;
            this.numericUpDown1.Location = new System.Drawing.Point(213, 92);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 6;
            // 
            // cbx
            // 
            this.cbx.FormattingEnabled = true;
            this.cbx.Items.AddRange(new object[] {
            "asd",
            "qew",
            "fer",
            "dfg"});
            this.cbx.Location = new System.Drawing.Point(109, 135);
            this.cbx.Name = "cbx";
            this.cbx.Size = new System.Drawing.Size(224, 28);
            this.cbx.TabIndex = 7;
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(713, 325);
            this.Controls.Add(this.cbx);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.lblSelectedIndex);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.label1);
            this.Name = "frmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.FrmStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.Label lblSelectedIndex;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbx;
    }
}

