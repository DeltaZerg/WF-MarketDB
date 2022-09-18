
namespace C_Project
{
    partial class ReductCustomer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ReductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(360, 20);
            this.textBox1.TabIndex = 5;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(148, 94);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(79, 13);
            this.CustomerLabel.TabIndex = 4;
            this.CustomerLabel.Text = "CustomerName";
            // 
            // ReductButton
            // 
            this.ReductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReductButton.Location = new System.Drawing.Point(12, 136);
            this.ReductButton.Name = "ReductButton";
            this.ReductButton.Size = new System.Drawing.Size(360, 63);
            this.ReductButton.TabIndex = 3;
            this.ReductButton.Text = "Редактировать";
            this.ReductButton.UseVisualStyleBackColor = true;
            this.ReductButton.Click += new System.EventHandler(this.ReductButton_Click);
            // 
            // ReductCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ReductButton);
            this.Name = "ReductCustomer";
            this.Text = "Reduct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Button ReductButton;
    }
}