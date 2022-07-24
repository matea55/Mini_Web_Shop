namespace MiniWebShop.Views
{
    partial class deleteProductFromCart
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
            this.productListInCartDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.removeFromCartBtn = new System.Windows.Forms.Button();
            this.returnToShoppingBtn = new System.Windows.Forms.Button();
            this.totalAmountLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.orderBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productListInCartDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // productListInCartDgv
            // 
            this.productListInCartDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productListInCartDgv.Location = new System.Drawing.Point(49, 89);
            this.productListInCartDgv.Name = "productListInCartDgv";
            this.productListInCartDgv.RowHeadersWidth = 51;
            this.productListInCartDgv.RowTemplate.Height = 24;
            this.productListInCartDgv.Size = new System.Drawing.Size(465, 173);
            this.productListInCartDgv.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proizvodi u kosarici";
            // 
            // removeFromCartBtn
            // 
            this.removeFromCartBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeFromCartBtn.Location = new System.Drawing.Point(551, 89);
            this.removeFromCartBtn.Name = "removeFromCartBtn";
            this.removeFromCartBtn.Size = new System.Drawing.Size(177, 53);
            this.removeFromCartBtn.TabIndex = 3;
            this.removeFromCartBtn.Text = "Makni proizvod iz kosarice";
            this.removeFromCartBtn.UseVisualStyleBackColor = true;
            this.removeFromCartBtn.Click += new System.EventHandler(this.addToCartBtn_Click);
            // 
            // returnToShoppingBtn
            // 
            this.returnToShoppingBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToShoppingBtn.Location = new System.Drawing.Point(49, 310);
            this.returnToShoppingBtn.Name = "returnToShoppingBtn";
            this.returnToShoppingBtn.Size = new System.Drawing.Size(177, 53);
            this.returnToShoppingBtn.TabIndex = 4;
            this.returnToShoppingBtn.Text = "Povratak na kupnju";
            this.returnToShoppingBtn.UseVisualStyleBackColor = true;
            this.returnToShoppingBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalAmountLbl
            // 
            this.totalAmountLbl.AutoSize = true;
            this.totalAmountLbl.Location = new System.Drawing.Point(675, 179);
            this.totalAmountLbl.Name = "totalAmountLbl";
            this.totalAmountLbl.Size = new System.Drawing.Size(0, 16);
            this.totalAmountLbl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ukupno kn";
            // 
            // orderBtn
            // 
            this.orderBtn.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBtn.Location = new System.Drawing.Point(551, 229);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(177, 53);
            this.orderBtn.TabIndex = 7;
            this.orderBtn.Text = "Narudzba i placanje";
            this.orderBtn.UseVisualStyleBackColor = true;
            this.orderBtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // deleteProductFromCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalAmountLbl);
            this.Controls.Add(this.returnToShoppingBtn);
            this.Controls.Add(this.removeFromCartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productListInCartDgv);
            this.Name = "deleteProductFromCart";
            this.Text = "CartView";
            this.Load += new System.EventHandler(this.CartView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productListInCartDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productListInCartDgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeFromCartBtn;
        private System.Windows.Forms.Button returnToShoppingBtn;
        private System.Windows.Forms.Label totalAmountLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button orderBtn;
    }
}