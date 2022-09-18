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
    public partial class CreateProduct : Form
    {
        DB db = new DB();
        DataGridView data;
        public CreateProduct()
        {
            InitializeComponent();
        }
        public CreateProduct(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            db.Products.Add(new Product() { Name = TB_Name.Text, Price = Convert.ToDouble(TB_Price.Text) });
            db.SaveChanges();
            db.Products.Load();
            data.DataSource = db.Products.Local.ToBindingList();
            this.Close();
        }

        
    }
}
