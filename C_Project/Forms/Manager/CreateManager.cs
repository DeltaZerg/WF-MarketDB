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
    public partial class CreateManager : Form
    {
        DB db = new DB();
        DataGridView data;
        public CreateManager()
        {
            InitializeComponent();
        }
        public CreateManager(DataGridView data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            db.Managers.Add(new Manager() { Name = textBox1.Text });
            db.SaveChanges();
            db.Managers.Load();
            data.DataSource = db.Managers.Local.ToBindingList();
            this.Close();
        }
    }
}
