namespace FormProject4_Methods
{
    partial class Form1
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
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.gbxAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCustomerList.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.Size = new System.Drawing.Size(822, 191);
            this.dgvCustomerList.TabIndex = 0;
            // 
            // tbxId
            // 
            this.tbxId.Location = new System.Drawing.Point(101, 22);
            this.tbxId.Name = "tbxId";
            this.tbxId.Size = new System.Drawing.Size(140, 20);
            this.tbxId.TabIndex = 1;
            this.tbxId.TextChanged += new System.EventHandler(this.tbxId_TextChanged);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(101, 94);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(140, 20);
            this.tbxLastName.TabIndex = 3;
            // 
            // tbxAge
            // 
            this.tbxAge.Location = new System.Drawing.Point(101, 129);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(140, 20);
            this.tbxAge.TabIndex = 4;
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(101, 165);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(140, 20);
            this.tbxMail.TabIndex = 5;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(101, 59);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(140, 20);
            this.tbxFirstName.TabIndex = 2;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 62);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(22, 13);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "AD";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 97);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(44, 13);
            this.lblLastName.TabIndex = 8;
            this.lblLastName.Text = "SOYAD";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(15, 132);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 13);
            this.lblAge.TabIndex = 9;
            this.lblAge.Text = "YAŞ";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(15, 168);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(32, 13);
            this.lblMail.TabIndex = 10;
            this.lblMail.Text = "MAİL";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(138, 201);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.lblId);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxId);
            this.gbxAdd.Controls.Add(this.lblMail);
            this.gbxAdd.Controls.Add(this.tbxFirstName);
            this.gbxAdd.Controls.Add(this.lblAge);
            this.gbxAdd.Controls.Add(this.tbxLastName);
            this.gbxAdd.Controls.Add(this.lblLastName);
            this.gbxAdd.Controls.Add(this.tbxAge);
            this.gbxAdd.Controls.Add(this.lblFirstName);
            this.gbxAdd.Controls.Add(this.tbxMail);
            this.gbxAdd.Location = new System.Drawing.Point(12, 197);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(248, 233);
            this.gbxAdd.TabIndex = 12;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "EKLE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 564);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.dgvCustomerList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbxAdd;
    }
}

