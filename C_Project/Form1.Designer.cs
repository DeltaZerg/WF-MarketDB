
namespace C_Project
{
    partial class Form1
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
            SaveSettings();
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TexTab = new System.Windows.Forms.TabPage();
            this.CTU = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.UsersTab = new System.Windows.Forms.TabPage();
            this.dataUsers = new System.Windows.Forms.DataGridView();
            this.ProductsTab = new System.Windows.Forms.TabPage();
            this.dataProducts = new System.Windows.Forms.DataGridView();
            this.OrdersTab = new System.Windows.Forms.TabPage();
            this.dataGoods = new System.Windows.Forms.DataGridView();
            this.dataOrders = new System.Windows.Forms.DataGridView();
            this.ManagersTab = new System.Windows.Forms.TabPage();
            this.dataManagers = new System.Windows.Forms.DataGridView();
            this.CustomerTab = new System.Windows.Forms.TabPage();
            this.dataCustomers = new System.Windows.Forms.DataGridView();
            this.TabsControl = new System.Windows.Forms.TabControl();
            this.CreateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ReductButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.ChangeCol = new System.Windows.Forms.Label();
            this.TexTab.SuspendLayout();
            this.UsersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).BeginInit();
            this.ProductsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).BeginInit();
            this.OrdersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).BeginInit();
            this.ManagersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataManagers)).BeginInit();
            this.CustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).BeginInit();
            this.TabsControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // TexTab
            // 
            this.TexTab.Controls.Add(this.CTU);
            this.TexTab.Location = new System.Drawing.Point(4, 22);
            this.TexTab.Name = "TexTab";
            this.TexTab.Padding = new System.Windows.Forms.Padding(3);
            this.TexTab.Size = new System.Drawing.Size(776, 392);
            this.TexTab.TabIndex = 6;
            this.TexTab.Text = "Tex";
            this.TexTab.UseVisualStyleBackColor = true;
            // 
            // CTU
            // 
            this.CTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CTU.Location = new System.Drawing.Point(6, 6);
            this.CTU.Name = "CTU";
            this.CTU.Size = new System.Drawing.Size(222, 23);
            this.CTU.TabIndex = 1;
            this.CTU.Text = "Создать 2х пользователей";
            this.CTU.UseVisualStyleBackColor = true;
            this.CTU.Click += new System.EventHandler(this.CTU_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckButton.Location = new System.Drawing.Point(334, 5);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(222, 23);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Распечатать чек";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // UsersTab
            // 
            this.UsersTab.Controls.Add(this.dataUsers);
            this.UsersTab.Location = new System.Drawing.Point(4, 22);
            this.UsersTab.Name = "UsersTab";
            this.UsersTab.Padding = new System.Windows.Forms.Padding(3);
            this.UsersTab.Size = new System.Drawing.Size(776, 392);
            this.UsersTab.TabIndex = 5;
            this.UsersTab.Text = "Users";
            this.UsersTab.UseVisualStyleBackColor = true;
            // 
            // dataUsers
            // 
            this.dataUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataUsers.Location = new System.Drawing.Point(3, 3);
            this.dataUsers.Name = "dataUsers";
            this.dataUsers.Size = new System.Drawing.Size(770, 386);
            this.dataUsers.TabIndex = 0;
            // 
            // ProductsTab
            // 
            this.ProductsTab.Controls.Add(this.dataProducts);
            this.ProductsTab.Location = new System.Drawing.Point(4, 22);
            this.ProductsTab.Name = "ProductsTab";
            this.ProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.ProductsTab.Size = new System.Drawing.Size(776, 392);
            this.ProductsTab.TabIndex = 4;
            this.ProductsTab.Text = "Products";
            this.ProductsTab.UseVisualStyleBackColor = true;
            // 
            // dataProducts
            // 
            this.dataProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataProducts.Location = new System.Drawing.Point(3, 3);
            this.dataProducts.Name = "dataProducts";
            this.dataProducts.Size = new System.Drawing.Size(770, 386);
            this.dataProducts.TabIndex = 0;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Controls.Add(this.dataGoods);
            this.OrdersTab.Controls.Add(this.dataOrders);
            this.OrdersTab.Location = new System.Drawing.Point(4, 22);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTab.Size = new System.Drawing.Size(776, 392);
            this.OrdersTab.TabIndex = 3;
            this.OrdersTab.Text = "Orders";
            this.OrdersTab.UseVisualStyleBackColor = true;
            // 
            // dataGoods
            // 
            this.dataGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGoods.Location = new System.Drawing.Point(3, 199);
            this.dataGoods.Name = "dataGoods";
            this.dataGoods.Size = new System.Drawing.Size(770, 184);
            this.dataGoods.TabIndex = 1;
            // 
            // dataOrders
            // 
            this.dataOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataOrders.Location = new System.Drawing.Point(3, 3);
            this.dataOrders.Name = "dataOrders";
            this.dataOrders.Size = new System.Drawing.Size(770, 189);
            this.dataOrders.TabIndex = 0;
            // 
            // ManagersTab
            // 
            this.ManagersTab.Controls.Add(this.dataManagers);
            this.ManagersTab.Location = new System.Drawing.Point(4, 22);
            this.ManagersTab.Name = "ManagersTab";
            this.ManagersTab.Padding = new System.Windows.Forms.Padding(3);
            this.ManagersTab.Size = new System.Drawing.Size(776, 392);
            this.ManagersTab.TabIndex = 2;
            this.ManagersTab.Text = "Managers";
            this.ManagersTab.UseVisualStyleBackColor = true;
            // 
            // dataManagers
            // 
            this.dataManagers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataManagers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataManagers.Location = new System.Drawing.Point(3, 3);
            this.dataManagers.Name = "dataManagers";
            this.dataManagers.Size = new System.Drawing.Size(770, 386);
            this.dataManagers.TabIndex = 0;
            // 
            // CustomerTab
            // 
            this.CustomerTab.Controls.Add(this.dataCustomers);
            this.CustomerTab.Location = new System.Drawing.Point(4, 22);
            this.CustomerTab.Name = "CustomerTab";
            this.CustomerTab.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTab.Size = new System.Drawing.Size(776, 392);
            this.CustomerTab.TabIndex = 0;
            this.CustomerTab.Text = "Customer";
            this.CustomerTab.UseVisualStyleBackColor = true;
            // 
            // dataCustomers
            // 
            this.dataCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataCustomers.Location = new System.Drawing.Point(3, 3);
            this.dataCustomers.Name = "dataCustomers";
            this.dataCustomers.Size = new System.Drawing.Size(770, 386);
            this.dataCustomers.TabIndex = 0;
            // 
            // TabsControl
            // 
            this.TabsControl.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.TabsControl.Controls.Add(this.CustomerTab);
            this.TabsControl.Controls.Add(this.ManagersTab);
            this.TabsControl.Controls.Add(this.OrdersTab);
            this.TabsControl.Controls.Add(this.ProductsTab);
            this.TabsControl.Controls.Add(this.UsersTab);
            this.TabsControl.Controls.Add(this.TexTab);
            this.TabsControl.Location = new System.Drawing.Point(12, 12);
            this.TabsControl.Name = "TabsControl";
            this.TabsControl.SelectedIndex = 0;
            this.TabsControl.Size = new System.Drawing.Size(784, 418);
            this.TabsControl.TabIndex = 2;
            this.TabsControl.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.TabsControl_Selecting);
            // 
            // CreateButton
            // 
            this.CreateButton.Location = new System.Drawing.Point(16, 429);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(168, 23);
            this.CreateButton.TabIndex = 3;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(216, 429);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(168, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ReductButton
            // 
            this.ReductButton.Location = new System.Drawing.Point(416, 429);
            this.ReductButton.Name = "ReductButton";
            this.ReductButton.Size = new System.Drawing.Size(168, 23);
            this.ReductButton.TabIndex = 5;
            this.ReductButton.Text = "Reduct";
            this.ReductButton.UseVisualStyleBackColor = true;
            this.ReductButton.Click += new System.EventHandler(this.ReductButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(616, 429);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(168, 23);
            this.RefreshButton.TabIndex = 6;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // ChangeCol
            // 
            this.ChangeCol.AutoSize = true;
            this.ChangeCol.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ChangeCol.Location = new System.Drawing.Point(575, 5);
            this.ChangeCol.Name = "ChangeCol";
            this.ChangeCol.Size = new System.Drawing.Size(113, 13);
            this.ChangeCol.TabIndex = 1;
            this.ChangeCol.Text = "Изменить цвет фона";
            this.ChangeCol.Click += new System.EventHandler(this.ChangeCol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.ChangeCol);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.ReductButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.TabsControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TexTab.ResumeLayout(false);
            this.UsersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataUsers)).EndInit();
            this.ProductsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataProducts)).EndInit();
            this.OrdersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataOrders)).EndInit();
            this.ManagersTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataManagers)).EndInit();
            this.CustomerTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataCustomers)).EndInit();
            this.TabsControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage TexTab;
        private System.Windows.Forms.Button CTU;
        private System.Windows.Forms.TabPage UsersTab;
        private System.Windows.Forms.DataGridView dataUsers;
        private System.Windows.Forms.TabPage ProductsTab;
        private System.Windows.Forms.DataGridView dataProducts;
        private System.Windows.Forms.TabPage OrdersTab;
        private System.Windows.Forms.DataGridView dataOrders;
        private System.Windows.Forms.TabPage ManagersTab;
        private System.Windows.Forms.DataGridView dataManagers;
        private System.Windows.Forms.TabPage CustomerTab;
        private System.Windows.Forms.DataGridView dataCustomers;
        private System.Windows.Forms.TabControl TabsControl;
        private System.Windows.Forms.DataGridView dataGoods;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ReductButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Label ChangeCol;
    }
}

