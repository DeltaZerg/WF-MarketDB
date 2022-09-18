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
    public partial class CreateCustomer : Form
    {
        DB db = new DB();
        DataGridView data;
        public CreateCustomer()
        {
            InitializeComponent();
        }
        public CreateCustomer(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            db.Customers.Add(new Customer() { Name = textBox1.Text });
            db.SaveChanges();
            db.Customers.Load();
            data.DataSource = db.Customers.Local.ToBindingList();
            this.Close();
        }
    }
}
