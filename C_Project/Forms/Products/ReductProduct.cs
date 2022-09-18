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
    public partial class ReductProduct : Form
    {
        DB db = new DB();
        public static int Id { get; set; }
        public DataGridView data;
        public ReductProduct()
        {
            InitializeComponent();
        }
        public ReductProduct(int id, string name,double price, DataGridView data = null)
        {
            Id = id;
            InitializeComponent();
            TB_Name.Text = name;
            TB_Price.Text = price.ToString();

            this.data = data;
        }

        private void ReductButton_Click(object sender, EventArgs e)
        {
            var item = db.Products.Find(Id);
            if (item == null) return;
            item.Name = TB_Name.Text;
            item.Price = Convert.ToDouble(TB_Price.Text);
            db.Entry(item).State = EntityState.Modified;
            db.Products.AddOrUpdate(item);
            db.SaveChanges();
            db.Products.Load();
            data.DataSource = db.Products.Local.ToBindingList();
            this.Close();
        }
    }
}
