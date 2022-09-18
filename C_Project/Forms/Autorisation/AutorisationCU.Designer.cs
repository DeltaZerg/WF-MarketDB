
namespace C_Project
{
    partial class AutorisationCU
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
            this.TB_UN = new System.Windows.Forms.TextBox();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TB_PW = new System.Windows.Forms.TextBox();
            this.PassWordLabel = new System.Windows.Forms.Label();
            this.ReductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TB_UN
            // 
            this.TB_UN.Location = new System.Drawing.Point(12, 71);
            this.TB_UN.Name = "TB_UN";
            this.TB_UN.Size = new System.Drawing.Size(360, 20);
            this.TB_UN.TabIndex = 15;

            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(148, 55);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(57, 13);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "UserName";
 
            // 
            // TB_PW
            // 
            this.TB_PW.Location = new System.Drawing.Point(12, 110);
            this.TB_PW.Name = "TB_PW";
            this.TB_PW.Size = new System.Drawing.Size(360, 20);
            this.TB_PW.TabIndex = 13;
            
            // 
            // PassWordLabel
            // 
            this.PassWordLabel.AutoSize = true;
            this.PassWordLabel.Location = new System.Drawing.Point(148, 94);
            this.PassWordLabel.Name = "PassWordLabel";
            this.PassWordLabel.Size = new System.Drawing.Size(53, 13);
            this.PassWordLabel.TabIndex = 12;
            this.PassWordLabel.Text = "Password";
          
            // 
            // ReductButton
            // 
            this.ReductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReductButton.Location = new System.Drawing.Point(12, 136);
            this.ReductButton.Name = "ReductButton";
            this.ReductButton.Size = new System.Drawing.Size(360, 63);
            this.ReductButton.TabIndex = 11;
            this.ReductButton.Text = "Create";
            this.ReductButton.UseVisualStyleBackColor = true;
            this.ReductButton.Click += new System.EventHandler(this.ReductButton_Click);
            // 
            // AutorisationCU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.TB_UN);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.TB_PW);
            this.Controls.Add(this.PassWordLabel);
            this.Controls.Add(this.ReductButton);
            this.Name = "AutorisationCU";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_UN;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.TextBox TB_PW;
        private System.Windows.Forms.Label PassWordLabel;
        private System.Windows.Forms.Button ReductButton;
    }
}