namespace Project8_RapidApiCurrency
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
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.Label();
            this.rdbDollar = new System.Windows.Forms.RadioButton();
            this.rdbEuro = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDollar.Location = new System.Drawing.Point(47, 52);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(51, 20);
            this.lblDollar.TabIndex = 0;
            this.lblDollar.Text = "label1";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEuro.Location = new System.Drawing.Point(220, 52);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(51, 20);
            this.lblEuro.TabIndex = 2;
            this.lblEuro.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 4;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoSize = true;
            this.txtUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUnitPrice.Location = new System.Drawing.Point(47, 134);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(85, 20);
            this.txtUnitPrice.TabIndex = 5;
            this.txtUnitPrice.Text = "Birim Tutar";
            // 
            // rdbDollar
            // 
            this.rdbDollar.AutoSize = true;
            this.rdbDollar.Location = new System.Drawing.Point(51, 95);
            this.rdbDollar.Name = "rdbDollar";
            this.rdbDollar.Size = new System.Drawing.Size(50, 17);
            this.rdbDollar.TabIndex = 6;
            this.rdbDollar.TabStop = true;
            this.rdbDollar.Text = "Dolar";
            this.rdbDollar.UseVisualStyleBackColor = true;
            // 
            // rdbEuro
            // 
            this.rdbEuro.AutoSize = true;
            this.rdbEuro.Location = new System.Drawing.Point(215, 95);
            this.rdbEuro.Name = "rdbEuro";
            this.rdbEuro.Size = new System.Drawing.Size(47, 17);
            this.rdbEuro.TabIndex = 7;
            this.rdbEuro.TabStop = true;
            this.rdbEuro.Text = "Euro";
            this.rdbEuro.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(150, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "İşlemi Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.AutoSize = true;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTotalPrice.Location = new System.Drawing.Point(9, 160);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(123, 20);
            this.txtTotalPrice.TabIndex = 11;
            this.txtTotalPrice.Text = "Ödenecek Tutar";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(138, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdbEuro);
            this.Controls.Add(this.rdbDollar);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDollar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtUnitPrice;
        private System.Windows.Forms.RadioButton rdbDollar;
        private System.Windows.Forms.RadioButton rdbEuro;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTotalPrice;
        private System.Windows.Forms.TextBox textBox2;
    }
}

