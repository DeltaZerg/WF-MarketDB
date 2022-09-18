
namespace C_Project
{
    partial class ReductOrders
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
            this.CO_GOODS = new System.Windows.Forms.DataGridView();
            this.ReductButton = new System.Windows.Forms.Button();
            this.ManagerLB = new System.Windows.Forms.ComboBox();
            this.CustomerLB = new System.Windows.Forms.ComboBox();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.ManagerLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CO_GOODS)).BeginInit();
            this.SuspendLayout();
            // 
            // CO_GOODS
            // 
            this.CO_GOODS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CO_GOODS.Location = new System.Drawing.Point(12, 117);
            this.CO_GOODS.Name = "CO_GOODS";
            this.CO_GOODS.Size = new System.Drawing.Size(760, 150);
            this.CO_GOODS.TabIndex = 21;
            // 
            // ReductButton
            // 
            this.ReductButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ReductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReductButton.Location = new System.Drawing.Point(12, 273);
            this.ReductButton.Name = "ReductButton";
            this.ReductButton.Size = new System.Drawing.Size(564, 76);
            this.ReductButton.TabIndex = 20;
            this.ReductButton.Text = "Reduct";
            this.ReductButton.UseVisualStyleBackColor = false;
            this.ReductButton.Click += new System.EventHandler(this.ReductButton_Click);
            // 
            // ManagerLB
            // 
            this.ManagerLB.FormattingEnabled = true;
            this.ManagerLB.Location = new System.Drawing.Point(12, 73);
            this.ManagerLB.Name = "ManagerLB";
            this.ManagerLB.Size = new System.Drawing.Size(149, 21);
            this.ManagerLB.TabIndex = 19;
            // 
            // CustomerLB
            // 
            this.CustomerLB.FormattingEnabled = true;
            this.CustomerLB.Location = new System.Drawing.Point(208, 73);
            this.CustomerLB.Name = "CustomerLB";
            this.CustomerLB.Size = new System.Drawing.Size(149, 21);
            this.CustomerLB.TabIndex = 18;
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Location = new System.Drawing.Point(234, 57);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(67, 13);
            this.CustomerLabel.TabIndex = 17;
            this.CustomerLabel.Text = "Покупатель";
            // 
            // ManagerLabel
            // 
            this.ManagerLabel.AutoSize = true;
            this.ManagerLabel.Location = new System.Drawing.Point(67, 57);
            this.ManagerLabel.Name = "ManagerLabel";
            this.ManagerLabel.Size = new System.Drawing.Size(60, 13);
            this.ManagerLabel.TabIndex = 16;
            this.ManagerLabel.Text = "Менеджер";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(190, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID Номер заказа";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(208, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete.Location = new System.Drawing.Point(582, 273);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(190, 76);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // ReductOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.CO_GOODS);
            this.Controls.Add(this.ReductButton);
            this.Controls.Add(this.ManagerLB);
            this.Controls.Add(this.CustomerLB);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.ManagerLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "ReductOrders";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.CO_GOODS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView CO_GOODS;
        private System.Windows.Forms.Button ReductButton;
        private System.Windows.Forms.ComboBox ManagerLB;
        private System.Windows.Forms.ComboBox CustomerLB;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label ManagerLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Delete;
    }
}