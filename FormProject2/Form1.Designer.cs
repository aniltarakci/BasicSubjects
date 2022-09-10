namespace FormProject2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.tbxAddStudent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(476, 30);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(97, 23);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Öğrenci Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(476, 110);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(97, 23);
            this.btnRemoveStudent.TabIndex = 1;
            this.btnRemoveStudent.Text = "Öğrenci Sil";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // tbxAddStudent
            // 
            this.tbxAddStudent.Location = new System.Drawing.Point(301, 30);
            this.tbxAddStudent.Name = "tbxAddStudent";
            this.tbxAddStudent.Size = new System.Drawing.Size(138, 23);
            this.tbxAddStudent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "ÖĞRENCİ EKLE";
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 15;
            this.lbxStudentList.Location = new System.Drawing.Point(24, 30);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(127, 199);
            this.lbxStudentList.TabIndex = 5;
            this.lbxStudentList.SelectedIndexChanged += new System.EventHandler(this.lbxStudentList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "ÖĞRENCİ SİL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbxStudentList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxAddStudent);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemoveStudent;
        private System.Windows.Forms.TextBox tbxAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label label3;
    }
}
