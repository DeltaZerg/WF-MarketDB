using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Project
{
    public partial class ReductOrders : Form
    {
        DB db = new DB();
        List<Manager> managers = new List<Manager>();
        List<Customer> customers = new List<Customer>();
        List<Product> products = new List<Product>();
        DataGridView dataO, dataG;
        int id;
        int i = 0;
        public ReductOrders()
        {
            InitializeComponent();
        }
        public ReductOrders(int id, Manager manager, Customer customer, DateTime date, DataGridView dataO, DataGridView dataG)
        {
            InitializeComponent();
            customers = db.Customers.ToList();
            managers = db.Managers.ToList();
            products = db.Products.ToList();
            textBox1.Text = id.ToString();
            dateTimePicker1.Value = date;
            foreach (Customer cust in customers)
            {
                if(customer.Name == cust.Name)
                {
                    CustomerLB.Items.Add(customer.Name);
                    CustomerLB.Text = customer.Name;
                    continue;
                }else
                {
                    CustomerLB.Items.Add(cust.Name);
                }
                
            }
            foreach (Manager man in managers)
            {
                if (manager.Name == man.Name)
                {
                    ManagerLB.Items.Add(manager.Name);
                    ManagerLB.Text = manager.Name;
                    continue;
                }
                else
                {
                    ManagerLB.Items.Add(man.Name);
                }

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
            CO_GOODS.Columns.AddRange(column1, column2, column3, column4);
            db.Goods.Where(p => p.Id == id);
            foreach (var good in db.Goods.Where(p => p.Order == id))
            {
                //CO_GOODS.Rows[i].Cells["Products"].Value = good.Product;
                //CO_GOODS.Rows[i].Cells["Price"].Value = (double)good.Price;
                //CO_GOODS.Rows[i].Cells["Count"].Value = (double)good.Count;
                //CO_GOODS.Rows[i].Cells["Sum"].Value = (double)good.Sum;
                if (db.Goods.Where(p => p.Order == id).Count() != CO_GOODS.Rows.Count)
                {
                    CO_GOODS.Rows.Add(CO_GOODS.Rows[i].Cells["Products"].Value = good.Product,
                    CO_GOODS.Rows[i].Cells["Price"].Value = (double)good.Price,
                    CO_GOODS.Rows[i].Cells["Count"].Value = (double)good.Count,
                    CO_GOODS.Rows[i].Cells["Sum"].Value = (double)good.Sum);
                }
                else
                {
                    CO_GOODS.Rows[i].Cells["Products"].Value = good.Product;
                    CO_GOODS.Rows[i].Cells["Price"].Value = (double)good.Price;
                    CO_GOODS.Rows[i].Cells["Count"].Value = (double)good.Count;
                    CO_GOODS.Rows[i].Cells["Sum"].Value = (double)good.Sum;
                }         
                i++;
            }
            i = 0;
            this.id = id;
            this.dataO = dataO;
            this.dataG = dataG;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            
            CO_GOODS.Rows.RemoveAt(CO_GOODS.SelectedRows[0].Index);
            db.Goods.Remove(db.Goods.First(p => p.Id == (int)CO_GOODS.SelectedRows[0].Cells[0].Value));
            db.SaveChanges();
        }

        private void ReductButton_Click(object sender, EventArgs e)
        {
            var item = db.Orders.Find(id);
            #region Orders
            if (item == null) return;
            item.SetCustomer(customers.First(p => p.Name == CustomerLB.Text));
            item.SetManager(managers.First(p => p.Name == ManagerLB.Text));
            item.Customer = CustomerLB.Text;
            item.Manager = ManagerLB.Text;
            item.Date = dateTimePicker1.Value;
            #endregion 
            #region Goods
            foreach (var good in db.Goods.Where(p => p.Order == id))
            {
               
                if (db.Goods.Where(p => p.Order == id).Count() != CO_GOODS.Rows.Count)
                {
                    good.Product = CO_GOODS.Rows[i].Cells["Products"].Value.ToString();
                    good.Price = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Price"].Value);
                    good.Count = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Count"].Value);
                    good.Sum = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Sum"].Value);
                    db.Entry(good).State = EntityState.Modified;
                    db.Goods.AddOrUpdate(good);
                }
                else
                {
                    good.Product = CO_GOODS.Rows[i].Cells["Products"].Value.ToString();
                    good.Price = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Price"].Value);
                    good.Count = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Count"].Value);
                    good.Sum = Convert.ToDouble(CO_GOODS.Rows[i].Cells["Sum"].Value);
                    db.Entry(good).State = EntityState.Modified;
                    db.Goods.AddOrUpdate(good);
                }
                
                i++;
            }
            i = 0;

            db.Entry(item).State = EntityState.Modified;
            db.Orders.AddOrUpdate(item);
            #endregion
            db.SaveChanges();
            db.Orders.Load();
            db.Goods.Load();
            dataO.DataSource = db.Orders.Local.ToBindingList();
            dataG.DataSource = db.Goods.Local.ToBindingList();
            this.Close();
        }
    }
}
