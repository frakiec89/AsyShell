namespace AsyShell.Forms
{
    partial class SellerForm
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
            this.dGWSeller = new System.Windows.Forms.DataGridView();
            this.cBSeller = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGWSeller)).BeginInit();
            this.SuspendLayout();
            // 
            // dGWSeller
            // 
            this.dGWSeller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWSeller.Location = new System.Drawing.Point(12, 61);
            this.dGWSeller.Name = "dGWSeller";
            this.dGWSeller.Size = new System.Drawing.Size(733, 335);
            this.dGWSeller.TabIndex = 0;
            // 
            // cBSeller
            // 
            this.cBSeller.FormattingEnabled = true;
            this.cBSeller.Location = new System.Drawing.Point(12, 13);
            this.cBSeller.Name = "cBSeller";
            this.cBSeller.Size = new System.Drawing.Size(348, 21);
            this.cBSeller.TabIndex = 1;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cBSeller);
            this.Controls.Add(this.dGWSeller);
            this.Name = "SellerForm";
            this.Text = "Продавцы";
            ((System.ComponentModel.ISupportInitialize)(this.dGWSeller)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGWSeller;
        private System.Windows.Forms.ComboBox cBSeller;
    }
}