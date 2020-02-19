namespace AsyShell
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btAddCustomer = new System.Windows.Forms.Button();
            this.btAddSeller = new System.Windows.Forms.Button();
            this.btAddProduct = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSeller = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAddCustomer
            // 
            this.btAddCustomer.Location = new System.Drawing.Point(6, 37);
            this.btAddCustomer.Name = "btAddCustomer";
            this.btAddCustomer.Size = new System.Drawing.Size(165, 23);
            this.btAddCustomer.TabIndex = 2;
            this.btAddCustomer.Text = "Покупателя ";
            this.btAddCustomer.UseVisualStyleBackColor = true;
            this.btAddCustomer.Click += new System.EventHandler(this.btAddCustomer_Click);
            // 
            // btAddSeller
            // 
            this.btAddSeller.Location = new System.Drawing.Point(6, 66);
            this.btAddSeller.Name = "btAddSeller";
            this.btAddSeller.Size = new System.Drawing.Size(165, 23);
            this.btAddSeller.TabIndex = 3;
            this.btAddSeller.Text = "Продавца";
            this.btAddSeller.UseVisualStyleBackColor = true;
            this.btAddSeller.Click += new System.EventHandler(this.btAddSeller_Click);
            // 
            // btAddProduct
            // 
            this.btAddProduct.Location = new System.Drawing.Point(6, 95);
            this.btAddProduct.Name = "btAddProduct";
            this.btAddProduct.Size = new System.Drawing.Size(165, 23);
            this.btAddProduct.TabIndex = 4;
            this.btAddProduct.Text = "Продукты";
            this.btAddProduct.UseVisualStyleBackColor = true;
            this.btAddProduct.Click += new System.EventHandler(this.btAddProduct_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btAddCustomer);
            this.groupBox1.Controls.Add(this.btAddProduct);
            this.groupBox1.Controls.Add(this.btAddSeller);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 155);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить";
            // 
            // btSeller
            // 
            this.btSeller.Location = new System.Drawing.Point(553, 110);
            this.btSeller.Name = "btSeller";
            this.btSeller.Size = new System.Drawing.Size(145, 23);
            this.btSeller.TabIndex = 6;
            this.btSeller.Text = "Продавцы";
            this.btSeller.UseVisualStyleBackColor = true;
            this.btSeller.Click += new System.EventHandler(this.btSeller_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSeller);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Главная Форма";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btAddCustomer;
        private System.Windows.Forms.Button btAddSeller;
        private System.Windows.Forms.Button btAddProduct;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSeller;
    }
}

