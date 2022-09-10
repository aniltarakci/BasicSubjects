namespace FormProject3_Classes
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
            this.lbxStudentsList = new System.Windows.Forms.ListBox();
            this.dgvStudentsList = new System.Windows.Forms.DataGridView();
            this.btnGetStudentsLbx = new System.Windows.Forms.Button();
            this.btnGetStudentsDgv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbxStudentsList
            // 
            this.lbxStudentsList.FormattingEnabled = true;
            this.lbxStudentsList.ItemHeight = 15;
            this.lbxStudentsList.Location = new System.Drawing.Point(27, 12);
            this.lbxStudentsList.Name = "lbxStudentsList";
            this.lbxStudentsList.Size = new System.Drawing.Size(358, 229);
            this.lbxStudentsList.TabIndex = 0;
            // 
            // dgvStudentsList
            // 
            this.dgvStudentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentsList.Location = new System.Drawing.Point(453, 12);
            this.dgvStudentsList.Name = "dgvStudentsList";
            this.dgvStudentsList.RowTemplate.Height = 25;
            this.dgvStudentsList.Size = new System.Drawing.Size(498, 229);
            this.dgvStudentsList.TabIndex = 1;
            // 
            // btnGetStudentsLbx
            // 
            this.btnGetStudentsLbx.Location = new System.Drawing.Point(27, 247);
            this.btnGetStudentsLbx.Name = "btnGetStudentsLbx";
            this.btnGetStudentsLbx.Size = new System.Drawing.Size(164, 23);
            this.btnGetStudentsLbx.TabIndex = 2;
            this.btnGetStudentsLbx.Text = "Öğrenileri Listele";
            this.btnGetStudentsLbx.UseVisualStyleBackColor = true;
            this.btnGetStudentsLbx.Click += new System.EventHandler(this.btnGetStudentsLbx_Click);
            // 
            // btnGetStudentsDgv
            // 
            this.btnGetStudentsDgv.Location = new System.Drawing.Point(453, 247);
            this.btnGetStudentsDgv.Name = "btnGetStudentsDgv";
            this.btnGetStudentsDgv.Size = new System.Drawing.Size(164, 23);
            this.btnGetStudentsDgv.TabIndex = 3;
            this.btnGetStudentsDgv.Text = "Öğrencileri Listele";
            this.btnGetStudentsDgv.UseVisualStyleBackColor = true;
            this.btnGetStudentsDgv.Click += new System.EventHandler(this.btnGetStudentsDgv_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 450);
            this.Controls.Add(this.btnGetStudentsDgv);
            this.Controls.Add(this.btnGetStudentsLbx);
            this.Controls.Add(this.dgvStudentsList);
            this.Controls.Add(this.lbxStudentsList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentsList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudentsList;
        private System.Windows.Forms.DataGridView dgvStudentsList;
        private System.Windows.Forms.Button btnGetStudentsLbx;
        private System.Windows.Forms.Button btnGetStudentsDgv;
    }
}
