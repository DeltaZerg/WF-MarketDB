using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class CreateOrders : Form
    {
        DB db = new DB();
        List<Customer> customers = new List<Customer>();
        List<Manager> managers = new List<Manager>();
        List<Product> products = new List<Product>();
        
        DataGridView data;

        public CreateOrders()
        {
            
            InitializeComponent();
            customers = db.Customers.ToList();
            managers = db.Managers.ToList();
            //orders = db.Orders.ToList();
            foreach (var item in customers)
            {
                CustomerLB.Items.Add(item.Id + " " + item.Name);
            }
            foreach (var item in managers)
            {
                ManagerLB.Items.Add(item.Id + " " + item.Name);
            }
            
        }
        public CreateOrders(DataGridView data)
        {

            InitializeComponent();
            CO_GOODS.AllowUserToDeleteRows = true;
            customers = db.Customers.ToList();
            managers = db.Managers.ToList();
            products = db.Products.ToList();
            foreach (var item in customers)
            {
                CustomerLB.Items.Add(item.Name);
            }
            foreach (var item in managers)
            {
                ManagerLB.Items.Add(item.Name);
            }
           
            
            var column1 = new DataGridViewComboBoxColumn();
            var column2 = new DataGridViewTextBoxColumn();
            var column3 = new DataGridViewTextBoxColumn();
            var column4 = new DataGridViewTextBoxColumn();

            column1.HeaderText = "Products";
            column1.Name = "Products";
            foreach (var item in products)
            {
                column1.Items.Add(item.Name);
            }

            column2.HeaderText = "Price";
            column2.Name = "Price";
            column2.ValueType = typeof(double);

            column3.HeaderText = "Count";
            column3.Name = "Count";
            column3.ValueType = typeof(double);

            column4.HeaderText = "Sum";
            column4.Name = "Sum";
            column4.ValueType = typeof(double);
            CO_GOODS.Columns.AddRange(column1, column2,column3,column4);

            this.data = data;
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            db.Orders.Load();
            
            var o1 = new Order(customers.First(p => p.Name == CustomerLB.SelectedItem.ToString()), managers.First(p => p.Name == ManagerLB.SelectedItem.ToString())) { Date = dateTimePicker1.Value, Id = db.Orders.Local.Count+1 };
            db.Orders.Add(o1);
            for (int i = 0; i < CO_GOODS.Rows.Count-1; i++)
            {
                db.Goods.Add(new Good(products.First(p => p.Name == CO_GOODS.Rows[i].Cells[0].Value.ToString()), o1) { 
                    Price = (double)CO_GOODS.Rows[i].Cells[1].Value,
                    Count = (double)CO_GOODS.Rows[i].Cells[2].Value,
                    Sum = (double)CO_GOODS.Rows[i].Cells[3].Value });
                
            }

            db.SaveChanges();
            db.Orders.Load();
            data.DataSource = db.Orders.Local.ToBindingList();
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            CO_GOODS.Rows.RemoveAt(CO_GOODS.SelectedRows[0].Index);
        }
    }
}
