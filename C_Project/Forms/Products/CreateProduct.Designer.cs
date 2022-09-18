
namespace C_Project
{
    partial class CreateProduct
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
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.ProductLabel_N = new System.Windows.Forms.Label();
            this.ReductButton = new System.Windows.Forms.Button();
            this.TB_Price = new System.Windows.Forms.TextBox();
            this.ProductLabel_P = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(12, 110);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(360, 20);
            this.TB_Name.TabIndex = 8;
            // 
            // ProductLabel_N
            // 
            this.ProductLabel_N.AutoSize = true;
            this.ProductLabel_N.Location = new System.Drawing.Point(148, 94);
            this.ProductLabel_N.Name = "ProductLabel_N";
            this.ProductLabel_N.Size = new System.Drawing.Size(72, 13);
            this.ProductLabel_N.TabIndex = 7;
            this.ProductLabel_N.Text = "ProductName";
            // 
            // ReductButton
            // 
            this.ReductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReductButton.Location = new System.Drawing.Point(12, 136);
            this.ReductButton.Name = "ReductButton";
            this.ReductButton.Size = new System.Drawing.Size(360, 63);
            this.ReductButton.TabIndex = 6;
            this.ReductButton.Text = "Редактировать";
            this.ReductButton.UseVisualStyleBackColor = true;
            this.ReductButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // TB_Price
            // 
            this.TB_Price.Location = new System.Drawing.Point(12, 71);
            this.TB_Price.Name = "TB_Price";
            this.TB_Price.Size = new System.Drawing.Size(360, 20);
            this.TB_Price.TabIndex = 10;
            // 
            // ProductLabel_P
            // 
            this.ProductLabel_P.AutoSize = true;
            this.ProductLabel_P.Location = new System.Drawing.Point(148, 55);
            this.ProductLabel_P.Name = "ProductLabel_P";
            this.ProductLabel_P.Size = new System.Drawing.Size(68, 13);
            this.ProductLabel_P.TabIndex = 9;
            this.ProductLabel_P.Text = "ProductPrice";
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.TB_Price);
            this.Controls.Add(this.ProductLabel_P);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.ProductLabel_N);
            this.Controls.Add(this.ReductButton);
            this.Name = "CreateProduct";
            this.Text = "CreateProduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.Label ProductLabel_N;
        private System.Windows.Forms.Button ReductButton;
        private System.Windows.Forms.TextBox TB_Price;
        private System.Windows.Forms.Label ProductLabel_P;
    }
}