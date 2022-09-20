namespace FormProject5_Threading
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
            this.btnprocess1 = new System.Windows.Forms.Button();
            this.btnprocess2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnprocess1
            // 
            this.btnprocess1.Location = new System.Drawing.Point(104, 99);
            this.btnprocess1.Name = "btnprocess1";
            this.btnprocess1.Size = new System.Drawing.Size(75, 23);
            this.btnprocess1.TabIndex = 0;
            this.btnprocess1.Text = "İŞLEM 1";
            this.btnprocess1.UseVisualStyleBackColor = true;
            this.btnprocess1.Click += new System.EventHandler(this.btnprocess1_Click);
            // 
            // btnprocess2
            // 
            this.btnprocess2.Location = new System.Drawing.Point(262, 99);
            this.btnprocess2.Name = "btnprocess2";
            this.btnprocess2.Size = new System.Drawing.Size(75, 23);
            this.btnprocess2.TabIndex = 1;
            this.btnprocess2.Text = "İŞLEM 2";
            this.btnprocess2.UseVisualStyleBackColor = true;
            this.btnprocess2.Click += new System.EventHandler(this.btnprocess2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 248);
            this.Controls.Add(this.btnprocess2);
            this.Controls.Add(this.btnprocess1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnprocess1;
        private System.Windows.Forms.Button btnprocess2;
    }
}
