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
    public partial class ReductManager : Form
    {
        DB db = new DB();
        public static int Id { get; set; }
        public DataGridView data;
        public ReductManager()
        {
            InitializeComponent();
        }
        public ReductManager(int id, string name, DataGridView data = null)
        {
            Id = id;
            InitializeComponent();
            textBox1.Text = name;
            this.data = data;
        }

        private void ReductButton_Click(object sender, EventArgs e)
        {
            var item = db.Managers.Find(Id);
            if (item == null) return;
            item.Name = textBox1.Text;
            db.Entry(item).State = EntityState.Modified;
            db.Managers.AddOrUpdate(item);
            db.SaveChanges();
            db.Managers.Load();
            data.DataSource = db.Managers.Local.ToBindingList();
            this.Close();
        }
    }
}
