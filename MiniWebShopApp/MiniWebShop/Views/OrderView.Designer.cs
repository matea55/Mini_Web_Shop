namespace MiniWebShop.Views
{
    partial class payBtn
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
            this.label2 = new System.Windows.Forms.Label();
            this.cuponTxt = new System.Windows.Forms.TextBox();
            this.cardTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.priceAmountOnOrderLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.paymentTxt = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cuponBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Odaberite nacin placanja";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "2. Unesite kupon za popust ukoliko ga imate";
            // 
            // cuponTxt
            // 
            this.cuponTxt.Location = new System.Drawing.Point(202, 252);
            this.cuponTxt.Name = "cuponTxt";
            this.cuponTxt.Size = new System.Drawing.Size(179, 22);
            this.cuponTxt.TabIndex = 5;
            // 
            // cardTxt
            // 
            this.cardTxt.Location = new System.Drawing.Point(357, 132);
            this.cardTxt.Name = "cardTxt";
            this.cardTxt.Size = new System.Drawing.Size(188, 22);
            this.cardTxt.TabIndex = 6;
            this.cardTxt.TextChanged += new System.EventHandler(this.cardTxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ukupno u kn";
            // 
            // priceAmountOnOrderLbl
            // 
            this.priceAmountOnOrderLbl.AutoSize = true;
            this.priceAmountOnOrderLbl.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.priceAmountOnOrderLbl.Location = new System.Drawing.Point(442, 319);
            this.priceAmountOnOrderLbl.Name = "priceAmountOnOrderLbl";
            this.priceAmountOnOrderLbl.Size = new System.Drawing.Size(61, 20);
            this.priceAmountOnOrderLbl.TabIndex = 8;
            this.priceAmountOnOrderLbl.Text = "label4";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.button1.Location = new System.Drawing.Point(303, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "Plati";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // paymentTxt
            // 
            this.paymentTxt.Location = new System.Drawing.Point(183, 72);
            this.paymentTxt.Name = "paymentTxt";
            this.paymentTxt.Size = new System.Drawing.Size(188, 22);
            this.paymentTxt.TabIndex = 10;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(446, 68);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(99, 30);
            this.confirmBtn.TabIndex = 11;
            this.confirmBtn.Text = "Potvrdi odabir";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Unesite \"kartica\" ili \"gotovina\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Unesite broj kartice";
            // 
            // cuponBtn
            // 
            this.cuponBtn.Location = new System.Drawing.Point(423, 248);
            this.cuponBtn.Name = "cuponBtn";
            this.cuponBtn.Size = new System.Drawing.Size(177, 30);
            this.cuponBtn.TabIndex = 14;
            this.cuponBtn.Text = "Provjeri ispravnost kupona";
            this.cuponBtn.UseVisualStyleBackColor = true;
            this.cuponBtn.Click += new System.EventHandler(this.cuponBtn_Click);
            // 
            // payBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cuponBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.paymentTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.priceAmountOnOrderLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cardTxt);
            this.Controls.Add(this.cuponTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "payBtn";
            this.Text = "OrderView";
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cuponTxt;
        private System.Windows.Forms.TextBox cardTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label priceAmountOnOrderLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox paymentTxt;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cuponBtn;
    }
}