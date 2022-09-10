namespace FormProject1
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
            this.lblProducts = new System.Windows.Forms.Label();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.lblCart = new System.Windows.Forms.Label();
            this.btnDeleteCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Location = new System.Drawing.Point(35, 18);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(67, 15);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "lblProducts";
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 15;
            this.lbxProducts.Location = new System.Drawing.Point(35, 47);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(127, 184);
            this.lbxProducts.TabIndex = 1;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(171, 111);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(127, 25);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "btnAddToCart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCard_Click);
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 15;
            this.lbxCart.Location = new System.Drawing.Point(307, 47);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(127, 184);
            this.lbxCart.TabIndex = 3;
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Location = new System.Drawing.Point(338, 18);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(42, 15);
            this.lblCart.TabIndex = 4;
            this.lblCart.Text = "lblCart";
            // 
            // btnDeleteCart
            // 
            this.btnDeleteCart.Location = new System.Drawing.Point(171, 152);
            this.btnDeleteCart.Name = "btnDeleteCart";
            this.btnDeleteCart.Size = new System.Drawing.Size(127, 25);
            this.btnDeleteCart.TabIndex = 5;
            this.btnDeleteCart.Text = "btnDeleteCart";
            this.btnDeleteCart.UseVisualStyleBackColor = true;
            this.btnDeleteCart.Click += new System.EventHandler(this.btnDeleteCart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 302);
            this.Controls.Add(this.btnDeleteCart);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.lbxCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.lbxProducts);
            this.Controls.Add(this.lblProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label lblCart;
        private System.Windows.Forms.Button btnDeleteCart;
    }
}
